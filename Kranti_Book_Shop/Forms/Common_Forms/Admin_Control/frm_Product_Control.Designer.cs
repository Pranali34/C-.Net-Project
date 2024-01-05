
namespace Kranti_Book_Shop.Forms.Common_Forms.Admin_Control
{
    partial class frm_Product_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Product_Control));
            this.pnl_1 = new System.Windows.Forms.Panel();
            this.pb_Logout_Button = new System.Windows.Forms.PictureBox();
            this.pb_Back_Button = new System.Windows.Forms.PictureBox();
            this.lbl_Store_Name = new System.Windows.Forms.Label();
            this.btn_Add_Book = new System.Windows.Forms.Button();
            this.btn_Update_Book = new System.Windows.Forms.Button();
            this.btn_View_Book_List = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pnl_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logout_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Back_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_1
            // 
            this.pnl_1.BackColor = System.Drawing.Color.Navy;
            this.pnl_1.Controls.Add(this.pb_Logout_Button);
            this.pnl_1.Controls.Add(this.pb_Back_Button);
            this.pnl_1.Controls.Add(this.lbl_Store_Name);
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
            this.pb_Logout_Button.Location = new System.Drawing.Point(1146, 0);
            this.pb_Logout_Button.Name = "pb_Logout_Button";
            this.pb_Logout_Button.Size = new System.Drawing.Size(112, 101);
            this.pb_Logout_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Logout_Button.TabIndex = 64;
            this.pb_Logout_Button.TabStop = false;
            this.pb_Logout_Button.Click += new System.EventHandler(this.pb_Logout_Button_Click);
            // 
            // pb_Back_Button
            // 
            this.pb_Back_Button.Image = global::Kranti_Book_Shop.Properties.Resources.back_btn;
            this.pb_Back_Button.InitialImage = null;
            this.pb_Back_Button.Location = new System.Drawing.Point(22, 0);
            this.pb_Back_Button.Name = "pb_Back_Button";
            this.pb_Back_Button.Size = new System.Drawing.Size(112, 101);
            this.pb_Back_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Back_Button.TabIndex = 63;
            this.pb_Back_Button.TabStop = false;
            this.pb_Back_Button.Click += new System.EventHandler(this.pb_Back_Button_Click);
            // 
            // lbl_Store_Name
            // 
            this.lbl_Store_Name.AutoSize = true;
            this.lbl_Store_Name.BackColor = System.Drawing.Color.White;
            this.lbl_Store_Name.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Store_Name.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Store_Name.Location = new System.Drawing.Point(456, 23);
            this.lbl_Store_Name.Name = "lbl_Store_Name";
            this.lbl_Store_Name.Size = new System.Drawing.Size(349, 57);
            this.lbl_Store_Name.TabIndex = 1;
            this.lbl_Store_Name.Text = "Kranti Book Shop";
            // 
            // btn_Add_Book
            // 
            this.btn_Add_Book.BackColor = System.Drawing.Color.Indigo;
            this.btn_Add_Book.Font = new System.Drawing.Font("High Tower Text", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Book.ForeColor = System.Drawing.Color.White;
            this.btn_Add_Book.Location = new System.Drawing.Point(58, 557);
            this.btn_Add_Book.Name = "btn_Add_Book";
            this.btn_Add_Book.Size = new System.Drawing.Size(332, 97);
            this.btn_Add_Book.TabIndex = 57;
            this.btn_Add_Book.Text = "Add Book";
            this.btn_Add_Book.UseVisualStyleBackColor = false;
            this.btn_Add_Book.Click += new System.EventHandler(this.btn_Add_Book_Click);
            // 
            // btn_Update_Book
            // 
            this.btn_Update_Book.BackColor = System.Drawing.Color.Indigo;
            this.btn_Update_Book.Font = new System.Drawing.Font("High Tower Text", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Book.ForeColor = System.Drawing.Color.White;
            this.btn_Update_Book.Location = new System.Drawing.Point(484, 557);
            this.btn_Update_Book.Name = "btn_Update_Book";
            this.btn_Update_Book.Size = new System.Drawing.Size(332, 97);
            this.btn_Update_Book.TabIndex = 58;
            this.btn_Update_Book.Text = "Update Book";
            this.btn_Update_Book.UseVisualStyleBackColor = false;
            this.btn_Update_Book.Click += new System.EventHandler(this.btn_Update_Book_Click);
            // 
            // btn_View_Book_List
            // 
            this.btn_View_Book_List.BackColor = System.Drawing.Color.Indigo;
            this.btn_View_Book_List.Font = new System.Drawing.Font("High Tower Text", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_Book_List.ForeColor = System.Drawing.Color.White;
            this.btn_View_Book_List.Location = new System.Drawing.Point(911, 557);
            this.btn_View_Book_List.Name = "btn_View_Book_List";
            this.btn_View_Book_List.Size = new System.Drawing.Size(332, 97);
            this.btn_View_Book_List.TabIndex = 59;
            this.btn_View_Book_List.Text = "View Book List";
            this.btn_View_Book_List.UseVisualStyleBackColor = false;
            this.btn_View_Book_List.Click += new System.EventHandler(this.btn_View_Book_List_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(61, 214);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(313, 279);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 60;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(492, 214);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(313, 279);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 61;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(911, 214);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(313, 279);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 62;
            this.pictureBox5.TabStop = false;
            // 
            // frm_Product_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_View_Book_List);
            this.Controls.Add(this.btn_Update_Book);
            this.Controls.Add(this.btn_Add_Book);
            this.Controls.Add(this.pnl_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Product_Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Control";
            this.pnl_1.ResumeLayout(false);
            this.pnl_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logout_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Back_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_1;
        private System.Windows.Forms.Label lbl_Store_Name;
        private System.Windows.Forms.Button btn_Add_Book;
        private System.Windows.Forms.Button btn_Update_Book;
        private System.Windows.Forms.Button btn_View_Book_List;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pb_Logout_Button;
        private System.Windows.Forms.PictureBox pb_Back_Button;
    }
}