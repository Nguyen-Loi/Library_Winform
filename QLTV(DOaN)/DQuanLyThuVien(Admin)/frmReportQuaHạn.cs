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
    public partial class frmReportQuaHạn : DevExpress.XtraEditors.XtraForm
    {
        public frmReportQuaHạn()
        {
            InitializeComponent();
        }
        BUS_ChiTietMuon busTS = new BUS_ChiTietMuon();

           
        
        private void frmReportQuaHạn_Load(object sender, EventArgs e)
        {
            DataTable rQuaH = busTS.getDaTaChiTietMuontrehan();
            crQuaHan crTS = new crQuaHan();
            crTS.SetDataSource(rQuaH);
            crvQuaHan.ReportSource = crTS;
        }
    }
}