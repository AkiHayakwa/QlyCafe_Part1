using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class TaiKhoanDAO
    {
        private DatabaseConnection conn;

        public TaiKhoanDAO()
        {
            conn = new DatabaseConnection();
        }

        // Lấy danh sách tất cả tài khoản
        public List<TaiKhoanDTO> GetAllTaiKhoan()
        {
            List<TaiKhoanDTO> taiKhoanList = new List<TaiKhoanDTO>();
            try
            {
                conn.OpenConnection();
                string query = "SELECT * FROM TaiKhoan";
                SqlCommand command = new SqlCommand(query, conn.GetConnection());
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    TaiKhoanDTO taiKhoan = new TaiKhoanDTO(
                        Convert.ToInt32(reader["id_TaiKhoan"]),
                        reader["TenNguoiDung"].ToString(),
                        reader["MatKhau"].ToString(),
                        reader["TrangThai"].ToString(),
                        reader["Quyen"].ToString(),
                        reader["HoVaTen"] != DBNull.Value ? reader["HoVaTen"].ToString() : "",
                        reader["SoDienThoai"] != DBNull.Value ? reader["SoDienThoai"].ToString() : "",
                        reader["Email"] != DBNull.Value ? reader["Email"].ToString() : "",
                        reader["NgayTao"] != DBNull.Value ? Convert.ToDateTime(reader["NgayTao"]) : DateTime.MinValue,
                        reader["GioiTinh"] != DBNull.Value ? reader["GioiTinh"].ToString() : "",
                        reader["CMND"] != DBNull.Value ? reader["CMND"].ToString() : "",
                        reader["Hinh"] != DBNull.Value ? (byte[])reader["Hinh"] : null
                    );
                    taiKhoanList.Add(taiKhoan);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách tài khoản: " + ex.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
            return taiKhoanList;
        }

        // Thêm tài khoản mới
        public bool AddTaiKhoan(TaiKhoanDTO taiKhoan)
        {
            try
            {
                conn.OpenConnection();
                string query = "INSERT INTO TaiKhoan (TenNguoiDung, MatKhau, TrangThai, Quyen, NgayTao) " +
                               "VALUES (@TenNguoiDung, @MatKhau, @TrangThai, @Quyen, @NgayTao)";
                SqlCommand command = new SqlCommand(query, conn.GetConnection());

                command.Parameters.AddWithValue("@TenNguoiDung", taiKhoan.TenNguoiDung);
                command.Parameters.AddWithValue("@MatKhau", taiKhoan.MatKhau);
                command.Parameters.AddWithValue("@TrangThai", taiKhoan.TrangThai);
                command.Parameters.AddWithValue("@Quyen", taiKhoan.Quyen);
                command.Parameters.AddWithValue("@NgayTao", taiKhoan.NgayTao);

                int result = command.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm tài khoản: " + ex.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        // Cập nhật thông tin tài khoản
        public bool UpdateTaiKhoan(TaiKhoanDTO taiKhoan)
        {
            try
            {
                conn.OpenConnection();
                string query = "UPDATE TaiKhoan SET TenNguoiDung = @TenNguoiDung, MatKhau = @MatKhau, " +
                               "TrangThai = @TrangThai, Quyen = @Quyen, HoVaTen = @HoVaTen, SoDienThoai = @SoDienThoai, Email = @Email, " +
                               "GioiTinh = @GioiTinh, CMND = @CMND, Hinh = @Hinh " +
                               "WHERE Id_TaiKhoan = @Id_TaiKhoan";
                SqlCommand command = new SqlCommand(query, conn.GetConnection());

                command.Parameters.AddWithValue("@Id_TaiKhoan", taiKhoan.Id_TaiKhoan);
                command.Parameters.AddWithValue("@TenNguoiDung", taiKhoan.TenNguoiDung);
                command.Parameters.AddWithValue("@MatKhau", taiKhoan.MatKhau);
                command.Parameters.AddWithValue("@TrangThai", taiKhoan.TrangThai);
                command.Parameters.AddWithValue("@Quyen", taiKhoan.Quyen);
                command.Parameters.AddWithValue("@HoVaTen", taiKhoan.HoVaTen);
                command.Parameters.AddWithValue("@SoDienThoai", taiKhoan.dienThoai);
                command.Parameters.AddWithValue("@Email", taiKhoan.Email);
                command.Parameters.AddWithValue("@GioiTinh", taiKhoan.GioiTinh);
                command.Parameters.AddWithValue("@CMND", taiKhoan.CMND);
                command.Parameters.AddWithValue("@Hinh", taiKhoan.Hinh);

                int result = command.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật tài khoản: " + ex.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        // Xóa tài khoản theo ID
        public bool DeleteTaiKhoan(int idTaiKhoan)
        {
            try
            {
                conn.OpenConnection();
                string query = "DELETE FROM TaiKhoan WHERE id_TaiKhoan = @Id";
                SqlCommand command = new SqlCommand(query, conn.GetConnection());
                command.Parameters.AddWithValue("@Id", idTaiKhoan);
                int result = command.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa tài khoản: " + ex.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        // Lấy tài khoản theo ID
        public TaiKhoanDTO GetTaiKhoanById(int idTaiKhoan)
        {
            TaiKhoanDTO taiKhoan = null;
            try
            {
                conn.OpenConnection();
                string query = "SELECT * FROM TaiKhoan WHERE id_TaiKhoan = @Id";
                SqlCommand command = new SqlCommand(query, conn.GetConnection());
                command.Parameters.AddWithValue("@Id", idTaiKhoan);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    taiKhoan = new TaiKhoanDTO(
                        Convert.ToInt32(reader["id_TaiKhoan"]),
                        reader["TenNguoiDung"].ToString(),
                        reader["MatKhau"].ToString(),
                        reader["TrangThai"].ToString(),
                        reader["Quyen"].ToString(),
                        reader["HoVaTen"] != DBNull.Value ? reader["HoVaTen"].ToString() : "",
                        reader["SoDienThoai"] != DBNull.Value ? reader["SoDienThoai"].ToString() : "",
                        reader["Email"] != DBNull.Value ? reader["Email"].ToString() : "",
                        reader["NgayTao"] != DBNull.Value ? Convert.ToDateTime(reader["NgayTao"]) : DateTime.MinValue,
                        reader["GioiTinh"] != DBNull.Value ? reader["GioiTinh"].ToString() : "",
                        reader["CMND"] != DBNull.Value ? reader["CMND"].ToString() : "",
                        reader["Hinh"] != DBNull.Value ? (byte[])reader["Hinh"] : null
                    );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy tài khoản theo ID: " + ex.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
            return taiKhoan;
        }

        // Đăng nhập
        public string Login(string tenNguoiDung, string matKhau)
        {
            try
            {
                conn.OpenConnection();
                string query = "SELECT Quyen FROM TaiKhoan WHERE TenNguoiDung = @TenNguoiDung AND MatKhau = @MatKhau AND TrangThai = N'Hoạt động'";
                SqlCommand command = new SqlCommand(query, conn.GetConnection());
                command.Parameters.AddWithValue("@TenNguoiDung", tenNguoiDung);
                command.Parameters.AddWithValue("@MatKhau", matKhau);

                object result = command.ExecuteScalar(); // Trả về quyền của người dùng nếu đăng nhập hợp lệ

                if (result != null)
                {
                    return result.ToString(); // Trả về quyền của người dùng
                }
                return null; // Nếu không có tài khoản hoặc mật khẩu không chính xác
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi đăng nhập: " + ex.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }
        // Reset mật khẩu
        public bool ResetPassword(string username, string newPassword)
        {
            try
            {
                conn.OpenConnection();
                string query = "UPDATE TaiKhoan SET MatKhau = @MatKhau WHERE TenNguoiDung = @TenNguoiDung";
                SqlCommand cmd = new SqlCommand(query, conn.GetConnection());

                cmd.Parameters.AddWithValue("@MatKhau", newPassword);
                cmd.Parameters.AddWithValue("@TenNguoiDung", username);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;  // Nếu có ít nhất 1 dòng bị ảnh hưởng, trả về true
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi reset mật khẩu: " + ex.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        // Cập nhật thông tin cá nhân
        public bool UpdatePersonalInfo(TaiKhoanDTO taiKhoan)
        {
            try
            {
                conn.OpenConnection();
                string query = "UPDATE TaiKhoan SET HoVaTen = @HoVaTen, GioiTinh = @GioiTinh, SoDienThoai = @SoDienThoai,Email = @Email ,  CMND = @CMND, Hinh = @Hinh WHERE id_TaiKhoan = @Id_TaiKhoan";
                SqlCommand command = new SqlCommand(query, conn.GetConnection());
                command.Parameters.AddWithValue("@Id_TaiKhoan", taiKhoan.Id_TaiKhoan);
                command.Parameters.AddWithValue("@HoVaTen", taiKhoan.HoVaTen);
                command.Parameters.AddWithValue("@GioiTinh", taiKhoan.GioiTinh);
                command.Parameters.AddWithValue("@SoDienThoai", taiKhoan.dienThoai);
                command.Parameters.AddWithValue("@Email", taiKhoan.Email);
                command.Parameters.AddWithValue("@CMND", taiKhoan.CMND);
                command.Parameters.AddWithValue("@Hinh", (object)taiKhoan.Hinh ?? DBNull.Value);

                int result = command.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật thông tin cá nhân: " + ex.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        public int GetCurrentUserId(string tenNguoiDung)
        {
            try
            {
                conn.OpenConnection();
                string query = "SELECT id_TaiKhoan FROM TaiKhoan WHERE TenNguoiDung = @TenNguoiDung";
                SqlCommand command = new SqlCommand(query, conn.GetConnection());
                command.Parameters.AddWithValue("@TenNguoiDung", tenNguoiDung);
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    throw new Exception("Không tìm thấy người dùng.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy ID người dùng: " + ex.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }
    }
}
