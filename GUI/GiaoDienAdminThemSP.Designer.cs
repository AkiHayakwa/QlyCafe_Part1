namespace GUI
{
    partial class GiaoDienAdminThemSP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoDienAdminThemSP));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_Prod = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AdmPrd_Price = new System.Windows.Forms.TextBox();
            this.AdmPrd_NamePrd = new System.Windows.Forms.TextBox();
            this.AdmPrd_Status = new System.Windows.Forms.ComboBox();
            this.AdmPrd_Stock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AdmPrd_Category = new System.Windows.Forms.ComboBox();
            this.AdmPrd_IdPrd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddProd = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateProd = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteProd = new Guna.UI2.WinForms.Guna2Button();
            this.btnClearProd = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Prod)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dữ liệu Sản phẩm";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgv_Prod);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(28, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 359);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgv_Prod
            // 
            this.dgv_Prod.AllowUserToAddRows = false;
            this.dgv_Prod.AllowUserToDeleteRows = false;
            this.dgv_Prod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Prod.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Prod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Prod.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Prod.EnableHeadersVisualStyles = false;
            this.dgv_Prod.Location = new System.Drawing.Point(28, 49);
            this.dgv_Prod.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Prod.Name = "dgv_Prod";
            this.dgv_Prod.ReadOnly = true;
            this.dgv_Prod.RowHeadersVisible = false;
            this.dgv_Prod.RowHeadersWidth = 51;
            this.dgv_Prod.RowTemplate.Height = 24;
            this.dgv_Prod.Size = new System.Drawing.Size(1118, 296);
            this.dgv_Prod.TabIndex = 2;
            this.dgv_Prod.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Prod_CellClick);
            this.dgv_Prod.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Prod_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnClearProd);
            this.panel2.Controls.Add(this.btnDeleteProd);
            this.panel2.Controls.Add(this.btnUpdateProd);
            this.panel2.Controls.Add(this.btnAddProd);
            this.panel2.Controls.Add(this.AdmPrd_Price);
            this.panel2.Controls.Add(this.AdmPrd_NamePrd);
            this.panel2.Controls.Add(this.AdmPrd_Status);
            this.panel2.Controls.Add(this.AdmPrd_Stock);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.AdmPrd_Category);
            this.panel2.Controls.Add(this.AdmPrd_IdPrd);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(28, 410);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1165, 307);
            this.panel2.TabIndex = 3;
            // 
            // AdmPrd_Price
            // 
            this.AdmPrd_Price.Location = new System.Drawing.Point(770, 111);
            this.AdmPrd_Price.Name = "AdmPrd_Price";
            this.AdmPrd_Price.Size = new System.Drawing.Size(165, 20);
            this.AdmPrd_Price.TabIndex = 17;
            // 
            // AdmPrd_NamePrd
            // 
            this.AdmPrd_NamePrd.Location = new System.Drawing.Point(294, 107);
            this.AdmPrd_NamePrd.Name = "AdmPrd_NamePrd";
            this.AdmPrd_NamePrd.Size = new System.Drawing.Size(165, 20);
            this.AdmPrd_NamePrd.TabIndex = 16;
            // 
            // AdmPrd_Status
            // 
            this.AdmPrd_Status.FormattingEnabled = true;
            this.AdmPrd_Status.Items.AddRange(new object[] {
            "Còn",
            "Không Còn"});
            this.AdmPrd_Status.Location = new System.Drawing.Point(770, 157);
            this.AdmPrd_Status.Name = "AdmPrd_Status";
            this.AdmPrd_Status.Size = new System.Drawing.Size(165, 21);
            this.AdmPrd_Status.TabIndex = 11;
            // 
            // AdmPrd_Stock
            // 
            this.AdmPrd_Stock.Location = new System.Drawing.Point(770, 64);
            this.AdmPrd_Stock.Name = "AdmPrd_Stock";
            this.AdmPrd_Stock.Size = new System.Drawing.Size(165, 20);
            this.AdmPrd_Stock.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(640, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Trạng thái :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(684, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Giá : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(664, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Còn lại :";
            // 
            // AdmPrd_Category
            // 
            this.AdmPrd_Category.FormattingEnabled = true;
            this.AdmPrd_Category.Items.AddRange(new object[] {
            "Bánh Ngọt",
            "Trà Sữa ",
            "Sinh Tố",
            "Cafe"});
            this.AdmPrd_Category.Location = new System.Drawing.Point(294, 160);
            this.AdmPrd_Category.Name = "AdmPrd_Category";
            this.AdmPrd_Category.Size = new System.Drawing.Size(165, 21);
            this.AdmPrd_Category.TabIndex = 5;
            // 
            // AdmPrd_IdPrd
            // 
            this.AdmPrd_IdPrd.Location = new System.Drawing.Point(294, 62);
            this.AdmPrd_IdPrd.Name = "AdmPrd_IdPrd";
            this.AdmPrd_IdPrd.Size = new System.Drawing.Size(165, 20);
            this.AdmPrd_IdPrd.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(203, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Loại :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Sản Phẩm :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Sản Phẩm :";
            // 
            // btnAddProd
            // 
            this.btnAddProd.BorderRadius = 20;
            this.btnAddProd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddProd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddProd.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAddProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddProd.ForeColor = System.Drawing.Color.White;
            this.btnAddProd.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProd.Image")));
            this.btnAddProd.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddProd.Location = new System.Drawing.Point(182, 234);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(168, 41);
            this.btnAddProd.TabIndex = 22;
            this.btnAddProd.Text = "Thêm";
            // 
            // btnUpdateProd
            // 
            this.btnUpdateProd.BorderRadius = 20;
            this.btnUpdateProd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateProd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateProd.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdateProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProd.ForeColor = System.Drawing.Color.White;
            this.btnUpdateProd.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateProd.Image")));
            this.btnUpdateProd.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdateProd.Location = new System.Drawing.Point(382, 234);
            this.btnUpdateProd.Name = "btnUpdateProd";
            this.btnUpdateProd.Size = new System.Drawing.Size(168, 41);
            this.btnUpdateProd.TabIndex = 23;
            this.btnUpdateProd.Text = "Cập Nhật";
            // 
            // btnDeleteProd
            // 
            this.btnDeleteProd.BorderRadius = 20;
            this.btnDeleteProd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteProd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteProd.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProd.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProd.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteProd.Image")));
            this.btnDeleteProd.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteProd.Location = new System.Drawing.Point(590, 234);
            this.btnDeleteProd.Name = "btnDeleteProd";
            this.btnDeleteProd.Size = new System.Drawing.Size(168, 41);
            this.btnDeleteProd.TabIndex = 24;
            this.btnDeleteProd.Text = "Xóa";
            // 
            // btnClearProd
            // 
            this.btnClearProd.BorderRadius = 20;
            this.btnClearProd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClearProd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClearProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClearProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClearProd.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnClearProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearProd.ForeColor = System.Drawing.Color.White;
            this.btnClearProd.Image = ((System.Drawing.Image)(resources.GetObject("btnClearProd.Image")));
            this.btnClearProd.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClearProd.Location = new System.Drawing.Point(794, 234);
            this.btnClearProd.Name = "btnClearProd";
            this.btnClearProd.Size = new System.Drawing.Size(168, 41);
            this.btnClearProd.TabIndex = 25;
            this.btnClearProd.Text = "Xóa bỏ";
            // 
            // GiaoDienAdminThemSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GiaoDienAdminThemSP";
            this.Size = new System.Drawing.Size(1251, 745);
            this.Load += new System.EventHandler(this.GiaoDienAdminThemSP_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Prod)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_Prod;
        private System.Windows.Forms.ComboBox AdmPrd_Category;
        private System.Windows.Forms.TextBox AdmPrd_IdPrd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox AdmPrd_Status;
        private System.Windows.Forms.TextBox AdmPrd_Stock;
        private System.Windows.Forms.TextBox AdmPrd_Price;
        private System.Windows.Forms.TextBox AdmPrd_NamePrd;
        private Guna.UI2.WinForms.Guna2Button btnAddProd;
        private Guna.UI2.WinForms.Guna2Button btnUpdateProd;
        private Guna.UI2.WinForms.Guna2Button btnDeleteProd;
        private Guna.UI2.WinForms.Guna2Button btnClearProd;
    }
}
