
namespace quanLyNhaHangBuffer
{
    partial class formKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formKhachHang));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClose = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnRefresh = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnXoa = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnCapNhat = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnLuu = new Bunifu.Framework.UI.BunifuTileButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdiemtichluy = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kH = new quanLyNhaHangBuffer.KH();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHACHHANGTableAdapter = new quanLyNhaHangBuffer.KHTableAdapters.KHACHHANGTableAdapter();
            this.mAKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAHANGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIEMTLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtdiemtichluy);
            this.groupBox2.Controls.Add(this.txtsdt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.txtmakh);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txttenkh);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnCapNhat);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 800);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
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
            this.btnClose.Location = new System.Drawing.Point(278, 612);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 134);
            this.btnClose.TabIndex = 69;
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
            this.btnRefresh.Location = new System.Drawing.Point(102, 612);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(133, 134);
            this.btnRefresh.TabIndex = 68;
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
            this.btnXoa.Location = new System.Drawing.Point(363, 434);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(133, 134);
            this.btnXoa.TabIndex = 67;
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
            this.btnCapNhat.Location = new System.Drawing.Point(187, 434);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(6);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(133, 134);
            this.btnCapNhat.TabIndex = 66;
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
            this.btnLuu.Location = new System.Drawing.Point(13, 434);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(6);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(133, 134);
            this.btnLuu.TabIndex = 65;
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "MAHANG";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(227, 170);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(233, 31);
            this.comboBox1.TabIndex = 75;
            this.comboBox1.ValueMember = "MAHANG";
            // 
            // txtmakh
            // 
            this.txtmakh.Enabled = false;
            this.txtmakh.Location = new System.Drawing.Point(227, 65);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(233, 30);
            this.txtmakh.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 23);
            this.label5.TabIndex = 73;
            this.label5.Text = "Mã khách hàng";
            // 
            // txttenkh
            // 
            this.txttenkh.Location = new System.Drawing.Point(227, 120);
            this.txttenkh.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(233, 30);
            this.txttenkh.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 71;
            this.label2.Text = "Tên hạng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 70;
            this.label1.Text = "Tên khách hàng";
            // 
            // txtdiemtichluy
            // 
            this.txtdiemtichluy.Location = new System.Drawing.Point(227, 280);
            this.txtdiemtichluy.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtdiemtichluy.Name = "txtdiemtichluy";
            this.txtdiemtichluy.Size = new System.Drawing.Size(233, 30);
            this.txtdiemtichluy.TabIndex = 79;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(227, 226);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtsdt.MaxLength = 10;
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(233, 30);
            this.txtsdt.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 23);
            this.label4.TabIndex = 77;
            this.label4.Text = "Điểm tích lũy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 23);
            this.label3.TabIndex = 76;
            this.label3.Text = "SDT";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(513, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 776);
            this.panel1.TabIndex = 33;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAKHDataGridViewTextBoxColumn,
            this.tENKHDataGridViewTextBoxColumn,
            this.mAHANGDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.dIEMTLDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kHACHHANGBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1124, 776);
            this.dataGridView1.TabIndex = 0;
            // 
            // kH
            // 
            this.kH.DataSetName = "KH";
            this.kH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.kH;
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // mAKHDataGridViewTextBoxColumn
            // 
            this.mAKHDataGridViewTextBoxColumn.DataPropertyName = "MAKH";
            this.mAKHDataGridViewTextBoxColumn.HeaderText = "Mã khách hàng";
            this.mAKHDataGridViewTextBoxColumn.Name = "mAKHDataGridViewTextBoxColumn";
            // 
            // tENKHDataGridViewTextBoxColumn
            // 
            this.tENKHDataGridViewTextBoxColumn.DataPropertyName = "TENKH";
            this.tENKHDataGridViewTextBoxColumn.HeaderText = "Tên khách hàng";
            this.tENKHDataGridViewTextBoxColumn.Name = "tENKHDataGridViewTextBoxColumn";
            // 
            // mAHANGDataGridViewTextBoxColumn
            // 
            this.mAHANGDataGridViewTextBoxColumn.DataPropertyName = "TENHANG";
            this.mAHANGDataGridViewTextBoxColumn.HeaderText = "Tên hạng";
            this.mAHANGDataGridViewTextBoxColumn.Name = "mAHANGDataGridViewTextBoxColumn";
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SĐT";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            // 
            // dIEMTLDataGridViewTextBoxColumn
            // 
            this.dIEMTLDataGridViewTextBoxColumn.DataPropertyName = "DIEMTL";
            this.dIEMTLDataGridViewTextBoxColumn.HeaderText = "Điểm tích lũy";
            this.dIEMTLDataGridViewTextBoxColumn.Name = "dIEMTLDataGridViewTextBoxColumn";
            // 
            // formKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1649, 800);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "formKhachHang";
            this.Text = "formKhachHang";
            this.Load += new System.EventHandler(this.formKhachHang_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtdiemtichluy;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttenkh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuTileButton btnClose;
        private Bunifu.Framework.UI.BunifuTileButton btnRefresh;
        private Bunifu.Framework.UI.BunifuTileButton btnXoa;
        private Bunifu.Framework.UI.BunifuTileButton btnCapNhat;
        private Bunifu.Framework.UI.BunifuTileButton btnLuu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KH kH;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private KHTableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAHANGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIEMTLDataGridViewTextBoxColumn;
    }
}