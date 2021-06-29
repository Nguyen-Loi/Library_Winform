
namespace DQuanLyThuVien_Admin_
{
    partial class frmQL_DOCGIA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQL_DOCGIA));
            this.txt_diachi = new DevExpress.XtraEditors.TextEdit();
            this.btn_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btn_huy = new DevExpress.XtraEditors.SimpleButton();
            this.btn_luu = new DevExpress.XtraEditors.SimpleButton();
            this.rdb_nu = new System.Windows.Forms.RadioButton();
            this.rdb_nam = new System.Windows.Forms.RadioButton();
            this.dtb_ngayhethan = new System.Windows.Forms.DateTimePicker();
            this.dtb_ngaylapthe = new System.Windows.Forms.DateTimePicker();
            this.dtb_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txt_nghenghiep = new DevExpress.XtraEditors.TextEdit();
            this.txt_tendocgia = new DevExpress.XtraEditors.TextEdit();
            this.txt_madocgia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_timkiem = new DevExpress.XtraEditors.SimpleButton();
            this.txt_timkiem = new DevExpress.XtraEditors.TextEdit();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dgv_docgia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.txt_diachi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nghenghiep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tendocgia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_madocgia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timkiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_docgia)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(1095, 198);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diachi.Properties.Appearance.Options.UseFont = true;
            this.txt_diachi.Size = new System.Drawing.Size(146, 24);
            this.txt_diachi.TabIndex = 9;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Appearance.Options.UseFont = true;
            this.btn_xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.ImageOptions.Image")));
            this.btn_xoa.Location = new System.Drawing.Point(228, 32);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(77, 46);
            this.btn_xoa.TabIndex = 13;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Appearance.Options.UseFont = true;
            this.btn_sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.ImageOptions.Image")));
            this.btn_sua.Location = new System.Drawing.Point(135, 32);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(77, 46);
            this.btn_sua.TabIndex = 12;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // btn_them
            // 
            this.btn_them.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Appearance.Options.UseFont = true;
            this.btn_them.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.ImageOptions.Image")));
            this.btn_them.Location = new System.Drawing.Point(21, 32);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(95, 46);
            this.btn_them.TabIndex = 11;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btn_huy);
            this.groupControl2.Controls.Add(this.btn_luu);
            this.groupControl2.Controls.Add(this.btn_xoa);
            this.groupControl2.Controls.Add(this.btn_sua);
            this.groupControl2.Controls.Add(this.btn_them);
            this.groupControl2.Location = new System.Drawing.Point(773, 299);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(511, 83);
            this.groupControl2.TabIndex = 30;
            this.groupControl2.Text = "Chức năng";
            // 
            // btn_huy
            // 
            this.btn_huy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_huy.ImageOptions.Image")));
            this.btn_huy.Location = new System.Drawing.Point(416, 32);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(76, 46);
            this.btn_huy.TabIndex = 31;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_luu.ImageOptions.Image")));
            this.btn_luu.Location = new System.Drawing.Point(322, 32);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 46);
            this.btn_luu.TabIndex = 14;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // rdb_nu
            // 
            this.rdb_nu.AutoSize = true;
            this.rdb_nu.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_nu.Location = new System.Drawing.Point(889, 239);
            this.rdb_nu.Name = "rdb_nu";
            this.rdb_nu.Size = new System.Drawing.Size(45, 22);
            this.rdb_nu.TabIndex = 29;
            this.rdb_nu.TabStop = true;
            this.rdb_nu.Text = "Nữ";
            this.rdb_nu.UseVisualStyleBackColor = true;
            // 
            // rdb_nam
            // 
            this.rdb_nam.AutoSize = true;
            this.rdb_nam.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_nam.Location = new System.Drawing.Point(806, 241);
            this.rdb_nam.Name = "rdb_nam";
            this.rdb_nam.Size = new System.Drawing.Size(57, 22);
            this.rdb_nam.TabIndex = 28;
            this.rdb_nam.TabStop = true;
            this.rdb_nam.Text = "Nam";
            this.rdb_nam.UseVisualStyleBackColor = true;
            // 
            // dtb_ngayhethan
            // 
            this.dtb_ngayhethan.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtb_ngayhethan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtb_ngayhethan.Location = new System.Drawing.Point(1095, 156);
            this.dtb_ngayhethan.Name = "dtb_ngayhethan";
            this.dtb_ngayhethan.Size = new System.Drawing.Size(144, 26);
            this.dtb_ngayhethan.TabIndex = 8;
            // 
            // dtb_ngaylapthe
            // 
            this.dtb_ngaylapthe.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtb_ngaylapthe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtb_ngaylapthe.Location = new System.Drawing.Point(1095, 111);
            this.dtb_ngaylapthe.Name = "dtb_ngaylapthe";
            this.dtb_ngaylapthe.Size = new System.Drawing.Size(144, 26);
            this.dtb_ngaylapthe.TabIndex = 7;
            // 
            // dtb_ngaysinh
            // 
            this.dtb_ngaysinh.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtb_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtb_ngaysinh.Location = new System.Drawing.Point(806, 195);
            this.dtb_ngaysinh.Name = "dtb_ngaysinh";
            this.dtb_ngaysinh.Size = new System.Drawing.Size(159, 26);
            this.dtb_ngaysinh.TabIndex = 6;
            // 
            // txt_nghenghiep
            // 
            this.txt_nghenghiep.Location = new System.Drawing.Point(1095, 238);
            this.txt_nghenghiep.Name = "txt_nghenghiep";
            this.txt_nghenghiep.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nghenghiep.Properties.Appearance.Options.UseFont = true;
            this.txt_nghenghiep.Size = new System.Drawing.Size(146, 24);
            this.txt_nghenghiep.TabIndex = 10;
            // 
            // txt_tendocgia
            // 
            this.txt_tendocgia.Location = new System.Drawing.Point(807, 153);
            this.txt_tendocgia.Name = "txt_tendocgia";
            this.txt_tendocgia.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tendocgia.Properties.Appearance.Options.UseFont = true;
            this.txt_tendocgia.Size = new System.Drawing.Size(158, 24);
            this.txt_tendocgia.TabIndex = 5;
            // 
            // txt_madocgia
            // 
            this.txt_madocgia.Location = new System.Drawing.Point(807, 111);
            this.txt_madocgia.Name = "txt_madocgia";
            this.txt_madocgia.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_madocgia.Properties.Appearance.Options.UseFont = true;
            this.txt_madocgia.Size = new System.Drawing.Size(158, 24);
            this.txt_madocgia.TabIndex = 4;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(1001, 117);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(88, 18);
            this.labelControl9.TabIndex = 20;
            this.labelControl9.Text = "Ngày lập thẻ:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(1042, 207);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(47, 18);
            this.labelControl5.TabIndex = 19;
            this.labelControl5.Text = "Địa chỉ:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(724, 201);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(69, 18);
            this.labelControl7.TabIndex = 18;
            this.labelControl7.Text = "Ngày sinh:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(995, 162);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(94, 18);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "Ngày hết hạn:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(724, 117);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(77, 18);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "Mã độc giả:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(1008, 245);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(81, 18);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Nghề nghiệp";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(733, 240);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(55, 18);
            this.labelControl6.TabIndex = 14;
            this.labelControl6.Text = "Giới tính:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(718, 162);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(83, 18);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Tên độc giả:";
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Appearance.Options.UseFont = true;
            this.btn_timkiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_timkiem.ImageOptions.Image")));
            this.btn_timkiem.Location = new System.Drawing.Point(156, 123);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(104, 41);
            this.btn_timkiem.TabIndex = 3;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(20, 93);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Properties.Appearance.Options.UseFont = true;
            this.txt_timkiem.Size = new System.Drawing.Size(240, 24);
            this.txt_timkiem.TabIndex = 2;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(156, 41);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 22);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Tên độc giả";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(20, 41);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(98, 22);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Mã độc giả";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_timkiem);
            this.groupControl1.Controls.Add(this.txt_timkiem);
            this.groupControl1.Controls.Add(this.radioButton2);
            this.groupControl1.Controls.Add(this.radioButton1);
            this.groupControl1.Location = new System.Drawing.Point(225, 139);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(283, 169);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "Tìm kiếm";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(520, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(369, 35);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Quản lý thông tin độc giả";
            // 
            // dgv_docgia
            // 
            this.dgv_docgia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_docgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_docgia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_docgia.Location = new System.Drawing.Point(0, 388);
            this.dgv_docgia.Name = "dgv_docgia";
            this.dgv_docgia.Size = new System.Drawing.Size(1451, 202);
            this.dgv_docgia.TabIndex = 14;
            this.dgv_docgia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_docgia_CellClick);
            // 
            // frmQL_DOCGIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_docgia);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.rdb_nu);
            this.Controls.Add(this.rdb_nam);
            this.Controls.Add(this.dtb_ngayhethan);
            this.Controls.Add(this.dtb_ngaylapthe);
            this.Controls.Add(this.dtb_ngaysinh);
            this.Controls.Add(this.txt_nghenghiep);
            this.Controls.Add(this.txt_tendocgia);
            this.Controls.Add(this.txt_madocgia);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmQL_DOCGIA";
            this.Size = new System.Drawing.Size(1451, 590);
            this.Load += new System.EventHandler(this.frmQL_DOCGIA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_diachi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_nghenghiep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tendocgia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_madocgia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timkiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_docgia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txt_diachi;
        private DevExpress.XtraEditors.SimpleButton btn_xoa;
        private DevExpress.XtraEditors.SimpleButton btn_sua;
        private DevExpress.XtraEditors.SimpleButton btn_them;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.RadioButton rdb_nu;
        private System.Windows.Forms.RadioButton rdb_nam;
        private System.Windows.Forms.DateTimePicker dtb_ngayhethan;
        private System.Windows.Forms.DateTimePicker dtb_ngaylapthe;
        private System.Windows.Forms.DateTimePicker dtb_ngaysinh;
        private DevExpress.XtraEditors.TextEdit txt_nghenghiep;
        private DevExpress.XtraEditors.TextEdit txt_tendocgia;
        private DevExpress.XtraEditors.TextEdit txt_madocgia;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_timkiem;
        private DevExpress.XtraEditors.TextEdit txt_timkiem;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridView dgv_docgia;
        private DevExpress.XtraEditors.SimpleButton btn_huy;
        private DevExpress.XtraEditors.SimpleButton btn_luu;
    }
}
