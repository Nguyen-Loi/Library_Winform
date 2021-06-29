
namespace DQuanLyThuVien_Admin_
{
    partial class frmReportQuaHạn
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crvQuaHan = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvQuaHan
            // 
            this.crvQuaHan.ActiveViewIndex = -1;
            this.crvQuaHan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvQuaHan.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvQuaHan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvQuaHan.Location = new System.Drawing.Point(0, 0);
            this.crvQuaHan.Name = "crvQuaHan";
            this.crvQuaHan.Size = new System.Drawing.Size(298, 268);
            this.crvQuaHan.TabIndex = 0;
            // 
            // frmReportQuaHạn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 268);
            this.Controls.Add(this.crvQuaHan);
            this.Name = "frmReportQuaHạn";
            this.Text = "Thống kê danh sách quá hạn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportQuaHạn_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvQuaHan;
    }
}