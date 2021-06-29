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
    public partial class dMuonSach : DevExpress.XtraEditors.XtraUserControl
    {
        public dMuonSach()
        {
            InitializeComponent();
        }
        DataTable dtSach = new DataTable();
        BUS_TraSach busTS = new BUS_TraSach();
        bool[] arrKTMuonSach = new bool[3];
        BUS_ChiTietMuon busCTMuon = new BUS_ChiTietMuon();
        BUS_Sach busS = new BUS_Sach();
        BUS_DocGia busDG = new BUS_DocGia();
        bool[] arrKT = new bool[2];
        ListView listThem = new ListView();
        ListView listSua = new ListView();
        // phương thức chọn button tim kiếm
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string bienTable = null;
            if (radMaSach.Checked == true)
            {
                bienTable = "maSH";
            }
            if (radMaDocGia.Checked == true)
            {
                bienTable = "maDG";
            }
            if (radMaSach.Checked == true || radMaDocGia.Checked == true)
            {
                if (busCTMuon.searchAlmostRight(bienTable, txtTimKiem.Text).Rows.Count > 0)
                {
                    dgvMuonSach.DataSource = busCTMuon.searchAlmostRight(bienTable, txtTimKiem.Text);
                }
                else
                {
                    MessageBox.Show("Khong Tim Thay !!");
                    dgvMuonSach.DataSource = busCTMuon.searchAlmostRight(bienTable, txtTimKiem.Text);
                }
            }
            else
            {
                MessageBox.Show("Hay Kiem Tra Lai !!");
            }
        }   
        // phương thức chọn button hiện toàn bộ danh sách
        private void btnHienThiToanBoDanhSach_Click(object sender, EventArgs e)
        {
            dgvMuonSach.DataSource = busCTMuon.getDaTaChiTietMuon();
        }
        // phương thức chọn button mượn sách
        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            DataTable dtChiTietMuon = busCTMuon.getDaTaChiTietMuon();          
            arrKTMuonSach[2] = true;
            bool ketQua = false;
            bool ketQua1 = true;
            int dem = 0;
            if (dtpNgayThue.Value >= dtpNgayTra.Value)
            {
                arrKTMuonSach[0] = false;
            }
            else
            {
                arrKTMuonSach[0] = true;
            }
            for (int i = 0; i < busDG.DuLieuDocGia().Rows.Count; i++)
            {
                if(txtMaDocGia.Text.Trim() == busDG.DuLieuDocGia().Rows[i].ItemArray[0].ToString())
                {
                    ketQua = true;
                    break;
                }
            }
            for (int i = 0; i < dtChiTietMuon.Rows.Count; i++)
            {
                if (txtMaDocGia.Text.Trim() == dtChiTietMuon.Rows[i].ItemArray[0].ToString())
                {
                    dem++;
                    if (cboTenSach.SelectedValue.ToString() == dtChiTietMuon.Rows[i].ItemArray[1].ToString())
                    {
                        arrKTMuonSach[2] = false;
                    }
                }
            }
            if (dem == 3)
            {
                arrKTMuonSach[1] = false;
            }
            else
            {
                arrKTMuonSach[1] = true;
            }
            if (arrKT[0] == true)
            {
                if (arrKTMuonSach[0] == true && arrKTMuonSach[1] == true && arrKTMuonSach[2] == true && ketQua == true)
                {                                     
                    string ngayThue = dtpNgayThue.Text;
                    string ngayTra = dtpNgayTra.Text;
                    string[] arr;
                    if (rtbGhiChu.Text.Trim().Length == 0)
                    {
                        arr = new string[]
                        {
                        txtMaDocGia.Text,cboTenSach.SelectedValue.ToString(),dtpNgayThue.Text,dtpNgayTra.Text,rtbGhiChu.Text,""
                        };
                    }
                    else
                    {
                        arr = new string[]
                        {
                        txtMaDocGia.Text,cboTenSach.SelectedValue.ToString(),dtpNgayThue.Text,dtpNgayTra.Text,rtbGhiChu.Text,rtbGhiChu.Text
                        };
                    }
                    ListViewItem listViewThem = new ListViewItem(arr);
                    for (int i = 0; i < listThem.Items.Count; i++)
                    {
                        if(listThem.Items[i].SubItems[0].Text == listViewThem.SubItems[0].Text && 
                            listThem.Items[i].SubItems[1].Text == listViewThem.SubItems[1].Text)
                        {
                            ketQua1 = false;                          
                        }
                    }
                    if (ketQua1 == true)
                    {
                        listThem.Items.Add(listViewThem);
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã thêm dữ liệu này rồi !!");
                    }
                    btnLuu.Enabled = true;
                    btnKhongLuu.Enabled = true;                  
                }
                else if (arrKTMuonSach[0] == false)
                {
                    MessageBox.Show("Ngày thuê không được lớn hơn ngày trả");
                }
                else if (arrKTMuonSach[1] == false)
                {
                    MessageBox.Show("Độc giả đã mượn đủ 3 cuốn sách");
                }
                else if (arrKTMuonSach[2] == false)
                {
                    MessageBox.Show("Bạn đã mượn sách này rồi !!");
                }
                else if(ketQua == false)
                {
                    MessageBox.Show("Mã Độc Giả Không tồn tại !!");
                }
                else
                {
                    MessageBox.Show("Sai dữ liệu");
                }
            }
            else
            {
                MessageBox.Show("Hãy kiểm tra lại dữ liệu !!");
            }
        }
        // phương thức chọn button trả sách
        private void btnTraSach_Click(object sender, EventArgs e)
        {
            dtSach = busS.layDuLieuSachTheoMaSach(cboTenSach.SelectedValue.ToString());
            int soLuong = int.Parse(dtSach.Rows[0].ItemArray[11].ToString());
            bool ketQua = false;
            DataTable dt = new DataTable();
            dt = busCTMuon.getDaTaChiTietMuon();
            DialogResult r = MessageBox.Show("Bạn có muốn trả sách không ? ", "Hop Thoai",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (txtMaDocGia.Text == dt.Rows[i].ItemArray[0].ToString())
                {
                    if (cboTenSach.SelectedValue.ToString() == dt.Rows[i].ItemArray[1].ToString())
                    {
                        ketQua = true;
                    }
                }
            }
            if (r == DialogResult.Yes)
            {
                if (ketQua == true && arrKT[0] == true)
                {
                    DataTable dtTraSach = new DataTable();
                    dtTraSach = busTS.layDulieuTraSachKhongDieuKien();
                    busCTMuon.payBookFromChiTietMuon(txtMaDocGia.Text, cboTenSach.SelectedValue.ToString());
                    dtSach = busTS.layDuLieuSachTheoMaSach(cboTenSach.SelectedValue.ToString());
                    bool ketQuaTraSach = true;
                    MessageBox.Show("Trả sách thành công !!");
                    soLuong++;
                    if(busS.SuaSoLuongSach(cboTenSach.SelectedValue.ToString(),soLuong) == true)
                    {
                       
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại");
                    }
                    for (int i = 0; i < dtTraSach.Rows.Count; i++)
                    {
                        if (txtMaDocGia.Text == dtTraSach.Rows[i].ItemArray[0].ToString() &&
                            cboTenSach.SelectedValue.ToString() == dtTraSach.Rows[i].ItemArray[1].ToString() &&
                            DateTime.Now.ToShortDateString().Substring(0, 8) == dtTraSach.Rows[i].ItemArray[3].ToString().Substring(0, 8))
                        {
                            ketQuaTraSach = false;
                        }
                    }
                    if (ketQuaTraSach == true)
                    {
                        if (busTS.themDuLieuTraSach(txtMaDocGia.Text, cboTenSach.SelectedValue.ToString()
                            , dtSach.Rows[0].ItemArray[3].ToString(), DateTime.Now) == true)
                        {
                            
                        }
                        else
                        {
                            MessageBox.Show("Thêm vào thất bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không duyệt dữ liệu này vì đã tồn tại ");
                    }
                    dgvMuonSach.DataSource = busCTMuon.getDaTaChiTietMuon();
                }
                else
                {
                    MessageBox.Show("Tra Sach Khong Thanh Cong !!");
                }
            }
        }
        // phương thức chọn button sửa sáchs
        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            bool ketQua1 = true;
            if (btnSuaSach.Text == "Chỉnh Sửa")
            {
                txtMaDocGia.Enabled = false;
                cboTenSach.Enabled = false;
                btnSuaSach.Text = "Hủy Chế Độ Sửa";
            }
            else
            {
                if (dgvMuonSach.SelectedRows.Count > 0)
                {
                    btnLuu.Enabled = true;
                    btnKhongLuu.Enabled = true;
                    string[] arr;                   
                    if (rtbGhiChu.Text.Trim().Length == 0)
                    {
                        arr = new string[] { txtMaDocGia.Text, cboTenSach.SelectedValue.ToString(), rtbGhiChu.Text, "" };
                    }
                    else
                    {
                        arr = new string[] { txtMaDocGia.Text, cboTenSach.SelectedValue.ToString(), rtbGhiChu.Text, cboTinhTrang.Text };
                    }
                    ListViewItem listViewSua1 = new ListViewItem(arr);
                    for (int i = 0; i < listSua.Items.Count; i++)
                    {
                        if (listSua.Items[i].SubItems[0].Text == listViewSua1.SubItems[0].Text &&
                            listSua.Items[i].SubItems[1].Text == listViewSua1.SubItems[1].Text)
                        {
                            ketQua1 = false;
                        }
                    }
                    if (ketQua1 == true)
                    {
                        listSua.Items.Add(listViewSua1);
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã thêm dữ liệu này rồi !!");
                    }                              
                    txtMaDocGia.Enabled = true;
                    cboTenSach.Enabled = true;
                    btnSuaSach.Text = "Chỉnh Sửa";
                }
                else
                {
                    MessageBox.Show("Hãy chọn một cột để chỉnh sửa!!");
                }
            }
        }     
        // phương thức kiểm tra chữ số
        private bool kiemTraChuSo(string nhap)
        {
            for (int i = 0; i < nhap.Length; i++)
            {
                if (nhap[i] >= '0' && nhap[i] <= '9')
                {
                    return true;
                }
            }
            return false;
        }
        // khi phương thức tải form được dùng thì truyền vào dữ liệu cho form mượn sách
        private void dMuonSach_Load(object sender, EventArgs e)
        {
            dgvMuonSach.DataSource = busCTMuon.getDaTaChiTietMuon();
            cboTenSach.DataSource = busS.getDaTaFromSach();
            cboTenSach.DisplayMember = "TenSach";
            cboTenSach.ValueMember = "MaSH";
            dgvMuonSach.ClearSelection();    
        }
        // kiểm tra dữ liệu đầu vào khi chỉnh sửa dữ liệu
        private void txtMaDocGia_EditValueChanged(object sender, EventArgs e)
        {
            if (txtMaDocGia.Text.Trim().Length == 0 || kiemTraChuSo(txtMaDocGia.Text) == false)
            {
                arrKT[0] = false;
                errorProvider1.SetError(txtMaDocGia, "Khong Duoc Nhap Ky Tu !!");
            }
            else
            {
                errorProvider1.Clear();
                arrKT[0] = true;
            }
        }            
        // phương thức chọn vào bảng để nhận giá trị của các control
        private void dgvMuonSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            if (d >= 0)
            {
                txtMaDocGia.Text = dgvMuonSach.Rows[d].Cells[0].Value.ToString();
                cboTenSach.SelectedValue = dgvMuonSach.Rows[d].Cells[1].Value.ToString();
                dtpNgayThue.Text = dgvMuonSach.Rows[d].Cells[2].Value.ToString();
                dtpNgayTra.Text = dgvMuonSach.Rows[d].Cells[3].Value.ToString();
                rtbGhiChu.Text = dgvMuonSach.Rows[d].Cells[4].Value.ToString();
                cboTinhTrang.Text = dgvMuonSach.Rows[d].Cells[5].Value.ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataTable dtChiTietMuon = busCTMuon.getDaTaChiTietMuon();
            int dem = 0;
            if (listThem.Items.Count > 0)
            {
                for (int i = 0; i < listThem.Items.Count; i++)
                {
                    for (int j = 0; j < dtChiTietMuon.Rows.Count; j++)
                    {
                        if (listThem.Items[i].SubItems[0].Text == dtChiTietMuon.Rows[j].ItemArray[0].ToString())
                        {
                            dem++;                         
                        }
                    }
                    if (dem <= 3)
                    {
                        dtSach = busS.layDuLieuSachTheoMaSach(listThem.Items[i].SubItems[1].Text);
                        int soLuong = 0;
                        if (dtSach.Rows.Count > 0)
                        {
                            soLuong = int.Parse(dtSach.Rows[0].ItemArray[11].ToString());
                        }
                        if (soLuong > 0)
                        {
                            DateTime dThue = new DateTime();
                            dThue = DateTime.Parse(listThem.Items[i].SubItems[2].Text);
                            DateTime dTra = new DateTime();
                            dTra = DateTime.Parse(listThem.Items[i].SubItems[3].Text);

                            if (busCTMuon.addDataChiTietMuon(listThem.Items[i].SubItems[0].Text, listThem.Items[i].SubItems[1].Text, dThue, dTra, listThem.Items[i].SubItems[4].Text, listThem.Items[i].SubItems[5].Text) == true)
                            {
                            }
                            else
                            {
                                MessageBox.Show("Thêm không thành công !!");
                            }
                            dgvMuonSach.DataSource = busCTMuon.getDaTaChiTietMuon();
                            soLuong -= 1;
                            if (busS.SuaSoLuongSach(listThem.Items[i].SubItems[1].Text, soLuong) == true)
                            {
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật số lượng " + listThem.Items[i].SubItems[1].Text.ToString() + "Thất bại");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sách này " + listThem.Items[i].SubItems[1].Text.ToString() + "đã hết");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Độc Giả : "+listThem.Items[i].SubItems[0].Text.ToString()+"Đã mượn 3 cuốn sách");
                    }             
                }
            }
            if(listSua.Items.Count>0)
            {
                for (int i = 0; i < listSua.Items.Count; i++)
                {
                    if (busCTMuon.updateStatusFromDaTaFromSach(listSua.Items[i].SubItems[0].Text, listSua.Items[i].SubItems[1].Text, listSua.Items[i].SubItems[2].Text, listSua.Items[i].SubItems[3].Text) == true)
                    {                  
                        dgvMuonSach.DataSource = busCTMuon.getDaTaChiTietMuon();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
            }
            btnLuu.Enabled = false;
            btnKhongLuu.Enabled = false;
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnKhongLuu.Enabled = false;
            listThem.Items.Clear();
            listSua.Items.Clear();
        }
    }
}
