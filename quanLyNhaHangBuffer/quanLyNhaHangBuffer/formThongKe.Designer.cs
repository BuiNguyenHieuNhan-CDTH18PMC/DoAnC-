
namespace quanLyNhaHangBuffer
{
    partial class formThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThongKeNgay = new System.Windows.Forms.Button();
            this.btnThongKeThang = new System.Windows.Forms.Button();
            this.btnThongKeHH = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1609, 737);
            this.panel1.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(500, 14);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(634, 720);
            this.chart1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThongKeHH);
            this.groupBox1.Controls.Add(this.btnThongKeThang);
            this.groupBox1.Controls.Add(this.btnThongKeNgay);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 731);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // btnThongKeNgay
            // 
            this.btnThongKeNgay.Location = new System.Drawing.Point(64, 52);
            this.btnThongKeNgay.Name = "btnThongKeNgay";
            this.btnThongKeNgay.Size = new System.Drawing.Size(281, 39);
            this.btnThongKeNgay.TabIndex = 0;
            this.btnThongKeNgay.Text = "Thống kê ngày trong tháng";
            this.btnThongKeNgay.UseVisualStyleBackColor = true;
            this.btnThongKeNgay.Click += new System.EventHandler(this.btnThongKeNgay_Click);
            // 
            // btnThongKeThang
            // 
            this.btnThongKeThang.Location = new System.Drawing.Point(64, 127);
            this.btnThongKeThang.Name = "btnThongKeThang";
            this.btnThongKeThang.Size = new System.Drawing.Size(281, 39);
            this.btnThongKeThang.TabIndex = 1;
            this.btnThongKeThang.Text = "Thống kê tháng";
            this.btnThongKeThang.UseVisualStyleBackColor = true;
            this.btnThongKeThang.Click += new System.EventHandler(this.btnThongKeThang_Click);
            // 
            // btnThongKeHH
            // 
            this.btnThongKeHH.Location = new System.Drawing.Point(64, 202);
            this.btnThongKeHH.Name = "btnThongKeHH";
            this.btnThongKeHH.Size = new System.Drawing.Size(281, 39);
            this.btnThongKeHH.TabIndex = 2;
            this.btnThongKeHH.Text = "Thống kê hàng hóa";
            this.btnThongKeHH.UseVisualStyleBackColor = true;
            this.btnThongKeHH.Click += new System.EventHandler(this.btnThongKeHH_Click);
            // 
            // formThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1633, 761);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "formThongKe";
            this.Text = "formThongKe";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThongKeThang;
        private System.Windows.Forms.Button btnThongKeNgay;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnThongKeHH;
    }
}