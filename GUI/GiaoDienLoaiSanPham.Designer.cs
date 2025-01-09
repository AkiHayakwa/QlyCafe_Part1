namespace GUI
{
    partial class GiaoDienLoaiSanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoDienLoaiSanPham));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_Category = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClearCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteCategory = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateCategory = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddCategory = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CategoryName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CategoryId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Category)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dgv_Category);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(443, 37);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 670);
            this.panel2.TabIndex = 5;
            // 
            // dgv_Category
            // 
            this.dgv_Category.AllowUserToAddRows = false;
            this.dgv_Category.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Category.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Category.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Category.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Category.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Category.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Category.EnableHeadersVisualStyles = false;
            this.dgv_Category.Location = new System.Drawing.Point(20, 56);
            this.dgv_Category.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Category.Name = "dgv_Category";
            this.dgv_Category.ReadOnly = true;
            this.dgv_Category.RowHeadersVisible = false;
            this.dgv_Category.RowHeadersWidth = 51;
            this.dgv_Category.RowTemplate.Height = 24;
            this.dgv_Category.Size = new System.Drawing.Size(696, 612);
            this.dgv_Category.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dữ liệu Danh Mục ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnClearCustomer);
            this.panel1.Controls.Add(this.btnDeleteCategory);
            this.panel1.Controls.Add(this.btnUpdateCategory);
            this.panel1.Controls.Add(this.btnAddCategory);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.CategoryName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CategoryId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(38, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 670);
            this.panel1.TabIndex = 4;
            // 
            // btnClearCustomer
            // 
            this.btnClearCustomer.BorderRadius = 20;
            this.btnClearCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClearCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClearCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClearCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClearCustomer.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnClearCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCustomer.ForeColor = System.Drawing.Color.White;
            this.btnClearCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnClearCustomer.Image")));
            this.btnClearCustomer.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClearCustomer.Location = new System.Drawing.Point(174, 320);
            this.btnClearCustomer.Name = "btnClearCustomer";
            this.btnClearCustomer.Size = new System.Drawing.Size(168, 41);
            this.btnClearCustomer.TabIndex = 26;
            this.btnClearCustomer.Text = "Xóa bỏ";
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BorderRadius = 20;
            this.btnDeleteCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteCategory.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCategory.Image")));
            this.btnDeleteCategory.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteCategory.Location = new System.Drawing.Point(3, 320);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(168, 41);
            this.btnDeleteCategory.TabIndex = 25;
            this.btnDeleteCategory.Text = "Xóa";
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.BorderRadius = 20;
            this.btnUpdateCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateCategory.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdateCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCategory.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateCategory.Image")));
            this.btnUpdateCategory.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdateCategory.Location = new System.Drawing.Point(174, 223);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(168, 41);
            this.btnUpdateCategory.TabIndex = 24;
            this.btnUpdateCategory.Text = "Cập Nhật";
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BorderRadius = 20;
            this.btnAddCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddCategory.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAddCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCategory.Image")));
            this.btnAddCategory.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddCategory.Location = new System.Drawing.Point(3, 223);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(168, 41);
            this.btnAddCategory.TabIndex = 23;
            this.btnAddCategory.Text = "Thêm";
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(102, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Bảng nhập liệu";
            // 
            // CategoryName
            // 
            this.CategoryName.Location = new System.Drawing.Point(152, 144);
            this.CategoryName.Margin = new System.Windows.Forms.Padding(2);
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Size = new System.Drawing.Size(190, 20);
            this.CategoryName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Danh Mục :";
            // 
            // CategoryId
            // 
            this.CategoryId.Location = new System.Drawing.Point(152, 78);
            this.CategoryId.Margin = new System.Windows.Forms.Padding(2);
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.ReadOnly = true;
            this.CategoryId.Size = new System.Drawing.Size(190, 20);
            this.CategoryId.TabIndex = 2;
            this.CategoryId.TextChanged += new System.EventHandler(this.CategoryId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Danh Mục :";
            // 
            // GiaoDienLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GiaoDienLoaiSanPham";
            this.Size = new System.Drawing.Size(1251, 745);
            this.Load += new System.EventHandler(this.GiaoDienLoaiSanPham_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Category)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_Category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnClearCustomer;
        private Guna.UI2.WinForms.Guna2Button btnDeleteCategory;
        private Guna.UI2.WinForms.Guna2Button btnUpdateCategory;
        private Guna.UI2.WinForms.Guna2Button btnAddCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CategoryName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CategoryId;
        private System.Windows.Forms.Label label2;
    }
}
