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
    public partial class frmQL_SACH : DevExpress.XtraEditors.XtraUserControl
    {
        string tenDangNhap;
        BUS_TraSach busTS = new BUS_TraSach();
        BUS_ChiTietMuon busCTMuon = new BUS_ChiTietMuon();
        BUS_TheLoai tl = new BUS_TheLoai();
        BUS_ViTri vt = new BUS_ViTri();
        int mode = 0;

        public frmQL_SACH()
        {
            InitializeComponent();
            DataTable dtb = tl.getDaTaFromTheLoai();
            DataTable dtb2 = vt.getDaTaFromViTri();
        }
        public frmQL_SACH(string tenDangNhap)
        {
            InitializeComponent();
            BUS_TheLoai tl = new BUS_TheLoai();
            BUS_ViTri vt = new BUS_ViTri();

            DataTable dtb = tl.getDaTaFromTheLoai();
            DataTable dtb2 = vt.getDaTaFromViTri();          
            this.tenDangNhap = tenDangNhap;
        }
        BUS_Sach bussach = new BUS_Sach();
        //Kiem tra rong
        private bool ktRong()
        {
            if(txt_giathue.Text.Trim()==""||txt_ngonngu.Text.Trim()==""||cbxTinhTrang.Text.Trim()==""||nbSoSach.Value==0
                || txt_nxb.Text.Trim() == "" || txt_tacgia.Text.Trim() == "" || txt_tensach.Text.Trim() == "")
            {
                return false;
            }
            return true;
        }
        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (txt_timkiem.Text.Trim() != "")
            {
                if (rdb_masach.Checked == true)
                {
                    dataGridView1.DataSource = bussach.searchAlmostRight("maSH", txt_timkiem.Text);
                }
                else if (rdb_vitri.Checked == true)
                {
                    dataGridView1.DataSource = bussach.searchAlmostRight("maVT", txt_timkiem.Text.Trim());
                }
                else if (rdb_tensach.Checked == true)
                {
                    dataGridView1.DataSource = bussach.searchAlmostRight("tenSach", txt_timkiem.Text);
                }
                else if (rdb_theloai.Checked == true)
                {
                    dataGridView1.DataSource = bussach.searchAlmostRight("maTL", txt_timkiem.Text);
                }
                else { dataGridView1.DataSource = bussach.getDaTaFromSach(); }
            }
            else
            {
                XtraMessageBox.Show("Tìm kiếm để trống!");
            }
        }

        private void frmQL_SACH_Load(object sender, EventArgs e)
        {
            txt_masach.Enabled = false;
            dataGridView1.DataSource = bussach.getDaTaFromSach();
            cbx_matheloai.DataSource = tl.getDaTaFromTheLoai();
            cbx_matheloai.DisplayMember = "TenTL";
            cbx_matheloai.ValueMember = "MaTL";
            cbx_mavitri.DataSource = vt.getDaTaFromViTri();
            cbx_mavitri.DisplayMember = "TenKeSach";
            cbx_mavitri.ValueMember = "MaVT";
            txt_giathue.Enabled = txt_masach.Enabled = txt_ngonngu.Enabled = txt_nxb.Enabled = txt_tacgia.Enabled = txt_tensach.Enabled = false;
            cbxTinhTrang.Enabled = cbx_matheloai.Enabled = cbx_mavitri.Enabled = false;
            rtb_noidung.Enabled = false;
            btn_KhongLuu.Enabled = btn_Luu.Enabled = false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            mode = 1;
            txt_giathue.Enabled  = txt_ngonngu.Enabled = txt_nxb.Enabled = txt_tacgia.Enabled = txt_tensach.Enabled = true;
            txt_masach.Enabled = false;
            cbxTinhTrang.Enabled = cbx_matheloai.Enabled = cbx_mavitri.Enabled = true;
            rtb_noidung.Enabled = true;
            btn_KhongLuu.Enabled = btn_Luu.Enabled = true;
            btn_sua.Enabled = false;
            btn_them.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {         
            if (txt_masach.Text != null)
            {
                DialogResult rl = MessageBox.Show("Bạn có muốn xóa cuốn sách này không?", "Xóa sách", MessageBoxButtons.YesNo);
                if (rl == DialogResult.Yes)
                {
                    DialogResult rl2 = MessageBox.Show("Bạn có đồng ý xóa dữ liệu trả sách và chi tiết mượn ? ", "Confirm", MessageBoxButtons.YesNo);
                    if (rl2 == DialogResult.Yes)
                    {
                        if (busTS.layDuLieuTraSachTheoMaSach(txt_masach.Text).Rows.Count > 0)
                        {
                            if (busTS.xoaDuLieuTraSachTheoMaSach(txt_masach.Text) == true)
                            {
                            }
                            else
                            {
                                MessageBox.Show("Xóa không thành công !!");
                            }
                        }
                        if (busCTMuon.getDaTaFromChiTietMuonByMaSach(txt_masach.Text).Rows.Count > 0)
                        {
                            if (busCTMuon.deleteChiTietMuonByMaSach(txt_masach.Text) == true)
                            {
                            }
                            else
                            {
                                MessageBox.Show("Xóa không thành công !!");
                            }
                        }
                        bussach.xoaSach(txt_masach.Text);
                        dataGridView1.DataSource = bussach.getDaTaFromSach();
                    }
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            mode = 2;
            
            txt_giathue.Enabled = txt_ngonngu.Enabled = txt_nxb.Enabled = txt_tacgia.Enabled = txt_tensach.Enabled = true;
            txt_masach.Enabled = true;
            cbxTinhTrang.Enabled = cbx_matheloai.Enabled = cbx_mavitri.Enabled = true;
            rtb_noidung.Enabled = true;
            btn_KhongLuu.Enabled = btn_Luu.Enabled = true;
            btn_them.Enabled = btn_sua.Enabled=false;
         
    
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;            
            if (i >= 0)
            {
                if (dataGridView1.Rows[i].Cells[5].Value.ToString().Trim().Length>0 && dataGridView1.Rows[i].Cells[11].Value.ToString().Trim().Length>0)
                {
                    txt_masach.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    cbx_matheloai.SelectedValue = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    cbx_mavitri.SelectedValue = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    txt_tensach.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();                   
                    nup_sotrang.Value = decimal.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                    txt_ngonngu.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
                    rtb_noidung.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    txt_tacgia.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                    txt_nxb.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
                    txt_giathue.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
                    dtp_ngaymuasach.CustomFormat = "MM/dd/yyyy";
                    dtp_ngaymuasach.Value = DateTime.Parse(dataGridView1.Rows[i].Cells[9].Value.ToString());
                    nbSoSach.Value = decimal.Parse(dataGridView1.Rows[i].Cells[11].Value.ToString());
                    cbxTinhTrang.Text = dataGridView1.Rows[i].Cells[12].Value.ToString();
                }
                else
                {
                    txt_masach.Text = string.Empty;
                    txt_tensach.Text = string.Empty;                   
                    nup_sotrang.Value = 0;
                    txt_ngonngu.Text = string.Empty;
                    rtb_noidung.Text = string.Empty;
                    txt_tacgia.Text = string.Empty;
                    txt_nxb.Text = string.Empty;
                    txt_giathue.Text = string.Empty;
                    nbSoSach.Value = 0;
                }
            }           
        }

        private void labelControl14_Click(object sender, EventArgs e)
        {

        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("ban co muon luu thay doi?!", "confirm", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                if (mode == 1)
                {
                    bool ketQua = true;
                    for (int i = 0; i < bussach.getDaTaFromSach().Rows.Count; i++)
                    {
                        if (txt_tensach.Text == bussach.getDaTaFromSach().Rows[i].ItemArray[3].ToString())
                        {
                            ketQua = false;
                            break;
                        }
                    }
                    if (ktRong() == true)
                    {
                        if (cbx_matheloai.Text != null && cbx_mavitri.Text != null && txt_tacgia.Text != null && txt_tensach.Text != null)
                        {
                            if (ketQua == true)
                            {
                                bussach.addDaTaFromSach(cbx_matheloai.SelectedValue.ToString(), cbx_mavitri.SelectedValue.ToString(), txt_tensach.Text, rtb_noidung.Text, int.Parse(nup_sotrang.Value.ToString()), txt_tacgia.Text, txt_ngonngu.Text, txt_nxb.Text, dtp_ngaymuasach.Value, float.Parse(txt_giathue.Text), int.Parse(nbSoSach.Value.ToString()), cbxTinhTrang.Text);
                                dataGridView1.DataSource = bussach.getDaTaFromSach();
                                mode = 0;
                                txt_giathue.Enabled = txt_ngonngu.Enabled = txt_nxb.Enabled = txt_tacgia.Enabled = txt_tensach.Enabled = false;
                                txt_masach.Enabled = false;
                                cbxTinhTrang.Enabled = cbx_matheloai.Enabled = cbx_mavitri.Enabled = false;
                                rtb_noidung.Enabled = false;
                                btn_KhongLuu.Enabled = btn_Luu.Enabled = false;
                                btn_them.Enabled = btn_sua.Enabled = true;
                                txt_giathue.Text = txt_ngonngu.Text = txt_nxb.Text = txt_tacgia.Text = txt_tensach.Text = string.Empty;
                                txt_masach.Text = string.Empty;
                                rtb_noidung.Text = "";
                                
                            }
                            else
                            {
                                MessageBox.Show("Trùng tên sách !");
                            }
                        }
                        else { MessageBox.Show("Không đươc để trống!"); }
                    }
                    else
                    {
                        XtraMessageBox.Show("Không được để trống");
                    }

                }
                else if (mode == 2)
                {
                    if (ktRong() == true)
                    {
                        {
                            if (cbx_matheloai.Text != null && cbx_mavitri.Text != null && txt_tacgia.Text != null && txt_tensach.Text != null)
                            {
                                DialogResult dr = XtraMessageBox.Show("Bạn có chắc muốn thay đổi thông tin cuốn sách này không?", "Thay đổi thông tin sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (dr == DialogResult.Yes)
                                {
                                    try
                                    {
                                        bussach.SuaSoLuongSach(txt_masach.Text, int.Parse(nbSoSach.Value.ToString()));
                                        bussach.SuaDuLieuSach(txt_masach.Text, cbx_matheloai.SelectedValue.ToString(), cbx_mavitri.SelectedValue.ToString(), txt_tensach.Text, rtb_noidung.Text, int.Parse(nup_sotrang.Value.ToString()), txt_tacgia.Text, txt_ngonngu.Text, txt_nxb.Text, dtp_ngaymuasach.Value, float.Parse(txt_giathue.Text), cbxTinhTrang.Text);
                                        dataGridView1.DataSource = bussach.getDaTaFromSach();
                                        mode = 0;
                                        
                                        txt_giathue.Enabled = txt_ngonngu.Enabled = txt_nxb.Enabled = txt_tacgia.Enabled = txt_tensach.Enabled = false;
                                        txt_masach.Enabled = false;
                                        cbxTinhTrang.Enabled = cbx_matheloai.Enabled = cbx_mavitri.Enabled = false;
                                        rtb_noidung.Enabled = false;
                                        btn_KhongLuu.Enabled = btn_Luu.Enabled = false;
                                        btn_them.Enabled = btn_sua.Enabled = true;
                                        txt_giathue.Text = txt_ngonngu.Text = txt_nxb.Text = txt_tacgia.Text = txt_tensach.Text = string.Empty;
                                        txt_masach.Text = string.Empty;
                                        rtb_noidung.Text = "";
                                    }
                                    catch (Exception ex)
                                    {

                                        MessageBox.Show("" + ex);
                                    }

                                }
                            }
                            else { MessageBox.Show("Không được để trống thông tin!"); }
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Không được để trống");
                    }
                }
            }
           
        }

        private void btn_KhongLuu_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("ban co muon huy thay doi?!", "confirm", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                mode = 0;
                txt_giathue.Enabled = txt_ngonngu.Enabled = txt_nxb.Enabled = txt_tacgia.Enabled = txt_tensach.Enabled = false;
                txt_masach.Enabled = false;
                cbxTinhTrang.Enabled = cbx_matheloai.Enabled = cbx_mavitri.Enabled = false;
                rtb_noidung.Enabled = false;
                btn_KhongLuu.Enabled = btn_Luu.Enabled = false;
                btn_them.Enabled = btn_sua.Enabled = true;
                txt_giathue.Text = txt_ngonngu.Text = txt_nxb.Text = txt_tacgia.Text = txt_tensach.Text = string.Empty;
                txt_masach.Text = string.Empty;
                rtb_noidung.Text = "";
            }
        }
    }
}
