
namespace DQuanLyThuVien_Admin_
{
    partial class frmReport_ALL
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
            this.crvTatCa = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvTatCa
            // 
            this.crvTatCa.ActiveViewIndex = -1;
            this.crvTatCa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvTatCa.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvTatCa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvTatCa.Location = new System.Drawing.Point(0, 0);
            this.crvTatCa.Name = "crvTatCa";
            this.crvTatCa.Size = new System.Drawing.Size(298, 268);
            this.crvTatCa.TabIndex = 0;
            // 
            // frmReport_ALL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 268);
            this.Controls.Add(this.crvTatCa);
            this.Name = "frmReport_ALL";
            this.Text = "Thống kê toàn bộ danh sách trong thư viện";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReport_ALL_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvTatCa;
    }
}