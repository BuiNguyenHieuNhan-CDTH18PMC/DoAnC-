
namespace quanLyNhaHangBuffer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.panelDM = new System.Windows.Forms.Panel();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnChiTietLich = new System.Windows.Forms.Button();
            this.btnHH = new System.Windows.Forms.Button();
            this.btnNCC = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnDM = new System.Windows.Forms.Button();
            this.panelChild = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel.SuspendLayout();
            this.panelDM.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 150);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1742, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 931);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1920, 130);
            this.panel2.TabIndex = 1;
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.btnThongKe);
            this.panel.Controls.Add(this.btnNhapHang);
            this.panel.Controls.Add(this.btnBanHang);
            this.panel.Controls.Add(this.panelDM);
            this.panel.Controls.Add(this.btnDM);
            this.panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel.Location = new System.Drawing.Point(0, 150);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(271, 781);
            this.panel.TabIndex = 2;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.Location = new System.Drawing.Point(0, 558);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(269, 68);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhapHang.Location = new System.Drawing.Point(0, 490);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(269, 68);
            this.btnNhapHang.TabIndex = 3;
            this.btnNhapHang.Text = "Nhập hàng";
            this.btnNhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhapHang.UseVisualStyleBackColor = true;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBanHang.Location = new System.Drawing.Point(0, 422);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(269, 68);
            this.btnBanHang.TabIndex = 2;
            this.btnBanHang.Text = "Bán hàng";
            this.btnBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBanHang.UseVisualStyleBackColor = true;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // panelDM
            // 
            this.panelDM.Controls.Add(this.btnKhachHang);
            this.panelDM.Controls.Add(this.btnChiTietLich);
            this.panelDM.Controls.Add(this.btnHH);
            this.panelDM.Controls.Add(this.btnNCC);
            this.panelDM.Controls.Add(this.btnNhanVien);
            this.panelDM.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDM.Location = new System.Drawing.Point(0, 68);
            this.panelDM.Name = "panelDM";
            this.panelDM.Size = new System.Drawing.Size(269, 354);
            this.panelDM.TabIndex = 1;
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhachHang.Location = new System.Drawing.Point(0, 68);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(269, 71);
            this.btnKhachHang.TabIndex = 5;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnChiTietLich
            // 
            this.btnChiTietLich.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnChiTietLich.Location = new System.Drawing.Point(0, 138);
            this.btnChiTietLich.Name = "btnChiTietLich";
            this.btnChiTietLich.Size = new System.Drawing.Size(269, 74);
            this.btnChiTietLich.TabIndex = 4;
            this.btnChiTietLich.Text = "Chi tiết thời gian làm";
            this.btnChiTietLich.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChiTietLich.UseVisualStyleBackColor = true;
            this.btnChiTietLich.Click += new System.EventHandler(this.btnChiTietLich_Click);
            // 
            // btnHH
            // 
            this.btnHH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnHH.Location = new System.Drawing.Point(0, 212);
            this.btnHH.Name = "btnHH";
            this.btnHH.Size = new System.Drawing.Size(269, 71);
            this.btnHH.TabIndex = 3;
            this.btnHH.Text = "Hàng hóa";
            this.btnHH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHH.UseVisualStyleBackColor = true;
            this.btnHH.Click += new System.EventHandler(this.btnHH_Click);
            // 
            // btnNCC
            // 
            this.btnNCC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNCC.Location = new System.Drawing.Point(0, 283);
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.Size = new System.Drawing.Size(269, 71);
            this.btnNCC.TabIndex = 2;
            this.btnNCC.Text = "Nhà cung cấp";
            this.btnNCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNCC.UseVisualStyleBackColor = true;
            this.btnNCC.Click += new System.EventHandler(this.btnNCC_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 0);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(269, 68);
            this.btnNhanVien.TabIndex = 1;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnDM
            // 
            this.btnDM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDM.Location = new System.Drawing.Point(0, 0);
            this.btnDM.Name = "btnDM";
            this.btnDM.Size = new System.Drawing.Size(269, 68);
            this.btnDM.TabIndex = 0;
            this.btnDM.Text = "Danh mục";
            this.btnDM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDM.UseVisualStyleBackColor = true;
            this.btnDM.Click += new System.EventHandler(this.btnDM_Click);
            // 
            // panelChild
            // 
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChild.Location = new System.Drawing.Point(271, 150);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(1649, 781);
            this.panelChild.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1061);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel.ResumeLayout(false);
            this.panelDM.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panelDM;
        private System.Windows.Forms.Button btnNCC;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnDM;
        private System.Windows.Forms.Panel panelChild;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnHH;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnChiTietLich;
        private System.Windows.Forms.Button btnKhachHang;
    }
}

