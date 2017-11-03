using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dothi
{
    public enum Mode
    {
        DocTuFile,
        VeTrucTiep
    }
    public enum Tool
    {
        VeNode,
        VeCanh,
        DiChuyen,
        Xoa
    }
    public partial class Form1 : Form
    {
        #region Các Thuộc tính 
        private Graph graph;
        private static Pen pen;
        private static SolidBrush sb;
        private static SolidBrush sb1;
        private Graphics grs;
        private bool isOpenFile;
        private Mode _mode;
        private Tool _tool;
        private Point _mouseDownLocation;
        private Point _mouseUpLocation;
        private bool isMouseDown;
        private int curSelectedNode;
        private int _curNode;
        private int _nameUnicode;
        private int _nodeDau;
        private int _nodeCuoi;
        #endregion
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            graph = new Graph();
            _nodeDau = -1;
            _nodeCuoi = -1;
            _curNode = 0;
            _nameUnicode = 65;
            isOpenFile = false;
            isMouseDown = false;
            pen = new Pen(Color.Black, 3.0F);
            sb = new SolidBrush(Color.YellowGreen);
            grs = pnlGraph.CreateGraphics();
            curSelectedNode = -1;
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
        #region Event LoadForm
        private void Form1_Load(object sender, EventArgs e)
        {
            rdbDocTuFile.Checked = true;
            txtDisplayMatrix.Enabled = false;
            btnReset.Enabled = false;
            btnDisplay.Enabled = false;
            btnGrapColoring.Enabled = false;
            btnDrawGraph.Enabled = false;
            rdbVeNode.Enabled = false;
            rdbVeCanh.Enabled = false;
            txtDisplayMatrix.Enabled = false;
        }
        #endregion
        #region Button_ClickOpen
        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt File |*.txt";
            openFileDialog1.InitialDirectory = @"D:\Lý thuyết đồ thị";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                isOpenFile = true;
                txtPath.Text = openFileDialog1.FileName;
                graph.DocFile(txtPath.Text);
                graph.MaTranHopLe(File.ReadAllText(openFileDialog1.FileName));
                if (graph.GetKiemTraMaTran == true)
                {
                    for (int i = 0; i < graph.soDinh; ++i)
                    {
                        for (int j = 0; j < graph.soDinh; ++j)
                            txtDisplayMatrix.Text += (graph.matrix[i, j].ToString() + " ");
                        txtDisplayMatrix.Text += "\r\n";
                    }
                    graph.VoHuong();
                    graph.XetTrongSo();
                    if ((graph.xetHuong == false && graph.coTrongSo == false))
                    {
                        txtDisplayMatrix.Clear();
                        MessageBox.Show("Nhập thành công");
                        btnDisplay.Enabled = true;
                        btnOpen.Enabled = false;
                    }
                    else
                    {
                        lblGraphType.Text += graph.LoaiDoThi();
                        MessageBox.Show("Nhập lỗi!\nChương trình chỉ xét trên đồ thị vô hướng và không có trọng số.\nVui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        lblGraphType.Text = "Loại đồ thị: ";
                        txtDisplayMatrix.Clear();
                        btnDisplay.Enabled = false;
                        rdbDiChuyen.Enabled = false;
                        txtPath.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Ma Trận không hợp lệ!\nVui lòng 'Đặt lại' để tiếp tục.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnDisplay.Enabled = false;
                    btnDrawGraph.Enabled = false;
                    btnGrapColoring.Enabled = false;
                    rdbDiChuyen.Enabled = false;
                    txtDisplayMatrix.Clear();
                    txtPath.Clear();
                }
            }
        }
        #endregion
        #region Button Hiển Thị 
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (rdbVeTrucTiep.Checked == true)
                btnDrawGraph.Enabled = false;
            else
                btnDrawGraph.Enabled = true;
            btnDisplay.Enabled = false;
            btnReset.Enabled = true;
            if (graph.matrix != null)
            {
                if (txtDisplayMatrix.Text == "")
                {
                    for (int i = 0; i < graph.soDinh; ++i)
                    {
                        for (int j = 0; j < graph.soDinh; ++j)
                            txtDisplayMatrix.Text += (graph.matrix[i, j].ToString() + " ");
                        txtDisplayMatrix.Text += "\r\n";
                    }
                }
                if (_mode == Mode.DocTuFile)
                {
                    lblGraphType.Text += graph.LoaiDoThi();
                    graph.CreatePoint(pnlGraph.Width, pnlGraph.Height);
                    btnDrawGraph.Enabled = true;
                }
                if (_mode == Mode.VeTrucTiep)
                {
                    graph.TinhBac();
                    lblGraphType.Text += graph.LoaiDoThi();
                }
                lblSoDinh.Text += graph.soDinh.ToString();
                lblSoBac.Text += graph.tongBac.ToString();
                lblSoCanh.Text += (graph.tongBac / 2).ToString();
                HienThiThongTinListView();
            }
            else
                MessageBox.Show("Chưa có thông tin ma trận", "Thông báo");
        }
        #endregion
        #region Hiển thị thông tin lên ListView
        private void HienThiThongTinListView()
        {
            ListViewItem item;
            string[] thongTin = new string[4];
            for (int i = 0; i < graph.soDinh; ++i)
            {
                thongTin[0] = graph.lstDinh[i].tenDinh;
                thongTin[1] = graph.lstDinh[i].bacCuaDinh.ToString();
                item = new ListViewItem(thongTin);
                lsvThongTinDoThi.Items.Add(item);
            }
        }
        #endregion
        #region Button vẽ đồ thị
        private void btnDrawGraph_Click(object sender, EventArgs e)
        {
            if (_mode == Mode.DocTuFile)
            {
                if (isOpenFile)
                {
                    for (int i = 0; i < graph.soDinh; ++i)
                    {
                        graph.Draw(grs, sb, pen);
                    }
                    btnDrawGraph.Enabled = false;
                    btnGrapColoring.Enabled = true;
                }
                else
                    MessageBox.Show("Chưa có thông tin đồ thị!!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            rdbDiChuyen.Enabled = true;
            rdbDiChuyen.Checked = true;
            pnlGraph.Enabled = true;
        }
        #endregion
        #region Button Đặt lại
        private void btnReset_Click(object sender, EventArgs e)
        {
            _curNode = 0;
            btnOpen.Enabled = true;
            txtPath.Clear();
            txtDisplayMatrix.Clear();
            isOpenFile = false;
            lsvThongTinDoThi.Items.Clear();
            grs.Clear(Color.White);
            lblSoDinh.Text = "Số đỉnh:";
            lblSoBac.Text = "Số bậc: ";
            lblSoCanh.Text = "Số cạnh: ";
            lblSacso.Text = "Tổng sắc số: ";
            lblGraphType.Text = "Loại đồ thị: ";
            graph = new Graph();
            btnReset.Enabled = false;
            rdbDocTuFile.Checked = true;
            btnGrapColoring.Enabled = false;
        }
        #endregion
        #region Vẽ.
        private void pnlGraph_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < graph.soDinh; ++i)
                graph.Draw(grs, sb, pen);
        }
        #endregion
        #region Xử lí các sự kiện di chuyển của đồ thị trên paint.
        private void pnlGraph_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDownLocation = e.Location;
            isMouseDown = true;
            if (_tool == Tool.DiChuyen)
            {
                for (int i = 0; i < graph.soDinh; ++i)
                {
                    int x = graph.lstDinh[i].pos.X;
                    int y = graph.lstDinh[i].pos.Y;
                    if (_mouseDownLocation.X > x && _mouseDownLocation.X < x + 30
                        && _mouseDownLocation.Y > y && _mouseDownLocation.Y < y + 30)
                    {
                        curSelectedNode = i; // lấy vị trí node của sự kiện mousedown. 
                        break;
                    }
                }
            }
            if (_tool == Tool.VeNode)
            {
                if (_curNode == 0)
                    graph.lstDinh = new List<Dinh>();
                Dinh dinh = new Dinh(((char)(_nameUnicode + _curNode)).ToString(), 0, e.Location);
                dinh.DrawNode(grs, sb);
                dinh.AddNodeName(grs);
                _curNode++;
                graph.lstDinh.Add(dinh);
                if (graph.MaTranBangKhong())
                {
                    graph.matrix = new int[_curNode, _curNode];
                    for (int i = 0; i < _curNode; ++i)
                        for (int j = 0; j < _curNode; ++j)
                            graph.matrix[i, j] = 0;
                }
                else
                {
                    int[,] temMatrix = new int[_curNode - 1, _curNode - 1];
                    for (int i = 0; i < _curNode - 1; ++i)
                        for (int j = 0; j < _curNode - 1; ++j)
                            temMatrix[i, j] = graph.matrix[i, j];
                    graph.matrix = new int[_curNode, _curNode];
                    for (int i = 0; i < _curNode - 1; ++i)
                        for (int j = 0; j < _curNode - 1; ++j)
                            graph.matrix[i, j] = temMatrix[i, j];
                }
                graph.soDinh = _curNode;
            }
            if (_tool == Tool.VeCanh)
            {
                for (int i = 0; i < _curNode; ++i)
                {
                    int x = graph.lstDinh[i].pos.X;
                    int y = graph.lstDinh[i].pos.Y;
                    if (_mouseDownLocation.X > x && _mouseDownLocation.X < x + 30
                        && _mouseDownLocation.Y > y && _mouseDownLocation.Y < y + 30)
                    {
                        _nodeDau = i;
                        break;
                    }
                }
            }
        }
        private void pnlGraph_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown && curSelectedNode != -1 && _tool == Tool.DiChuyen)
            {
                graph.lstDinh[curSelectedNode].pos = new Point(e.X, e.Y);
                pnlGraph.Invalidate(); //dùng để yêu cầu control vẽ lại.
            }
        }
        private void pnlGraph_MouseUp(object sender, MouseEventArgs e)
        {
            if (_mode == Mode.DocTuFile)
                curSelectedNode = -1;
            if (_mode == Mode.VeTrucTiep)
            {
                if (_tool == Tool.VeCanh)
                {
                    _mouseUpLocation = e.Location;
                    for (int i = 0; i < _curNode; ++i)
                    {
                        int x = graph.lstDinh[i].pos.X;
                        int y = graph.lstDinh[i].pos.Y;
                        if (_mouseUpLocation.X > x && _mouseUpLocation.X < x + 30
                            && _mouseUpLocation.Y > y && _mouseUpLocation.Y < y + 30)
                        {
                            _nodeCuoi = i;
                            break;
                        }
                    }
                    if (_nodeCuoi != -1)
                    {
                        graph.DrawLine(grs, pen, graph.lstDinh[_nodeDau].pos, graph.lstDinh[_nodeCuoi].pos);
                        graph.matrix[_nodeDau, _nodeCuoi] = 1;
                        graph.matrix[_nodeCuoi, _nodeDau] = 1;    
                    }
                    _nodeCuoi = -1;
                }
            }
            isMouseDown = false;
        }
        #endregion
        #region Các nút RadioSelect
        private void rdbDocTuFile_CheckedChanged(object sender, EventArgs e)
        {
            pnlGraph.Enabled = false;
            rdbVeNode.Checked = false;
            btnOpen.Enabled = true;
            txtDisplayMatrix.Enabled = false;
            rdbVeNode.Enabled = false;
            rdbVeCanh.Enabled = false;
            rdbDiChuyen.Enabled = false;
            _mode = Mode.DocTuFile;
        }
        private void rdbVeTrucTiep_CheckedChanged(object sender, EventArgs e)
        {
            graph = new Graph();
            _curNode = 0;
            _mode = Mode.VeTrucTiep;
            btnDrawGraph.Enabled = false;
            btnDisplay.Enabled = true;
            btnOpen.Enabled = false;
            rdbVeNode.Checked = true;
            rdbVeNode.Enabled = true;
            rdbVeCanh.Enabled = true;
            rdbDiChuyen.Enabled = true;
            txtDisplayMatrix.Enabled = false;
            btnGrapColoring.Enabled = true;
            pnlGraph.Enabled = true;
            btnReset.Enabled = true;        
        }
        
        private void btnVeDinh_Click(object sender, EventArgs e)
        {
            _tool = Tool.VeNode;
        }
        private void btnVeCanh_Click(object sender, EventArgs e)
        {
            _tool = Tool.VeCanh;
        }
        private void btnDiChuyen_Click(object sender, EventArgs e)
        {
            _tool = Tool.DiChuyen;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            _tool = Tool.Xoa;
        }
        private void rdbVeNode_CheckedChanged(object sender, EventArgs e)
        {
            _tool = Tool.VeNode;
        }
        private void rdbVeCanh_CheckedChanged(object sender, EventArgs e)
        {
            _tool = Tool.VeCanh;
        }
        private void rdbDiChuyen_CheckedChanged(object sender, EventArgs e)
        {
            _tool = Tool.DiChuyen;
        }
        #endregion
        #region Lưu ảnh của đồ thị
        // Take image tool
        private void editGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PNG Files (.png)|*.png|All Files (*.*)|*.*";
            Size size = new Size(pnlGraph.Width, pnlGraph.Height);
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                int x = Screen.PrimaryScreen.Bounds.X + this.Location.X + pnlGraph.Location.X + 9;
                int y = Screen.PrimaryScreen.Bounds.Y + this.Location.Y + pnlGraph.Location.Y + 31;
                Bitmap bitmap = new Bitmap(pnlGraph.Width - 3, pnlGraph.Height - 3);
                Graphics screenGraphics = Graphics.FromImage(bitmap);
                screenGraphics.CopyFromScreen(x, y, 0, 0, size, CopyPixelOperation.SourceCopy); // chup man hinh va luu vao Bitmap
                bitmap.Save(saveDialog.FileName, ImageFormat.Png); // luu anh voi dinh dang la Png
                MessageBox.Show("Lưu thành công!!");
            }
        }
        #endregion
        #region Đóng chương trình
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult re;
            re = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.No)
                e.Cancel = true;
            else
            {
                grs.Dispose();
                pen.Dispose();
                sb.Dispose();
            }
        }
        #endregion
        #region Xuất đồ thị ra file text
        private void tablePictrureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_mode == Mode.VeTrucTiep)
            {
                if (txtDisplayMatrix.Text != "")
                {
                    saveFileDialog1.Filter = "Text file (*.txt)|*.txt|All files (*.*)|*.*";
                    saveFileDialog1.InitialDirectory = @":D";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog1.FileName, txtDisplayMatrix.Text);
                        txtPath.Text = saveFileDialog1.FileName;
                        MessageBox.Show("Lưu thành công!!!");
                    }
                }
                else
                    MessageBox.Show("Ma trận không tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion   
        #region Button_GrapColoring
        private void btnGrapColoring_Click(object sender, EventArgs e)
        {
            Color[] cl = new Color[10];
            cl[1] = Color.Blue;
            cl[2] = Color.Red;
            cl[3] = Color.Purple;
            cl[4] = Color.Yellow;
            cl[5] = Color.AliceBlue;
            cl[6] = Color.Black;
            cl[7] = Color.RoyalBlue;
            graph.tomau();
            for (int i = 0; i < graph.soDinh; ++i)
            {
                if (graph.getMauDinh[i] == 1)
                {
                    sb1 = new SolidBrush(cl[1]);
                    graph.lstDinh[i].DrawNode(grs,sb1);
                    graph.lstDinh[i].AddNodeName(grs);
                }

                if (graph.getMauDinh[i] == 2)
                {
                    sb1 = new SolidBrush(cl[2]);
                    graph.lstDinh[i].DrawNode(grs,sb1);
                    graph.lstDinh[i].AddNodeName(grs);
                }
                if (graph.getMauDinh[i] == 3)
                {
                    sb1 = new SolidBrush(cl[3]);
                    graph.lstDinh[i].DrawNode(grs,sb1);
                    graph.lstDinh[i].AddNodeName(grs);
                }
                if (graph.getMauDinh[i] == 4)
                {
                    sb1 = new SolidBrush(cl[4]);
                    graph.lstDinh[i].DrawNode(grs,sb1);
                    graph.lstDinh[i].AddNodeName(grs);
                }
                if (graph.getMauDinh[i] == 5)
                {
                    sb1 = new SolidBrush(cl[5]);
                    graph.lstDinh[i].DrawNode(grs,sb1);
                    graph.lstDinh[i].AddNodeName(grs);
                }
                if (graph.getMauDinh[i] == 6)
                {
                    sb1 = new SolidBrush(cl[6]);
                    graph.lstDinh[i].DrawNode(grs,sb1);
                    graph.lstDinh[i].AddNodeName(grs);
                }
                if (graph.getMauDinh[i] == 7)
                {
                    sb1 = new SolidBrush(cl[7]);
                    graph.lstDinh[i].DrawNode(grs,sb1);
                    graph.lstDinh[i].AddNodeName(grs);
                }
            }
            graph.tinhSacSo();
            lblSacso.Text = "Tổng sắc số là: ";
            lblSacso.Text += graph.Getsacso.ToString();
        }
        #endregion
    }
}