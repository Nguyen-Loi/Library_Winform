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

namespace DQuanLyThuVien_Admin_
{
    public partial class frmReport_ALL : DevExpress.XtraEditors.XtraForm
    {
        public frmReport_ALL()
        {
            InitializeComponent();
        }
        BUS_ChiTietMuon busTS = new BUS_ChiTietMuon();
        private void frmReport_ALL_Load(object sender, EventArgs e)
        {
            DataTable rLaySach= busTS.getDaTaChiTietMuon();
            crTatCa crTS = new crTatCa();
            crTS.SetDataSource(rLaySach);
            crvTatCa.ReportSource = crTS;
        }
    }
}