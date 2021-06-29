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

namespace DQuanLyThuVien
{
    public partial class dQuyDinh : DevExpress.XtraEditors.XtraUserControl
    {
        public dQuyDinh()
        {
            InitializeComponent();
        }

        
        private void dQuyDinh_Load(object sender, EventArgs e)
        {
            rTbQuyDinh.Enabled = false;
        }

        private void rTbQuyDinh_Click(object sender, EventArgs e)
        {

        }
    }
}
