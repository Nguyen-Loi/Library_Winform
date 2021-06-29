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
    public partial class frm_ChinhSuaThongTin : DevExpress.XtraEditors.XtraUserControl
    {
        BUS_NhanVien busnv = new BUS_NhanVien();
        BUS_TaiKhoan bustk = new BUS_TaiKhoan();
        private string tenDangNhap;
        public frm_ChinhSuaThongTin()
        {
            InitializeComponent();
        }
        // phương thức khởi tạo của form có 1 tham trị
        public frm_ChinhSuaThongTin(string tenDangNhap)
        {
            InitializeComponent();
            this.tenDangNhap = tenDangNhap;
        }
        // phương tải tải form để truyền dữ liệu
        private void frm_ChinhSuaThongTin_Load(object sender, EventArgs e)
        {
            txtHoTen.Enabled = false;
            txtDiaChi.Enabled = false;
            mtbSoDienThoai.Enabled = false;
            btnKhongLuu.Enabled = false;
            btnChinhSua.Enabled = false;            
            DataTable dtb = busnv.getmaNVtheoTenDangNhap("ad123");
            string manv = dtb.Rows[0].ItemArray[0].ToString() ;
            DataTable nhanvien = busnv.getnhanvientheomanvs(manv);
            //label2.Text = "Mã : " + nhanvien.Rows[0].ItemArray[0];
            txtHoTen.Text =  nhanvien.Rows[0].ItemArray[1].ToString();
            //textEdit1.Text = "Giới tính: " + nhanvien.Rows[0].ItemArray[2];
            txtDiaChi.Text =nhanvien.Rows[0].ItemArray[3].ToString();
            mtbSoDienThoai.Text =  nhanvien.Rows[0].ItemArray[4].ToString();
          
        }

        private void btnChinhSuaxx_Click(object sender, EventArgs e)
        {
            btnKhongLuu.Enabled = true;
            btnChinhSua.Enabled = true;
            txtHoTen.Enabled = true;
            txtDiaChi.Enabled = true;
            mtbSoDienThoai.Enabled = true;
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            DataTable dtb = busnv.getmaNVtheoTenDangNhap(tenDangNhap);
            //DataTable dtTaiKhoan = bustk.getTaiKhoan(tenDangNhap);
            string i = dtb.Rows[0].ItemArray[0].ToString();
            string phai = "";
            if (radNam.Checked == true)
            {
                phai = "Nam";
            }
            if (radNu.Checked == true)
            {
                phai = "Nữ";
            }
            if (txtHoTen.Text != null && txtDiaChi.Text != null)
            {
                byte[] arr = new byte[] { };

                //frm_DoiMat f = new frm_DoiMat(tenDangNhap);
                busnv.SuaDuLieuNhanVienHasImage(i, txtHoTen.Text, phai, txtDiaChi.Text, mtbSoDienThoai.Text, arr);
    //            bustk.updateDaTaTaiKhoan(tenDangNhap, dtTaiKhoan.Rows[0].ItemArray[1].ToString(),
    //dtTaiKhoan.Rows[0].ItemArray[2].ToString(), dtTaiKhoan.Rows[0].ItemArray[3].ToString(),f.txtMatKhauMoi.Text);
                XtraMessageBox.Show("Thay đổi thông tin thành công");
                btnChinhSua.Enabled = false;
                
                btnKhongLuu.Enabled = false;
            }
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            btnKhongLuu.Enabled = false;
            btnChinhSua.Enabled = false;
        }
    }
}
