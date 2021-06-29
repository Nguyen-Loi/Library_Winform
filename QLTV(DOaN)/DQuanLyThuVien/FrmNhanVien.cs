using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using System.IO;

namespace DQuanLyThuVien
{
    public partial class FrmNhanVien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private string tenDangNhap;
        private string matKhau = null;
        // gọi lên các thư viện bên trong BUS
        BUS_TaiKhoan busTK = new BUS_TaiKhoan();
        BUS_Sach busSach = new BUS_Sach();
        BUS_TheLoai busTheLoai = new BUS_TheLoai();
        BUS_ViTri busViTri = new BUS_ViTri();
        BUS_ChiTietMuon busCTMuon = new BUS_ChiTietMuon();
        BUS_TraSach busTS = new BUS_TraSach();
        DataTable dtSach = new DataTable();
        // tạo 2 mảng bool để kiểm tra từng điều kiện
        bool[] arrKT = new bool[2];
        bool[] arrKTMuonSach = new bool[3];
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        // tạo phương thức khỏi tạo cho form có 2 tham trị
        public FrmNhanVien(string tenDangNhap, string matKhau)
        {
            InitializeComponent();
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
        }    
        private void btnGioiThieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // chuyển form
            pnThuVien.Controls.Clear();
            pnThuVien.Controls.Add(new dGioiThieu());
        }

        private void btnQuyDinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // chuyển form
            pnThuVien.Controls.Clear();
            pnThuVien.Controls.Add(new dQuyDinh());
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void btnThongTin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // chuyển form
            pnThuVien.Controls.Clear();
            pnThuVien.Controls.Add(new dThongTinCaNhan(tenDangNhap));
        }                 
        private void btnChinhSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // chuyển form
            FrmChinhSuaThongTin fcs = new FrmChinhSuaThongTin(tenDangNhap);
            this.Hide();
            fcs.ShowDialog();
            this.Close();
        }

        private void btnDoiMK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // chuyển form
            FrmDoiMatKhau fdmk = new FrmDoiMatKhau(matKhau, tenDangNhap);
            this.Hide();
            fdmk.ShowDialog();
            this.Close();
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // đóng form nếu chọn Yes
            DialogResult r = MessageBox.Show("Bạn có muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnMuonSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // chuyển form
            pnThuVien.Controls.Clear();
            pnThuVien.Controls.Add(new dMuonSach());
        }

        private void btnHetHan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // chuyển form
            pnThuVien.Controls.Clear();
            pnThuVien.Controls.Add(new dQuaHan());
        }

        private void btnTraSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }

        private void btnTimKiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnThuVien.Controls.Clear();
            pnThuVien.Controls.Add(new dTimKiem());
        }

        private void btnThongKe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // chuyển form
            pnThuVien.Controls.Clear();
            pnThuVien.Controls.Add(new dQuaHan());
        }      
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // chuyển form
            pnThuVien.Controls.Clear();
            pnThuVien.Controls.Add(new dBaoCaoTraSach());
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            pnThuVien.Controls.Add(new dGioiThieu());
            DevExpress.LookAndFeel.DefaultLookAndFeel theme = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            theme.LookAndFeel.SkinName = "Summer 2008";
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void FrmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
