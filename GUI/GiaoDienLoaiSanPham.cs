using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GiaoDienLoaiSanPham : UserControl
    {
        private DanhMucBUS danhMucBus;
        public GiaoDienLoaiSanPham()
        {
            InitializeComponent();
            danhMucBus = new DanhMucBUS();

            dgv_Category.CellClick += new DataGridViewCellEventHandler(dgv_Category_CellClick);
        }

        private void CategoryId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            DanhMucDTO danhMuc = new DanhMucDTO { 
                TenDanhMuc = CategoryName.Text 
            };
            if (danhMucBus.AddDanhMuc(danhMuc)) { 
                MessageBox.Show("Thêm danh mục thành công!"); 
                LoadCategoryData(); 
                ClearInputFields(); 
            } else { 
                MessageBox.Show("Thêm danh mục thất bại.");
            }
        }

        private void GiaoDienLoaiSanPham_Load(object sender, EventArgs e)
        {
            LoadCategoryData();
        }

        private void LoadCategoryData() { 
            try {
                dgv_Category.DataSource = danhMucBus.GetAllDanhMuc(); 
                dgv_Category.Columns["id_DanhMuc"].HeaderText = "ID Danh Mục"; 
                dgv_Category.Columns["TenDanhMuc"].HeaderText = "Tên Danh Mục"; 
            } catch (Exception ex) { 
                MessageBox.Show("Lỗi khi tải dữ liệu danh mục: " + ex.Message);
            } 
        }

        // Xóa danh mục
        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (dgv_Category.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_Category.SelectedRows[0];
                int idDanhMuc = Convert.ToInt32(selectedRow.Cells["id_DanhMuc"].Value);

                if (danhMucBus.DeleteDanhMuc(idDanhMuc))
                {
                    MessageBox.Show("Xóa danh mục thành công!");
                    LoadCategoryData();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Xóa danh mục thất bại.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn danh mục để xóa.");
            }
        }

        // Phương thức xóa trắng các ô nhập liệu
        private void ClearInputFields()
        {
            CategoryId.Clear();
            CategoryName.Clear();
        }

        // Sự kiện CellClick của DataGridView (để điền thông tin danh mục vào TextBox)
        private void dgv_Category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_Category.Rows[e.RowIndex];

                CategoryId.Text = selectedRow.Cells["id_DanhMuc"].Value.ToString();
                CategoryName.Text = selectedRow.Cells["TenDanhMuc"].Value.ToString();
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CategoryId.Text)) {
                int idDanhMuc; if (int.TryParse(CategoryId.Text, out idDanhMuc)) { 
                    DanhMucDTO danhMuc = new DanhMucDTO {
                        Id_danhMuc = idDanhMuc, 
                        TenDanhMuc = CategoryName.Text 
                    }; 
                    if (danhMucBus.UpdateDanhMuc(danhMuc)) {
                        MessageBox.Show("Cập nhật danh mục thành công!"); 
                        LoadCategoryData(); ClearInputFields(); 
                    } else { 
                        MessageBox.Show("Cập nhật danh mục thất bại."); 
                    } 
                } else {
                    MessageBox.Show("ID danh mục không hợp lệ."); 
                } 
            } else {
                MessageBox.Show("Vui lòng chọn danh mục để cập nhật."); 
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
                if (!string.IsNullOrEmpty(CategoryId.Text))
                {
                    int idDanhMuc = Convert.ToInt32(CategoryId.Text);

                    if (danhMucBus.DeleteDanhMuc(idDanhMuc))
                    {
                        MessageBox.Show("Xóa danh mục thành công!");
                        LoadCategoryData();
                        ClearInputFields();
                    }
                    else
                    {
                        MessageBox.Show("Xóa danh mục thất bại.");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn danh mục để xóa.");
                }
            }

    }

}
