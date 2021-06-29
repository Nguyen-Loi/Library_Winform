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
    public partial class dTimKiem : DevExpress.XtraEditors.XtraUserControl
    {
        public dTimKiem()
        {
            InitializeComponent();
        }
        BUS_Sach busSach = new BUS_Sach();
        // phương thức truyền dữ liệu sách nếu nhấn vào button
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            dgvQuanLySach.DataSource = busSach.getDaTaFromSach();
        }
        // phương thức tìm kiếm
        private void btnTimKiem1_Click(object sender, EventArgs e)
        {
            string bienTable = null;
            if (radTenSach1.Checked == true)
            {
                bienTable = "tenSach";
            }
            if (radNgonNgu1.Checked == true)
            {
                bienTable = "ngonNgu";
            }
            if (radTacGia1.Checked == true)
            {
                bienTable = "tacGia";
            }
            if (radNgonNgu1.Checked == true || radTacGia1.Checked == true || radTenSach1.Checked == true)
            {
                if (busSach.searchAlmostRight(bienTable, txtTimKiem1.Text).Rows.Count > 0)
                {
                    dgvQuanLySach.DataSource = busSach.searchAlmostRight(bienTable, txtTimKiem1.Text);
                }
                else
                {
                    MessageBox.Show("Khong Tim Thay !!");
                    dgvQuanLySach.DataSource = busSach.searchAlmostRight(bienTable, txtTimKiem1.Text);
                }
            }
            else
            {
                MessageBox.Show("Hay Kiem Tra Lai !!");
            }
        }

        private void dTimKiem_Load(object sender, EventArgs e)
        {

        }

        private void dgvQuanLySach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
