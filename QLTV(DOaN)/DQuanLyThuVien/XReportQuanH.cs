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
    public partial class XReportQuanH : DevExpress.XtraEditors.XtraForm
    {
        public XReportQuanH()
        {
            InitializeComponent();
        }
        BUS_ChiTietMuon busTS = new BUS_ChiTietMuon();
        private void XReportQuanH_Load(object sender, EventArgs e)
        {
            DataTable dtReportTraSach = busTS.getDaTaChiTietMuontrehan();
            crQuaHan crTS = new crQuaHan();
            crTS.SetDataSource(dtReportTraSach);
            crvHetHan.ReportSource = crTS;
        }
    }
}