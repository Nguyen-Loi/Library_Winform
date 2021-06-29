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
    public partial class frm_ThongKe : DevExpress.XtraEditors.XtraUserControl
    {
        string tendangnhap;
        public frm_ThongKe()
        {
            InitializeComponent();
            if (dtp_ngaymuon.Value < dtb_ngaytraa.Value)
            {
                dgv_thongke.DataSource = buschitietmuon.getDaTaChiTietMuonFromDateStartAndEnd(dtp_ngaymuon.Value, dtb_ngaytraa.Value);
            }
        }
        public frm_ThongKe(string tendangnhap)
        {
            InitializeComponent();
            if (dtp_ngaymuon.Value < dtb_ngaytraa.Value)
            {
                dgv_thongke.DataSource = buschitietmuon.getDaTaChiTietMuonFromDateStartAndEnd(dtp_ngaymuon.Value, dtb_ngaytraa.Value);
            }
            this.tendangnhap = tendangnhap;
        }
        BUS_ChiTietMuon buschitietmuon = new BUS_ChiTietMuon();

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (rdbMaSach.Checked == true)
            {

                dgv_thongke.DataSource = buschitietmuon.searchAlmostRight("MaSH", txtTimKiem.Text);
            }
            if (rdbMaDocGia.Checked == true)
            {

                dgv_thongke.DataSource = buschitietmuon.searchAlmostRight("MaDG", txtTimKiem.Text);
            }
        }

        private void btn_hienthiall_Click(object sender, EventArgs e)
        {
             dgv_thongke.DataSource = buschitietmuon.getDaTaChiTietMuon();
            txtTongSach.Text =  dgv_thongke.RowCount.ToString();
            DataTable dtb = buschitietmuon.getDaTaChiTietMuontrehan();
            DataTable dtb2 = buschitietmuon.getDaTaChiTietMuonconhan();
            DataTable dtb3 = buschitietmuon.getDaTaChiTietMuonSachDaCu();
            txtSachConThoiHan.Text = dtb2.Rows.Count.ToString();
            txtSachHetHan.Text =  dtb.Rows.Count.ToString();
            txtSoLuongSachCu.Text = dtb3.Rows.Count.ToString();
        }

        private void btn_dunghan_Click(object sender, EventArgs e)
        {
            dgv_thongke.DataSource = buschitietmuon.getDaTaChiTietMuonconhan();
        }

        private void btn_trehan_Click(object sender, EventArgs e)
        {
            dgv_thongke.DataSource = buschitietmuon.getDaTaChiTietMuontrehan();
        }

        private void frm_ThongKe_Load(object sender, EventArgs e)
        {
            dgv_thongke.DataSource = buschitietmuon.getDaTaChiTietMuon();
            txtSachConThoiHan.Enabled = false;
            txtSachHetHan.Enabled = false;
            txtSoLuongSachCu.Enabled = false;
           
            txtTongSach.Enabled = false;
        }

        private void dtp_ngaymuon_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_ngaymuon.Value < dtb_ngaytraa.Value)
                dgv_thongke.DataSource = buschitietmuon.getDaTaChiTietMuonFromDateStartAndEnd(dtp_ngaymuon.Value, dtb_ngaytraa.Value);
            else MessageBox.Show("Ngày của bạn sai!");
           
        }

        private void dtb_ngaytraa_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_ngaymuon.Value < dtb_ngaytraa.Value)
                dgv_thongke.DataSource = buschitietmuon.getDaTaChiTietMuonFromDateStartAndEnd(dtp_ngaymuon.Value, dtb_ngaytraa.Value);
            else MessageBox.Show("Ngày của bạn sai!");
        }
    }
}
