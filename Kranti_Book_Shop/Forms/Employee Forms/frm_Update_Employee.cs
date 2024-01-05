using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kranti_Book_Shop.Forms.Employee
{
    public partial class frm_Update_Employee : Form
    {
        public frm_Update_Employee()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Mini_Kranti_Book_Shop;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }
        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        void Clear_Controls()
        {
            tb_Employee_Id.Clear();
            tb_Full_Name.Clear();
            tb_Mobile_No.Clear();
            tb_Alternate_No.Clear();
            tb_Adhaar_No.Clear();
            tb_Pan_No.Clear();
            tb_Address.Clear();
            tb_Qualification.Clear();
            cmb_Shift_Time.SelectedIndex = -1;
            cmb_Job_Position.SelectedIndex = -1;

        }
        void Enable_Controls()
        {
            tb_Employee_Id.Enabled = false;
            tb_Full_Name.Enabled = true;
            tb_Mobile_No.Enabled = true;
            tb_Alternate_No.Enabled = true;
            tb_Adhaar_No.Enabled = true;
            tb_Pan_No.Enabled = true;
            tb_Address.Enabled = true;
            tb_Qualification.Enabled = true;
            cmb_Shift_Time.Enabled = true;
            cmb_Job_Position.Enabled = true;
        }
        void Disable_Controls()
        {
            tb_Employee_Id.Enabled = true;
            tb_Full_Name.Enabled = false; ;
            tb_Mobile_No.Enabled = false; ;
            tb_Alternate_No.Enabled = false; ;
            tb_Adhaar_No.Enabled = false; ;
            tb_Pan_No.Enabled = false; ;
            tb_Address.Enabled = false; ;
            tb_Qualification.Enabled = false; ;
            cmb_Shift_Time.Enabled = false; ;
            cmb_Job_Position.Enabled = false; ;
        }
        private void frm_Update_Employee_Load(object sender, EventArgs e)
        {
            Disable_Controls();
            tb_Employee_Id.Focus();
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Employee_Id.Text != "")
            {

                string Query = "Select * from Employee_Details where Employee_Id = '" + tb_Employee_Id.Text + "'";

                SqlCommand Cmd = new SqlCommand(Query, Con);

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_Full_Name.Text = Dr.GetString(Dr.GetOrdinal("Full_Name"));
                    tb_Mobile_No.Text = (Dr["Mobile_No"].ToString());
                    tb_Alternate_No.Text = (Dr["Alternate_No"].ToString());
                    tb_Adhaar_No.Text = (Dr["Adhaar_No"].ToString());
                    tb_Pan_No.Text = Dr.GetString(Dr.GetOrdinal("PAN_No"));
                    tb_Address.Text = Dr.GetString(Dr.GetOrdinal("Address"));
                    dtp_DOB.Text = (Dr["DOB"].ToString());
                    tb_Qualification.Text = Dr.GetString(Dr.GetOrdinal("Qualification"));
                    dtp_Joining.Text = (Dr["Joining_Date"].ToString());
                    cmb_Job_Position.Text = (Dr["Job_Position"].ToString());
                    cmb_Shift_Time.Text = (Dr["Shift_Time"].ToString());

                    Enable_Controls();
                }
                else
                {
                    MessageBox.Show("No Student Found With Given Data", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb_Employee_Id.Clear();
                    tb_Employee_Id.Focus();
                }

            }

            Con_Close();
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();


            if (tb_Employee_Id.Text != "" && tb_Full_Name.Text != "" && tb_Mobile_No.Text != "" && tb_Alternate_No.Text != "" && tb_Adhaar_No.Text != "" && tb_Address.Text != "" && tb_Pan_No.Text != "" && dtp_DOB.Text != "" && tb_Qualification.Text != "" && dtp_Joining.Text != "" && cmb_Job_Position.Text != "" && cmb_Shift_Time.Text != "")
            {

                string Query = "Update Employee_Details Set   Full_Name = '" + tb_Full_Name.Text + "', Mobile_No = '" + tb_Mobile_No.Text + "', Alternate_No = '" + tb_Alternate_No.Text + "', Adhaar_No = '" + tb_Adhaar_No.Text + "', PAN_No = '" + tb_Pan_No.Text + "',Address ='" + tb_Address.Text + "', DOB = '" + dtp_DOB.Text + "', Qualification = '" + tb_Qualification.Text + "', Joining_Date = '" + dtp_Joining.Text + "', Job_Position = '" + cmb_Job_Position.Text + "', Shift_Time = '" + cmb_Shift_Time.Text + "' Where Employee_Id = '" + tb_Employee_Id.Text + "' ";

                SqlCommand Cmd = new SqlCommand(Query, Con);

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Clear_Controls();
                Disable_Controls();
                tb_Employee_Id.Focus();
            }
            else
            {
                MessageBox.Show("First Fill All Fields", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            Disable_Controls();
            tb_Employee_Id.Focus();
        }
        private void pb_Back_Button_Click(object sender, EventArgs e)
        {
            if (Common_Content.Log_UName == "Admin")
            {
                Forms.Common_Forms.Admin_Control.frm_Employee_Control obj = new Common_Forms.Admin_Control.frm_Employee_Control();
                obj.Show();
                this.Hide();
            }
            else
            {
                Forms.Common_Forms.frm_User_Control obj = new Common_Forms.frm_User_Control();
                obj.Show();
                this.Hide();
            }
        }

        private void pb_Logout_Button_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
        }
    }
}
