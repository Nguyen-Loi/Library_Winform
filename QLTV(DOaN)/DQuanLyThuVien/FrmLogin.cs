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
using DQuanLyThuVien_Admin_;


namespace DQuanLyThuVien
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        // Gọi lên thư viện Bus_TaiKhoan
        BUS_TaiKhoan busTK = new BUS_TaiKhoan();     
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // gọi lên phương thức đăng nhập nếu dữ liệu tồn tại thì sẽ tăng lên 1 cột
            if (busTK.loGin(txtDangNhap.Text, txtMatKhau.Text).Rows.Count > 0)
            {
                // kiểm tra quyền khi đăng nhập
                if (busTK.loGin(txtDangNhap.Text, txtMatKhau.Text).Rows[0].ItemArray[3].ToString() == "Admin" && txtMatKhau.Text.Equals((busTK.loGin(txtDangNhap.Text, txtMatKhau.Text).Rows[0].ItemArray[4].ToString())))
                {
                    XtraMessageBox.Show("Bạn đã đăng nhập thành công với tư cách Admin !!");
                    frmAdmin ql = new frmAdmin(txtDangNhap.Text);
                    this.Hide();
                    ql.ShowDialog();
                    this.Show();
                }
                else if (busTK.loGin(txtDangNhap.Text, txtMatKhau.Text).Rows[0].ItemArray[3].ToString() == "NhanVien")
                {
                    XtraMessageBox.Show("Bạn đã đăng nhập thành công với tư cách nhân viên !!");
                    FrmNhanVien fnv = new FrmNhanVien(busTK.loGin(txtDangNhap.Text, txtMatKhau.Text).Rows[0].ItemArray[0].ToString(), busTK.loGin(txtDangNhap.Text, txtMatKhau.Text).Rows[0].ItemArray[4].ToString());
                    this.Hide();
                    fnv.ShowDialog();
                    this.Show();
                }
               // nếu không chọn ghi nhớ mật khẩu thì sẽ xóa mật khẩu vừa đăng nhập và ngược lại
               if(ckGhiNho.Checked == false)
                {
                    txtMatKhau.Text=null;
                }
                txtDangNhap.Text = null;
            }
            else
            {
                XtraMessageBox.Show("Sai tài khoản hoặc mật khẩu !!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // nếu chọn yes thì sẽ đóng form
            DialogResult dr = XtraMessageBox.Show("Bạn muốn thoát chương trình ?", "Thoát chương trình", MessageBoxButtons.YesNo
               ,MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
        
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel theme = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            theme.LookAndFeel.SkinName = "Summer 2008";
           
        }

        private void ckGhiNho_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}