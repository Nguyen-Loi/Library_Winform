
namespace DQuanLyThuVien
{
    partial class dQuyDinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dQuyDinh));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.numericChartRangeControlClient1 = new DevExpress.XtraEditors.NumericChartRangeControlClient();
            this.rTbQuyDinh = new DevExpress.XtraRichEdit.RichEditControl();
            ((System.ComponentModel.ISupportInitialize)(this.numericChartRangeControlClient1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(594, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(264, 39);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nội quy thư viện";
            // 
            // rTbQuyDinh
            // 
            this.rTbQuyDinh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rTbQuyDinh.Location = new System.Drawing.Point(0, 126);
            this.rTbQuyDinh.Name = "rTbQuyDinh";
            this.rTbQuyDinh.Size = new System.Drawing.Size(1451, 464);
            this.rTbQuyDinh.TabIndex = 1;
            this.rTbQuyDinh.Text = resources.GetString("rTbQuyDinh.Text");
            this.rTbQuyDinh.Click += new System.EventHandler(this.rTbQuyDinh_Click);
            // 
            // dQuyDinh
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rTbQuyDinh);
            this.Controls.Add(this.labelControl1);
            this.Name = "dQuyDinh";
            this.Size = new System.Drawing.Size(1451, 590);
            this.Load += new System.EventHandler(this.dQuyDinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericChartRangeControlClient1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.NumericChartRangeControlClient numericChartRangeControlClient1;
        private DevExpress.XtraRichEdit.RichEditControl rTbQuyDinh;
    }
}
