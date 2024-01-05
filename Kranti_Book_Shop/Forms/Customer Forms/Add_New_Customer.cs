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

namespace Kranti_Book_Shop.Forms.Customer_Forms
{
    public partial class Add_New_Customer : Form
    {
        Double Tot_Bill;
        public Add_New_Customer()
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
            Cmd.CommandText = "Select Count(*) from Customer_Personal_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Customer_ID) from Customer_Personal_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                Cnt = Cnt + 1;
            }
            else
            {
                Cnt = 1001;
            }

            tb_Customer_Id.Text = Convert.ToString(Cnt);

            Con_Close();
        }
        void Clear_Controls()
        {
            tb_Customer_Id.Clear();
            tb_Mob_No.Clear();
            tb_Full_Name.Clear();
            cmb_Book_Name.SelectedIndex = -1;
            tb_Price.Text = "0";
            tb_Qty.Text = "0";
            tb_Total_Bill.Clear();

            Auto_Incr();
        }
         
        private void Add_New_Customer_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_Customer_Id.Text != "" && cmb_Book_Name.Text != "" && tb_Price.Text != "" && tb_Qty.Text != "" && tb_Total_Price.Text != "")
            {
                String Query = "Insert into Customer_Purchase_Details( Customer_ID, Book_Name, Price, Qty,Total_Price, Total_Bill ) " +
                    "Values('" + tb_Customer_Id.Text + "','" + cmb_Book_Name.Text + "','" + tb_Price.Text + "','" + tb_Qty.Text + "','" + tb_Total_Price.Text + "','" + tb_Total_Bill.Text + "')";

                SqlCommand Cmd = new SqlCommand(Query,Con);

                Tot_Bill = Convert.ToDouble(Tot_Bill) +  Convert.ToDouble(tb_Total_Price.Text);
                tb_Total_Bill.Text = Convert.ToString(Tot_Bill);

                Cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter("select * from Customer_Purchase_Details", Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_View_Added_Product_List.DataSource = dt;

                cmb_Book_Name.SelectedIndex = -1;
                tb_Qty.Clear();
                tb_Price.Clear();
                tb_Total_Price.Clear();

            }

            Con_Close();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(dgv_View_Added_Product_List.Rows.Count > 0)
            {
                string Query = "insert Into Customer_Personal_Details (Customer_ID, Bill_Date, Mob_No, Full_Name) Values('"+ tb_Customer_Id.Text + "','" + dtp_Bill_Date.Text + "','" + tb_Mob_No.Text + "','" + tb_Full_Name.Text + "')";
                ////string Query1 = "insert Into Customer_Purchase_Details Values('" + tb_Customer_Id.Text + "','" + cmb_Book_Name.Text + "','" + tb_Price.Text + "','" + tb_Qty.Text + "','" + tb_Total_Bill.Text + "')";

                SqlCommand cmd = new SqlCommand(Query,Con);
                ///SqlCommand cmd1 = new SqlCommand(Query1, Con);

                cmd.ExecuteNonQuery();
                //cmd1.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Clear_Controls();
                dgv_View_Added_Product_List.DataSource = null;
            }
            else
            {
                MessageBox.Show("First Fill All Fields", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Con_Close();
        }
        private void pb_Back_Button_Click(object sender, EventArgs e)
        {
            if (Common_Content.Log_UName == "Admin")
            {
                Forms.Common_Forms.Admin_Control.frm_Customer_Control obj = new Common_Forms.Admin_Control.frm_Customer_Control();
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

        private void tb_Qty_TextChanged(object sender, EventArgs e)
        {
            if(tb_Qty.Text != "")
            {
                Double Ans = Convert.ToDouble(tb_Qty.Text) * Convert.ToDouble(tb_Price.Text);
                tb_Total_Price.Text = Convert.ToString(Ans);
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Clear_Controls();

        }




        //private void cmb_Book_Name_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Con_Open();

        //    //cmb_Book_Name.Items.Clear();

        //    String Query = "Select Distinct (Book_Name) from Book_Details";

        //    SqlCommand cmd = new SqlCommand(Query,Con);

        //    SqlDataReader Dr = cmd.ExecuteReader();

        //    while(Dr.Read())
        //    {
        //        cmb_Book_Name.Items.Add(Dr.GetString(Dr.GetOrdinal("Book_Name")));
        //    }

        //    Con_Close();
        //}
    }
}
