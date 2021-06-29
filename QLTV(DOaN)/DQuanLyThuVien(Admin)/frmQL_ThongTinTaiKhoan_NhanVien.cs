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
    public partial class frmQL_ThongTinTaiKhoan_NhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        private string tendangnhap;
        private string maNV;
        public frmQL_ThongTinTaiKhoan_NhanVien()
        {
            InitializeComponent();


        }
        public frmQL_ThongTinTaiKhoan_NhanVien(string tendangnhap)
        {
            InitializeComponent();
            this.tendangnhap = tendangnhap;


        }
        public frmQL_ThongTinTaiKhoan_NhanVien(string tendangnhap, string maNV)
        {
            InitializeComponent();
            this.tendangnhap = tendangnhap;
            this.maNV = maNV;

        }
        BUS_NhanVien busnv = new BUS_NhanVien();
        BUS_TaiKhoan bustk = new BUS_TaiKhoan();

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_themtk_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_xoatk_Click(object sender, EventArgs e)
        {
           

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void frmQL_ThongTinTaiKhoan_NhanVien_Load(object sender, EventArgs e)
        {
            txt_matkhau.UseSystemPasswordChar = true;
            dataGridView1.DataSource = bustk.showAll();
            if (maNV != string.Empty)
            {
                txt_manv.Text = maNV;


            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void cbx_hienthi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_matkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                txt_manv.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                txt_hienThi.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                txt_tendangnhap.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                txt_matkhau.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            }
            else { }
        }

        private void btnChinhSua_Click_1(object sender, EventArgs e)
        {
            if (txt_hienThi.Text != null && txt_tendangnhap.Text != null)
            {
                bustk.updateDaTaTaiKhoan(txt_tendangnhap.Text, txt_hienThi.Text, txt_manv.Text, "NhanVien", txt_matkhau.Text);
                dataGridView1.DataSource = bustk.showAll();
            }
            else
            {
                MessageBox.Show("Không được bỏ trống");
            }
        }

        private void btn_themtk_Click_1(object sender, EventArgs e)
        {
            if (txt_hienThi.Text != null && txt_tendangnhap.Text != null)
            {
                bustk.THemDataTK(txt_tendangnhap.Text, txt_hienThi.Text, txt_manv.Text, "NhanVien", txt_matkhau.Text);
                dataGridView1.DataSource = bustk.showAll();
            }
            else
            {
                MessageBox.Show("Không được để trống!");
            }
        }

        private void btn_xoatk_Click_1(object sender, EventArgs e)
        {
            if (txt_tendangnhap.Text != null)
            {
                bustk.RemovedataTK(txt_tendangnhap.Text);
                dataGridView1.DataSource = bustk.showAll();

            }
        }

        private void cbx_hienthi2_CheckedChanged(object sender, EventArgs e)
        {
            if(cbx_hienthi2.Checked == true)
            {
                txt_matkhau.UseSystemPasswordChar = false;
            }
            else { txt_matkhau.UseSystemPasswordChar = true; }
        }
    }
}
