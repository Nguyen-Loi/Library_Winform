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
using System.IO;
using DevExpress.Pdf.Native.BouncyCastle.Asn1.Ocsp;
using System.Text.RegularExpressions;

namespace DQuanLyThuVien_Admin_
{
    public partial class frmQL_NHANVIEN : DevExpress.XtraEditors.XtraUserControl
    {
        public frmQL_NHANVIEN()
        {
            InitializeComponent();
        }
        //Kiem tra cac textbox rong
        private bool ktNhap()
        {
            if(txt_diachi.Text.Trim()==""||
                txt_sodienthoai.Text.Trim() == "" || txt_tennhanvien.Text.Trim() == "")
            {
                return false;
            }
            return true;
        }
        string tendangnhap;
        string fileName;
        int mode = 0;
        public frmQL_NHANVIEN(string tendangnhap)
        {
            InitializeComponent();
            this.tendangnhap = tendangnhap;
        }
        BUS_NhanVien busnv = new BUS_NhanVien();

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (txt_timkiem.Text.Trim() != "")
            {
                if (rdb_manv.Checked == true)
                {
                    dgv_NhanVien.DataSource = busnv.getNhanVienDaTaTheoBang("maNV", txt_timkiem.Text.Trim());
                }
                else if (rdb_tennv.Checked == true)
                {
                    dgv_NhanVien.DataSource = busnv.getNhanVienDaTaTheoBang("tenNV", txt_timkiem.Text.Trim());
                }
                else { dgv_NhanVien.DataSource = busnv.getNhanVienDaTa(); }
            }
            else
            {
                XtraMessageBox.Show("Bạn phải nhập giá trị để tìm kiếm");
            }
        }

