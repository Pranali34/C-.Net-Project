
namespace Kranti_Book_Shop.Forms.Product_Forms
{
    partial class frm_Add_New_Book
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
            this.lbl_Add_New_Book = new System.Windows.Forms.Label();
            this.gb_Book_Details = new System.Windows.Forms.GroupBox();
            this.cmb_Genre = new System.Windows.Forms.ComboBox();
            this.cmb_Supplier = new System.Windows.Forms.ComboBox();
            this.tb_Book_Note = new System.Windows.Forms.RichTextBox();
            this.tb_Selling_Price = new System.Windows.Forms.TextBox();
            this.lbl_Selling_Price = new System.Windows.Forms.Label();
            this.tb_Purchase_Price = new System.Windows.Forms.TextBox();
            this.lbl_Purchase_Price = new System.Windows.Forms.Label();
            this.lbl_Book_Note = new System.Windows.Forms.Label();
            this.lbl_Supplier = new System.Windows.Forms.Label();
            this.lbl_Genre = new System.Windows.Forms.Label();
            this.tb_Author = new System.Windows.Forms.TextBox();
            this.lbl_Author = new System.Windows.Forms.Label();
            this.tb_Book_Name = new System.Windows.Forms.TextBox();
            this.lbl_Book_Name = new System.Windows.Forms.Label();
            this.tb_Book_Id = new System.Windows.Forms.TextBox();
            this.lbl_Book_ID = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.pnl_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Back_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logout_Button)).BeginInit();
            this.gb_Book_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_1
            // 
            this.pnl_1.BackColor = System.Drawing.Color.Navy;
            this.pnl_1.Controls.Add(this.pb_Back_Button);
            this.pnl_1.Controls.Add(this.pb_Logout_Button);
            this.pnl_1.Controls.Add(this.lbl_Add_New_Book);
            this.pnl_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_1.Location = new System.Drawing.Point(0, 0);
            this.pnl_1.Name = "pnl_1";
            this.pnl_1.Size = new System.Drawing.Size(1282, 101);
            this.pnl_1.TabIndex = 1;
            // 
            // pb_Back_Button
            // 
            this.pb_Back_Button.Image = global::Kranti_Book_Shop.Properties.Resources.back_btn;
            this.pb_Back_Button.InitialImage = null;
            this.pb_Back_Button.Location = new System.Drawing.Point(24, 0);
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
            this.pb_Logout_Button.Location = new System.Drawing.Point(1145, 0);
            this.pb_Logout_Button.Name = "pb_Logout_Button";
            this.pb_Logout_Button.Size = new System.Drawing.Size(112, 101);
            this.pb_Logout_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Logout_Button.TabIndex = 61;
            this.pb_Logout_Button.TabStop = false;
            this.pb_Logout_Button.Click += new System.EventHandler(this.pb_Logout_Button_Click);
            // 
            // lbl_Add_New_Book
            // 
            this.lbl_Add_New_Book.AutoSize = true;
            this.lbl_Add_New_Book.BackColor = System.Drawing.Color.White;
            this.lbl_Add_New_Book.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Book.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Add_New_Book.Location = new System.Drawing.Point(496, 22);
            this.lbl_Add_New_Book.Name = "lbl_Add_New_Book";
            this.lbl_Add_New_Book.Size = new System.Drawing.Size(302, 57);
            this.lbl_Add_New_Book.TabIndex = 1;
            this.lbl_Add_New_Book.Text = "Add New Book";
            // 
            // gb_Book_Details
            // 
            this.gb_Book_Details.BackColor = System.Drawing.Color.Lavender;
            this.gb_Book_Details.Controls.Add(this.cmb_Genre);
            this.gb_Book_Details.Controls.Add(this.cmb_Supplier);
            this.gb_Book_Details.Controls.Add(this.tb_Book_Note);
            this.gb_Book_Details.Controls.Add(this.tb_Selling_Price);
            this.gb_Book_Details.Controls.Add(this.lbl_Selling_Price);
            this.gb_Book_Details.Controls.Add(this.tb_Purchase_Price);
            this.gb_Book_Details.Controls.Add(this.lbl_Purchase_Price);
            this.gb_Book_Details.Controls.Add(this.lbl_Book_Note);
            this.gb_Book_Details.Controls.Add(this.lbl_Supplier);
            this.gb_Book_Details.Controls.Add(this.lbl_Genre);
            this.gb_Book_Details.Controls.Add(this.tb_Author);
            this.gb_Book_Details.Controls.Add(this.lbl_Author);
            this.gb_Book_Details.Controls.Add(this.tb_Book_Name);
            this.gb_Book_Details.Controls.Add(this.lbl_Book_Name);
            this.gb_Book_Details.Controls.Add(this.tb_Book_Id);
            this.gb_Book_Details.Controls.Add(this.lbl_Book_ID);
            this.gb_Book_Details.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Book_Details.ForeColor = System.Drawing.Color.Black;
            this.gb_Book_Details.Location = new System.Drawing.Point(50, 146);
            this.gb_Book_Details.Name = "gb_Book_Details";
            this.gb_Book_Details.Size = new System.Drawing.Size(1185, 488);
            this.gb_Book_Details.TabIndex = 2;
            this.gb_Book_Details.TabStop = false;
            this.gb_Book_Details.Text = "Book Details";
            // 
            // cmb_Genre
            // 
            this.cmb_Genre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Genre.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.cmb_Genre.FormattingEnabled = true;
            this.cmb_Genre.Items.AddRange(new object[] {
            "Fiction",
            "Novel",
            "Mystery",
            "Historical ",
            "Narrative"});
            this.cmb_Genre.Location = new System.Drawing.Point(246, 227);
            this.cmb_Genre.Name = "cmb_Genre";
            this.cmb_Genre.Size = new System.Drawing.Size(325, 39);
            this.cmb_Genre.TabIndex = 4;
            // 
            // cmb_Supplier
            // 
            this.cmb_Supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Supplier.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.cmb_Supplier.FormattingEnabled = true;
            this.cmb_Supplier.Items.AddRange(new object[] {
            "lakshmi Agency",
            "Learn Vern ",
            "Mahalakshmi",
            "Karad Agency",
            ""});
            this.cmb_Supplier.Location = new System.Drawing.Point(805, 224);
            this.cmb_Supplier.Name = "cmb_Supplier";
            this.cmb_Supplier.Size = new System.Drawing.Size(325, 39);
            this.cmb_Supplier.TabIndex = 5;
            // 
            // tb_Book_Note
            // 
            this.tb_Book_Note.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.tb_Book_Note.Location = new System.Drawing.Point(805, 315);
            this.tb_Book_Note.Name = "tb_Book_Note";
            this.tb_Book_Note.Size = new System.Drawing.Size(325, 130);
            this.tb_Book_Note.TabIndex = 8;
            this.tb_Book_Note.Text = "";
            // 
            // tb_Selling_Price
            // 
            this.tb_Selling_Price.BackColor = System.Drawing.Color.White;
            this.tb_Selling_Price.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Selling_Price.Location = new System.Drawing.Point(246, 406);
            this.tb_Selling_Price.MaxLength = 120;
            this.tb_Selling_Price.Name = "tb_Selling_Price";
            this.tb_Selling_Price.Size = new System.Drawing.Size(325, 39);
            this.tb_Selling_Price.TabIndex = 7;
            this.tb_Selling_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Selling_Price
            // 
            this.lbl_Selling_Price.AutoSize = true;
            this.lbl_Selling_Price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Selling_Price.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Selling_Price.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Selling_Price.Location = new System.Drawing.Point(45, 409);
            this.lbl_Selling_Price.Name = "lbl_Selling_Price";
            this.lbl_Selling_Price.Size = new System.Drawing.Size(158, 33);
            this.lbl_Selling_Price.TabIndex = 24;
            this.lbl_Selling_Price.Text = "Selling Price";
            // 
            // tb_Purchase_Price
            // 
            this.tb_Purchase_Price.BackColor = System.Drawing.Color.White;
            this.tb_Purchase_Price.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Purchase_Price.Location = new System.Drawing.Point(246, 315);
            this.tb_Purchase_Price.MaxLength = 120;
            this.tb_Purchase_Price.Name = "tb_Purchase_Price";
            this.tb_Purchase_Price.Size = new System.Drawing.Size(325, 39);
            this.tb_Purchase_Price.TabIndex = 6;
            this.tb_Purchase_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Purchase_Price
            // 
            this.lbl_Purchase_Price.AutoSize = true;
            this.lbl_Purchase_Price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Purchase_Price.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purchase_Price.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Purchase_Price.Location = new System.Drawing.Point(45, 318);
            this.lbl_Purchase_Price.Name = "lbl_Purchase_Price";
            this.lbl_Purchase_Price.Size = new System.Drawing.Size(179, 33);
            this.lbl_Purchase_Price.TabIndex = 22;
            this.lbl_Purchase_Price.Text = "Purchase Price";
            // 
            // lbl_Book_Note
            // 
            this.lbl_Book_Note.AutoSize = true;
            this.lbl_Book_Note.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Book_Note.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Note.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Book_Note.Location = new System.Drawing.Point(635, 315);
            this.lbl_Book_Note.Name = "lbl_Book_Note";
            this.lbl_Book_Note.Size = new System.Drawing.Size(137, 33);
            this.lbl_Book_Note.TabIndex = 20;
            this.lbl_Book_Note.Text = "Book Note";
            // 
            // lbl_Supplier
            // 
            this.lbl_Supplier.AutoSize = true;
            this.lbl_Supplier.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Supplier.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Supplier.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Supplier.Location = new System.Drawing.Point(635, 227);
            this.lbl_Supplier.Name = "lbl_Supplier";
            this.lbl_Supplier.Size = new System.Drawing.Size(110, 33);
            this.lbl_Supplier.TabIndex = 18;
            this.lbl_Supplier.Text = "Supplier";
            // 
            // lbl_Genre
            // 
            this.lbl_Genre.AutoSize = true;
            this.lbl_Genre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Genre.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Genre.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Genre.Location = new System.Drawing.Point(45, 230);
            this.lbl_Genre.Name = "lbl_Genre";
            this.lbl_Genre.Size = new System.Drawing.Size(81, 33);
            this.lbl_Genre.TabIndex = 16;
            this.lbl_Genre.Text = "Genre";
            // 
            // tb_Author
            // 
            this.tb_Author.BackColor = System.Drawing.Color.White;
            this.tb_Author.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Author.Location = new System.Drawing.Point(805, 54);
            this.tb_Author.MaxLength = 120;
            this.tb_Author.Name = "tb_Author";
            this.tb_Author.Size = new System.Drawing.Size(325, 39);
            this.tb_Author.TabIndex = 2;
            this.tb_Author.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // lbl_Author
            // 
            this.lbl_Author.AutoSize = true;
            this.lbl_Author.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Author.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Author.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Author.Location = new System.Drawing.Point(635, 57);
            this.lbl_Author.Name = "lbl_Author";
            this.lbl_Author.Size = new System.Drawing.Size(93, 33);
            this.lbl_Author.TabIndex = 14;
            this.lbl_Author.Text = "Author";
            // 
            // tb_Book_Name
            // 
            this.tb_Book_Name.BackColor = System.Drawing.Color.White;
            this.tb_Book_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Book_Name.Location = new System.Drawing.Point(246, 140);
            this.tb_Book_Name.MaxLength = 120;
            this.tb_Book_Name.Name = "tb_Book_Name";
            this.tb_Book_Name.Size = new System.Drawing.Size(884, 39);
            this.tb_Book_Name.TabIndex = 3;
            // 
            // lbl_Book_Name
            // 
            this.lbl_Book_Name.AutoSize = true;
            this.lbl_Book_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Book_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Name.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Book_Name.Location = new System.Drawing.Point(45, 143);
            this.lbl_Book_Name.Name = "lbl_Book_Name";
            this.lbl_Book_Name.Size = new System.Drawing.Size(147, 33);
            this.lbl_Book_Name.TabIndex = 12;
            this.lbl_Book_Name.Text = "Book Name";
            // 
            // tb_Book_Id
            // 
            this.tb_Book_Id.BackColor = System.Drawing.Color.White;
            this.tb_Book_Id.Enabled = false;
            this.tb_Book_Id.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Book_Id.Location = new System.Drawing.Point(246, 54);
            this.tb_Book_Id.MaxLength = 120;
            this.tb_Book_Id.Name = "tb_Book_Id";
            this.tb_Book_Id.Size = new System.Drawing.Size(325, 39);
            this.tb_Book_Id.TabIndex = 1;
            // 
            // lbl_Book_ID
            // 
            this.lbl_Book_ID.AutoSize = true;
            this.lbl_Book_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Book_ID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_ID.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Book_ID.Location = new System.Drawing.Point(45, 57);
            this.lbl_Book_ID.Name = "lbl_Book_ID";
            this.lbl_Book_ID.Size = new System.Drawing.Size(111, 33);
            this.lbl_Book_ID.TabIndex = 10;
            this.lbl_Book_ID.Text = "Book ID";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Indigo;
            this.btn_Save.Font = new System.Drawing.Font("High Tower Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(296, 667);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(218, 59);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.Indigo;
            this.btn_Reset.Font = new System.Drawing.Font("High Tower Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.White;
            this.btn_Reset.Location = new System.Drawing.Point(764, 667);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(218, 59);
            this.btn_Reset.TabIndex = 10;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // frm_Add_New_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.gb_Book_Details);
            this.Controls.Add(this.pnl_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_New_Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Form";
            this.Load += new System.EventHandler(this.frm_Add_New_Book_Load);
            this.pnl_1.ResumeLayout(false);
            this.pnl_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Back_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logout_Button)).EndInit();
            this.gb_Book_Details.ResumeLayout(false);
            this.gb_Book_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_1;
        private System.Windows.Forms.Label lbl_Add_New_Book;
        private System.Windows.Forms.GroupBox gb_Book_Details;
        private System.Windows.Forms.ComboBox cmb_Supplier;
        private System.Windows.Forms.RichTextBox tb_Book_Note;
        private System.Windows.Forms.TextBox tb_Selling_Price;
        private System.Windows.Forms.Label lbl_Selling_Price;
        private System.Windows.Forms.TextBox tb_Purchase_Price;
        private System.Windows.Forms.Label lbl_Purchase_Price;
        private System.Windows.Forms.Label lbl_Book_Note;
        private System.Windows.Forms.Label lbl_Supplier;
        private System.Windows.Forms.Label lbl_Genre;
        private System.Windows.Forms.TextBox tb_Author;
        private System.Windows.Forms.Label lbl_Author;
        private System.Windows.Forms.TextBox tb_Book_Name;
        private System.Windows.Forms.Label lbl_Book_Name;
        private System.Windows.Forms.TextBox tb_Book_Id;
        private System.Windows.Forms.Label lbl_Book_ID;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.ComboBox cmb_Genre;
        private System.Windows.Forms.PictureBox pb_Back_Button;
        private System.Windows.Forms.PictureBox pb_Logout_Button;
    }
}