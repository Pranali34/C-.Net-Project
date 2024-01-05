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
    public partial class frm_Add_New_Book : Form
    {
        public frm_Add_New_Book()
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
            Cmd.CommandText = "Select Count(*) from Book_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Book_ID) from Book_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                Cnt = Cnt + 1;
            }
            else
            {
                Cnt = 1;
            }

            tb_Book_Id.Text = Convert.ToString(Cnt);

            Con_Close();
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

            Auto_Incr();
        }
        private void frm_Add_New_Book_Load(object sender, EventArgs e)
        {
            Clear_Controls();
            tb_Author.Focus();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if ( tb_Book_Id.Text != "" && tb_Author.Text != "" && tb_Book_Name.Text != "" && cmb_Genre.Text != "" && cmb_Supplier.Text != "" && tb_Purchase_Price.Text != "" && tb_Selling_Price.Text != "")
            {
                string Query = "Insert Into Book_Details (Author, Book_Name, Genre, Supplier, Purchase_Price, Selling_Price, Book_Note) " +
                    "Values('" + tb_Author.Text + "','" + tb_Book_Name.Text + "','" + cmb_Genre.Text + "','" + cmb_Supplier.Text + "','" + tb_Purchase_Price.Text + "','" + tb_Selling_Price.Text + "','" + tb_Book_Note.Text + "')";


                SqlCommand Cmd = new SqlCommand(Query, Con);

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
            tb_Author.Focus();
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