        private void btn_chonanh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    fileName = dlg.FileName;
                    ptb_nhanvien.BackgroundImage = Image.FromFile(fileName);
                }
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            mode = 1;
            txt_diachi.Enabled =  txt_sodienthoai.Enabled = txt_tennhanvien.Enabled = true; 
            txt_manhanvien.Enabled = false;
             btn_huy.Enabled = btn_luu.Enabled = true;
            btn_them.Enabled = btn_sua.Enabled = false;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            mode = 2;
            txt_diachi.Enabled = txt_manhanvien.Enabled = txt_sodienthoai.Enabled = txt_tennhanvien.Enabled = true;
            btn_huy.Enabled = btn_luu.Enabled = true;
            btn_them.Enabled = btn_sua.Enabled = false;
          
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            BUS_TaiKhoan bustk = new BUS_TaiKhoan();
            DialogResult r = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này không?", "Xóa nhân viên", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                bustk.RemovedataTKbyMANV(txt_manhanvien.Text);
                busnv.xoaDuLieuNhanVien(txt_manhanvien.Text);
                dgv_NhanVien.DataSource = busnv.getNhanVienDaTa();
            }
        }       
        private void frmQL_NHANVIEN_Load(object sender, EventArgs e)
        {           
            DataTable showlall = busnv.getNhanVienDaTa(); 
            dgv_NhanVien.DataSource = busnv.getNhanVienDaTa();           
            txt_manhanvien.Enabled = false;
            txt_diachi.Enabled = txt_manhanvien.Enabled = txt_sodienthoai.Enabled = txt_tennhanvien.Enabled = false;
            btn_huy.Enabled = btn_luu.Enabled = false;
            btn_them.Enabled = btn_sua.Enabled = true;
        }

        private void dgv_NhanVien_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = e.RowIndex;
            DataTable dtThongTinNhanVien = new DataTable();    
            if (i >= 0)
            {
                if (dgv_NhanVien.Rows[i].Cells[0].Value.ToString().Trim().Length != 0)
                {
                    rdb_nu.Checked = true;
                    if (dgv_NhanVien.Rows[i].Cells[2].Value.ToString().Equals("Nam")) { rdb_nam.Checked = true; }
                    txt_manhanvien.Text = dgv_NhanVien.Rows[i].Cells[0].Value.ToString();
                    dtThongTinNhanVien = busnv.GETAnhNhanVienTheoMaNV(txt_manhanvien.Text);
                    txt_tennhanvien.Text = dgv_NhanVien.Rows[i].Cells[1].Value.ToString();
                    txt_diachi.Text = dgv_NhanVien.Rows[i].Cells[3].Value.ToString();
                    txt_sodienthoai.Text = dgv_NhanVien.Rows[i].Cells[4].Value.ToString();
                    try
                    {
                        byte[] images = (byte[])dtThongTinNhanVien.Rows[0].ItemArray[0];
                        MemoryStream ms = new MemoryStream(images);
                        ptb_nhanvien.Image = Image.FromStream(ms);
                    }
                    catch (Exception)
                    {
                       
                       MessageBox.Show("Nhân viên " +txt_manhanvien.Text+ " không có ảnh !!");
                    }
                }
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("ban co muon luu thay doi?!", "confirm", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                if (mode == 1)
                {

                    if (ktNhap() == true)
                    {
                        string a = "";
                        if (rdb_nam.Checked == true)
                        {
                            a = "nam";
                        }
                        else
                        {
                            a = "Nu";
                        }
                        if (ptb_nhanvien.BackgroundImage != null)
                        {
                            MemoryStream ms = new MemoryStream();
                            ptb_nhanvien.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            byte[] arrImage = ms.GetBuffer();
                            busnv.themDuLieuNhanVien(txt_tennhanvien.Text, a, txt_diachi.Text, txt_sodienthoai.Text, arrImage);
                            dgv_NhanVien.DataSource = busnv.getNhanVienDaTa();
                            DataTable newestnvdata = busnv.getNewestNhanVienDaTa();
                            XtraMessageBox.Show("Bạn hãy tạo tài khoản với mã nhân viên là: " + newestnvdata.Rows[0].ItemArray[0].ToString());
                            frmQL_ThongTinTaiKhoan_NhanVien ql = new frmQL_ThongTinTaiKhoan_NhanVien(tendangnhap, newestnvdata.Rows[0].ItemArray[0].ToString());
                            txt_diachi.Text = txt_manhanvien.Text = txt_sodienthoai.Text = txt_tennhanvien.Text = string.Empty;
                            ptb_nhanvien.Image = null;
                            btn_huy.Enabled = btn_luu.Enabled = false;
                            btn_them.Enabled = btn_sua.Enabled = true;
                            mode = 0;
                        }
                        else
                        {
                            MessageBox.Show("Bạn phải chọn ảnh cho nhân viên!!?");
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn phải điền đầy đủ thông tin");
                    }

                }
                else if (mode == 2)
                {
                    if (ktNhap() == true)
                    {
                        string a = "Nu";
                        if (rdb_nam.Checked == true) { a = "Nam"; }
                        //them dieu kien picturebox

                        if (ptb_nhanvien.BackgroundImage != null)
                        {
                            MemoryStream ms = new MemoryStream();
                            ptb_nhanvien.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            byte[] arrImage = ms.GetBuffer();
                            busnv.SuaDuLieuNhanVienHasImage(txt_manhanvien.Text, txt_tennhanvien.Text, a, txt_diachi.Text, txt_sodienthoai.Text, arrImage);
                            dgv_NhanVien.DataSource = busnv.getNhanVienDaTa();
                            txt_diachi.Text = txt_manhanvien.Text = txt_sodienthoai.Text = txt_tennhanvien.Text = string.Empty;
                            ptb_nhanvien.Image = null;
                            btn_huy.Enabled = btn_luu.Enabled = false;
                            btn_them.Enabled = btn_sua.Enabled = true;
                            mode = 0;
                        }
                        else
                        {
                            MessageBox.Show("Bạn phải chọn ảnh cho nhân viên!");
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn phải điền đầy đủ thông tin!");
                    }
                }
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
           
            DialogResult r = MessageBox.Show("ban co muon huy thay doi?!", "confirm", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                mode = 0;
                txt_diachi.Enabled = txt_manhanvien.Enabled = txt_sodienthoai.Enabled = txt_tennhanvien.Enabled = false;
                
                
                btn_huy.Enabled = btn_luu.Enabled = false;
                btn_them.Enabled = btn_sua.Enabled = true;
                txt_diachi.Text = txt_manhanvien.Text = txt_sodienthoai.Text = txt_tennhanvien.Text = string.Empty;
                ptb_nhanvien.Image = null;
           
            }
        }
    }
}
