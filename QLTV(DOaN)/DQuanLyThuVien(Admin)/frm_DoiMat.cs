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
    public partial class frm_DoiMat : DevExpress.XtraEditors.XtraUserControl
    {
        BUS_NhanVien busnv = new BUS_NhanVien();
        BUS_TaiKhoan bustk = new BUS_TaiKhoan();
        private string tenDangNhap;
        public frm_DoiMat()
        {
            InitializeComponent();
        }
        public frm_DoiMat(string tenDangNhap)
        {
            InitializeComponent();
            this.tenDangNhap = tenDangNhap;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            DataTable dtTaiKhoan = bustk.getTaiKhoan(tenDangNhap);
            DataTable dtb = bustk.getMatKhau(tenDangNhap);
            bool[] arrKT = new bool[3];
            if (txtMatKhauCu.Text != dtb.Rows[0].ItemArray[0].ToString())
            {
                arrKT[0] = false;
            }
            else
            {
                arrKT[0] = true;
            }
            if (txtMatKhauMoi.Text.Trim().Length < 6)
            {
                arrKT[1] = false;
            }
            else
            {
                arrKT[1] = true;
            }
            if (txtMatKhauMoi.Text != txtNhapLaiMatKhauMoi.Text)
            {
                arrKT[2] = false;
            }
            else
            {
                arrKT[2] = true;
            }
            if (arrKT[0] == false)
            {
                MessageBox.Show("Nhập không chính xác mật khẩu cũ !!");
            }
            else if (arrKT[1] == false)
            {
                MessageBox.Show("Mật khẩu phải hơn hoặc bằng 6 ký tự !!");
            }
            else if (arrKT[2] == false)
            {
                MessageBox.Show("2 Mật khẩu mới không trùng nhau !!");
            }
            else
            {
                bustk.updateDaTaTaiKhoan(tenDangNhap, dtTaiKhoan.Rows[0].ItemArray[1].ToString(),
                dtTaiKhoan.Rows[0].ItemArray[2].ToString(), dtTaiKhoan.Rows[0].ItemArray[3].ToString(), txtMatKhauMoi.Text);
                MessageBox.Show("Đổi mật khẩu thành công !!");              
            }
        }
        
        private void txtMatKhauMoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_DoiMat_Load(object sender, EventArgs e)
        {

        }
    }
}
