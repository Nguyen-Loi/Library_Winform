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
    public partial class frmQL_DOCGIA : DevExpress.XtraEditors.XtraUserControl
    {
        public frmQL_DOCGIA()
        {
            InitializeComponent();
        }
        string tendangnhap;
        //public frmQL_DOCGIA()
        //{
        //    InitializeComponent();
        //    dtb_ngaysinh.CustomFormat = "MM/dd/yyyy";
        //    dtb_ngaylapthe.CustomFormat = "MM/dd/yyyy";
        //    dtb_ngayhethan.CustomFormat = "MM/dd/yyyy";
        //}
        public frmQL_DOCGIA(string tendangnhap)
        {
            InitializeComponent();
            dtb_ngaysinh.CustomFormat = "MM/dd/yyyy";
            dtb_ngaylapthe.CustomFormat = "MM/dd/yyyy";
            dtb_ngayhethan.CustomFormat = "MM/dd/yyyy";
            this.tendangnhap = tendangnhap;
        }
        BUS_DocGia busdg = new BUS_DocGia();
        int mode = 0;
        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                dgv_docgia.DataSource = busdg.DuLieuDocGiaTheoBang("maDG", txt_timkiem.Text);
            }
            else if (radioButton2.Checked == true)
            {
                dgv_docgia.DataSource = busdg.DuLieuDocGiaTheoBang("tenDG", txt_timkiem.Text);

            }
            else { dgv_docgia.DataSource = busdg.DuLieuDocGia(); }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            mode = 1;
            btn_them.Enabled = btn_sua.Enabled = false;
            btn_luu.Enabled = true;btn_huy.Enabled = true;
            txt_diachi.Enabled = txt_nghenghiep.Enabled = txt_tendocgia.Enabled = true;
            txt_madocgia.Enabled = false;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            mode = 2;
            btn_them.Enabled = btn_sua.Enabled = false;
            btn_luu.Enabled = true; btn_huy.Enabled = true;
            txt_diachi.Enabled = txt_nghenghiep.Enabled = txt_tendocgia.Enabled = true;
            txt_madocgia.Enabled = true;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            DialogResult r = XtraMessageBox.Show("Bạn có chắc chăn muốn xóa:", "Xóa độc giả", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {

                busdg.xoaDuLieuDocGia(txt_madocgia.Text);
                dgv_docgia.DataSource = busdg.DuLieuDocGia();
            }
        }

        private void frmQL_DOCGIA_Load(object sender, EventArgs e)
        {
            dgv_docgia.DataSource = busdg.DuLieuDocGia();
            txt_madocgia.Enabled = false;
            txt_madocgia.Enabled = false;
            txt_diachi.Enabled = txt_nghenghiep.Enabled = txt_tendocgia.Enabled  = false;
            btn_huy.Enabled = btn_luu.Enabled = false;
            btn_them.Enabled = btn_sua.Enabled = true;
        }

        private void dgv_docgia_Click(object sender, EventArgs e)
        {
           
        }

        private void dgv_docgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                txt_madocgia.Text = dgv_docgia.Rows[i].Cells[0].Value.ToString();
                txt_tendocgia.Text = dgv_docgia.Rows[i].Cells[1].Value.ToString();
                if (dgv_docgia.Rows[i].Cells[2].Value.ToString().Equals("nam")) { rdb_nam.Checked = true; }
                dtb_ngaysinh.Text = dgv_docgia.Rows[i].Cells[3].Value.ToString();
                txt_nghenghiep.Text = dgv_docgia.Rows[i].Cells[4].Value.ToString();
                dtb_ngaylapthe.Text = dgv_docgia.Rows[i].Cells[5].Value.ToString();
                dtb_ngayhethan.Text = dgv_docgia.Rows[i].Cells[6].Value.ToString();
                txt_diachi.Text = dgv_docgia.Rows[i].Cells[7].Value.ToString();
            }
            else { }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("ban co muon luu thay doi?!", "confirm", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                if (mode == 1)
                {


                    string a = "nu";
                    if (rdb_nam.Checked == true) { a = "nam"; }
                    if ((dtb_ngaylapthe.Value < dtb_ngayhethan.Value) && txt_tendocgia.Text != null)
                    {
                        busdg.themDuLieuDocGia(txt_tendocgia.Text, a, dtb_ngaysinh.Value.ToShortDateString(), txt_nghenghiep.Text, dtb_ngaylapthe.Value.ToShortDateString(), dtb_ngayhethan.Value.ToShortDateString(), txt_diachi.Text);
                        dgv_docgia.DataSource = busdg.DuLieuDocGia();
                        txt_diachi.Text = txt_nghenghiep.Text = txt_tendocgia.Text = string.Empty;
                        txt_diachi.Enabled = txt_madocgia.Enabled = txt_nghenghiep.Enabled = txt_tendocgia.Enabled = false;

                        btn_huy.Enabled = btn_luu.Enabled = false;
                        btn_them.Enabled = btn_sua.Enabled = true;
                        mode = 0;
                    }
                    else { XtraMessageBox.Show("Thêm không thành công \n Bạn cần thêm đầy đủ bảng ngày cấp thẻ, ngày hết hạn và tên độc giả"); }
                }
                else if (mode == 2)
                {
                    string a = "nu";
                    if (rdb_nam.Checked == true) { a = "nam"; }
                   

                        busdg.suaDuLieuDocGia(txt_madocgia.Text, txt_tendocgia.Text, a, dtb_ngaysinh.Value.ToShortDateString(), txt_nghenghiep.Text, dtb_ngaylapthe.Value.ToShortDateString(), dtb_ngayhethan.Value.ToShortDateString(), txt_diachi.Text);
                        dgv_docgia.DataSource = busdg.DuLieuDocGia();
                        txt_diachi.Text = txt_nghenghiep.Text = txt_tendocgia.Text = string.Empty;
                        txt_madocgia.Text = string.Empty;
                    txt_diachi.Enabled = txt_madocgia.Enabled = txt_nghenghiep.Enabled = txt_tendocgia.Enabled = false;

                    btn_huy.Enabled = btn_luu.Enabled = false;
                        btn_them.Enabled = btn_sua.Enabled = true;
                       mode = 0;
                    
                }
            }

        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("ban co muon huy thay doi?!", "confirm", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                mode = 0;
                txt_diachi.Enabled = txt_madocgia.Enabled = txt_nghenghiep.Enabled = txt_tendocgia.Enabled = false;


                btn_huy.Enabled = btn_luu.Enabled = false;
                btn_them.Enabled = btn_sua.Enabled = true;
                txt_diachi.Text = txt_madocgia.Text = txt_nghenghiep.Text = txt_tendocgia.Text = string.Empty;
             

            }
        }
    }
}
