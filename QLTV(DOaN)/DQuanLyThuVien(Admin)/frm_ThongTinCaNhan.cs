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
    public partial class frm_ThongTinCaNhan : DevExpress.XtraEditors.XtraUserControl
    {
        BUS_NhanVien busnv = new BUS_NhanVien();
        BUS_TaiKhoan bustk = new BUS_TaiKhoan();
        private string tenDangNhap;
        public frm_ThongTinCaNhan()
        {
            InitializeComponent();
        }
        public frm_ThongTinCaNhan(string tenDangNhap)
        {
            InitializeComponent();
            this.tenDangNhap = tenDangNhap;
        }

        private void frm_ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            txtDiaChi.Enabled = false;
            txtGioiTinh.Enabled = false;
            txtMaTK.Enabled = false;
            txtSoDienThoai.Enabled = false;
            txtTenDangNhap.Enabled = false;
            txtTenTK.Enabled = false;
            DataTable dtb = busnv.getmaNVtheoTenDangNhap("ad123");
            string manv = dtb.Rows[0].ItemArray[0].ToString();
            DataTable nhanvien = busnv.getnhanvientheomanvs(manv);
            txtMaTK.Text =  nhanvien.Rows[0].ItemArray[0].ToString();
            txtTenTK.Text =  nhanvien.Rows[0].ItemArray[1].ToString();
            txtGioiTinh.Text = nhanvien.Rows[0].ItemArray[2].ToString();
            txtDiaChi.Text = nhanvien.Rows[0].ItemArray[3].ToString();
            txtSoDienThoai.Text = nhanvien.Rows[0].ItemArray[4].ToString();
            txtTenDangNhap.Text = tenDangNhap;
        }
    }
}
