
namespace Kranti_Book_Shop.Forms.Employee
{
    partial class frm_Add_New_Employee
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
            this.lbl_Add_New_Employee = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.gb_Employee_Details = new System.Windows.Forms.GroupBox();
            this.cmb_Shift_Time = new System.Windows.Forms.ComboBox();
            this.tb_Qualification = new System.Windows.Forms.TextBox();
            this.lbl_Qualification = new System.Windows.Forms.Label();
            this.tb_Pan_No = new System.Windows.Forms.TextBox();
            this.lbl_PAN_No = new System.Windows.Forms.Label();
            this.cmb_Job_Position = new System.Windows.Forms.ComboBox();
            this.lbl_Job_Position = new System.Windows.Forms.Label();
            this.tb_Address = new System.Windows.Forms.RichTextBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.dtp_Joining = new System.Windows.Forms.DateTimePicker();
            this.tb_Adhaar_No = new System.Windows.Forms.TextBox();
            this.lbl_Adhaar_No = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.tb_Full_Name = new System.Windows.Forms.TextBox();
            this.lbl_Full_Name = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Joining_Date = new System.Windows.Forms.Label();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.tb_Alternate_No = new System.Windows.Forms.TextBox();
            this.lbl_Alternate_No = new System.Windows.Forms.Label();
            this.lbl_Shift_Time = new System.Windows.Forms.Label();
            this.tb_Employee_Id = new System.Windows.Forms.TextBox();
            this.lbl_Employee_Id = new System.Windows.Forms.Label();
            this.pnl_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logout_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Back_Button)).BeginInit();
            this.gb_Employee_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_1
            // 
            this.pnl_1.BackColor = System.Drawing.Color.Navy;
            this.pnl_1.Controls.Add(this.pb_Logout_Button);
            this.pnl_1.Controls.Add(this.pb_Back_Button);
            this.pnl_1.Controls.Add(this.lbl_Add_New_Employee);
            this.pnl_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_1.Location = new System.Drawing.Point(0, 0);
            this.pnl_1.Name = "pnl_1";
            this.pnl_1.Size = new System.Drawing.Size(1282, 101);
            this.pnl_1.TabIndex = 5;
            // 
            // pb_Logout_Button
            // 
            this.pb_Logout_Button.Image = global::Kranti_Book_Shop.Properties.Resources.logout_btn;
            this.pb_Logout_Button.InitialImage = null;
            this.pb_Logout_Button.Location = new System.Drawing.Point(1146, 0);
            this.pb_Logout_Button.Name = "pb_Logout_Button";
            this.pb_Logout_Button.Size = new System.Drawing.Size(112, 101);
            this.pb_Logout_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Logout_Button.TabIndex = 216;
            this.pb_Logout_Button.TabStop = false;
            this.pb_Logout_Button.Click += new System.EventHandler(this.pb_Logout_Button_Click);
            // 
            // pb_Back_Button
            // 
            this.pb_Back_Button.Image = global::Kranti_Book_Shop.Properties.Resources.back_btn;
            this.pb_Back_Button.InitialImage = null;
            this.pb_Back_Button.Location = new System.Drawing.Point(21, 0);
            this.pb_Back_Button.Name = "pb_Back_Button";
            this.pb_Back_Button.Size = new System.Drawing.Size(112, 101);
            this.pb_Back_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Back_Button.TabIndex = 215;
            this.pb_Back_Button.TabStop = false;
            this.pb_Back_Button.Click += new System.EventHandler(this.pb_Back_Button_Click);
            // 
            // lbl_Add_New_Employee
            // 
            this.lbl_Add_New_Employee.AutoSize = true;
            this.lbl_Add_New_Employee.BackColor = System.Drawing.Color.White;
            this.lbl_Add_New_Employee.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Employee.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Add_New_Employee.Location = new System.Drawing.Point(457, 22);
            this.lbl_Add_New_Employee.Name = "lbl_Add_New_Employee";
            this.lbl_Add_New_Employee.Size = new System.Drawing.Size(381, 57);
            this.lbl_Add_New_Employee.TabIndex = 1;
            this.lbl_Add_New_Employee.Text = "Add New Employee";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Indigo;
            this.btn_Save.Font = new System.Drawing.Font("High Tower Text", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(309, 668);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(240, 60);
            this.btn_Save.TabIndex = 15;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.Indigo;
            this.btn_Reset.Font = new System.Drawing.Font("High Tower Text", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.White;
            this.btn_Reset.Location = new System.Drawing.Point(758, 668);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(240, 60);
            this.btn_Reset.TabIndex = 16;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // gb_Employee_Details
            // 
            this.gb_Employee_Details.BackColor = System.Drawing.Color.Lavender;
            this.gb_Employee_Details.Controls.Add(this.cmb_Shift_Time);
            this.gb_Employee_Details.Controls.Add(this.tb_Qualification);
            this.gb_Employee_Details.Controls.Add(this.lbl_Qualification);
            this.gb_Employee_Details.Controls.Add(this.tb_Pan_No);
            this.gb_Employee_Details.Controls.Add(this.lbl_PAN_No);
            this.gb_Employee_Details.Controls.Add(this.cmb_Job_Position);
            this.gb_Employee_Details.Controls.Add(this.lbl_Job_Position);
            this.gb_Employee_Details.Controls.Add(this.tb_Address);
            this.gb_Employee_Details.Controls.Add(this.dtp_DOB);
            this.gb_Employee_Details.Controls.Add(this.dtp_Joining);
            this.gb_Employee_Details.Controls.Add(this.tb_Adhaar_No);
            this.gb_Employee_Details.Controls.Add(this.lbl_Adhaar_No);
            this.gb_Employee_Details.Controls.Add(this.lbl_Address);
            this.gb_Employee_Details.Controls.Add(this.tb_Full_Name);
            this.gb_Employee_Details.Controls.Add(this.lbl_Full_Name);
            this.gb_Employee_Details.Controls.Add(this.lbl_DOB);
            this.gb_Employee_Details.Controls.Add(this.lbl_Joining_Date);
            this.gb_Employee_Details.Controls.Add(this.tb_Mobile_No);
            this.gb_Employee_Details.Controls.Add(this.lbl_Mobile_No);
            this.gb_Employee_Details.Controls.Add(this.tb_Alternate_No);
            this.gb_Employee_Details.Controls.Add(this.lbl_Alternate_No);
            this.gb_Employee_Details.Controls.Add(this.lbl_Shift_Time);
            this.gb_Employee_Details.Controls.Add(this.tb_Employee_Id);
            this.gb_Employee_Details.Controls.Add(this.lbl_Employee_Id);
            this.gb_Employee_Details.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Employee_Details.Location = new System.Drawing.Point(53, 126);
            this.gb_Employee_Details.Name = "gb_Employee_Details";
            this.gb_Employee_Details.Size = new System.Drawing.Size(1171, 516);
            this.gb_Employee_Details.TabIndex = 214;
            this.gb_Employee_Details.TabStop = false;
            this.gb_Employee_Details.Text = "Employee Details";
            // 
            // cmb_Shift_Time
            // 
            this.cmb_Shift_Time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Shift_Time.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Shift_Time.FormattingEnabled = true;
            this.cmb_Shift_Time.Items.AddRange(new object[] {
            "Morning",
            "Evening\t",
            "Night"});
            this.cmb_Shift_Time.Location = new System.Drawing.Point(221, 425);
            this.cmb_Shift_Time.Name = "cmb_Shift_Time";
            this.cmb_Shift_Time.Size = new System.Drawing.Size(310, 34);
            this.cmb_Shift_Time.TabIndex = 235;
            // 
            // tb_Qualification
            // 
            this.tb_Qualification.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Qualification.Location = new System.Drawing.Point(787, 362);
            this.tb_Qualification.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_Qualification.Name = "tb_Qualification";
            this.tb_Qualification.Size = new System.Drawing.Size(332, 34);
            this.tb_Qualification.TabIndex = 9;
            // 
            // lbl_Qualification
            // 
            this.lbl_Qualification.AutoSize = true;
            this.lbl_Qualification.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Qualification.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Qualification.Location = new System.Drawing.Point(606, 365);
            this.lbl_Qualification.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Qualification.Name = "lbl_Qualification";
            this.lbl_Qualification.Size = new System.Drawing.Size(137, 27);
            this.lbl_Qualification.TabIndex = 234;
            this.lbl_Qualification.Text = "Qualification";
            // 
            // tb_Pan_No
            // 
            this.tb_Pan_No.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Pan_No.Location = new System.Drawing.Point(221, 218);
            this.tb_Pan_No.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_Pan_No.MaxLength = 10;
            this.tb_Pan_No.Name = "tb_Pan_No";
            this.tb_Pan_No.Size = new System.Drawing.Size(310, 34);
            this.tb_Pan_No.TabIndex = 6;
            // 
            // lbl_PAN_No
            // 
            this.lbl_PAN_No.AutoSize = true;
            this.lbl_PAN_No.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PAN_No.ForeColor = System.Drawing.Color.Navy;
            this.lbl_PAN_No.Location = new System.Drawing.Point(49, 218);
            this.lbl_PAN_No.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PAN_No.Name = "lbl_PAN_No";
            this.lbl_PAN_No.Size = new System.Drawing.Size(99, 27);
            this.lbl_PAN_No.TabIndex = 232;
            this.lbl_PAN_No.Text = "PAN No ";
            // 
            // cmb_Job_Position
            // 
            this.cmb_Job_Position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Job_Position.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Job_Position.FormattingEnabled = true;
            this.cmb_Job_Position.Items.AddRange(new object[] {
            "Worker",
            "Cashier"});
            this.cmb_Job_Position.Location = new System.Drawing.Point(787, 425);
            this.cmb_Job_Position.Name = "cmb_Job_Position";
            this.cmb_Job_Position.Size = new System.Drawing.Size(332, 34);
            this.cmb_Job_Position.TabIndex = 11;
            // 
            // lbl_Job_Position
            // 
            this.lbl_Job_Position.AutoSize = true;
            this.lbl_Job_Position.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Job_Position.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Job_Position.Location = new System.Drawing.Point(606, 428);
            this.lbl_Job_Position.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Job_Position.Name = "lbl_Job_Position";
            this.lbl_Job_Position.Size = new System.Drawing.Size(135, 27);
            this.lbl_Job_Position.TabIndex = 230;
            this.lbl_Job_Position.Text = "Job Position ";
            // 
            // tb_Address
            // 
            this.tb_Address.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.Location = new System.Drawing.Point(787, 154);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(332, 165);
            this.tb_Address.TabIndex = 7;
            this.tb_Address.Text = "";
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Location = new System.Drawing.Point(221, 285);
            this.dtp_DOB.MaxDate = new System.DateTime(2023, 8, 13, 0, 0, 0, 0);
            this.dtp_DOB.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(310, 34);
            this.dtp_DOB.TabIndex = 8;
            this.dtp_DOB.Value = new System.DateTime(2023, 8, 13, 0, 0, 0, 0);
            // 
            // dtp_Joining
            // 
            this.dtp_Joining.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Joining.Location = new System.Drawing.Point(221, 342);
            this.dtp_Joining.MaxDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dtp_Joining.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtp_Joining.Name = "dtp_Joining";
            this.dtp_Joining.Size = new System.Drawing.Size(310, 34);
            this.dtp_Joining.TabIndex = 10;
            this.dtp_Joining.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // tb_Adhaar_No
            // 
            this.tb_Adhaar_No.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Adhaar_No.Location = new System.Drawing.Point(221, 154);
            this.tb_Adhaar_No.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_Adhaar_No.MaxLength = 12;
            this.tb_Adhaar_No.Name = "tb_Adhaar_No";
            this.tb_Adhaar_No.Size = new System.Drawing.Size(310, 34);
            this.tb_Adhaar_No.TabIndex = 5;
            this.tb_Adhaar_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Adhaar_No
            // 
            this.lbl_Adhaar_No.AutoSize = true;
            this.lbl_Adhaar_No.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Adhaar_No.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Adhaar_No.Location = new System.Drawing.Point(49, 154);
            this.lbl_Adhaar_No.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Adhaar_No.Name = "lbl_Adhaar_No";
            this.lbl_Adhaar_No.Size = new System.Drawing.Size(124, 27);
            this.lbl_Adhaar_No.TabIndex = 228;
            this.lbl_Adhaar_No.Text = "Adhaar No ";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Address.Location = new System.Drawing.Point(606, 154);
            this.lbl_Address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(96, 27);
            this.lbl_Address.TabIndex = 227;
            this.lbl_Address.Text = "Address ";
            // 
            // tb_Full_Name
            // 
            this.tb_Full_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Full_Name.Location = new System.Drawing.Point(565, 34);
            this.tb_Full_Name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_Full_Name.Name = "tb_Full_Name";
            this.tb_Full_Name.Size = new System.Drawing.Size(554, 34);
            this.tb_Full_Name.TabIndex = 2;
            this.tb_Full_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // lbl_Full_Name
            // 
            this.lbl_Full_Name.AutoSize = true;
            this.lbl_Full_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Full_Name.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Full_Name.Location = new System.Drawing.Point(432, 37);
            this.lbl_Full_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Full_Name.Name = "lbl_Full_Name";
            this.lbl_Full_Name.Size = new System.Drawing.Size(112, 27);
            this.lbl_Full_Name.TabIndex = 226;
            this.lbl_Full_Name.Text = "Full Name";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.ForeColor = System.Drawing.Color.Navy;
            this.lbl_DOB.Location = new System.Drawing.Point(49, 285);
            this.lbl_DOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(68, 27);
            this.lbl_DOB.TabIndex = 225;
            this.lbl_DOB.Text = "DOB ";
            // 
            // lbl_Joining_Date
            // 
            this.lbl_Joining_Date.AutoSize = true;
            this.lbl_Joining_Date.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Joining_Date.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Joining_Date.Location = new System.Drawing.Point(49, 345);
            this.lbl_Joining_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Joining_Date.Name = "lbl_Joining_Date";
            this.lbl_Joining_Date.Size = new System.Drawing.Size(132, 27);
            this.lbl_Joining_Date.TabIndex = 224;
            this.lbl_Joining_Date.Text = "Joining Date";
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(221, 93);
            this.tb_Mobile_No.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(310, 34);
            this.tb_Mobile_No.TabIndex = 3;
            this.tb_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(49, 93);
            this.lbl_Mobile_No.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(121, 27);
            this.lbl_Mobile_No.TabIndex = 223;
            this.lbl_Mobile_No.Text = "Mobile No ";
            // 
            // tb_Alternate_No
            // 
            this.tb_Alternate_No.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Alternate_No.Location = new System.Drawing.Point(787, 96);
            this.tb_Alternate_No.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_Alternate_No.MaxLength = 10;
            this.tb_Alternate_No.Name = "tb_Alternate_No";
            this.tb_Alternate_No.Size = new System.Drawing.Size(332, 34);
            this.tb_Alternate_No.TabIndex = 4;
            this.tb_Alternate_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Alternate_No
            // 
            this.lbl_Alternate_No.AutoSize = true;
            this.lbl_Alternate_No.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Alternate_No.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Alternate_No.Location = new System.Drawing.Point(606, 99);
            this.lbl_Alternate_No.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Alternate_No.Name = "lbl_Alternate_No";
            this.lbl_Alternate_No.Size = new System.Drawing.Size(143, 27);
            this.lbl_Alternate_No.TabIndex = 222;
            this.lbl_Alternate_No.Text = "Alternate No ";
            // 
            // lbl_Shift_Time
            // 
            this.lbl_Shift_Time.AutoSize = true;
            this.lbl_Shift_Time.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Shift_Time.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Shift_Time.Location = new System.Drawing.Point(49, 425);
            this.lbl_Shift_Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Shift_Time.Name = "lbl_Shift_Time";
            this.lbl_Shift_Time.Size = new System.Drawing.Size(117, 27);
            this.lbl_Shift_Time.TabIndex = 221;
            this.lbl_Shift_Time.Text = "Shift Time ";
            // 
            // tb_Employee_Id
            // 
            this.tb_Employee_Id.Enabled = false;
            this.tb_Employee_Id.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Employee_Id.Location = new System.Drawing.Point(221, 34);
            this.tb_Employee_Id.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_Employee_Id.Name = "tb_Employee_Id";
            this.tb_Employee_Id.Size = new System.Drawing.Size(155, 34);
            this.tb_Employee_Id.TabIndex = 1;
            // 
            // lbl_Employee_Id
            // 
            this.lbl_Employee_Id.AutoSize = true;
            this.lbl_Employee_Id.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Id.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Employee_Id.Location = new System.Drawing.Point(49, 37);
            this.lbl_Employee_Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Employee_Id.Name = "lbl_Employee_Id";
            this.lbl_Employee_Id.Size = new System.Drawing.Size(141, 27);
            this.lbl_Employee_Id.TabIndex = 220;
            this.lbl_Employee_Id.Text = "Employee Id ";
            // 
            // frm_Add_New_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.gb_Employee_Details);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.pnl_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_New_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Employee";
            this.Load += new System.EventHandler(this.frm_Add_New_Employee_Load);
            this.pnl_1.ResumeLayout(false);
            this.pnl_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logout_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Back_Button)).EndInit();
            this.gb_Employee_Details.ResumeLayout(false);
            this.gb_Employee_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_1;
        private System.Windows.Forms.Label lbl_Add_New_Employee;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.GroupBox gb_Employee_Details;
        private System.Windows.Forms.TextBox tb_Qualification;
        private System.Windows.Forms.Label lbl_Qualification;
        private System.Windows.Forms.TextBox tb_Pan_No;
        private System.Windows.Forms.Label lbl_PAN_No;
        private System.Windows.Forms.ComboBox cmb_Job_Position;
        private System.Windows.Forms.Label lbl_Job_Position;
        private System.Windows.Forms.RichTextBox tb_Address;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.DateTimePicker dtp_Joining;
        private System.Windows.Forms.TextBox tb_Adhaar_No;
        private System.Windows.Forms.Label lbl_Adhaar_No;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox tb_Full_Name;
        private System.Windows.Forms.Label lbl_Full_Name;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Joining_Date;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.TextBox tb_Alternate_No;
        private System.Windows.Forms.Label lbl_Alternate_No;
        private System.Windows.Forms.Label lbl_Shift_Time;
        private System.Windows.Forms.TextBox tb_Employee_Id;
        private System.Windows.Forms.Label lbl_Employee_Id;
        private System.Windows.Forms.PictureBox pb_Logout_Button;
        private System.Windows.Forms.PictureBox pb_Back_Button;
        private System.Windows.Forms.ComboBox cmb_Shift_Time;
    }
}