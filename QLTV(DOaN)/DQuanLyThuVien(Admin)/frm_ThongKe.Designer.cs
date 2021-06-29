
namespace DQuanLyThuVien_Admin_
{
    partial class frm_ThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ThongKe));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dtb_ngaytraa = new System.Windows.Forms.DateTimePicker();
            this.dtp_ngaymuon = new System.Windows.Forms.DateTimePicker();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtTimKiem = new DevExpress.XtraEditors.TextEdit();
            this.rdbMaDocGia = new System.Windows.Forms.RadioButton();
            this.rdbMaSach = new System.Windows.Forms.RadioButton();
            this.label_tongsosach = new DevExpress.XtraEditors.LabelControl();
            this.label_sachcu = new DevExpress.XtraEditors.LabelControl();
            this.label_conhan = new DevExpress.XtraEditors.LabelControl();
            this.label_trehan = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btn_trehan = new DevExpress.XtraEditors.SimpleButton();
            this.btn_dunghan = new DevExpress.XtraEditors.SimpleButton();
            this.btn_hienthiall = new DevExpress.XtraEditors.SimpleButton();
            this.txtTongSach = new DevExpress.XtraEditors.TextEdit();
            this.txtSoLuongSachCu = new DevExpress.XtraEditors.TextEdit();
            this.txtSachConThoiHan = new DevExpress.XtraEditors.TextEdit();
            this.txtSachHetHan = new DevExpress.XtraEditors.TextEdit();
            this.dgv_thongke = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongSach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongSachCu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSachConThoiHan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSachHetHan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongke)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(523, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(362, 33);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Thống kê sử dụng thư viện";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(298, 55);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 18);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Ngày mượn:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(863, 53);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 18);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Ngày trả:";
            // 
            // dtb_ngaytraa
            // 
            this.dtb_ngaytraa.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtb_ngaytraa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtb_ngaytraa.Location = new System.Drawing.Point(939, 47);
            this.dtb_ngaytraa.Margin = new System.Windows.Forms.Padding(2);
            this.dtb_ngaytraa.Name = "dtb_ngaytraa";
            this.dtb_ngaytraa.Size = new System.Drawing.Size(121, 26);
            this.dtb_ngaytraa.TabIndex = 1;
            this.dtb_ngaytraa.ValueChanged += new System.EventHandler(this.dtb_ngaytraa_ValueChanged);
            // 
            // dtp_ngaymuon
            // 
            this.dtp_ngaymuon.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaymuon.Location = new System.Drawing.Point(385, 47);
            this.dtp_ngaymuon.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_ngaymuon.Name = "dtp_ngaymuon";
            this.dtp_ngaymuon.Size = new System.Drawing.Size(122, 26);
            this.dtp_ngaymuon.TabIndex = 0;
            this.dtp_ngaymuon.ValueChanged += new System.EventHandler(this.dtp_ngaymuon_ValueChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.txtTimKiem);
            this.groupControl1.Controls.Add(this.rdbMaDocGia);
            this.groupControl1.Controls.Add(this.rdbMaSach);
            this.groupControl1.Location = new System.Drawing.Point(192, 112);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(336, 167);
            this.groupControl1.TabIndex = 26;
            this.groupControl1.Text = "Tìm kiếm";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(223, 111);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 37);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Tìm";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(32, 71);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Properties.Appearance.Options.UseFont = true;
            this.txtTimKiem.Size = new System.Drawing.Size(266, 24);
            this.txtTimKiem.TabIndex = 4;
            // 
            // rdbMaDocGia
            // 
            this.rdbMaDocGia.AutoSize = true;
            this.rdbMaDocGia.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMaDocGia.Location = new System.Drawing.Point(197, 36);
            this.rdbMaDocGia.Margin = new System.Windows.Forms.Padding(2);
            this.rdbMaDocGia.Name = "rdbMaDocGia";
            this.rdbMaDocGia.Size = new System.Drawing.Size(101, 22);
            this.rdbMaDocGia.TabIndex = 3;
            this.rdbMaDocGia.TabStop = true;
            this.rdbMaDocGia.Text = "Mã Độc Giả";
            this.rdbMaDocGia.UseVisualStyleBackColor = true;
            // 
            // rdbMaSach
            // 
            this.rdbMaSach.AutoSize = true;
            this.rdbMaSach.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMaSach.Location = new System.Drawing.Point(32, 36);
            this.rdbMaSach.Margin = new System.Windows.Forms.Padding(2);
            this.rdbMaSach.Name = "rdbMaSach";
            this.rdbMaSach.Size = new System.Drawing.Size(87, 22);
            this.rdbMaSach.TabIndex = 2;
            this.rdbMaSach.TabStop = true;
            this.rdbMaSach.Text = "Mã Sách ";
            this.rdbMaSach.UseVisualStyleBackColor = true;
            // 
            // label_tongsosach
            // 
            this.label_tongsosach.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tongsosach.Appearance.Options.UseFont = true;
            this.label_tongsosach.Location = new System.Drawing.Point(879, 107);
            this.label_tongsosach.Name = "label_tongsosach";
            this.label_tongsosach.Size = new System.Drawing.Size(94, 18);
            this.label_tongsosach.TabIndex = 28;
            this.label_tongsosach.Text = "Tổng số sách:";
            // 
            // label_sachcu
            // 
            this.label_sachcu.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sachcu.Appearance.Options.UseFont = true;
            this.label_sachcu.Location = new System.Drawing.Point(879, 147);
            this.label_sachcu.Name = "label_sachcu";
            this.label_sachcu.Size = new System.Drawing.Size(138, 18);
            this.label_sachcu.TabIndex = 28;
            this.label_sachcu.Text = "Số lượng sách đã cũ:";
            // 
            // label_conhan
            // 
            this.label_conhan.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_conhan.Appearance.Options.UseFont = true;
            this.label_conhan.Location = new System.Drawing.Point(879, 185);
            this.label_conhan.Name = "label_conhan";
            this.label_conhan.Size = new System.Drawing.Size(181, 18);
            this.label_conhan.TabIndex = 28;
            this.label_conhan.Text = "Số lượng sách còn thời hạn:";
            // 
            // label_trehan
            // 
            this.label_trehan.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_trehan.Appearance.Options.UseFont = true;
            this.label_trehan.Location = new System.Drawing.Point(878, 233);
            this.label_trehan.Name = "label_trehan";
            this.label_trehan.Size = new System.Drawing.Size(151, 18);
            this.label_trehan.TabIndex = 28;
            this.label_trehan.Text = "Số lượng sách hết hạn:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btn_trehan);
            this.groupControl2.Controls.Add(this.btn_dunghan);
            this.groupControl2.Controls.Add(this.btn_hienthiall);
            this.groupControl2.Location = new System.Drawing.Point(27, 285);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(529, 95);
            this.groupControl2.TabIndex = 30;
            this.groupControl2.Text = "Hiển thị";
            // 
            // btn_trehan
            // 
            this.btn_trehan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_trehan.ImageOptions.Image")));
            this.btn_trehan.Location = new System.Drawing.Point(372, 35);
            this.btn_trehan.Name = "btn_trehan";
            this.btn_trehan.Size = new System.Drawing.Size(141, 43);
            this.btn_trehan.TabIndex = 12;
            this.btn_trehan.Text = "Danh sách trễ hạn";
            this.btn_trehan.Click += new System.EventHandler(this.btn_trehan_Click);
            // 
            // btn_dunghan
            // 
            this.btn_dunghan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_dunghan.ImageOptions.Image")));
            this.btn_dunghan.Location = new System.Drawing.Point(189, 35);
            this.btn_dunghan.Name = "btn_dunghan";
            this.btn_dunghan.Size = new System.Drawing.Size(149, 39);
            this.btn_dunghan.TabIndex = 11;
            this.btn_dunghan.Text = "Danh sách đúng hạn";
            this.btn_dunghan.Click += new System.EventHandler(this.btn_dunghan_Click);
            // 
            // btn_hienthiall
            // 
            this.btn_hienthiall.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_hienthiall.ImageOptions.Image")));
            this.btn_hienthiall.Location = new System.Drawing.Point(17, 35);
            this.btn_hienthiall.Name = "btn_hienthiall";
            this.btn_hienthiall.Size = new System.Drawing.Size(113, 43);
            this.btn_hienthiall.TabIndex = 10;
            this.btn_hienthiall.Text = "Hiển thị tất cả";
            this.btn_hienthiall.Click += new System.EventHandler(this.btn_hienthiall_Click);
            // 
            // txtTongSach
            // 
            this.txtTongSach.Location = new System.Drawing.Point(1086, 101);
            this.txtTongSach.Name = "txtTongSach";
            this.txtTongSach.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongSach.Properties.Appearance.Options.UseFont = true;
            this.txtTongSach.Size = new System.Drawing.Size(153, 24);
            this.txtTongSach.TabIndex = 6;
            // 
            // txtSoLuongSachCu
            // 
            this.txtSoLuongSachCu.Location = new System.Drawing.Point(1086, 141);
            this.txtSoLuongSachCu.Name = "txtSoLuongSachCu";
            this.txtSoLuongSachCu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongSachCu.Properties.Appearance.Options.UseFont = true;
            this.txtSoLuongSachCu.Size = new System.Drawing.Size(153, 24);
            this.txtSoLuongSachCu.TabIndex = 7;
            // 
            // txtSachConThoiHan
            // 
            this.txtSachConThoiHan.Location = new System.Drawing.Point(1086, 179);
            this.txtSachConThoiHan.Name = "txtSachConThoiHan";
            this.txtSachConThoiHan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSachConThoiHan.Properties.Appearance.Options.UseFont = true;
            this.txtSachConThoiHan.Size = new System.Drawing.Size(153, 24);
            this.txtSachConThoiHan.TabIndex = 8;
            // 
            // txtSachHetHan
            // 
            this.txtSachHetHan.Location = new System.Drawing.Point(1086, 227);
            this.txtSachHetHan.Name = "txtSachHetHan";
            this.txtSachHetHan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSachHetHan.Properties.Appearance.Options.UseFont = true;
            this.txtSachHetHan.Size = new System.Drawing.Size(153, 24);
            this.txtSachHetHan.TabIndex = 9;
            // 
            // dgv_thongke
            // 
            this.dgv_thongke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_thongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongke.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_thongke.Location = new System.Drawing.Point(0, 385);
            this.dgv_thongke.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_thongke.Name = "dgv_thongke";
            this.dgv_thongke.RowHeadersWidth = 51;
            this.dgv_thongke.RowTemplate.Height = 24;
            this.dgv_thongke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_thongke.Size = new System.Drawing.Size(1451, 205);
            this.dgv_thongke.TabIndex = 33;
            // 
            // frm_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_thongke);
            this.Controls.Add(this.txtSachHetHan);
            this.Controls.Add(this.txtSachConThoiHan);
            this.Controls.Add(this.txtSoLuongSachCu);
            this.Controls.Add(this.txtTongSach);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.label_trehan);
            this.Controls.Add(this.label_conhan);
            this.Controls.Add(this.label_sachcu);
            this.Controls.Add(this.label_tongsosach);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dtb_ngaytraa);
            this.Controls.Add(this.dtp_ngaymuon);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "frm_ThongKe";
            this.Size = new System.Drawing.Size(1451, 590);
            this.Load += new System.EventHandler(this.frm_ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTongSach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongSachCu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSachConThoiHan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSachHetHan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.DateTimePicker dtb_ngaytraa;
        private System.Windows.Forms.DateTimePicker dtp_ngaymuon;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RadioButton rdbMaDocGia;
        private System.Windows.Forms.RadioButton rdbMaSach;
        private DevExpress.XtraEditors.TextEdit txtTimKiem;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl label_tongsosach;
        private DevExpress.XtraEditors.LabelControl label_sachcu;
        private DevExpress.XtraEditors.LabelControl label_conhan;
        private DevExpress.XtraEditors.LabelControl label_trehan;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btn_trehan;
        private DevExpress.XtraEditors.SimpleButton btn_dunghan;
        private DevExpress.XtraEditors.SimpleButton btn_hienthiall;
        private DevExpress.XtraEditors.TextEdit txtTongSach;
        private DevExpress.XtraEditors.TextEdit txtSoLuongSachCu;
        private DevExpress.XtraEditors.TextEdit txtSachConThoiHan;
        private DevExpress.XtraEditors.TextEdit txtSachHetHan;
        private System.Windows.Forms.DataGridView dgv_thongke;
    }
}
