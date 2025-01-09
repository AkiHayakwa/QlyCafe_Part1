using BUS;
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
    public partial class GiaoDienThuNganNguoiDung : UserControl
    {
        private KhachHangBus khachHangBus;
        public GiaoDienThuNganNguoiDung()
        {
            InitializeComponent();
            khachHangBus = new KhachHangBus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GiaoDienThuNganNguoiDung_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        private void LoadCustomerData()
        {
            try
            {
                dgv_KhachHang.DataSource = khachHangBus.LayTatCaKhachHang();
                dgv_KhachHang.Columns["id_KhachHang"].HeaderText = "ID Khách Hàng";
                dgv_KhachHang.Columns["TENKH"].HeaderText = "Tên Khách Hàng";
                dgv_KhachHang.Columns["DT"].HeaderText = "Điện Thoại";
                dgv_KhachHang.Columns["EMAIL"].HeaderText = "Email";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu khách hàng: " + ex.Message);
            }
        }
            }
}
