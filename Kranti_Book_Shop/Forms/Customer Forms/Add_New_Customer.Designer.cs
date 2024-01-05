
namespace Kranti_Book_Shop.Forms.Customer_Forms
{
    partial class Add_New_Customer
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
            this.pb_Back_Button = new System.Windows.Forms.PictureBox();
            this.pb_Logout_Button = new System.Windows.Forms.PictureBox();
            this.lbl_Add_New_Customer = new System.Windows.Forms.Label();
            this.lbl_Customer_Details = new System.Windows.Forms.GroupBox();
            this.dtp_Bill_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Bill_Date = new System.Windows.Forms.Label();
            this.tb_Mob_No = new System.Windows.Forms.TextBox();
            this.lbl_Mob_No = new System.Windows.Forms.Label();
            this.tb_Full_Name = new System.Windows.Forms.TextBox();
            this.lbl_Full_Name = new System.Windows.Forms.Label();
            this.tb_Customer_Id = new System.Windows.Forms.TextBox();
            this.lbl_Customer_ID = new System.Windows.Forms.Label();
            this.gb_Add_Book = new System.Windows.Forms.GroupBox();
            this.tb_Total_Price = new System.Windows.Forms.TextBox();
            this.lbl_Total_Price = new System.Windows.Forms.Label();
            this.tb_Qty = new System.Windows.Forms.TextBox();
            this.lbl_Qty = new System.Windows.Forms.Label();
            this.cmb_Book_Name = new System.Windows.Forms.ComboBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Book_Name = new System.Windows.Forms.Label();
            this.dgv_View_Added_Product_List = new System.Windows.Forms.DataGridView();
            this.tb_Total_Bill = new System.Windows.Forms.TextBox();
            this.lbl_Total_Bill = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.pnl_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Back_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logout_Button)).BeginInit();
            this.lbl_Customer_Details.SuspendLayout();
            this.gb_Add_Book.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Added_Product_List)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_1
            // 
            this.pnl_1.BackColor = System.Drawing.Color.Navy;
            this.pnl_1.Controls.Add(this.pb_Back_Button);
            this.pnl_1.Controls.Add(this.pb_Logout_Button);
            this.pnl_1.Controls.Add(this.lbl_Add_New_Customer);
            this.pnl_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_1.Location = new System.Drawing.Point(0, 0);
            this.pnl_1.Name = "pnl_1";
            this.pnl_1.Size = new System.Drawing.Size(1282, 101);
            this.pnl_1.TabIndex = 3;
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
            // pb_Logout_Button
            // 
            this.pb_Logout_Button.Image = global::Kranti_Book_Shop.Properties.Resources.logout_btn;
            this.pb_Logout_Button.InitialImage = null;
            this.pb_Logout_Button.Location = new System.Drawing.Point(1147, 0);
            this.pb_Logout_Button.Name = "pb_Logout_Button";
            this.pb_Logout_Button.Size = new System.Drawing.Size(112, 101);
            this.pb_Logout_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Logout_Button.TabIndex = 61;
            this.pb_Logout_Button.TabStop = false;
            this.pb_Logout_Button.Click += new System.EventHandler(this.pb_Logout_Button_Click);
            // 
            // lbl_Add_New_Customer
            // 
            this.lbl_Add_New_Customer.AutoSize = true;
            this.lbl_Add_New_Customer.BackColor = System.Drawing.Color.White;
            this.lbl_Add_New_Customer.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Customer.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Add_New_Customer.Location = new System.Drawing.Point(457, 22);
            this.lbl_Add_New_Customer.Name = "lbl_Add_New_Customer";
            this.lbl_Add_New_Customer.Size = new System.Drawing.Size(374, 57);
            this.lbl_Add_New_Customer.TabIndex = 1;
            this.lbl_Add_New_Customer.Text = "Add New Customer";
            // 
            // lbl_Customer_Details
            // 
            this.lbl_Customer_Details.BackColor = System.Drawing.Color.Lavender;
            this.lbl_Customer_Details.Controls.Add(this.dtp_Bill_Date);
            this.lbl_Customer_Details.Controls.Add(this.lbl_Bill_Date);
            this.lbl_Customer_Details.Controls.Add(this.tb_Mob_No);
            this.lbl_Customer_Details.Controls.Add(this.lbl_Mob_No);
            this.lbl_Customer_Details.Controls.Add(this.tb_Full_Name);
            this.lbl_Customer_Details.Controls.Add(this.lbl_Full_Name);
            this.lbl_Customer_Details.Controls.Add(this.tb_Customer_Id);
            this.lbl_Customer_Details.Controls.Add(this.lbl_Customer_ID);
            this.lbl_Customer_Details.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Details.Location = new System.Drawing.Point(35, 117);
            this.lbl_Customer_Details.Name = "lbl_Customer_Details";
            this.lbl_Customer_Details.Size = new System.Drawing.Size(1209, 158);
            this.lbl_Customer_Details.TabIndex = 4;
            this.lbl_Customer_Details.TabStop = false;
            this.lbl_Customer_Details.Text = "Customer Details";
            // 
            // dtp_Bill_Date
            // 
            this.dtp_Bill_Date.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.dtp_Bill_Date.Location = new System.Drawing.Point(474, 40);
            this.dtp_Bill_Date.Name = "dtp_Bill_Date";
            this.dtp_Bill_Date.Size = new System.Drawing.Size(226, 34);
            this.dtp_Bill_Date.TabIndex = 2;
            // 
            // lbl_Bill_Date
            // 
            this.lbl_Bill_Date.AutoSize = true;
            this.lbl_Bill_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Bill_Date.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bill_Date.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Bill_Date.Location = new System.Drawing.Point(357, 43);
            this.lbl_Bill_Date.Name = "lbl_Bill_Date";
            this.lbl_Bill_Date.Size = new System.Drawing.Size(98, 27);
            this.lbl_Bill_Date.TabIndex = 2;
            this.lbl_Bill_Date.Text = "Bill Date";
            // 
            // tb_Mob_No
            // 
            this.tb_Mob_No.BackColor = System.Drawing.Color.White;
            this.tb_Mob_No.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mob_No.Location = new System.Drawing.Point(900, 40);
            this.tb_Mob_No.MaxLength = 10;
            this.tb_Mob_No.Name = "tb_Mob_No";
            this.tb_Mob_No.Size = new System.Drawing.Size(255, 34);
            this.tb_Mob_No.TabIndex = 3;
            this.tb_Mob_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Mob_No
            // 
            this.lbl_Mob_No.AutoSize = true;
            this.lbl_Mob_No.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Mob_No.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mob_No.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Mob_No.Location = new System.Drawing.Point(777, 43);
            this.lbl_Mob_No.Name = "lbl_Mob_No";
            this.lbl_Mob_No.Size = new System.Drawing.Size(98, 27);
            this.lbl_Mob_No.TabIndex = 16;
            this.lbl_Mob_No.Text = "Mob No.";
            // 
            // tb_Full_Name
            // 
            this.tb_Full_Name.BackColor = System.Drawing.Color.White;
            this.tb_Full_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Full_Name.Location = new System.Drawing.Point(187, 97);
            this.tb_Full_Name.MaxLength = 120;
            this.tb_Full_Name.Name = "tb_Full_Name";
            this.tb_Full_Name.Size = new System.Drawing.Size(958, 34);
            this.tb_Full_Name.TabIndex = 4;
            // 
            // lbl_Full_Name
            // 
            this.lbl_Full_Name.AutoSize = true;
            this.lbl_Full_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Full_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Full_Name.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Full_Name.Location = new System.Drawing.Point(31, 100);
            this.lbl_Full_Name.Name = "lbl_Full_Name";
            this.lbl_Full_Name.Size = new System.Drawing.Size(112, 27);
            this.lbl_Full_Name.TabIndex = 14;
            this.lbl_Full_Name.Text = "Full Name";
            // 
            // tb_Customer_Id
            // 
            this.tb_Customer_Id.BackColor = System.Drawing.Color.White;
            this.tb_Customer_Id.Enabled = false;
            this.tb_Customer_Id.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_Id.Location = new System.Drawing.Point(187, 40);
            this.tb_Customer_Id.MaxLength = 120;
            this.tb_Customer_Id.Name = "tb_Customer_Id";
            this.tb_Customer_Id.Size = new System.Drawing.Size(127, 34);
            this.tb_Customer_Id.TabIndex = 1;
            // 
            // lbl_Customer_ID
            // 
            this.lbl_Customer_ID.AutoSize = true;
            this.lbl_Customer_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Customer_ID.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_ID.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Customer_ID.Location = new System.Drawing.Point(31, 43);
            this.lbl_Customer_ID.Name = "lbl_Customer_ID";
            this.lbl_Customer_ID.Size = new System.Drawing.Size(136, 27);
            this.lbl_Customer_ID.TabIndex = 12;
            this.lbl_Customer_ID.Text = "Customer ID";
            // 
            // gb_Add_Book
            // 
            this.gb_Add_Book.BackColor = System.Drawing.Color.Lavender;
            this.gb_Add_Book.Controls.Add(this.tb_Total_Price);
            this.gb_Add_Book.Controls.Add(this.lbl_Total_Price);
            this.gb_Add_Book.Controls.Add(this.tb_Qty);
            this.gb_Add_Book.Controls.Add(this.lbl_Qty);
            this.gb_Add_Book.Controls.Add(this.cmb_Book_Name);
            this.gb_Add_Book.Controls.Add(this.btn_Add);
            this.gb_Add_Book.Controls.Add(this.tb_Price);
            this.gb_Add_Book.Controls.Add(this.lbl_Price);
            this.gb_Add_Book.Controls.Add(this.lbl_Book_Name);
            this.gb_Add_Book.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Add_Book.Location = new System.Drawing.Point(35, 281);
            this.gb_Add_Book.Name = "gb_Add_Book";
            this.gb_Add_Book.Size = new System.Drawing.Size(1209, 146);
            this.gb_Add_Book.TabIndex = 20;
            this.gb_Add_Book.TabStop = false;
            this.gb_Add_Book.Text = "Add Book";
            // 
            // tb_Total_Price
            // 
            this.tb_Total_Price.BackColor = System.Drawing.Color.White;
            this.tb_Total_Price.Enabled = false;
            this.tb_Total_Price.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Price.Location = new System.Drawing.Point(809, 88);
            this.tb_Total_Price.MaxLength = 120;
            this.tb_Total_Price.Name = "tb_Total_Price";
            this.tb_Total_Price.Size = new System.Drawing.Size(167, 34);
            this.tb_Total_Price.TabIndex = 8;
            this.tb_Total_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Total_Price
            // 
            this.lbl_Total_Price.AutoSize = true;
            this.lbl_Total_Price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Total_Price.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Price.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Total_Price.Location = new System.Drawing.Point(612, 91);
            this.lbl_Total_Price.Name = "lbl_Total_Price";
            this.lbl_Total_Price.Size = new System.Drawing.Size(116, 27);
            this.lbl_Total_Price.TabIndex = 24;
            this.lbl_Total_Price.Text = "Total Price";
            // 
            // tb_Qty
            // 
            this.tb_Qty.BackColor = System.Drawing.Color.White;
            this.tb_Qty.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Qty.Location = new System.Drawing.Point(188, 88);
            this.tb_Qty.MaxLength = 120;
            this.tb_Qty.Name = "tb_Qty";
            this.tb_Qty.Size = new System.Drawing.Size(146, 34);
            this.tb_Qty.TabIndex = 7;
            this.tb_Qty.TextChanged += new System.EventHandler(this.tb_Qty_TextChanged);
            this.tb_Qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Qty
            // 
            this.lbl_Qty.AutoSize = true;
            this.lbl_Qty.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Qty.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Qty.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Qty.Location = new System.Drawing.Point(71, 91);
            this.lbl_Qty.Name = "lbl_Qty";
            this.lbl_Qty.Size = new System.Drawing.Size(96, 27);
            this.lbl_Qty.TabIndex = 23;
            this.lbl_Qty.Text = "Quantity";
            // 
            // cmb_Book_Name
            // 
            this.cmb_Book_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Book_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Book_Name.FormattingEnabled = true;
            this.cmb_Book_Name.Items.AddRange(new object[] {
            "",
            "The Lord of the Rings",
            "Beloved",
            "The Hobbit",
            "Harry Potter"});
            this.cmb_Book_Name.Location = new System.Drawing.Point(188, 28);
            this.cmb_Book_Name.Name = "cmb_Book_Name";
            this.cmb_Book_Name.Size = new System.Drawing.Size(416, 34);
            this.cmb_Book_Name.TabIndex = 5;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Indigo;
            this.btn_Add.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(1033, 42);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(138, 67);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // tb_Price
            // 
            this.tb_Price.BackColor = System.Drawing.Color.White;
            this.tb_Price.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Price.Location = new System.Drawing.Point(809, 28);
            this.tb_Price.MaxLength = 120;
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(167, 34);
            this.tb_Price.TabIndex = 6;
            this.tb_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Price.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Price.Location = new System.Drawing.Point(666, 31);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(62, 27);
            this.lbl_Price.TabIndex = 18;
            this.lbl_Price.Text = "Price";
            // 
            // lbl_Book_Name
            // 
            this.lbl_Book_Name.AutoSize = true;
            this.lbl_Book_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Book_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Name.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Book_Name.Location = new System.Drawing.Point(41, 31);
            this.lbl_Book_Name.Name = "lbl_Book_Name";
            this.lbl_Book_Name.Size = new System.Drawing.Size(127, 27);
            this.lbl_Book_Name.TabIndex = 12;
            this.lbl_Book_Name.Text = "Book Name";
            // 
            // dgv_View_Added_Product_List
            // 
            this.dgv_View_Added_Product_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_Added_Product_List.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgv_View_Added_Product_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Added_Product_List.Location = new System.Drawing.Point(35, 450);
            this.dgv_View_Added_Product_List.Name = "dgv_View_Added_Product_List";
            this.dgv_View_Added_Product_List.RowHeadersWidth = 51;
            this.dgv_View_Added_Product_List.RowTemplate.Height = 24;
            this.dgv_View_Added_Product_List.Size = new System.Drawing.Size(1209, 185);
            this.dgv_View_Added_Product_List.TabIndex = 21;
            // 
            // tb_Total_Bill
            // 
            this.tb_Total_Bill.BackColor = System.Drawing.Color.White;
            this.tb_Total_Bill.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Bill.Location = new System.Drawing.Point(295, 673);
            this.tb_Total_Bill.MaxLength = 120;
            this.tb_Total_Bill.Name = "tb_Total_Bill";
            this.tb_Total_Bill.Size = new System.Drawing.Size(195, 39);
            this.tb_Total_Bill.TabIndex = 9;
            this.tb_Total_Bill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Total_Bill
            // 
            this.lbl_Total_Bill.AutoSize = true;
            this.lbl_Total_Bill.BackColor = System.Drawing.Color.Lavender;
            this.lbl_Total_Bill.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Bill.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Total_Bill.Location = new System.Drawing.Point(136, 676);
            this.lbl_Total_Bill.Name = "lbl_Total_Bill";
            this.lbl_Total_Bill.Size = new System.Drawing.Size(121, 33);
            this.lbl_Total_Bill.TabIndex = 37;
            this.lbl_Total_Bill.Text = "Total Bill";
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.Indigo;
            this.btn_Reset.Font = new System.Drawing.Font("High Tower Text", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.White;
            this.btn_Reset.Location = new System.Drawing.Point(956, 658);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(198, 60);
            this.btn_Reset.TabIndex = 11;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Indigo;
            this.btn_Save.Font = new System.Drawing.Font("High Tower Text", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(633, 658);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(198, 60);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Add_New_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.tb_Total_Bill);
            this.Controls.Add(this.lbl_Total_Bill);
            this.Controls.Add(this.dgv_View_Added_Product_List);
            this.Controls.Add(this.gb_Add_Book);
            this.Controls.Add(this.lbl_Customer_Details);
            this.Controls.Add(this.pnl_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_New_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Customer";
            this.Load += new System.EventHandler(this.Add_New_Customer_Load);
            this.pnl_1.ResumeLayout(false);
            this.pnl_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Back_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logout_Button)).EndInit();
            this.lbl_Customer_Details.ResumeLayout(false);
            this.lbl_Customer_Details.PerformLayout();
            this.gb_Add_Book.ResumeLayout(false);
            this.gb_Add_Book.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Added_Product_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_1;
        private System.Windows.Forms.Label lbl_Add_New_Customer;
        private System.Windows.Forms.GroupBox lbl_Customer_Details;
        private System.Windows.Forms.TextBox tb_Customer_Id;
        private System.Windows.Forms.Label lbl_Customer_ID;
        private System.Windows.Forms.Label lbl_Bill_Date;
        private System.Windows.Forms.TextBox tb_Mob_No;
        private System.Windows.Forms.Label lbl_Mob_No;
        private System.Windows.Forms.TextBox tb_Full_Name;
        private System.Windows.Forms.Label lbl_Full_Name;
        private System.Windows.Forms.DateTimePicker dtp_Bill_Date;
        private System.Windows.Forms.GroupBox gb_Add_Book;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Book_Name;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dgv_View_Added_Product_List;
        private System.Windows.Forms.TextBox tb_Total_Bill;
        private System.Windows.Forms.Label lbl_Total_Bill;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.PictureBox pb_Back_Button;
        private System.Windows.Forms.PictureBox pb_Logout_Button;
        private System.Windows.Forms.ComboBox cmb_Book_Name;
        private System.Windows.Forms.TextBox tb_Total_Price;
        private System.Windows.Forms.Label lbl_Total_Price;
        private System.Windows.Forms.TextBox tb_Qty;
        private System.Windows.Forms.Label lbl_Qty;
    }
}