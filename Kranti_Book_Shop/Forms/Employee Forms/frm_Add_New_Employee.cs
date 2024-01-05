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
    public partial class frm_Add_New_Employee : Form
    {
        public frm_Add_New_Employee()
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

        void Auto_Incr()
        {
            Con_Open();

            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) from Employee_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Employee_ID) from Employee_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                Cnt = Cnt + 1;
            }
            else
            {
                Cnt = 101;
            }

            tb_Employee_Id.Text = Convert.ToString(Cnt);

            Con_Close();
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

            Auto_Incr();
        }
        private void frm_Add_New_Employee_Load(object sender, EventArgs e)
        {
            Clear_Controls();
            tb_Full_Name.Focus();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_Employee_Id.Text != "" && tb_Full_Name.Text != "" && tb_Mobile_No.Text != "" && tb_Alternate_No.Text != "" && tb_Adhaar_No.Text != "" && tb_Address.Text != "" && tb_Pan_No.Text != "" && dtp_DOB.Text != "" && tb_Qualification.Text != "" && dtp_Joining.Text != "" && cmb_Job_Position.Text != "" && cmb_Shift_Time.Text != "")
            { 
                    SqlCommand Cmd = new SqlCommand();

                    Cmd.Connection = Con;
                    Cmd.CommandText = "Insert Into Employee_Details Values(@EmpId,@FNm,@MobNo,@AltNo,@Adhaar,@Address,@PAN,@Dob,@Qualification,@Joning_Date,@JobP,@Shift)";

                    Cmd.Parameters.Add("EmpId", SqlDbType.Int).Value = tb_Employee_Id.Text;
                    Cmd.Parameters.Add("FNm", SqlDbType.NVarChar).Value = tb_Full_Name.Text;
                    Cmd.Parameters.Add("MobNo", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                    Cmd.Parameters.Add("AltNo", SqlDbType.Decimal).Value = tb_Alternate_No.Text;
                    Cmd.Parameters.Add("Adhaar", SqlDbType.Decimal).Value = tb_Adhaar_No.Text;
                    Cmd.Parameters.Add("Address", SqlDbType.NVarChar).Value = tb_Address.Text;
                    Cmd.Parameters.Add("PAN", SqlDbType.NVarChar).Value = tb_Pan_No.Text;
                    Cmd.Parameters.Add("Dob", SqlDbType.Date).Value = dtp_DOB.Text;
                    Cmd.Parameters.Add("Qualification", SqlDbType.NVarChar).Value = tb_Qualification.Text;
                    Cmd.Parameters.Add("Joning_Date", SqlDbType.Date).Value = dtp_Joining.Text;
                    Cmd.Parameters.Add("JobP", SqlDbType.NVarChar).Value = cmb_Job_Position.Text;
                    Cmd.Parameters.Add("Shift", SqlDbType.NVarChar).Value = cmb_Shift_Time.Text;

                Cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Inserted Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("First Fill All Fields", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Con_Close();
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {

            Clear_Controls();
            tb_Full_Name.Focus();
        }
        private void pb_Back_Button_Click(object sender, EventArgs e)
        {
             if(Common_Content.Log_UName == "Admin")
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
