using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dothi
{
    class Graph
    {
        #region Thuoc tinh
        private int _soDinh;
        private int _tongBac;
        private int[,] _matrix;
        private bool _Xethuong;
        private bool _coTrongSo;
        private List<Dinh> _lstDinh;
        private int _Sacso;
        private bool _kiemTraMaTranHopLe;
        #endregion
        public Graph()
        {
            _soDinh = 0;
            _tongBac = 0;
        }
        #region Properties
        public int[,] matrix
        {
            get { return _matrix; }
            set { _matrix = value; }
        }
        public int tongBac
        {
            get { return _tongBac; }
            set { _tongBac = value; }
        }
        public int soDinh
        {
            get { return _soDinh; }
            set { _soDinh = value; }
        }
        public bool xetHuong
        {
            get { return _Xethuong; }
            set { _Xethuong = value; }
        }
        public bool coTrongSo
        {
            get { return _coTrongSo; }
            set { _coTrongSo = value; }
        }
        public List<Dinh> lstDinh
        {
            get { return _lstDinh; }
            set { _lstDinh = value; }
        }
        public int Getsacso
        {
            get { return _Sacso; }
        }
        public bool GetKiemTraMaTran
        {
            get { return _kiemTraMaTranHopLe; }
        }
        #endregion
        #region XuLiDoThi
        public bool MaTranBangKhong()
        {
            for (int i = 0; i < _soDinh; ++i)
                for (int j = 0; j < _soDinh; ++j)
                    if (_matrix[i, j] != 0)
                        return false;
            return true;
        }
        public void DocFile(string path)
        {
            StreamReader doc = new StreamReader(path);
            string [] temp = doc.ReadToEnd().Replace("\r\n", " ").Replace("  "," ").Split(' ');
            _soDinh = (int)Math.Sqrt(temp.Length);
            _matrix = new int[_soDinh, _soDinh];
            for (int i = 0; i < _soDinh; i++)
                for (int j = 0; j < _soDinh; j++)
                    _matrix[i, j] = int.Parse(temp[i * _soDinh +j].ToString());
            doc.Close();
        }
        public bool KiemTraMaTranHopLe(string text)
        {
            foreach (char c in text)
                if (!Char.IsDigit(c) && c != ' ' && c != '\n' && c != '\r')
                    return false;
            string[] array = text.Replace("\r\n", " ").Replace("  ", " ").Split(' ');
            int x = (int)Math.Sqrt(array.Length);
            if (x * x == array.Length)
                return true;
            return false;
        }
        public void MaTranHopLe(string text)
        {
            if (KiemTraMaTranHopLe(text))
                _kiemTraMaTranHopLe = true;
            else
                _kiemTraMaTranHopLe = false;
        }
        public void CreatePoint(int width, int heigth)
        {
            if (_lstDinh == null)
                _lstDinh = new List<Dinh>();
            int nameUnicode = 65;
            int bacCuaDinh;
            Dinh item;
            Random rand = new Random();
            Point pRand = new Point();
            for (int i = 0; i < _soDinh; i++)
            {
                pRand.X = rand.Next(width - 30);
                pRand.Y = rand.Next(heigth - 30);
                bacCuaDinh = 0;
                for (int j = 0; j < _soDinh; j++)
                if (_matrix[i, j] != 0)
                    bacCuaDinh++;
                _tongBac += bacCuaDinh;
                item = new Dinh(((char)(nameUnicode + i)).ToString(), bacCuaDinh, pRand);
                lstDinh.Add(item);
            }
        }
        public void TinhBac()
        {
            int bacCuaDinh;
            for (int i = 0; i < _soDinh; i++)
            {
                    bacCuaDinh = 0;
                    for (int j = 0; j < _soDinh; j++)
                        if (_matrix[i, j] != 0)
                            bacCuaDinh++;
                    _lstDinh[i].bacCuaDinh = bacCuaDinh;
                    _tongBac += bacCuaDinh;
            }
        }
        public bool MaTranDoiXung()
        {
            /*True==DoiXung. False==KhongDoiXung*/
            for (int i = 0; i < _soDinh; i++)
                for (int j = 0; j < _soDinh; j++)
                    if (_matrix[i, j] != _matrix[j, i])
                        return false;
            return true;
        }
        public void VoHuong()
        {
            /*false==VoHuong. True==CoHuong*/
            if (MaTranDoiXung() == true)
                _Xethuong = false;
            else
                _Xethuong = true;
        }
        public void XetTrongSo()
        {
            for (int i = 0; i < _soDinh; i++)
                for (int j = 0; j < _soDinh; j++)
                    if (_matrix[i, j] > 1)
                    {
                        _coTrongSo = true;
                        return;
                    }
            _coTrongSo = false;
        }
        public string LoaiDoThi()
        {
            VoHuong();
            XetTrongSo();
            string type = "";
            if (xetHuong)
                type = "Đồ thị có hướng";
            else
                type = "Đồ thị vô hướng";

            if (_coTrongSo)
                type += " và có trọng số";
            else
                type += " và không trọng số";
            return type;
        }
        #endregion
        #region VeDoThi
        public void Draw(Graphics g, SolidBrush sb, Pen p)
        {
            SolidBrush s = new SolidBrush(Color.Black);
                
            for (int i = 0; i < _soDinh; i++)
                for (int j = 0; j < _soDinh; j++)
                    if (_matrix[i, j] != 0)
                        DrawLine(g, p, _lstDinh[i].pos, _lstDinh[j].pos);
            for (int k = 0; k < _soDinh; ++k)
            {
                lstDinh[k].DrawNode(g, sb);
                lstDinh[k].AddNodeName(g);
            }
            s.Dispose();
        }
        public void DrawLine(Graphics g, Pen pen, Point dau, Point cuoi)
        {
            dau.X += 15;
            dau.Y += 15;
            cuoi.X += 15;
            cuoi.Y += 15;
            g.DrawLine(pen, dau, cuoi);
        }
        #endregion
        #region Graph Coloring

        private int[] maudinh = new int[28];
        public int[] getMauDinh
        {
            get { return maudinh; }
            set { maudinh = value; }
        }
        private int kiemtramau(int[] mauphu, int t, int mau)
        {
            int i;
            for (i = 0; i <= t; i++)
                if (mau == mauphu[i])
                    return 1;
            return 0;
        }
        // chon mau thich hop de to
        private int chonmau(int[] mauphu, int t)
        {
            int mau = 1;
            do
            {
                if (kiemtramau(mauphu, t, mau) == 0)
                    return mau;
                else
                    mau++;
            } while (true); //Lap den khi return mau, dung phuong thuc.
        }
        // to mau cho cac dinh do thi
        public void tomau()
        {
            int j, l;
            int mau, t;
            int[] dinhtruoc = new int[28];
            int[] mauphu = new int[28];//cap nhat mau da to cho nhung dinh ke truoc do
            mau = t = 1;//t: số lượng đỉnh kề trong số đỉnh đã duyệt trước đó.
            l = 0; // Xét đỉnh ở vị trí hiện tại so với các đỉnh đã ghé thăm, xem có kề không.
            j = 1; //Xét đỉnh.
            maudinh[0] = mau;
            dinhtruoc[0] = 0; // dinh da to dua vao mang dinhtruoc, 0 là đỉnh đầu tiên tức là đỉnh cha của đỉnh kế tiếp.
            mauphu[0] = 0;
            do
            {
                for (int i = 0; i <= l; i++)
                    if (_matrix[j, dinhtruoc[i]]  == 1)
                        mauphu[++t] = maudinh[dinhtruoc[i]];
                // dau mau cua dinh da to ma ke voi dinh dang xet vao mang mauphu
                maudinh[j] = chonmau(mauphu, t);
                l = j;
                dinhtruoc[l] = j;// dinh da to dua vao mang dinhtruoc
                j++;
                t = 0;
            } while (j < _soDinh);
        }
        #endregion
        #region Tinh tong sac so
        public void tinhSacSo()
        {
            int sacso = 0;
            tomau();
            for (int i = 0; i < _soDinh; i++)
            {
                if (maudinh[i] > sacso)
                    sacso = maudinh[i];
            }
            _Sacso = sacso;
        }
        #endregion
    }
}