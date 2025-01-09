using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   

    public class TaiKhoanDTO
    {
        public int Id_TaiKhoan { get; set; }
        public string TenNguoiDung { get; set; }
        public string MatKhau { get; set; }
        public string TrangThai { get; set; }
        public string Quyen { get; set; }
        public string HoVaTen { get; set; }
        public string dienThoai {  get; set; }
        public string Email { get; set; }
        public DateTime NgayTao { get; set; }
        public TaiKhoanDTO() { }
        public string GioiTinh { get; set; } 
        public string CMND { get; set; }
        public byte[] Hinh { get; set; }
        public TaiKhoanDTO(int id, string tenNguoiDung, string matKhau, string trangThai, string quyen, string Hovaten, string dienthoai, string email, DateTime ngaytao, string gioiTinh, string cmnd, byte[] hinh)
        {
            Id_TaiKhoan = id;
            TenNguoiDung = tenNguoiDung;
            MatKhau = matKhau;
            TrangThai = trangThai;
            Quyen = quyen;
            HoVaTen = Hovaten;
            dienThoai = dienthoai;
            Email = email;
            NgayTao = ngaytao;
            GioiTinh = gioiTinh;
            CMND = cmnd;
            Hinh = hinh;
        }
    }
}
