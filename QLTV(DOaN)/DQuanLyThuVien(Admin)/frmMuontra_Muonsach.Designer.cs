
namespace DQuanLyThuVien_Admin_
{
    partial class frmMuontra_Muonsach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuontra_Muonsach));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_timkiem = new DevExpress.XtraEditors.SimpleButton();
            this.txt_timkiem = new DevExpress.XtraEditors.TextEdit();
            this.rdb_maDG = new System.Windows.Forms.RadioButton();
            this.rdb_masach = new System.Windows.Forms.RadioButton();
            this.btn_danhsach = new DevExpress.XtraEditors.SimpleButton();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dataGridView1 = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timkiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(476, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(545, 35);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Danh sách sinh viên đang mượn sách";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_timkiem);
            this.groupControl1.Controls.Add(this.txt_timkiem);
            this.groupControl1.Controls.Add(this.rdb_maDG);
            this.groupControl1.Controls.Add(this.rdb_masach);
            this.groupControl1.Location = new System.Drawing.Point(198, 120);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(330, 182);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Tìm kiếm";
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Appearance.Options.UseFont = true;
            this.btn_timkiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_timkiem.ImageOptions.Image")));
            this.btn_timkiem.Location = new System.Drawing.Point(219, 133);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(95, 35);
            this.btn_timkiem.TabIndex = 3;
            this.btn_timkiem.Text = "Tìm";
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(27, 77);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Properties.Appearance.Options.UseFont = true;
            this.txt_timkiem.Size = new System.Drawing.Size(287, 24);
            this.txt_timkiem.TabIndex = 3;
            // 
            // rdb_maDG
            // 
            this.rdb_maDG.AutoSize = true;
            this.rdb_maDG.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_maDG.Location = new System.Drawing.Point(219, 42);
            this.rdb_maDG.Margin = new System.Windows.Forms.Padding(2);
            this.rdb_maDG.Name = "rdb_maDG";
            this.rdb_maDG.Size = new System.Drawing.Size(72, 22);
            this.rdb_maDG.TabIndex = 1;
            this.rdb_maDG.Text = "Mã thẻ";
            this.rdb_maDG.UseVisualStyleBackColor = true;
            // 
            // rdb_masach
            // 
            this.rdb_masach.AutoSize = true;
            this.rdb_masach.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_masach.Location = new System.Drawing.Point(27, 42);
            this.rdb_masach.Margin = new System.Windows.Forms.Padding(2);
            this.rdb_masach.Name = "rdb_masach";
            this.rdb_masach.Size = new System.Drawing.Size(81, 22);
            this.rdb_masach.TabIndex = 0;
            this.rdb_masach.Text = "Mã sách";
            this.rdb_masach.UseVisualStyleBackColor = true;
            // 
            // btn_danhsach
            // 
            this.btn_danhsach.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_danhsach.Appearance.Options.UseFont = true;
            this.btn_danhsach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_danhsach.ImageOptions.Image")));
            this.btn_danhsach.Location = new System.Drawing.Point(920, 162);
            this.btn_danhsach.Name = "btn_danhsach";
            this.btn_danhsach.Size = new System.Drawing.Size(149, 59);
            this.btn_danhsach.TabIndex = 4;
            this.btn_danhsach.Text = "Xem danh sách";
            this.btn_danhsach.Click += new System.EventHandler(this.btn_danhsach_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dataGridView1;
            this.gridView1.Name = "gridView1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 308);
            this.dataGridView1.MainView = this.gridView1;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1451, 282);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // frmMuontra_Muonsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_danhsach);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmMuontra_Muonsach";
            this.Size = new System.Drawing.Size(1451, 590);
            this.Load += new System.EventHandler(this.frmMuontra_Muonsach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timkiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RadioButton rdb_maDG;
        private System.Windows.Forms.RadioButton rdb_masach;
        private DevExpress.XtraEditors.SimpleButton btn_timkiem;
        private DevExpress.XtraEditors.TextEdit txt_timkiem;
        private DevExpress.XtraEditors.SimpleButton btn_danhsach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl dataGridView1;
    }
}
