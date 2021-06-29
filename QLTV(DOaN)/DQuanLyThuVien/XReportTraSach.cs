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
    public partial class XReportTraSach : DevExpress.XtraEditors.XtraForm
    {
        public XReportTraSach()
        {
            InitializeComponent();
        }
        BUS_TraSach busTS = new BUS_TraSach();
        public DateTime x, y;
        private void XReportTraSach_Load(object sender, EventArgs e)
        {
          
            DataTable dtReportTraSach = busTS.layDuLieuTraSach(x, y);
            crTraSach crTS = new crTraSach();
            crTS.SetDataSource(dtReportTraSach);
            crvTraSach.ReportSource = crTS;
        }
    }
}