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
    public partial class GiaoDienThemKhachHang : Form
    {
        private KhachHangBus khachHangBus;
        public GiaoDienThemKhachHang()
        {
            InitializeComponent();
            khachHangBus = new KhachHangBus();
            LoadCustomerData();

            dgv_Customer.CellClick += new DataGridViewCellEventHandler(dgv_Customer_CellClick);
        }

        private void LoadCustomerData()
        {
            dgv_Customer.DataSource = khachHangBus.LayTatCaKhachHang();
            dgv_Customer.Columns["id_KhachHang"].HeaderText = "ID Khách Hàng";
            dgv_Customer.Columns["TENKH"].HeaderText = "Tên Khách Hàng";
            dgv_Customer.Columns["DT"].HeaderText = "Điện Thoại";
            dgv_Customer.Columns["EMAIL"].HeaderText = "Email";
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            KhachHangDTO khachHang = new KhachHangDTO
            {
                IdKhachHang = int.Parse(CustomerId.Text),
                TenKH = CustomerName.Text,
                Dt = CustomerPhone.Text,
                Email = CustomerEmail.Text
            };
            if (khachHangBus.ThemKhachHang(khachHang))
            {
                MessageBox.Show("Thêm khách hàng thành công!");
                LoadCustomerData();
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại.");
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CustomerId.Text))
            {
                int idKhachHang = Convert.ToInt32(CustomerId.Text);

                KhachHangDTO khachHang = new KhachHangDTO
                {
                    IdKhachHang = idKhachHang,
                    TenKH = CustomerName.Text,
                    Dt = CustomerPhone.Text,
                    Email = CustomerEmail.Text
                };

                if (khachHangBus.CapNhatKhachHang(khachHang))
                {
                    MessageBox.Show("Cập nhật khách hàng thành công!");
                    LoadCustomerData();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Cập nhật khách hàng thất bại.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng để cập nhật.");
            }
        }


        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CustomerId.Text))
            {
                int idKhachHang = Convert.ToInt32(CustomerId.Text);

                if (khachHangBus.XoaKhachHang(idKhachHang))
                {
                    MessageBox.Show("Xóa khách hàng thành công!");
                    LoadCustomerData();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Xóa khách hàng thất bại.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xóa.");
            }
        }


        private void btnClearCustomer_Click(object sender, EventArgs e)
        {
                LoadCustomerData();
                ClearInputFields(); 
        }
        private void GiaoDienThemKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClearInputFields() { 
            CustomerId.Clear(); 
            CustomerName.Clear(); 
            CustomerPhone.Clear(); 
            CustomerEmail.Clear();
        }

        private void dgv_Customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_Customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_Customer.Rows[e.RowIndex];
                CustomerId.Text = selectedRow.Cells["id_KhachHang"].Value.ToString();
                CustomerName.Text = selectedRow.Cells["TENKH"].Value.ToString();
                CustomerPhone.Text = selectedRow.Cells["DT"].Value.ToString();
                CustomerEmail.Text = selectedRow.Cells["EMAIL"].Value.ToString();
            }
        }
    }
}
