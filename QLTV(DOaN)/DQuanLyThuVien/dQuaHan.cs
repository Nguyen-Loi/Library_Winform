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
    public partial class dQuaHan : DevExpress.XtraEditors.XtraUserControl
    {
        public dQuaHan()
        {
            InitializeComponent();
        }
        BUS_ChiTietMuon busCTMuon = new BUS_ChiTietMuon();
        // truyền dữ liệu khi form được dùng
        private void dQuaHan_Load(object sender, EventArgs e)
        {
            dgvHetHan.DataSource = busCTMuon.getDaTaChiTietMuon();
        }
        // chuyển form và xuất báo cáo
        private void btnIn_Click(object sender, EventArgs e)
        {
            // chuyển form
            XReportQuanH rQH = new XReportQuanH();
            rQH.Show();
        }
    }
}
