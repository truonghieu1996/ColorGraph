namespace Dothi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablePictrureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblSoDinh = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lsvThongTinDoThi = new System.Windows.Forms.ListView();
            this.Dinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlGraph = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDisplayMatrix = new System.Windows.Forms.TextBox();
            this.lblSacso = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDrawGraph = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbVeTrucTiep = new System.Windows.Forms.RadioButton();
            this.rdbDocTuFile = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSoCanh = new System.Windows.Forms.Label();
            this.lblSoBac = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Ve = new System.Windows.Forms.GroupBox();
            this.rdbDiChuyen = new System.Windows.Forms.RadioButton();
            this.rdbVeCanh = new System.Windows.Forms.RadioButton();
            this.rdbVeNode = new System.Windows.Forms.RadioButton();
            this.btnGrapColoring = new System.Windows.Forms.Button();
            this.lblGraphType = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Ve.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1214, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editGraphToolStripMenuItem,
            this.tablePictrureToolStripMenuItem});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolToolStripMenuItem.Text = "Tools";
            // 
            // editGraphToolStripMenuItem
            // 
            this.editGraphToolStripMenuItem.Name = "editGraphToolStripMenuItem";
            this.editGraphToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.editGraphToolStripMenuItem.Text = "Take picture";
            this.editGraphToolStripMenuItem.Click += new System.EventHandler(this.editGraphToolStripMenuItem_Click);
            // 
            // tablePictrureToolStripMenuItem
            // 
            this.tablePictrureToolStripMenuItem.Name = "tablePictrureToolStripMenuItem";
            this.tablePictrureToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.tablePictrureToolStripMenuItem.Text = "Output";
            this.tablePictrureToolStripMenuItem.Click += new System.EventHandler(this.tablePictrureToolStripMenuItem_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(1139, 33);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(63, 26);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(666, 33);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(467, 26);
            this.txtPath.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // lblSoDinh
            // 
            this.lblSoDinh.AutoSize = true;
            this.lblSoDinh.Location = new System.Drawing.Point(15, 34);
            this.lblSoDinh.Name = "lblSoDinh";
            this.lblSoDinh.Size = new System.Drawing.Size(66, 18);
            this.lblSoDinh.TabIndex = 10;
            this.lblSoDinh.Text = "Số đỉnh: ";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(165, 404);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(98, 60);
            this.btnDisplay.TabIndex = 13;
            this.btnDisplay.Text = "Hiển thị";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lsvThongTinDoThi
            // 
            this.lsvThongTinDoThi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Dinh,
            this.Bac});
            this.lsvThongTinDoThi.Enabled = false;
            this.lsvThongTinDoThi.GridLines = true;
            this.lsvThongTinDoThi.Location = new System.Drawing.Point(12, 231);
            this.lsvThongTinDoThi.Name = "lsvThongTinDoThi";
            this.lsvThongTinDoThi.Size = new System.Drawing.Size(136, 233);
            this.lsvThongTinDoThi.TabIndex = 14;
            this.lsvThongTinDoThi.UseCompatibleStateImageBehavior = false;
            this.lsvThongTinDoThi.View = System.Windows.Forms.View.Details;
            // 
            // Dinh
            // 
            this.Dinh.Text = "Đỉnh";
            this.Dinh.Width = 65;
            // 
            // Bac
            // 
            this.Bac.Text = "Bậc";
            this.Bac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlGraph
            // 
            this.pnlGraph.BackColor = System.Drawing.Color.White;
            this.pnlGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGraph.Location = new System.Drawing.Point(666, 65);
            this.pnlGraph.Name = "pnlGraph";
            this.pnlGraph.Size = new System.Drawing.Size(536, 399);
            this.pnlGraph.TabIndex = 15;
            this.pnlGraph.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGraph_Paint);
            this.pnlGraph.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlGraph_MouseDown);
            this.pnlGraph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlGraph_MouseMove);
            this.pnlGraph.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlGraph_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDisplayMatrix);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 198);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ma trận";
            // 
            // txtDisplayMatrix
            // 
            this.txtDisplayMatrix.Location = new System.Drawing.Point(6, 26);
            this.txtDisplayMatrix.Multiline = true;
            this.txtDisplayMatrix.Name = "txtDisplayMatrix";
            this.txtDisplayMatrix.Size = new System.Drawing.Size(123, 166);
            this.txtDisplayMatrix.TabIndex = 0;
            // 
            // lblSacso
            // 
            this.lblSacso.AutoSize = true;
            this.lblSacso.Location = new System.Drawing.Point(15, 141);
            this.lblSacso.Name = "lblSacso";
            this.lblSacso.Size = new System.Drawing.Size(99, 18);
            this.lblSacso.TabIndex = 11;
            this.lblSacso.Text = "Tổng sắc số: ";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(414, 404);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(98, 60);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Đặt lại";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDrawGraph
            // 
            this.btnDrawGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrawGraph.Location = new System.Drawing.Point(290, 404);
            this.btnDrawGraph.Name = "btnDrawGraph";
            this.btnDrawGraph.Size = new System.Drawing.Size(98, 60);
            this.btnDrawGraph.TabIndex = 19;
            this.btnDrawGraph.Text = "Vẽ đồ thị";
            this.btnDrawGraph.UseVisualStyleBackColor = true;
            this.btnDrawGraph.Click += new System.EventHandler(this.btnDrawGraph_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbVeTrucTiep);
            this.groupBox2.Controls.Add(this.rdbDocTuFile);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(165, 339);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 55);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mode";
            // 
            // rdbVeTrucTiep
            // 
            this.rdbVeTrucTiep.AutoSize = true;
            this.rdbVeTrucTiep.Location = new System.Drawing.Point(311, 23);
            this.rdbVeTrucTiep.Name = "rdbVeTrucTiep";
            this.rdbVeTrucTiep.Size = new System.Drawing.Size(139, 22);
            this.rdbVeTrucTiep.TabIndex = 2;
            this.rdbVeTrucTiep.TabStop = true;
            this.rdbVeTrucTiep.Text = "Vẽ đồ thị trực tiếp";
            this.rdbVeTrucTiep.UseVisualStyleBackColor = true;
            this.rdbVeTrucTiep.CheckedChanged += new System.EventHandler(this.rdbVeTrucTiep_CheckedChanged);
            // 
            // rdbDocTuFile
            // 
            this.rdbDocTuFile.AutoSize = true;
            this.rdbDocTuFile.Location = new System.Drawing.Point(24, 23);
            this.rdbDocTuFile.Name = "rdbDocTuFile";
            this.rdbDocTuFile.Size = new System.Drawing.Size(146, 22);
            this.rdbDocTuFile.TabIndex = 0;
            this.rdbDocTuFile.TabStop = true;
            this.rdbDocTuFile.Text = "Đọc ma trận từ file";
            this.rdbDocTuFile.UseVisualStyleBackColor = true;
            this.rdbDocTuFile.CheckedChanged += new System.EventHandler(this.rdbDocTuFile_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSoCanh);
            this.groupBox3.Controls.Add(this.lblSoBac);
            this.groupBox3.Controls.Add(this.lblSoDinh);
            this.groupBox3.Controls.Add(this.lblSacso);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(165, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(481, 170);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin";
            // 
            // lblSoCanh
            // 
            this.lblSoCanh.AutoSize = true;
            this.lblSoCanh.Location = new System.Drawing.Point(15, 105);
            this.lblSoCanh.Name = "lblSoCanh";
            this.lblSoCanh.Size = new System.Drawing.Size(71, 18);
            this.lblSoCanh.TabIndex = 14;
            this.lblSoCanh.Text = "Số cạnh: ";
            // 
            // lblSoBac
            // 
            this.lblSoBac.AutoSize = true;
            this.lblSoBac.Location = new System.Drawing.Point(15, 67);
            this.lblSoBac.Name = "lblSoBac";
            this.lblSoBac.Size = new System.Drawing.Size(63, 18);
            this.lblSoBac.TabIndex = 13;
            this.lblSoBac.Text = "Số bậc: ";
            // 
            // Ve
            // 
            this.Ve.Controls.Add(this.rdbDiChuyen);
            this.Ve.Controls.Add(this.rdbVeCanh);
            this.Ve.Controls.Add(this.rdbVeNode);
            this.Ve.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ve.Location = new System.Drawing.Point(165, 278);
            this.Ve.Name = "Ve";
            this.Ve.Size = new System.Drawing.Size(481, 55);
            this.Ve.TabIndex = 29;
            this.Ve.TabStop = false;
            this.Ve.Text = "Vẽ";
            // 
            // rdbDiChuyen
            // 
            this.rdbDiChuyen.AutoSize = true;
            this.rdbDiChuyen.Location = new System.Drawing.Point(359, 23);
            this.rdbDiChuyen.Name = "rdbDiChuyen";
            this.rdbDiChuyen.Size = new System.Drawing.Size(91, 22);
            this.rdbDiChuyen.TabIndex = 29;
            this.rdbDiChuyen.TabStop = true;
            this.rdbDiChuyen.Text = "Di chuyển";
            this.rdbDiChuyen.UseVisualStyleBackColor = true;
            this.rdbDiChuyen.CheckedChanged += new System.EventHandler(this.rdbDiChuyen_CheckedChanged);
            // 
            // rdbVeCanh
            // 
            this.rdbVeCanh.AutoSize = true;
            this.rdbVeCanh.Location = new System.Drawing.Point(184, 23);
            this.rdbVeCanh.Name = "rdbVeCanh";
            this.rdbVeCanh.Size = new System.Drawing.Size(79, 22);
            this.rdbVeCanh.TabIndex = 28;
            this.rdbVeCanh.TabStop = true;
            this.rdbVeCanh.Text = "Vẽ cạnh";
            this.rdbVeCanh.UseVisualStyleBackColor = true;
            this.rdbVeCanh.CheckedChanged += new System.EventHandler(this.rdbVeCanh_CheckedChanged);
            // 
            // rdbVeNode
            // 
            this.rdbVeNode.AutoSize = true;
            this.rdbVeNode.Location = new System.Drawing.Point(24, 23);
            this.rdbVeNode.Name = "rdbVeNode";
            this.rdbVeNode.Size = new System.Drawing.Size(74, 22);
            this.rdbVeNode.TabIndex = 27;
            this.rdbVeNode.TabStop = true;
            this.rdbVeNode.Text = "Vẽ đỉnh";
            this.rdbVeNode.UseVisualStyleBackColor = true;
            this.rdbVeNode.CheckedChanged += new System.EventHandler(this.rdbVeNode_CheckedChanged);
            // 
            // btnGrapColoring
            // 
            this.btnGrapColoring.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrapColoring.Location = new System.Drawing.Point(548, 404);
            this.btnGrapColoring.Name = "btnGrapColoring";
            this.btnGrapColoring.Size = new System.Drawing.Size(98, 57);
            this.btnGrapColoring.TabIndex = 32;
            this.btnGrapColoring.Text = "Tô màu";
            this.btnGrapColoring.UseVisualStyleBackColor = true;
            this.btnGrapColoring.Click += new System.EventHandler(this.btnGrapColoring_Click);
            // 
            // lblGraphType
            // 
            this.lblGraphType.AutoSize = true;
            this.lblGraphType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraphType.Location = new System.Drawing.Point(167, 36);
            this.lblGraphType.Name = "lblGraphType";
            this.lblGraphType.Size = new System.Drawing.Size(84, 18);
            this.lblGraphType.TabIndex = 33;
            this.lblGraphType.Text = "Loại đồ thị: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 473);
            this.Controls.Add(this.lblGraphType);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGrapColoring);
            this.Controls.Add(this.Ve);
            this.Controls.Add(this.lsvThongTinDoThi);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnDrawGraph);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlGraph);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "DEMO Giải Thuật Greedy Tô Màu Đồ Thị ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Ve.ResumeLayout(false);
            this.Ve.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablePictrureToolStripMenuItem;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblSoDinh;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.ListView lsvThongTinDoThi;
        private System.Windows.Forms.ColumnHeader Dinh;
        private System.Windows.Forms.ColumnHeader Bac;
        private System.Windows.Forms.Panel pnlGraph;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDisplayMatrix;
        private System.Windows.Forms.Label lblSacso;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDrawGraph;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbVeTrucTiep;
        private System.Windows.Forms.RadioButton rdbDocTuFile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblSoBac;
        private System.Windows.Forms.Label lblSoCanh;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox Ve;
        private System.Windows.Forms.RadioButton rdbVeNode;
        private System.Windows.Forms.RadioButton rdbDiChuyen;
        private System.Windows.Forms.RadioButton rdbVeCanh;
        private System.Windows.Forms.Button btnGrapColoring;
        private System.Windows.Forms.Label lblGraphType;
    }
}

