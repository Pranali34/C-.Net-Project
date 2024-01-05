
namespace Kranti_Book_Shop.Forms.Product_Forms
{
    partial class frm_View_Book_List
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
            this.pnl_1 = new System.Windows.Forms.Panel();
            this.pb_Logout_Button = new System.Windows.Forms.PictureBox();
            this.pb_Back_Button = new System.Windows.Forms.PictureBox();
            this.lbl_View_Book_List = new System.Windows.Forms.Label();
            this.dgv_Book_List = new System.Windows.Forms.DataGridView();
            this.pnl_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logout_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Back_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Book_List)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_1
            // 
            this.pnl_1.BackColor = System.Drawing.Color.Navy;
            this.pnl_1.Controls.Add(this.pb_Logout_Button);
            this.pnl_1.Controls.Add(this.pb_Back_Button);
            this.pnl_1.Controls.Add(this.lbl_View_Book_List);
            this.pnl_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_1.Location = new System.Drawing.Point(0, 0);
            this.pnl_1.Name = "pnl_1";
            this.pnl_1.Size = new System.Drawing.Size(1282, 101);
            this.pnl_1.TabIndex = 2;
            // 
            // pb_Logout_Button
            // 
            this.pb_Logout_Button.Image = global::Kranti_Book_Shop.Properties.Resources.logout_btn;
            this.pb_Logout_Button.InitialImage = null;
            this.pb_Logout_Button.Location = new System.Drawing.Point(1148, 0);
            this.pb_Logout_Button.Name = "pb_Logout_Button";
            this.pb_Logout_Button.Size = new System.Drawing.Size(112, 101);
            this.pb_Logout_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Logout_Button.TabIndex = 61;
            this.pb_Logout_Button.TabStop = false;
            this.pb_Logout_Button.Click += new System.EventHandler(this.pb_Logout_Button_Click);
            // 
            // pb_Back_Button
            // 
            this.pb_Back_Button.Image = global::Kranti_Book_Shop.Properties.Resources.back_btn;
            this.pb_Back_Button.InitialImage = null;
            this.pb_Back_Button.Location = new System.Drawing.Point(23, 0);
            this.pb_Back_Button.Name = "pb_Back_Button";
            this.pb_Back_Button.Size = new System.Drawing.Size(112, 101);
            this.pb_Back_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Back_Button.TabIndex = 60;
            this.pb_Back_Button.TabStop = false;
            this.pb_Back_Button.Click += new System.EventHandler(this.pb_Back_Button_Click);
            // 
            // lbl_View_Book_List
            // 
            this.lbl_View_Book_List.AutoSize = true;
            this.lbl_View_Book_List.BackColor = System.Drawing.Color.White;
            this.lbl_View_Book_List.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Book_List.ForeColor = System.Drawing.Color.Navy;
            this.lbl_View_Book_List.Location = new System.Drawing.Point(496, 22);
            this.lbl_View_Book_List.Name = "lbl_View_Book_List";
            this.lbl_View_Book_List.Size = new System.Drawing.Size(311, 57);
            this.lbl_View_Book_List.TabIndex = 1;
            this.lbl_View_Book_List.Text = "View Book List";
            // 
            // dgv_Book_List
            // 
            this.dgv_Book_List.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgv_Book_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Book_List.Location = new System.Drawing.Point(81, 198);
            this.dgv_Book_List.Name = "dgv_Book_List";
            this.dgv_Book_List.RowHeadersWidth = 51;
            this.dgv_Book_List.RowTemplate.Height = 24;
            this.dgv_Book_List.Size = new System.Drawing.Size(1113, 452);
            this.dgv_Book_List.TabIndex = 3;
            // 
            // frm_View_Book_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.dgv_Book_List);
            this.Controls.Add(this.pnl_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_View_Book_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Book List";
            this.Load += new System.EventHandler(this.frm_View_Book_List_Load);
            this.pnl_1.ResumeLayout(false);
            this.pnl_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logout_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Back_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Book_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_1;
        private System.Windows.Forms.Label lbl_View_Book_List;
        private System.Windows.Forms.DataGridView dgv_Book_List;
        private System.Windows.Forms.PictureBox pb_Logout_Button;
        private System.Windows.Forms.PictureBox pb_Back_Button;
    }
}