using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class GiaoDienThongKeHoaDon : UserControl
    {
        public GiaoDienThongKeHoaDon()
        {
            InitializeComponent();
        }

        private void btnXemThongKe_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtP_TuNgay.Value;
            int year = selectedDate.Year; 
            int month = selectedDate.Month; 
            HoaDonDAO hoaDonDAO = new HoaDonDAO(); 
            DataTable hoaDonTable = hoaDonDAO.LayHoaDonTheoThang(year, month);
            dgv_ThongKe.DataSource = hoaDonTable;
            chartThongKe.Series.Clear(); 
            chartThongKe.Titles.Clear();
            chartThongKe.Titles.Add("Số lượng hóa đơn trong tháng"); 
            chartThongKe.ChartAreas[0].AxisX.Title = "Ngày"; 
            chartThongKe.ChartAreas[0].AxisY.Title = "Số lượng hóa đơn";
            Series series = new Series("Số lượng hóa đơn");
            series.ChartType = SeriesChartType.Column; 
            var hoaDonCounts = hoaDonTable.AsEnumerable() .GroupBy(row => row.Field<DateTime>("Ngay").Day) .Select(g => new { Day = g.Key, Count = g.Count() }) .ToList();
            foreach (var count in hoaDonCounts) { 
                series.Points.AddXY(count.Day, count.Count); 
            } 
            chartThongKe.Series.Add(series);
        }
    }
}
