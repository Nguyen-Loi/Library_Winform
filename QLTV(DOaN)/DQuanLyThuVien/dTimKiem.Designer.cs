
namespace DQuanLyThuVien
{
    partial class dTimKiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dTimKiem));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnTimKiem1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtTimKiem1 = new DevExpress.XtraEditors.TextEdit();
            this.radTacGia1 = new System.Windows.Forms.RadioButton();
            this.radNgonNgu1 = new System.Windows.Forms.RadioButton();
            this.radTenSach1 = new System.Windows.Forms.RadioButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnHTDSBanDau = new DevExpress.XtraEditors.SimpleButton();
            this.dgvQuanLySach = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLySach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnTimKiem1);
            this.groupControl1.Controls.Add(this.btnHTDSBanDau);
            this.groupControl1.Controls.Add(this.txtTimKiem1);
            this.groupControl1.Controls.Add(this.radTacGia1);
            this.groupControl1.Controls.Add(this.radNgonNgu1);
            this.groupControl1.Controls.Add(this.radTenSach1);
            this.groupControl1.Location = new System.Drawing.Point(97, 76);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(310, 157);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Tìm sách";
            // 
            // btnTimKiem1
            // 
            this.btnTimKiem1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem1.Appearance.Options.UseFont = true;
            this.btnTimKiem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem1.ImageOptions.Image")));
            this.btnTimKiem1.Location = new System.Drawing.Point(186, 106);
            this.btnTimKiem1.Name = "btnTimKiem1";
            this.btnTimKiem1.Size = new System.Drawing.Size(98, 36);
            this.btnTimKiem1.TabIndex = 4;
            this.btnTimKiem1.Text = "Tìm kiếm";
            this.btnTimKiem1.Click += new System.EventHandler(this.btnTimKiem1_Click);
            // 
            // txtTimKiem1
            // 
            this.txtTimKiem1.Location = new System.Drawing.Point(15, 70);
            this.txtTimKiem1.Name = "txtTimKiem1";
            this.txtTimKiem1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem1.Properties.Appearance.Options.UseFont = true;
            this.txtTimKiem1.Size = new System.Drawing.Size(269, 24);
            this.txtTimKiem1.TabIndex = 3;
            // 
            // radTacGia1
            // 
            this.radTacGia1.AutoSize = true;
            this.radTacGia1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTacGia1.Location = new System.Drawing.Point(213, 37);
            this.radTacGia1.Name = "radTacGia1";
            this.radTacGia1.Size = new System.Drawing.Size(68, 20);
            this.radTacGia1.TabIndex = 2;
            this.radTacGia1.TabStop = true;
            this.radTacGia1.Text = "Tác giả";
            this.radTacGia1.UseVisualStyleBackColor = true;
            // 
            // radNgonNgu1
            // 
            this.radNgonNgu1.AutoSize = true;
            this.radNgonNgu1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNgonNgu1.Location = new System.Drawing.Point(104, 37);
            this.radNgonNgu1.Name = "radNgonNgu1";
            this.radNgonNgu1.Size = new System.Drawing.Size(81, 20);
            this.radNgonNgu1.TabIndex = 1;
            this.radNgonNgu1.TabStop = true;
            this.radNgonNgu1.Text = "Ngôn ngữ";
            this.radNgonNgu1.UseVisualStyleBackColor = true;
            // 
            // radTenSach1
            // 
            this.radTenSach1.AutoSize = true;
            this.radTenSach1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTenSach1.Location = new System.Drawing.Point(15, 37);
            this.radTenSach1.Name = "radTenSach1";
            this.radTenSach1.Size = new System.Drawing.Size(78, 20);
            this.radTenSach1.TabIndex = 0;
            this.radTenSach1.TabStop = true;
            this.radTenSach1.Text = "Tên sách";
            this.radTenSach1.UseVisualStyleBackColor = true;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(595, 20);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(230, 39);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tìm kiếm sách";
            // 
            // btnHTDSBanDau
            // 
            this.btnHTDSBanDau.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHTDSBanDau.Appearance.Options.UseFont = true;
            this.btnHTDSBanDau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHTDSBanDau.ImageOptions.Image")));
            this.btnHTDSBanDau.Location = new System.Drawing.Point(5, 106);
            this.btnHTDSBanDau.Name = "btnHTDSBanDau";
            this.btnHTDSBanDau.Size = new System.Drawing.Size(148, 36);
            this.btnHTDSBanDau.TabIndex = 5;
            this.btnHTDSBanDau.Text = "Hiển thị toàn bộ";
            this.btnHTDSBanDau.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // dgvQuanLySach
            // 
            this.dgvQuanLySach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvQuanLySach.Location = new System.Drawing.Point(0, 255);
            this.dgvQuanLySach.MainView = this.gridView1;
            this.dgvQuanLySach.Name = "dgvQuanLySach";
            this.dgvQuanLySach.Size = new System.Drawing.Size(1350, 325);
            this.dgvQuanLySach.TabIndex = 6;
            this.dgvQuanLySach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgvQuanLySach;
            this.gridView1.Name = "gridView1";
            // 
            // dTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvQuanLySach);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "dTimKiem";
            this.Size = new System.Drawing.Size(1350, 580);
            this.Load += new System.EventHandler(this.dTimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLySach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem1;
        private DevExpress.XtraEditors.TextEdit txtTimKiem1;
        private System.Windows.Forms.RadioButton radTacGia1;
        private System.Windows.Forms.RadioButton radNgonNgu1;
        private System.Windows.Forms.RadioButton radTenSach1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnHTDSBanDau;
        private DevExpress.XtraGrid.GridControl dgvQuanLySach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
