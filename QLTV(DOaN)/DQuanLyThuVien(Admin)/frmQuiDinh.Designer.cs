
namespace DQuanLyThuVien_Admin_
{
    partial class frmQuiDinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuiDinh));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.rtb_quidinh = new DevExpress.XtraRichEdit.RichEditControl();
            this.btnChinhSua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_luu = new DevExpress.XtraEditors.SimpleButton();
            this.btnKhongLuu = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(598, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(264, 39);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nội quy thư viện";
            // 
            // rtb_quidinh
            // 
            this.rtb_quidinh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtb_quidinh.Location = new System.Drawing.Point(0, 156);
            this.rtb_quidinh.Name = "rtb_quidinh";
            this.rtb_quidinh.Size = new System.Drawing.Size(1451, 434);
            this.rtb_quidinh.TabIndex = 3;
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.Appearance.Options.UseFont = true;
            this.btnChinhSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChinhSua.ImageOptions.Image")));
            this.btnChinhSua.Location = new System.Drawing.Point(5, 26);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(107, 47);
            this.btnChinhSua.TabIndex = 0;
            this.btnChinhSua.Text = "Chỉnh sửa";
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Appearance.Options.UseFont = true;
            this.btn_luu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_luu.ImageOptions.Image")));
            this.btn_luu.Location = new System.Drawing.Point(142, 26);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(89, 47);
            this.btn_luu.TabIndex = 1;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btnKhongLuu
            // 
            this.btnKhongLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhongLuu.Appearance.Options.UseFont = true;
            this.btnKhongLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKhongLuu.ImageOptions.Image")));
            this.btnKhongLuu.Location = new System.Drawing.Point(264, 26);
            this.btnKhongLuu.Name = "btnKhongLuu";
            this.btnKhongLuu.Size = new System.Drawing.Size(105, 47);
            this.btnKhongLuu.TabIndex = 2;
            this.btnKhongLuu.Text = "Không lưu";
            this.btnKhongLuu.Click += new System.EventHandler(this.btnKhongLuu_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnChinhSua);
            this.groupControl1.Controls.Add(this.btnKhongLuu);
            this.groupControl1.Controls.Add(this.btn_luu);
            this.groupControl1.Location = new System.Drawing.Point(967, 72);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(383, 78);
            this.groupControl1.TabIndex = 7;
            // 
            // frmQuiDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.rtb_quidinh);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmQuiDinh";
            this.Size = new System.Drawing.Size(1451, 590);
            this.Load += new System.EventHandler(this.frmQuiDinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraRichEdit.RichEditControl rtb_quidinh;
        private DevExpress.XtraEditors.SimpleButton btnChinhSua;
        private DevExpress.XtraEditors.SimpleButton btn_luu;
        private DevExpress.XtraEditors.SimpleButton btnKhongLuu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}
