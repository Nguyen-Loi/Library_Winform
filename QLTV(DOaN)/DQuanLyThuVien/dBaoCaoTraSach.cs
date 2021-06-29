using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace DQuanLyThuVien
{
    public partial class dBaoCaoTraSach : DevExpress.XtraEditors.XtraUserControl
    {
        public dBaoCaoTraSach()
        {
            InitializeComponent();
        }
        BUS_TraSach busTS = new BUS_TraSach();
        // phương thức chọn button BaoCao để lấy dữ liệu TraSach
        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            
            dgvDanhSachTraSach.DataSource = busTS.layDuLieuTraSach(dtNgayBatDau.Value, dtNgayKetThuc.Value);
            //crTraSach crTS = new crTraSach();
            //crTS.SetDataSource(dtReportTraSach);
            //crvTraSach.ReportSource = crTS;
        }
        XReportTraSach xTS = new XReportTraSach();
        // nhấn button để xuất báo cáo
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            xTS.x = dtNgayBatDau.Value;
            xTS.y = dtNgayKetThuc.Value;
            xTS.Show();
        }
    }
}
