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
    public partial class FrmChinhSuaThongTin : DevExpress.XtraEditors.XtraForm
    {
        private string tenDangNhap;
        BUS_TaiKhoan busTK = new BUS_TaiKhoan();
        DataTable dtThongTinTaiKhoan = new DataTable();
        DataTable dtThongTinNhanVien = new DataTable();
        bool[] arrKT = new bool[6];
        public FrmChinhSuaThongTin()
        {
            InitializeComponent();
        }
        private bool kiemTraNhap(string st)
        {
            for (int i = 0; i < st.Length; i++)
            {
                if (char.IsDigit(st[i]) == true)
                {
                    return true;
                }
            }
            return false;
        }
        private bool kiemTraSo(string st)
        {
            for (int i = 0; i < st.Length; i++)
            {
                if (st[i] >= '0' && st[i] <= '9')
                {
                    return true;
                }
            }
            return false;
        }
        public FrmChinhSuaThongTin(string tenDangNhap)
        {
            InitializeComponent();
            this.tenDangNhap = tenDangNhap;
        }
        private void ChinhSuaThongTin_Load(object sender, EventArgs e)
        {
            arrKT[0] = true;
            arrKT[1] = true;
            arrKT[2] = true;
            arrKT[3] = true;
            arrKT[4] = true;
            dtThongTinTaiKhoan = busTK.getTaiKhoan(tenDangNhap);
            dtThongTinNhanVien = busTK.getDaTaNhanVienFromLoGin(int.Parse(dtThongTinTaiKhoan.Rows[0].ItemArray[2].ToString()));
            txtTenHienThi.Text = dtThongTinTaiKhoan.Rows[0].ItemArray[1].ToString();
            txtHoTen.Text = dtThongTinNhanVien.Rows[0].ItemArray[1].ToString();
            radNam.Checked = true;
            txtDiaChi.Text = dtThongTinNhanVien.Rows[0].ItemArray[3].ToString();
            mtbSoDienThoai.Text = dtThongTinNhanVien.Rows[0].ItemArray[4].ToString();
        }
        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            string phai = "";
            if (radNam.Checked == true)
            {
                phai = "Nam";
            }
            if (radNu.Checked == true)
            {
                phai = "Nu";
            }
            if (txtTenHienThi.Text.Trim() == "" || txtHoTen.Text.Trim() == "" || txtDiaChi.Text.Trim() == "" || mtbSoDienThoai.Text.Trim() == "")
            {
                arrKT[3] = false;
            }
            else
            {
                arrKT[3] = true;
            }
            if (arrKT[0] == false || arrKT[1] == false || arrKT[2] == false || arrKT[3] == false)
            {
                arrKT[4] = false;
            }
            else
            {
                arrKT[4] = true;
            }
            if (arrKT[0] == false && arrKT[1] == false && arrKT[2] == false && arrKT[3] == false && arrKT[4] == false)
            {
                arrKT[5] = false;
            }
            else
            {
                arrKT[5] = true;
            }
            if (arrKT[4] == true && arrKT[5] == true)
            {
                busTK.updateDaTaNhanVien(dtThongTinNhanVien.Rows[0].ItemArray[0].ToString(),
                    txtHoTen.Text, phai, txtDiaChi.Text, mtbSoDienThoai.Text);
                busTK.updateDaTaTaiKhoan(tenDangNhap, txtTenHienThi.Text,
                    dtThongTinTaiKhoan.Rows[0].ItemArray[2].ToString()
                    , dtThongTinTaiKhoan.Rows[0].ItemArray[3].ToString(),
                    dtThongTinTaiKhoan.Rows[0].ItemArray[4].ToString());
                MessageBox.Show("Sửa thành công !!");
            }
            else
            {
                MessageBox.Show("Sửa thất bại !!");
            }
        }

        private void txtTenHienThi_TextChanged(object sender, EventArgs e)
        {
            if (txtTenHienThi.Text.Trim().Length == 0 || txtTenHienThi.Text.Trim().Length < 2 || kiemTraNhap(txtTenHienThi.Text) == true)
            {
                arrKT[0] = false;
                errorProvider1.SetError(txtTenHienThi, "Phải từ 2 ký tự trở lên !!");
                
            }
            else
            {
                arrKT[0] = true;
                errorProvider1.Clear();
            }
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Trim().Length == 0 || txtHoTen.Text.Trim().Length <= 7 || kiemTraNhap(txtTenHienThi.Text) == true)
            {
                arrKT[1] = false;
                errorProvider1.SetError(txtHoTen, "Kiểm tra lại hàm nhập !!");
            }
            else
            {
                arrKT[1] = true;
                errorProvider1.Clear();
            }
        }

        private void mtbSoDienThoai_Leave(object sender, EventArgs e)
        {
            mtbSoDienThoai.Text.Replace("_", "");
            if (mtbSoDienThoai.Text.Trim().Length == 0 || mtbSoDienThoai.Text.Length <= 10 || kiemTraSo(mtbSoDienThoai.Text) == false)
            {
                arrKT[2] = false;
                errorProvider1.SetError(mtbSoDienThoai, "Kiểm tra lại hàm nhập !!");
            }
            else
            {
                arrKT[2] = true;
                errorProvider1.Clear();
            }
        }    
        private void FrmChinhSuaThongTin_Load(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel theme = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            theme.LookAndFeel.SkinName = "Summer 2008";
            arrKT[0] = true;
            arrKT[1] = true;
            arrKT[2] = true;
            arrKT[3] = true;
            arrKT[4] = true;
            dtThongTinTaiKhoan = busTK.getTaiKhoan(tenDangNhap);
            dtThongTinNhanVien = busTK.getDaTaNhanVienFromLoGin(int.Parse(dtThongTinTaiKhoan.Rows[0].ItemArray[2].ToString()));
            txtTenHienThi.Text = dtThongTinTaiKhoan.Rows[0].ItemArray[1].ToString();
            txtHoTen.Text = dtThongTinNhanVien.Rows[0].ItemArray[1].ToString();
            radNam.Checked = true;
            txtDiaChi.Text = dtThongTinNhanVien.Rows[0].ItemArray[3].ToString();
            mtbSoDienThoai.Text = dtThongTinNhanVien.Rows[0].ItemArray[4].ToString();
        }

        private void btnChinhSua_Click_1(object sender, EventArgs e)
        {

            string phai = "";
            if (radNam.Checked == true)
            {
                phai = "Nam";
            }
            if (radNu.Checked == true)
            {
                phai = "Nu";
            }
            if (txtTenHienThi.Text.Trim() == "" || txtHoTen.Text.Trim() == "" || txtDiaChi.Text.Trim() == "" || mtbSoDienThoai.Text.Trim() == "")
            {
                arrKT[3] = false;
            }
            else
            {
                arrKT[3] = true;
            }
            if (arrKT[0] == false || arrKT[1] == false || arrKT[2] == false || arrKT[3] == false)
            {
                arrKT[4] = false;
            }
            else
            {
                arrKT[4] = true;
            }
            if (arrKT[0] == false && arrKT[1] == false && arrKT[2] == false && arrKT[3] == false && arrKT[4] == false)
            {
                arrKT[5] = false;
            }
            else
            {
                arrKT[5] = true;
            }
            if (arrKT[4] == true && arrKT[5] == true)
            {
                busTK.updateDaTaNhanVien(dtThongTinNhanVien.Rows[0].ItemArray[0].ToString(),
                    txtHoTen.Text, phai, txtDiaChi.Text, mtbSoDienThoai.Text);
                busTK.updateDaTaTaiKhoan(tenDangNhap, txtTenHienThi.Text,
                    dtThongTinTaiKhoan.Rows[0].ItemArray[2].ToString()
                    , dtThongTinTaiKhoan.Rows[0].ItemArray[3].ToString(),
                    dtThongTinTaiKhoan.Rows[0].ItemArray[4].ToString());
                MessageBox.Show("Sửa thành công !!");
            }
            else
            {
                MessageBox.Show("Sửa thất bại !!");
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmNhanVien fnv = new FrmNhanVien(tenDangNhap, dtThongTinTaiKhoan.Rows[0].ItemArray[4].ToString());
            fnv.ShowDialog();
            this.Close();
        }

        private void FrmChinhSuaThongTin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;  
        }
    }
}