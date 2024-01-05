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
    public partial class frm_View_Customer_List : Form
    {
        public frm_View_Customer_List()
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

        private void frm_View_Customer_List_Load(object sender, EventArgs e)
        {
            Con_Open();

            SqlDataAdapter da = new SqlDataAdapter("Select * from Customer_Personal_Details", Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_Customer_Personal_List.DataSource = dt;

            Con_Close();

        }
        private void dgv_Customer_Personal_List_MouseClick(object sender, MouseEventArgs e)
        {
            Con_Open();

            SqlDataAdapter da = new SqlDataAdapter("Select * from Customer_Purchase_Details where Customer_ID = '"+ dgv_Customer_Personal_List.SelectedRows[0].Cells["Customer_ID"].Value.ToString() +"'", Con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgv_Customer_Purchase_List.DataSource = dt;

            Con_Close();

        }

        private void dgv_Customer_Personal_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
