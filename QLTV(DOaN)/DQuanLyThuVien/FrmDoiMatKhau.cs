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
    public partial class FrmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public FrmDoiMatKhau(string matKhau, string tenDangNhap)
        {
            InitializeComponent();
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
        }
        private string tenDangNhap;
        private string matKhau = null;
        BUS_TaiKhoan busTK = new BUS_TaiKhoan();
        DataTable dtTaiKhoan = new DataTable();
        bool[] arrKT = new bool[5];
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text != matKhau)
            {
                arrKT[0] = false;
            }
            else
            {
                arrKT[0] = true;
            }
            if (txtMatKhauMoi.Text.Trim().Length <= 6)
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
                busTK.updateDaTaTaiKhoan(tenDangNhap, dtTaiKhoan.Rows[0].ItemArray[1].ToString(),
                dtTaiKhoan.Rows[0].ItemArray[2].ToString(), dtTaiKhoan.Rows[0].ItemArray[3].ToString(), txtMatKhauMoi.Text);
                MessageBox.Show("Đổi mật khẩu thành công !!");
                this.Hide();
                FrmNhanVien fnv = new FrmNhanVien(tenDangNhap, txtMatKhauMoi.Text);
                fnv.ShowDialog();
                this.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = busTK.getTaiKhoan(tenDangNhap);
            this.Hide();
            FrmNhanVien fnv = new FrmNhanVien(tenDangNhap, dt.Rows[0].ItemArray[4].ToString());
            fnv.ShowDialog();
            this.Close();
        }

        private void FrmDoiMatKhau_Load(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel theme = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            theme.LookAndFeel.SkinName = "Summer 2008";
            arrKT[0] = false;
            arrKT[1] = false;
            arrKT[2] = false;
            dtTaiKhoan = busTK.getTaiKhoan(tenDangNhap);
        }
    }
}