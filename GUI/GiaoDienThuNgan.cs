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
    public partial class GiaoDienThuNgan : Form
    {
        public GiaoDienThuNgan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình ? ", "Đồng ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có muốn đăng xuất ?", "Đồng ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }
        }

        private void giaoDienThuNganDatMon1_Load(object sender, EventArgs e)
        {

        }

        private void giaoDienThuNganDatMon1_Load_1(object sender, EventArgs e)
        {

        }

        private void GiaoDienThuNgan_Load(object sender, EventArgs e)
        {

        }

        private void giaoDienThuNganDatMon3_Load(object sender, EventArgs e)
        {

        }

        private void giaoDienThuNganDatMon3_Load_1(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            giaoDienThongKe1.Visible = false;
            giaoDienThuNganDatMon3.Visible = false;
            giaoDienThuNganNguoiDung1.Visible = true;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            giaoDienThongKe1.Visible = true;
            giaoDienThuNganDatMon3.Visible = false;
            giaoDienThuNganNguoiDung1.Visible = false;
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            giaoDienThongKe1.Visible = false;
            giaoDienThuNganDatMon3.Visible = false;
            giaoDienThuNganNguoiDung1.Visible = false;
        
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            giaoDienThongKe1.Visible = false;
            giaoDienThuNganDatMon3.Visible = true;
            giaoDienThuNganNguoiDung1.Visible = false;
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có muốn đăng xuất ?", "Đồng ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            giaoDienThongKe1.Visible = false;
            giaoDienThuNganDatMon3.Visible = true;
            giaoDienThuNganNguoiDung1.Visible = false;
            GiaoDienXuatHienThongTinNguoiDung giaoDienXuatHienThongTinNguoiDung = new GiaoDienXuatHienThongTinNguoiDung();
            giaoDienXuatHienThongTinNguoiDung.Show();
        }
    }
}
