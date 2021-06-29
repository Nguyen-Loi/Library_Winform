using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace DQuanLyThuVien
{
    public partial class dThongTinCaNhan : DevExpress.XtraEditors.XtraUserControl
    {
        public dThongTinCaNhan()
        {
            InitializeComponent();
        }
        // tạo phương thức khởi tạo có tham trị
        public dThongTinCaNhan(string tenDangNhap)
        {
            InitializeComponent();
            this.tenDangNhap = tenDangNhap;
        }
        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void textEdit5_EditValueChanged(object sender, EventArgs e)
        {

        }
        // tạo 1 trường , gọi thư viện BUS_TaiKhoan để dùng phương thức và tạo 2 mảng bool để xử lý từng điều kiện
        private string tenDangNhap; 
        BUS_TaiKhoan busTK = new BUS_TaiKhoan();     
        bool[] arrKT = new bool[2];
        bool[] arrKTMuonSach = new bool[3];
        // tải dữ liệu lên 
        private void dThongTinCaNhan_Load(object sender, EventArgs e)
        {           
            txtDiaChi.Enabled = false;
            txtGioiTinh.Enabled = false;
            txtHoTen.Enabled = false;
            txtMaNV.Enabled = false;
            txtSoDienThoai.Enabled = false;

            DataTable dtThongTinNhanVien = new DataTable();
            DataTable dtThongTinTaiKhoan = new DataTable();

            dtThongTinTaiKhoan = busTK.getTaiKhoan(tenDangNhap);
            dtThongTinNhanVien = busTK.getDaTaNhanVienFromLoGin(int.Parse(dtThongTinTaiKhoan.Rows[0].ItemArray[2].ToString()));
            
            txtMaNV.Text = dtThongTinNhanVien.Rows[0].ItemArray[0].ToString();
            txtHoTen.Text = dtThongTinNhanVien.Rows[0].ItemArray[1].ToString();
            txtGioiTinh.Text = dtThongTinNhanVien.Rows[0].ItemArray[2].ToString();
            txtDiaChi.Text = dtThongTinNhanVien.Rows[0].ItemArray[3].ToString();
            txtSoDienThoai.Text = dtThongTinNhanVien.Rows[0].ItemArray[4].ToString();
            byte[] images = (byte[])dtThongTinNhanVien.Rows[0].ItemArray[5];
            MemoryStream ms = new MemoryStream(images);
            ptbAnhNhanVien.Image = Image.FromStream(ms);

        }

        private void txtMaNV_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
