
namespace DQuanLyThuVien
{
    partial class dBaoCaoTraSach
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dBaoCaoTraSach));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbliem = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnBaoCao = new DevExpress.XtraEditors.SimpleButton();
            this.dgvDanhSachTraSach = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dtNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTraSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(539, 21);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(283, 39);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Thống kê trả sách";
            // 
            // lbliem
            // 
            this.lbliem.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbliem.Appearance.Options.UseFont = true;
            this.lbliem.Location = new System.Drawing.Point(146, 85);
            this.lbliem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbliem.Name = "lbliem";
            this.lbliem.Size = new System.Drawing.Size(26, 19);
            this.lbliem.TabIndex = 1;
            this.lbliem.Text = "Từ:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(967, 85);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Đến:";
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBaoCao.ImageOptions.Image")));
            this.btnBaoCao.Location = new System.Drawing.Point(403, 140);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(121, 48);
            this.btnBaoCao.TabIndex = 2;
            this.btnBaoCao.Text = "Kiểm tra";
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // dgvDanhSachTraSach
            // 
            this.dgvDanhSachTraSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDanhSachTraSach.Location = new System.Drawing.Point(0, 211);
            this.dgvDanhSachTraSach.MainView = this.gridView1;
            this.dgvDanhSachTraSach.Name = "dgvDanhSachTraSach";
            this.dgvDanhSachTraSach.Size = new System.Drawing.Size(1590, 379);
            this.dgvDanhSachTraSach.TabIndex = 4;
            this.dgvDanhSachTraSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgvDanhSachTraSach;
            this.gridView1.Name = "gridView1";
            // 
            // dtNgayKetThuc
            // 
            this.dtNgayKetThuc.CalendarFont = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayKetThuc.Location = new System.Drawing.Point(1016, 83);
            this.dtNgayKetThuc.Margin = new System.Windows.Forms.Padding(2);
            this.dtNgayKetThuc.Name = "dtNgayKetThuc";
            this.dtNgayKetThuc.Size = new System.Drawing.Size(140, 23);
            this.dtNgayKetThuc.TabIndex = 1;
            // 
            // dtNgayBatDau
            // 
            this.dtNgayBatDau.CalendarFont = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayBatDau.Location = new System.Drawing.Point(210, 83);
            this.dtNgayBatDau.Margin = new System.Windows.Forms.Padding(2);
            this.dtNgayBatDau.Name = "dtNgayBatDau";
            this.dtNgayBatDau.Size = new System.Drawing.Size(140, 23);
            this.dtNgayBatDau.TabIndex = 0;
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(735, 140);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(112, 48);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "In";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // dBaoCaoTraSach
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.dtNgayKetThuc);
            this.Controls.Add(this.dtNgayBatDau);
            this.Controls.Add(this.dgvDanhSachTraSach);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lbliem);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "dBaoCaoTraSach";
            this.Size = new System.Drawing.Size(1590, 590);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTraSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lbliem;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnBaoCao;
        private DevExpress.XtraGrid.GridControl dgvDanhSachTraSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        public System.Windows.Forms.DateTimePicker dtNgayKetThuc;
        public System.Windows.Forms.DateTimePicker dtNgayBatDau;
    }
}
