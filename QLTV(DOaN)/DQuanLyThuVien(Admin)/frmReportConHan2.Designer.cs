
namespace DQuanLyThuVien_Admin_
{
    partial class frmReportConHan2
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
            this.crvConHan = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvConHan
            // 
            this.crvConHan.ActiveViewIndex = -1;
            this.crvConHan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvConHan.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvConHan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvConHan.Location = new System.Drawing.Point(0, 0);
            this.crvConHan.Name = "crvConHan";
            this.crvConHan.Size = new System.Drawing.Size(298, 268);
            this.crvConHan.TabIndex = 0;
            // 
            // frmReportConHan2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 268);
            this.Controls.Add(this.crvConHan);
            this.Name = "frmReportConHan2";
            this.Text = "Thống kê danh sách còn hạn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportConHan2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvConHan;
    }
}