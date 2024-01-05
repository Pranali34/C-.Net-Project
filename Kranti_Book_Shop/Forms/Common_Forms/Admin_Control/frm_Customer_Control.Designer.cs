
namespace Kranti_Book_Shop.Forms.Common_Forms.Admin_Control
{
    partial class frm_Customer_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Customer_Control));
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_View_Book_List = new System.Windows.Forms.Button();
            this.btn_Add_Customer = new System.Windows.Forms.Button();
            this.pnl_1 = new System.Windows.Forms.Panel();
            this.pb_Back_Button = new System.Windows.Forms.PictureBox();
            this.pb_Logout_Button = new System.Windows.Forms.PictureBox();
            this.lbl_Store_Name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnl_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Back_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logout_Button)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(760, 208);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(377, 279);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 69;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(146, 208);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(377, 279);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 67;
            this.pictureBox3.TabStop = false;
            // 
            // btn_View_Book_List
            // 
            this.btn_View_Book_List.BackColor = System.Drawing.Color.Indigo;
            this.btn_View_Book_List.Font = new System.Drawing.Font("High Tower Text", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_Book_List.ForeColor = System.Drawing.Color.White;
            this.btn_View_Book_List.Location = new System.Drawing.Point(716, 553);
            this.btn_View_Book_List.Name = "btn_View_Book_List";
            this.btn_View_Book_List.Size = new System.Drawing.Size(476, 97);
            this.btn_View_Book_List.TabIndex = 66;
            this.btn_View_Book_List.Text = "View Customer List";
            this.btn_View_Book_List.UseVisualStyleBackColor = false;
            this.btn_View_Book_List.Click += new System.EventHandler(this.btn_View_Book_List_Click);
            // 
            // btn_Add_Customer
            // 
            this.btn_Add_Customer.BackColor = System.Drawing.Color.Indigo;
            this.btn_Add_Customer.Font = new System.Drawing.Font("High Tower Text", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Customer.ForeColor = System.Drawing.Color.White;
            this.btn_Add_Customer.Location = new System.Drawing.Point(101, 553);
            this.btn_Add_Customer.Name = "btn_Add_Customer";
            this.btn_Add_Customer.Size = new System.Drawing.Size(476, 97);
            this.btn_Add_Customer.TabIndex = 64;
            this.btn_Add_Customer.Text = "Add Customer";
            this.btn_Add_Customer.UseVisualStyleBackColor = false;
            this.btn_Add_Customer.Click += new System.EventHandler(this.btn_Add_Customer_Click);
            // 
            // pnl_1
            // 
            this.pnl_1.BackColor = System.Drawing.Color.Navy;
            this.pnl_1.Controls.Add(this.pb_Back_Button);
            this.pnl_1.Controls.Add(this.pb_Logout_Button);
            this.pnl_1.Controls.Add(this.lbl_Store_Name);
            this.pnl_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_1.Location = new System.Drawing.Point(0, 0);
            this.pnl_1.Name = "pnl_1";
            this.pnl_1.Size = new System.Drawing.Size(1282, 101);
            this.pnl_1.TabIndex = 63;
            // 
            // pb_Back_Button
            // 
            this.pb_Back_Button.Image = global::Kranti_Book_Shop.Properties.Resources.back_btn;
            this.pb_Back_Button.InitialImage = null;
            this.pb_Back_Button.Location = new System.Drawing.Point(27, 0);
            this.pb_Back_Button.Name = "pb_Back_Button";
            this.pb_Back_Button.Size = new System.Drawing.Size(112, 101);
            this.pb_Back_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Back_Button.TabIndex = 57;
            this.pb_Back_Button.TabStop = false;
            this.pb_Back_Button.Click += new System.EventHandler(this.pb_Back_Button_Click);
            // 
            // pb_Logout_Button
            // 
            this.pb_Logout_Button.Image = global::Kranti_Book_Shop.Properties.Resources.logout_btn;
            this.pb_Logout_Button.InitialImage = null;
            this.pb_Logout_Button.Location = new System.Drawing.Point(1144, 0);
            this.pb_Logout_Button.Name = "pb_Logout_Button";
            this.pb_Logout_Button.Size = new System.Drawing.Size(112, 101);
            this.pb_Logout_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Logout_Button.TabIndex = 56;
            this.pb_Logout_Button.TabStop = false;
            this.pb_Logout_Button.Click += new System.EventHandler(this.pb_Logout_Button_Click);
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
            // frm_Customer_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_View_Book_List);
            this.Controls.Add(this.btn_Add_Customer);
            this.Controls.Add(this.pnl_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Customer_Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Control";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnl_1.ResumeLayout(false);
            this.pnl_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Back_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logout_Button)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_View_Book_List;
        private System.Windows.Forms.Button btn_Add_Customer;
        private System.Windows.Forms.Panel pnl_1;
        private System.Windows.Forms.Label lbl_Store_Name;
        private System.Windows.Forms.PictureBox pb_Back_Button;
        private System.Windows.Forms.PictureBox pb_Logout_Button;
    }
}