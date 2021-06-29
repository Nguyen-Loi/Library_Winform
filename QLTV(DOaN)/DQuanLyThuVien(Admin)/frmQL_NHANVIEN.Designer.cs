
namespace DQuanLyThuVien_Admin_
{
    partial class frmQL_NHANVIEN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQL_NHANVIEN));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_timkiem = new DevExpress.XtraEditors.SimpleButton();
            this.txt_timkiem = new DevExpress.XtraEditors.TextEdit();
            this.rdb_tennv = new System.Windows.Forms.RadioButton();
            this.rdb_manv = new System.Windows.Forms.RadioButton();
            this.ptb_nhanvien = new System.Windows.Forms.PictureBox();
            this.btn_chonanh = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.rdb_nu = new System.Windows.Forms.RadioButton();
            this.rdb_nam = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_manhanvien = new DevExpress.XtraEditors.TextEdit();
            this.txt_tennhanvien = new DevExpress.XtraEditors.TextEdit();
            this.txt_diachi = new DevExpress.XtraEditors.TextEdit();
            this.txt_sodienthoai = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btn_huy = new DevExpress.XtraEditors.SimpleButton();
            this.btn_luu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.dgv_NhanVien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timkiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_nhanvien)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_manhanvien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tennhanvien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_diachi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sodienthoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(516, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(410, 35);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Quản lý thông tin nhân viên";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_timkiem);
            this.groupControl1.Controls.Add(this.txt_timkiem);
            this.groupControl1.Controls.Add(this.rdb_tennv);
            this.groupControl1.Controls.Add(this.rdb_manv);
            this.groupControl1.Location = new System.Drawing.Point(23, 77);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(294, 186);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Tìm kiếm";
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Appearance.Options.UseFont = true;
            this.btn_timkiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_timkiem.ImageOptions.Image")));
            this.btn_timkiem.Location = new System.Drawing.Point(187, 142);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(87, 30);
            this.btn_timkiem.TabIndex = 3;
            this.btn_timkiem.Text = "Tìm";
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(19, 101);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Properties.Appearance.Options.UseFont = true;
            this.txt_timkiem.Size = new System.Drawing.Size(255, 24);
            this.txt_timkiem.TabIndex = 2;
            // 
            // rdb_tennv
            // 
            this.rdb_tennv.AutoSize = true;
            this.rdb_tennv.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_tennv.Location = new System.Drawing.Point(151, 55);
            this.rdb_tennv.Margin = new System.Windows.Forms.Padding(2);
            this.rdb_tennv.Name = "rdb_tennv";
            this.rdb_tennv.Size = new System.Drawing.Size(123, 22);
            this.rdb_tennv.TabIndex = 1;
            this.rdb_tennv.Text = "Tên Nhân Viên";
            this.rdb_tennv.UseVisualStyleBackColor = true;
            // 
            // rdb_manv
            // 
            this.rdb_manv.AutoSize = true;
            this.rdb_manv.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_manv.Location = new System.Drawing.Point(19, 56);
            this.rdb_manv.Margin = new System.Windows.Forms.Padding(2);
            this.rdb_manv.Name = "rdb_manv";
            this.rdb_manv.Size = new System.Drawing.Size(117, 22);
            this.rdb_manv.TabIndex = 0;
            this.rdb_manv.Text = "Mã Nhân Viên";
            this.rdb_manv.UseVisualStyleBackColor = true;
            // 
            // ptb_nhanvien
            // 
            this.ptb_nhanvien.Location = new System.Drawing.Point(335, 101);
            this.ptb_nhanvien.Margin = new System.Windows.Forms.Padding(2);
            this.ptb_nhanvien.Name = "ptb_nhanvien";
            this.ptb_nhanvien.Size = new System.Drawing.Size(146, 148);
            this.ptb_nhanvien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_nhanvien.TabIndex = 53;
            this.ptb_nhanvien.TabStop = false;
            // 
            // btn_chonanh
            // 
            this.btn_chonanh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_chonanh.ImageOptions.Image")));
            this.btn_chonanh.Location = new System.Drawing.Point(350, 265);
            this.btn_chonanh.Name = "btn_chonanh";
            this.btn_chonanh.Size = new System.Drawing.Size(116, 35);
            this.btn_chonanh.TabIndex = 4;
            this.btn_chonanh.Text = "Chọn ảnh";
            this.btn_chonanh.Click += new System.EventHandler(this.btn_chonanh_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(644, 133);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(99, 18);
            this.labelControl2.TabIndex = 55;
            this.labelControl2.Text = "Tên nhân viên:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(650, 83);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(93, 18);
            this.labelControl3.TabIndex = 56;
            this.labelControl3.Text = "Mã nhân viên:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(688, 184);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(55, 18);
            this.labelControl4.TabIndex = 55;
            this.labelControl4.Text = "Giới tính:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(918, 133);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(89, 18);
            this.labelControl5.TabIndex = 55;
            this.labelControl5.Text = "Số điện thoai:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(960, 80);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 18);
            this.labelControl6.TabIndex = 56;
            this.labelControl6.Text = "Địa chỉ:";
            // 
            // rdb_nu
            // 
            this.rdb_nu.AutoSize = true;
            this.rdb_nu.Checked = true;
            this.rdb_nu.Location = new System.Drawing.Point(65, 10);
            this.rdb_nu.Margin = new System.Windows.Forms.Padding(2);
            this.rdb_nu.Name = "rdb_nu";
            this.rdb_nu.Size = new System.Drawing.Size(43, 22);
            this.rdb_nu.TabIndex = 8;
            this.rdb_nu.TabStop = true;
            this.rdb_nu.Text = "nữ";
            this.rdb_nu.UseVisualStyleBackColor = true;
            // 
            // rdb_nam
            // 
            this.rdb_nam.AutoSize = true;
            this.rdb_nam.Location = new System.Drawing.Point(5, 8);
            this.rdb_nam.Margin = new System.Windows.Forms.Padding(2);
            this.rdb_nam.Name = "rdb_nam";
            this.rdb_nam.Size = new System.Drawing.Size(55, 22);
            this.rdb_nam.TabIndex = 7;
            this.rdb_nam.Text = "nam";
            this.rdb_nam.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_nu);
            this.groupBox1.Controls.Add(this.rdb_nam);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(761, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 33);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            // 
            // txt_manhanvien
            // 
            this.txt_manhanvien.Location = new System.Drawing.Point(761, 77);
            this.txt_manhanvien.Name = "txt_manhanvien";
            this.txt_manhanvien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_manhanvien.Properties.Appearance.Options.UseFont = true;
            this.txt_manhanvien.Size = new System.Drawing.Size(140, 24);
            this.txt_manhanvien.TabIndex = 5;
            // 
            // txt_tennhanvien
            // 
            this.txt_tennhanvien.Location = new System.Drawing.Point(761, 127);
            this.txt_tennhanvien.Name = "txt_tennhanvien";
            this.txt_tennhanvien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tennhanvien.Properties.Appearance.Options.UseFont = true;
            this.txt_tennhanvien.Size = new System.Drawing.Size(140, 24);
            this.txt_tennhanvien.TabIndex = 6;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(1047, 74);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diachi.Properties.Appearance.Options.UseFont = true;
            this.txt_diachi.Size = new System.Drawing.Size(145, 24);
            this.txt_diachi.TabIndex = 9;
            // 
            // txt_sodienthoai
            // 
            this.txt_sodienthoai.Location = new System.Drawing.Point(1047, 130);
            this.txt_sodienthoai.Name = "txt_sodienthoai";
            this.txt_sodienthoai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sodienthoai.Properties.Appearance.Options.UseFont = true;
            this.txt_sodienthoai.Size = new System.Drawing.Size(145, 24);
            this.txt_sodienthoai.TabIndex = 10;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btn_huy);
            this.groupControl2.Controls.Add(this.btn_luu);
            this.groupControl2.Controls.Add(this.btn_xoa);
            this.groupControl2.Controls.Add(this.btn_sua);
            this.groupControl2.Controls.Add(this.btn_them);
            this.groupControl2.Location = new System.Drawing.Point(644, 265);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(631, 77);
            this.groupControl2.TabIndex = 77;
            this.groupControl2.Text = "Chức năng";
            // 
            // btn_huy
            // 
            this.btn_huy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_huy.ImageOptions.Image")));
            this.btn_huy.Location = new System.Drawing.Point(519, 26);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(87, 45);
            this.btn_huy.TabIndex = 14;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_luu.ImageOptions.Image")));
            this.btn_luu.Location = new System.Drawing.Point(403, 27);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(87, 45);
            this.btn_luu.TabIndex = 14;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Appearance.Options.UseFont = true;
            this.btn_xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.ImageOptions.Image")));
            this.btn_xoa.Location = new System.Drawing.Point(276, 26);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(90, 46);
            this.btn_xoa.TabIndex = 13;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Appearance.Options.UseFont = true;
            this.btn_sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.ImageOptions.Image")));
            this.btn_sua.Location = new System.Drawing.Point(137, 26);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(89, 46);
            this.btn_sua.TabIndex = 12;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Appearance.Options.UseFont = true;
            this.btn_them.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.ImageOptions.Image")));
            this.btn_them.Location = new System.Drawing.Point(14, 26);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(98, 46);
            this.btn_them.TabIndex = 11;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dgv_NhanVien
            // 
            this.dgv_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_NhanVien.Location = new System.Drawing.Point(0, 347);
            this.dgv_NhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_NhanVien.MultiSelect = false;
            this.dgv_NhanVien.Name = "dgv_NhanVien";
            this.dgv_NhanVien.RowHeadersWidth = 51;
            this.dgv_NhanVien.RowTemplate.Height = 24;
            this.dgv_NhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_NhanVien.Size = new System.Drawing.Size(1451, 243);
            this.dgv_NhanVien.TabIndex = 14;
            this.dgv_NhanVien.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_NhanVien_RowHeaderMouseClick);
            // 
            // frmQL_NHANVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_NhanVien);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.txt_sodienthoai);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_tennhanvien);
            this.Controls.Add(this.txt_manhanvien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btn_chonanh);
            this.Controls.Add(this.ptb_nhanvien);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmQL_NHANVIEN";
            this.Size = new System.Drawing.Size(1451, 590);
            this.Load += new System.EventHandler(this.frmQL_NHANVIEN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timkiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_nhanvien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_manhanvien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tennhanvien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_diachi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sodienthoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RadioButton rdb_tennv;
        private System.Windows.Forms.RadioButton rdb_manv;
        private DevExpress.XtraEditors.TextEdit txt_timkiem;
        private DevExpress.XtraEditors.SimpleButton btn_timkiem;
        private System.Windows.Forms.PictureBox ptb_nhanvien;
        private DevExpress.XtraEditors.SimpleButton btn_chonanh;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.RadioButton rdb_nu;
        private System.Windows.Forms.RadioButton rdb_nam;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txt_manhanvien;
        private DevExpress.XtraEditors.TextEdit txt_tennhanvien;
        private DevExpress.XtraEditors.TextEdit txt_diachi;
        private DevExpress.XtraEditors.TextEdit txt_sodienthoai;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btn_them;
        private DevExpress.XtraEditors.SimpleButton btn_xoa;
        private DevExpress.XtraEditors.SimpleButton btn_sua;
        private System.Windows.Forms.DataGridView dgv_NhanVien;
        private DevExpress.XtraEditors.SimpleButton btn_huy;
        private DevExpress.XtraEditors.SimpleButton btn_luu;
    }
}
