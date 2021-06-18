
namespace quanLyNhaHangBuffer
{
    partial class formBanHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formBanHang));
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tage1 = new System.Windows.Forms.TabPage();
            this.btnTraSua = new System.Windows.Forms.Button();
            this.btnTraDao = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblNam = new System.Windows.Forms.Label();
            this.lblThang = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvOder = new System.Windows.Forms.DataGridView();
            this.MAMON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnCapNhat = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnLuu = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnDong = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnTaoMa = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tage1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOder)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1124, 592);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1124, 592);
            this.tabControl1.TabIndex = 0;
            // 
            // tage1
            // 
            this.tage1.Controls.Add(this.btnTraSua);
            this.tage1.Controls.Add(this.btnTraDao);
            this.tage1.Location = new System.Drawing.Point(4, 32);
            this.tage1.Name = "tage1";
            this.tage1.Padding = new System.Windows.Forms.Padding(3);
            this.tage1.Size = new System.Drawing.Size(1116, 556);
            this.tage1.TabIndex = 0;
            this.tage1.Text = "Đồ uống";
            this.tage1.UseVisualStyleBackColor = true;
            // 
            // btnTraSua
            // 
            this.btnTraSua.Location = new System.Drawing.Point(143, 6);
            this.btnTraSua.Name = "btnTraSua";
            this.btnTraSua.Size = new System.Drawing.Size(129, 120);
            this.btnTraSua.TabIndex = 1;
            this.btnTraSua.Text = "Trà Sữa";
            this.btnTraSua.UseVisualStyleBackColor = true;
            this.btnTraSua.Click += new System.EventHandler(this.btnTraSua_Click);
            // 
            // btnTraDao
            // 
            this.btnTraDao.Location = new System.Drawing.Point(8, 6);
            this.btnTraDao.Name = "btnTraDao";
            this.btnTraDao.Size = new System.Drawing.Size(129, 120);
            this.btnTraDao.TabIndex = 0;
            this.btnTraDao.Text = "Trà Đào";
            this.btnTraDao.UseVisualStyleBackColor = true;
            this.btnTraDao.Click += new System.EventHandler(this.btnTraDao_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1116, 556);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thức ăn kèm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtMaHD);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtTongTien);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.lblNam);
            this.panel3.Controls.Add(this.lblThang);
            this.panel3.Controls.Add(this.lblNgay);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.dtgvOder);
            this.panel3.Location = new System.Drawing.Point(1142, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(495, 642);
            this.panel3.TabIndex = 2;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Enabled = false;
            this.txtMaHD.Location = new System.Drawing.Point(41, 38);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(184, 30);
            this.txtMaHD.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "HD:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(333, 600);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(159, 30);
            this.txtTongTien.TabIndex = 9;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 603);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tổng tiền";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "hh:mm:ss";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(341, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(102, 30);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2021, 6, 10, 2, 46, 0, 0);
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Location = new System.Drawing.Point(230, 6);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(54, 23);
            this.lblNam.TabIndex = 6;
            this.lblNam.Text = "2000";
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Location = new System.Drawing.Point(152, 6);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(32, 23);
            this.lblThang.TabIndex = 5;
            this.lblThang.Text = "04";
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(60, 6);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(32, 23);
            this.lblNgay.TabIndex = 4;
            this.lblNgay.Text = "04";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tháng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày";
            // 
            // dtgvOder
            // 
            this.dtgvOder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgvOder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvOder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvOder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvOder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvOder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAMON,
            this.TENMON,
            this.SL,
            this.DONGIA,
            this.THANHTIEN});
            this.dtgvOder.Location = new System.Drawing.Point(0, 73);
            this.dtgvOder.Name = "dtgvOder";
            this.dtgvOder.Size = new System.Drawing.Size(492, 519);
            this.dtgvOder.TabIndex = 0;
            // 
            // MAMON
            // 
            this.MAMON.HeaderText = "Mã món";
            this.MAMON.Name = "MAMON";
            this.MAMON.Visible = false;
            // 
            // TENMON
            // 
            this.TENMON.HeaderText = "Tên món";
            this.TENMON.Name = "TENMON";
            // 
            // SL
            // 
            this.SL.HeaderText = "Số lượng";
            this.SL.Name = "SL";
            // 
            // DONGIA
            // 
            this.DONGIA.HeaderText = "Giá";
            this.DONGIA.Name = "DONGIA";
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.HeaderText = "Thành tiền";
            this.THANHTIEN.Name = "THANHTIEN";
            // 
            // txtSL
            // 
            this.txtSL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSL.Location = new System.Drawing.Point(977, 635);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(159, 30);
            this.txtSL.TabIndex = 13;
            this.txtSL.Text = "1";
            this.txtSL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(883, 638);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Số lượng";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.btnTaoMa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 673);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1649, 127);
            this.panel1.TabIndex = 14;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnXoa.color = System.Drawing.Color.White;
            this.btnXoa.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnXoa.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImagePosition = 15;
            this.btnXoa.ImageZoom = 20;
            this.btnXoa.LabelPosition = 39;
            this.btnXoa.LabelText = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(989, 0);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(329, 125);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.White;
            this.btnCapNhat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnCapNhat.color = System.Drawing.Color.White;
            this.btnCapNhat.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhat.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCapNhat.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImagePosition = 15;
            this.btnCapNhat.ImageZoom = 20;
            this.btnCapNhat.LabelPosition = 39;
            this.btnCapNhat.LabelText = "Cập nhật";
            this.btnCapNhat.Location = new System.Drawing.Point(658, 0);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(6);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(329, 125);
            this.btnCapNhat.TabIndex = 3;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnLuu.color = System.Drawing.Color.White;
            this.btnLuu.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLuu.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImagePosition = 15;
            this.btnLuu.ImageZoom = 20;
            this.btnLuu.LabelPosition = 39;
            this.btnLuu.LabelText = "In";
            this.btnLuu.Location = new System.Drawing.Point(329, 0);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(6);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(329, 125);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.White;
            this.btnDong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnDong.color = System.Drawing.Color.White;
            this.btnDong.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDong.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDong.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.Black;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImagePosition = 15;
            this.btnDong.ImageZoom = 20;
            this.btnDong.LabelPosition = 39;
            this.btnDong.LabelText = "Đóng";
            this.btnDong.Location = new System.Drawing.Point(1318, 0);
            this.btnDong.Margin = new System.Windows.Forms.Padding(6);
            this.btnDong.Name = "btnDong";
            this.btnDong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDong.Size = new System.Drawing.Size(329, 125);
            this.btnDong.TabIndex = 1;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnTaoMa
            // 
            this.btnTaoMa.BackColor = System.Drawing.Color.White;
            this.btnTaoMa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnTaoMa.color = System.Drawing.Color.White;
            this.btnTaoMa.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnTaoMa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaoMa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTaoMa.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoMa.ForeColor = System.Drawing.Color.Black;
            this.btnTaoMa.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoMa.Image")));
            this.btnTaoMa.ImagePosition = 14;
            this.btnTaoMa.ImageZoom = 20;
            this.btnTaoMa.LabelPosition = 39;
            this.btnTaoMa.LabelText = "Tạo mã HD";
            this.btnTaoMa.Location = new System.Drawing.Point(0, 0);
            this.btnTaoMa.Margin = new System.Windows.Forms.Padding(6);
            this.btnTaoMa.Name = "btnTaoMa";
            this.btnTaoMa.Size = new System.Drawing.Size(329, 125);
            this.btnTaoMa.TabIndex = 0;
            this.btnTaoMa.Click += new System.EventHandler(this.btnTaoMa_Click);
            // 
            // formBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1649, 800);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "formBanHang";
            this.Text = "formBanHang";
            this.Load += new System.EventHandler(this.formBanHang_Load);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOder)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tage1;
        private System.Windows.Forms.Button btnTraSua;
        private System.Windows.Forms.Button btnTraDao;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvOder;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTileButton btnXoa;
        private Bunifu.Framework.UI.BunifuTileButton btnCapNhat;
        private Bunifu.Framework.UI.BunifuTileButton btnLuu;
        private Bunifu.Framework.UI.BunifuTileButton btnDong;
        private Bunifu.Framework.UI.BunifuTileButton btnTaoMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAMON;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMON;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
    }
}