
namespace Kranti_Book_Shop.Reports
{
    partial class View_Book_Details
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
            this.crv_Book_Details = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Book_Details1 = new Kranti_Book_Shop.Book_Details();
            this.SuspendLayout();
            // 
            // crv_Book_Details
            // 
            this.crv_Book_Details.ActiveViewIndex = -1;
            this.crv_Book_Details.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Book_Details.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Book_Details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_Book_Details.Location = new System.Drawing.Point(0, 0);
            this.crv_Book_Details.Name = "crv_Book_Details";
            this.crv_Book_Details.ReportSource = this.Book_Details1;
            this.crv_Book_Details.Size = new System.Drawing.Size(1282, 753);
            this.crv_Book_Details.TabIndex = 0;
            // 
            // View_Book_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.crv_Book_Details);
            this.Name = "View_Book_Details";
            this.Text = "View_Book_Details";
            this.ResumeLayout(false);

        }

        #endregion
        private Book_Details Book_Details1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Book_Details;
    }
}