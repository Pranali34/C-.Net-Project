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

namespace Kranti_Book_Shop.Forms.Product_Forms
{
    public partial class frm_Update_Book_Details : Form
    {
        public frm_Update_Book_Details()
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
            tb_Book_Id.Clear();
            tb_Author.Clear();
            tb_Book_Name.Clear();
            cmb_Genre.SelectedIndex = -1;
            cmb_Supplier.SelectedIndex = -1;
            tb_Purchase_Price.Clear();
            tb_Selling_Price.Clear();
            tb_Book_Note.Clear();
        }
        void Enable_Controls()
        {
            tb_Book_Id.Enabled = false;
            tb_Author.Enabled = true;
            tb_Book_Name.Enabled = true;
            cmb_Genre.Enabled = true;
            cmb_Supplier.Enabled = true;
            tb_Purchase_Price.Enabled = true;
            tb_Selling_Price.Enabled = true;
            tb_Book_Note.Enabled = true;
        }
        void Disable_Controls()
        {
            tb_Book_Id.Enabled = true;
            tb_Author.Enabled = false;
            tb_Book_Name.Enabled = false;
            cmb_Genre.Enabled = false;
            cmb_Supplier.Enabled = false;
            tb_Purchase_Price.Enabled = false;
            tb_Selling_Price.Enabled = false;
            tb_Book_Note.Enabled = false;
        }
        private void frm_Update_Book_Details_Load(object sender, EventArgs e)
        {
            Disable_Controls();
            tb_Book_Id.Focus();
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Book_Id.Text != "")
            {
               
               string Query = "Select * from Book_Details where Book_ID = '"+ tb_Book_Id.Text +"'";

                SqlCommand Cmd = new SqlCommand(Query,Con);

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_Author.Text = Dr.GetString(Dr.GetOrdinal("Author"));
                    tb_Book_Name.Text = Dr.GetString(Dr.GetOrdinal("Book_Name"));
                    cmb_Genre.Text = Dr.GetString(Dr.GetOrdinal("Genre"));
                    cmb_Supplier.Text = Dr.GetString(Dr.GetOrdinal("Supplier"));
                    tb_Purchase_Price.Text = (Dr["Purchase_Price"].ToString());
                    tb_Selling_Price.Text = (Dr["Selling_Price"].ToString());
                    tb_Book_Note.Text = Dr.GetString(Dr.GetOrdinal("Book_Note"));


                    Enable_Controls();
                }
                else
                {
                    MessageBox.Show("No Student Found With Given Data", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb_Book_Id.Clear();
                    tb_Book_Id.Focus();
                }

            }

            Con_Close();
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();


            if (tb_Book_Id.Text != "" && tb_Author.Text != "" && tb_Book_Name.Text != "" && cmb_Genre.Text != "" && cmb_Supplier.Text != "" && tb_Purchase_Price.Text != "" && tb_Selling_Price.Text != "")
            {

                string Query = "Update Book_Details Set  Author = '" + tb_Author.Text + "', Book_Name = '" + tb_Book_Name.Text + "', Genre = '" + cmb_Genre.Text + "', Supplier = '" + cmb_Supplier.Text + "', Purchase_Price = '" + tb_Purchase_Price.Text + "', Selling_Price ='" + tb_Selling_Price.Text + "', Book_Note = '" + tb_Book_Note.Text + "' Where Book_ID = '"+ tb_Book_Id.Text +"' ";                                                                       

                SqlCommand Cmd = new SqlCommand(Query, Con);

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Clear_Controls();
                Disable_Controls();
                tb_Book_Id.Focus();
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
            tb_Book_Id.Focus();
        }
        private void pb_Back_Button_Click(object sender, EventArgs e)
        {
            if (Common_Content.Log_UName == "Admin")
            {
                Forms.Common_Forms.Admin_Control.frm_Product_Control obj = new Common_Forms.Admin_Control.frm_Product_Control();
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
