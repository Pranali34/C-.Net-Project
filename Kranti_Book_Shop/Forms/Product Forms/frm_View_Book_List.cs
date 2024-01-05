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
    public partial class frm_View_Book_List : Form
    {
        public frm_View_Book_List()
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

        private void frm_View_Book_List_Load(object sender, EventArgs e)
        {
            Con_Open();

            SqlDataAdapter da = new SqlDataAdapter("Select * from Book_Details ", Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_Book_List.DataSource = dt;

            Con_Close();
        }
    }
}
