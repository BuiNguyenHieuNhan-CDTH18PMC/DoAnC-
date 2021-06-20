
namespace quanLyNhaHangBuffer
{
    partial class formNhanVien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formNhanVien));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvNV = new System.Windows.Forms.DataGridView();
            this.mANVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOTENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sINHNHATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIACHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lUONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nV = new quanLyNhaHangBuffer.NV();
            this.nHANVIENTableAdapter = new quanLyNhaHangBuffer.NVTableAdapters.NHANVIENTableAdapter();
            this.btnClose = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnRefresh = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnXoa = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnCapNhat = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnLuu = new Bunifu.Framework.UI.BunifuTileButton();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnCapNhat);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.txtLuong);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.txtCCCD);
            this.groupBox2.Controls.Add(this.txtSDT);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtTenNV);
            this.groupBox2.Controls.Add(this.dtNgaySinh);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 800);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(208, 356);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(254, 30);
            this.txtLuong.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 54;
            this.label1.Text = "Lương căn bản";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(208, 297);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(254, 30);
            this.txtDiaChi.TabIndex = 48;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(208, 181);
            this.txtCCCD.MaxLength = 12;
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(254, 30);
            this.txtCCCD.TabIndex = 49;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(208, 121);
            this.txtSDT.MaxLength = 10;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(254, 30);
            this.txtSDT.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 23);
            this.label5.TabIndex = 43;
            this.label5.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 23);
            this.label3.TabIndex = 41;
            this.label3.Text = "SDT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 40;
            this.label2.Text = "Họ tên";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(208, 70);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(254, 30);
            this.txtTenNV.TabIndex = 46;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.CustomFormat = "yyyy-MM-dd";
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaySinh.Location = new System.Drawing.Point(208, 237);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(254, 30);
            this.dtNgaySinh.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 23);
            this.label6.TabIndex = 44;
            this.label6.Text = "CCCD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 23);
            this.label4.TabIndex = 42;
            this.label4.Text = "Ngày sinh";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvNV);
            this.panel1.Location = new System.Drawing.Point(513, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 776);
            this.panel1.TabIndex = 32;
            // 
            // dtgvNV
            // 
            this.dtgvNV.AutoGenerateColumns = false;
            this.dtgvNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvNV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mANVDataGridViewTextBoxColumn,
            this.hOTENDataGridViewTextBoxColumn,
            this.sINHNHATDataGridViewTextBoxColumn,
            this.dIACHIDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.cCCDDataGridViewTextBoxColumn,
            this.lUONGDataGridViewTextBoxColumn});
            this.dtgvNV.DataSource = this.nHANVIENBindingSource;
            this.dtgvNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvNV.Location = new System.Drawing.Point(0, 0);
            this.dtgvNV.Name = "dtgvNV";
            this.dtgvNV.RowHeadersVisible = false;
            this.dtgvNV.Size = new System.Drawing.Size(1124, 776);
            this.dtgvNV.TabIndex = 0;
            this.dtgvNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvNV_CellClick);
            // 
            // mANVDataGridViewTextBoxColumn
            // 
            this.mANVDataGridViewTextBoxColumn.DataPropertyName = "MANV";
            this.mANVDataGridViewTextBoxColumn.HeaderText = "Mã nhân viên";
            this.mANVDataGridViewTextBoxColumn.Name = "mANVDataGridViewTextBoxColumn";
            this.mANVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hOTENDataGridViewTextBoxColumn
            // 
            this.hOTENDataGridViewTextBoxColumn.DataPropertyName = "HOTEN";
            this.hOTENDataGridViewTextBoxColumn.HeaderText = "Họ tên";
            this.hOTENDataGridViewTextBoxColumn.Name = "hOTENDataGridViewTextBoxColumn";
            // 
            // sINHNHATDataGridViewTextBoxColumn
            // 
            this.sINHNHATDataGridViewTextBoxColumn.DataPropertyName = "SINHNHAT";
            this.sINHNHATDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.sINHNHATDataGridViewTextBoxColumn.Name = "sINHNHATDataGridViewTextBoxColumn";
            // 
            // dIACHIDataGridViewTextBoxColumn
            // 
            this.dIACHIDataGridViewTextBoxColumn.DataPropertyName = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.dIACHIDataGridViewTextBoxColumn.Name = "dIACHIDataGridViewTextBoxColumn";
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SĐT";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            // 
            // cCCDDataGridViewTextBoxColumn
            // 
            this.cCCDDataGridViewTextBoxColumn.DataPropertyName = "CCCD";
            this.cCCDDataGridViewTextBoxColumn.HeaderText = "CCCD";
            this.cCCDDataGridViewTextBoxColumn.Name = "cCCDDataGridViewTextBoxColumn";
            // 
            // lUONGDataGridViewTextBoxColumn
            // 
            this.lUONGDataGridViewTextBoxColumn.DataPropertyName = "LUONG";
            this.lUONGDataGridViewTextBoxColumn.HeaderText = "Lương căn bản";
            this.lUONGDataGridViewTextBoxColumn.Name = "lUONGDataGridViewTextBoxColumn";
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.nV;
            // 
            // nV
            // 
            this.nV.DataSetName = "NV";
            this.nV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.color = System.Drawing.Color.White;
            this.btnClose.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImagePosition = 21;
            this.btnClose.ImageZoom = 50;
            this.btnClose.LabelPosition = 43;
            this.btnClose.LabelText = "Làm mới";
            this.btnClose.Location = new System.Drawing.Point(276, 619);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 134);
            this.btnClose.TabIndex = 69;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.color = System.Drawing.Color.White;
            this.btnRefresh.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImagePosition = 21;
            this.btnRefresh.ImageZoom = 50;
            this.btnRefresh.LabelPosition = 43;
            this.btnRefresh.LabelText = "Làm mới";
            this.btnRefresh.Location = new System.Drawing.Point(95, 619);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(133, 134);
            this.btnRefresh.TabIndex = 68;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.color = System.Drawing.Color.White;
            this.btnXoa.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImagePosition = 21;
            this.btnXoa.ImageZoom = 50;
            this.btnXoa.LabelPosition = 43;
            this.btnXoa.LabelText = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(363, 441);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(133, 134);
            this.btnXoa.TabIndex = 67;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.White;
            this.btnCapNhat.color = System.Drawing.Color.White;
            this.btnCapNhat.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhat.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImagePosition = 21;
            this.btnCapNhat.ImageZoom = 50;
            this.btnCapNhat.LabelPosition = 43;
            this.btnCapNhat.LabelText = "Cập nhật";
            this.btnCapNhat.Location = new System.Drawing.Point(187, 441);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(6);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(133, 134);
            this.btnCapNhat.TabIndex = 66;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.color = System.Drawing.Color.White;
            this.btnLuu.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImagePosition = 21;
            this.btnLuu.ImageZoom = 50;
            this.btnLuu.LabelPosition = 43;
            this.btnLuu.LabelText = "Lưu";
            this.btnLuu.Location = new System.Drawing.Point(13, 441);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(6);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(133, 134);
            this.btnLuu.TabIndex = 65;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // formNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1649, 800);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "formNhanVien";
            this.Text = "formNhanVien";
            this.Load += new System.EventHandler(this.formNhanVien_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvNV;
        private NV nV;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private NVTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hOTENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sINHNHATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIACHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lUONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuTileButton btnClose;
        private Bunifu.Framework.UI.BunifuTileButton btnRefresh;
        private Bunifu.Framework.UI.BunifuTileButton btnXoa;
        private Bunifu.Framework.UI.BunifuTileButton btnCapNhat;
        private Bunifu.Framework.UI.BunifuTileButton btnLuu;
    }
}