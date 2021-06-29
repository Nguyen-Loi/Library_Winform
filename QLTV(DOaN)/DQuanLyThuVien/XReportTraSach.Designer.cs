
namespace DQuanLyThuVien
{
    partial class XReportTraSach
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
            this.crvTraSach = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvTraSach
            // 
            this.crvTraSach.ActiveViewIndex = -1;
            this.crvTraSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvTraSach.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvTraSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvTraSach.Location = new System.Drawing.Point(0, 0);
            this.crvTraSach.Name = "crvTraSach";
            this.crvTraSach.Size = new System.Drawing.Size(1384, 558);
            this.crvTraSach.TabIndex = 2;
            // 
            // XReportTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 558);
            this.Controls.Add(this.crvTraSach);
            this.Name = "XReportTraSach";
            this.Text = "Thống kê trả sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.XReportTraSach_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvTraSach;
    }
}