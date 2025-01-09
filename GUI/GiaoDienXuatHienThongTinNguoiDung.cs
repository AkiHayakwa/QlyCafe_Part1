using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GiaoDienXuatHienThongTinNguoiDung : Form
    {
        private TaiKhoanBus taiKhoanBus;
        public GiaoDienXuatHienThongTinNguoiDung()
        {
            InitializeComponent();
            taiKhoanBus = new TaiKhoanBus();
        }

        private void GiaoDienXuatHienThongTinNguoiDung_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnLayAnhFolder_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                PictureBoxSuaAnh.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void LoadData() {
            try {
                int idNhanVien = Form1.idSession; 
                TaiKhoanDTO taiKhoan = taiKhoanBus.GetTaiKhoanById(idNhanVien);
                if (taiKhoan != null) {
                    textBoxIdNhanVien.Text = idNhanVien.ToString();
                    textBoxHoVaTen.Text = taiKhoan.HoVaTen;
                    if (taiKhoan.GioiTinh == "Nam") 
                        rButtonNam.Checked = true; 
                    else if (taiKhoan.GioiTinh == "Nu") 
                        rButtonNu.Checked = true;
                    textBoxSoDienThoai.Text = taiKhoan.dienThoai;
                    textBoxEmail.Text = taiKhoan.Email;
                    textBoxCMND.Text = taiKhoan.CMND; 
                    if (taiKhoan.Hinh != null) { 
                        MemoryStream ms = new MemoryStream(taiKhoan.Hinh); 
                        PictureBoxSuaAnh.Image = Image.FromStream(ms);
                    } else { 
                        PictureBoxSuaAnh.Image = null;
                    }
                }
            } catch (Exception ex) { 
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void UpdateData()
        {
            try { TaiKhoanDTO taiKhoan = new TaiKhoanDTO { 
                Id_TaiKhoan = Convert.ToInt32(textBoxIdNhanVien.Text), 
                HoVaTen = textBoxHoVaTen.Text,
                GioiTinh = rButtonNam.Checked ? "Nam" : "Nu", 
                dienThoai = textBoxSoDienThoai.Text,
                Email = textBoxEmail.Text,
                CMND = textBoxCMND.Text
            };
                if (PictureBoxSuaAnh.Image != null) { 
                    MemoryStream ms = new MemoryStream(); 
                    PictureBoxSuaAnh.Image.Save(ms, PictureBoxSuaAnh.Image.RawFormat); 
                    taiKhoan.Hinh = ms.ToArray(); 
                } else { 
                    taiKhoan.Hinh = null; 
                }
                if (taiKhoanBus.UpdatePersonalInfo(taiKhoan))
                    MessageBox.Show("Cập nhật thành công!"); 
                else MessageBox.Show("Không có dòng nào được cập nhật.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message);
            }
        }

        private void BtnUpdateData_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void BtnLoadData_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoanDTO taiKhoan = new TaiKhoanDTO
                {
                    Id_TaiKhoan = Convert.ToInt32(textBoxIdNhanVien.Text),
                    HoVaTen = textBoxHoVaTen.Text,
                    GioiTinh = rButtonNam.Checked ? "Nam" : "Nu",
                    dienThoai = textBoxSoDienThoai.Text,
                    Email = textBoxEmail.Text,
                    CMND = textBoxCMND.Text
                };

                if (PictureBoxSuaAnh.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        PictureBoxSuaAnh.Image.Save(ms, PictureBoxSuaAnh.Image.RawFormat);
                        taiKhoan.Hinh = ms.ToArray();
                    }
                }
                else
                {
                    taiKhoan.Hinh = null;
                }

                TaiKhoanBus taiKhoanBus = new TaiKhoanBus();
                bool isUpdated = taiKhoanBus.UpdatePersonalInfo(taiKhoan);

                if (isUpdated)
                {
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không có dòng nào được cập nhật.", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin: " + ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
