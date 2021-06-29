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
using System.IO;

namespace DQuanLyThuVien_Admin_
{
    public partial class frmQuiDinh : DevExpress.XtraEditors.XtraUserControl
    {
        string tendangnhap;
        public frmQuiDinh()
        {
            InitializeComponent();
            StreamReader sD = new StreamReader("quidinh.txt");
            string s = sD.ReadToEnd();
            rtb_quidinh.Text = s;
            sD.Close();
        }
        public frmQuiDinh(string tendangnhap)
        {
            InitializeComponent();
            StreamReader sD = new StreamReader("quidinh.txt");
            string s = sD.ReadToEnd();
            rtb_quidinh.Text = s;
            sD.Close();
            this.tendangnhap = tendangnhap;
        }     
        private void btn_luu_Click(object sender, EventArgs e)
        {
           File.WriteAllText("quidinh.txt", rtb_quidinh.Text);
            XtraMessageBox.Show("Thay đổi quy định thành công^^");
        }

        private void frmQuiDinh_Load(object sender, EventArgs e)
        {
            btn_luu.Enabled = false;
            btnKhongLuu.Enabled = false;
            rtb_quidinh.Enabled = false;
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            rtb_quidinh.Enabled = true;
            btn_luu.Enabled = true;
            btnKhongLuu.Enabled = true;
            
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            btn_luu.Enabled = false;
            btnKhongLuu.Enabled = false;
            rtb_quidinh.Enabled = false;
        }
    }
}
