using BUS;
using DAO;
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
    public partial class GiaoDienThongKe : UserControl
    {
        public GiaoDienThongKe()
        {
            InitializeComponent();
        }

        private void GiaoDienThongKe_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnXemThongKe_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtP_TuNgay.Value.Date; 
            DateTime denNgay = dtP_DenNgay.Value.Date;
            HoaDonDAO hoaDonDAO = new HoaDonDAO();
            DataTable thongKeTable = hoaDonDAO.LayThongKe(tuNgay, denNgay);
            dgv_ThongKe.DataSource = thongKeTable;
            chartThongKe.Series.Clear(); 
            chartThongKe.Titles.Clear(); 
            
            chartThongKe.Titles.Add("Doanh thu theo tháng"); 
            foreach (DataRow row in thongKeTable.Rows) {
                int year = (int)row["Nam"]; 
                int month = (int)row["Thang"];
                
                double totalRevenue = (double)row["TongDoanhThu"]; 
                string seriesName = $"{year}-{month}"; 
                chartThongKe.Series.Add(seriesName); 
                chartThongKe.Series[seriesName].Points.AddY(totalRevenue); 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
