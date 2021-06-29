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
    public partial class frmReportConHan2 : DevExpress.XtraEditors.XtraForm
    {
        public frmReportConHan2()
        {
            InitializeComponent();
        }
        BUS_ChiTietMuon busTS = new BUS_ChiTietMuon();

       
        private void frmReportConHan2_Load(object sender, EventArgs e)
        {
            DataTable rConH = busTS.getDaTaChiTietMuonconhan();
            crConHan crTS = new crConHan();
            crTS.SetDataSource(rConH);
            crvConHan.ReportSource = crTS;
        }
    }
}