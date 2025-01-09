using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class KhachHangDAO
    {
        private DatabaseConnection conn;

        public KhachHangDAO()
        {
            conn = new DatabaseConnection();
        }

        // Thêm khách hàng mới
        public bool ThemKhachHang(KhachHangDTO khachHang)
        {
            string query = "INSERT INTO KhachHang (id_KhachHang , TENKH, DT, EMAIL) VALUES (@idKhachHang,@TenKH, @DT, @Email)";
            try
            {
                conn.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, conn.GetConnection());
                cmd.Parameters.AddWithValue("@idKhachHang", khachHang.IdKhachHang);
                cmd.Parameters.AddWithValue("@TenKH", khachHang.TenKH);
                cmd.Parameters.AddWithValue("@DT", khachHang.Dt);
                cmd.Parameters.AddWithValue("@Email", khachHang.Email);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm khách hàng: " + ex.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        // Cập nhật thông tin khách hàng
        public bool CapNhatKhachHang(KhachHangDTO khachHang)
        {
            string query = "UPDATE KhachHang SET TENKH = @TenKH, DT = @DT, EMAIL = @Email WHERE id_KhachHang = @IdKhachHang";
            try
            {
                conn.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, conn.GetConnection());
                cmd.Parameters.AddWithValue("@IdKhachHang", khachHang.IdKhachHang);
                cmd.Parameters.AddWithValue("@TenKH", khachHang.TenKH);
                cmd.Parameters.AddWithValue("@DT", khachHang.Dt);
                cmd.Parameters.AddWithValue("@Email", khachHang.Email);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật khách hàng: " + ex.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }



        // Xóa khách hàng theo ID
        public bool XoaKhachHang(int idKhachHang)
        {
            string query = "DELETE FROM KhachHang WHERE id_KhachHang = @IdKhachHang";
            try
            {
                conn.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, conn.GetConnection());
                cmd.Parameters.AddWithValue("@IdKhachHang", idKhachHang);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa khách hàng: " + ex.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        public bool XoaTatCaKhachHang() { 
            string query = "DELETE FROM KhachHang";
            try { 
                conn.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, conn.GetConnection()); 
                int rowsAffected = cmd.ExecuteNonQuery(); 
                return rowsAffected > 0; 
            } catch (Exception ex) { 
                throw new Exception("Lỗi khi xóa tất cả khách hàng: " + ex.Message); 
            } finally {
                conn.CloseConnection(); 
            }
        }

        public DataTable LayTatCaKhachHang() { 
            DataTable khachHangTable = new DataTable(); 
            string query = "SELECT id_KhachHang, TENKH, DT, EMAIL FROM KhachHang"; 
            try { 
                conn.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, conn.GetConnection()); 
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(khachHangTable);
            } catch (Exception ex) { 
                throw new Exception("Lỗi khi lấy tất cả khách hàng: " + ex.Message);
            } finally {
                conn.CloseConnection();
            }
            return khachHangTable; 
        }
    }
}
