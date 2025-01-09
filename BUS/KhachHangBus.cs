using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAO;
using DTO;

namespace BUS
{
    public class KhachHangBus
    {
        private KhachHangDAO khachHangDAO;

        public KhachHangBus()
        {
            khachHangDAO = new KhachHangDAO();
        }

        public DataTable LayTatCaKhachHang() { 
            return khachHangDAO.LayTatCaKhachHang();
        }
        // Thêm khách hàng mới
        public bool ThemKhachHang(KhachHangDTO khachHang)
        {
            return khachHangDAO.ThemKhachHang(khachHang);
        }

        // Cập nhật thông tin khách hàng
        public bool CapNhatKhachHang(KhachHangDTO khachHang)
        {
            return khachHangDAO.CapNhatKhachHang(khachHang);
        }

        // Xóa khách hàng theo ID
        public bool XoaKhachHang(int idKhachHang)
        {
            return khachHangDAO.XoaKhachHang(idKhachHang);
        }

        public bool XoaTatCaKhachHang() { 
            return khachHangDAO.XoaTatCaKhachHang();
        }
    }
}

