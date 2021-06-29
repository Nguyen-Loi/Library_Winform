using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DQuanLyThuVien_Admin_
{
    public partial class frmAdmin : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string tendangnhap;
        public frmAdmin()
        {
            InitializeComponent();
        }
        public frmAdmin(string tendangnhap)
        {
            InitializeComponent();
            this.tendangnhap = tendangnhap;
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            pnAdmin.Controls.Clear();
            pnAdmin.Controls.Add(new frm_GioiThieu());
        }

        private void btnGioiThieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnAdmin.Controls.Clear();
            pnAdmin.Controls.Add(new frm_GioiThieu());
        }

        private void btnQuyDinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnAdmin.Controls.Clear();
            pnAdmin.Controls.Add(new frmQuiDinh());
        }

        private void btnThongTin_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnAdmin.Controls.Clear();
            pnAdmin.Controls.Add(new frm_ThongTinCaNhan(tendangnhap));
        }

        private void btnChinhSuaTT_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnAdmin.Controls.Clear();
            pnAdmin.Controls.Add(new frm_ChinhSuaThongTin(tendangnhap));
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát chương trình?", "Thoát chương trình", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnMuonSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnAdmin.Controls.Clear();
            pnAdmin.Controls.Add(new frmMuontra_Muonsach());
        }

        private void btnDocGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnAdmin.Controls.Clear();
            pnAdmin.Controls.Add(new frmQL_DOCGIA());
        }

        private void btnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnAdmin.Controls.Clear();
            pnAdmin.Controls.Add(new frmQL_NHANVIEN());
        }

        private void btnSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnAdmin.Controls.Clear();
            pnAdmin.Controls.Add(new frmQL_SACH());
        }

        private void btnTkNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnAdmin.Controls.Clear();
            pnAdmin.Controls.Add(new frmQL_ThongTinTaiKhoan_NhanVien());
        }

        private void btnThongKeTV_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnAdmin.Controls.Clear();
            pnAdmin.Controls.Add(new frm_ThongKe());
        }

        private void btnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnAdmin.Controls.Clear();
            pnAdmin.Controls.Add(new frm_DoiMat(tendangnhap));
        }

        private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmReport_ALL fR = new frmReport_ALL();
            fR.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmReportConHan2 fR = new frmReportConHan2();
            fR.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmReportQuaHạn fR = new frmReportQuaHạn();
            fR.Show();
        }
    }
}