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
    public partial class frmMuontra_Muonsach : DevExpress.XtraEditors.XtraUserControl
    {
        string tendangnhap;
        public frmMuontra_Muonsach()
        {
            InitializeComponent();
        }
        public frmMuontra_Muonsach(string tendangnhap)
        {
            InitializeComponent();
            this.tendangnhap = tendangnhap;
        }
        BUS_ChiTietMuon busCTMuon = new BUS_ChiTietMuon();
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMuontra_Muonsach_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_danhsach_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busCTMuon.getDaTaChiTietMuon();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string bienTable = null;
            if (rdb_masach.Checked == true)
            {
                bienTable = "maSH";
            }
            if (rdb_maDG.Checked == true)
            {
                bienTable = "maDG";
            }
            if (rdb_masach.Checked == true || rdb_maDG.Checked == true)
            {
                if (busCTMuon.searchAlmostRight(bienTable, txt_timkiem.Text).Rows.Count > 0)
                {
                    dataGridView1.DataSource = busCTMuon.searchAlmostRight(bienTable, txt_timkiem.Text);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy !!");
                    dataGridView1.DataSource = busCTMuon.searchAlmostRight(bienTable, txt_timkiem.Text);
                }
            }
            else
            {
                MessageBox.Show("Hãy kiểm tra lại !!");
            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}
