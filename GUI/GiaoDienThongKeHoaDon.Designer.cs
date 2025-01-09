namespace GUI
{
    partial class GiaoDienThongKeHoaDon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgv_ThongKe = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnXemThongKe = new System.Windows.Forms.Button();
            this.chartThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtP_DenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtP_TuNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKe)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ThongKe
            // 
            this.dgv_ThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ThongKe.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongKe.Location = new System.Drawing.Point(631, 46);
            this.dgv_ThongKe.Name = "dgv_ThongKe";
            this.dgv_ThongKe.Size = new System.Drawing.Size(591, 653);
            this.dgv_ThongKe.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnXemThongKe);
            this.groupBox1.Controls.Add(this.chartThongKe);
            this.groupBox1.Controls.Add(this.dtP_DenNgay);
            this.groupBox1.Controls.Add(this.dtP_TuNgay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 653);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lọc dữ liệu";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(252, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 37);
            this.button3.TabIndex = 7;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnXemThongKe
            // 
            this.btnXemThongKe.Location = new System.Drawing.Point(54, 145);
            this.btnXemThongKe.Name = "btnXemThongKe";
            this.btnXemThongKe.Size = new System.Drawing.Size(130, 37);
            this.btnXemThongKe.TabIndex = 5;
            this.btnXemThongKe.Text = "Xem";
            this.btnXemThongKe.UseVisualStyleBackColor = true;
            this.btnXemThongKe.Click += new System.EventHandler(this.btnXemThongKe_Click);
            // 
            // chartThongKe
            // 
            chartArea3.Name = "ChartArea1";
            this.chartThongKe.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartThongKe.Legends.Add(legend3);
            this.chartThongKe.Location = new System.Drawing.Point(35, 210);
            this.chartThongKe.Name = "chartThongKe";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartThongKe.Series.Add(series3);
            this.chartThongKe.Size = new System.Drawing.Size(460, 418);
            this.chartThongKe.TabIndex = 4;
            this.chartThongKe.Text = "chart1";
            // 
            // dtP_DenNgay
            // 
            this.dtP_DenNgay.Location = new System.Drawing.Point(113, 93);
            this.dtP_DenNgay.Name = "dtP_DenNgay";
            this.dtP_DenNgay.Size = new System.Drawing.Size(200, 25);
            this.dtP_DenNgay.TabIndex = 3;
            // 
            // dtP_TuNgay
            // 
            this.dtP_TuNgay.Location = new System.Drawing.Point(113, 44);
            this.dtP_TuNgay.Name = "dtP_TuNgay";
            this.dtP_TuNgay.Size = new System.Drawing.Size(200, 25);
            this.dtP_TuNgay.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến Ngày :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ Ngày : ";
            // 
            // GiaoDienThongKeHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_ThongKe);
            this.Controls.Add(this.groupBox1);
            this.Name = "GiaoDienThongKeHoaDon";
            this.Size = new System.Drawing.Size(1251, 745);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ThongKe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnXemThongKe;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKe;
        private System.Windows.Forms.DateTimePicker dtP_DenNgay;
        private System.Windows.Forms.DateTimePicker dtP_TuNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
