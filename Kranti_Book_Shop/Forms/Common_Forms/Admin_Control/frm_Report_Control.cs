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

namespace Kranti_Book_Shop.Forms.Common_Forms.Admin_Control
{
    public partial class frm_Report_Control : Form
    {
        public frm_Report_Control()
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

        private void btn_Customer_Report_Click(object sender, EventArgs e)
        {
            Reports.View_Customer_Bill obj = new Reports.View_Customer_Bill();

            Customer_Bill obj1 = new Customer_Bill();

            obj.crv_Customer_Bill.ReportSource = obj1;
            obj.Show();
        }

        private void btn_Book_Report_Click(object sender, EventArgs e)
        {
            Reports.View_Book_Details obj = new Reports.View_Book_Details();

            Book_Details obj1 = new Book_Details();

            obj.crv_Book_Details.ReportSource = obj1;
            obj.Show();
        }

        private void pb_Back_Button_Click(object sender, EventArgs e)
        {
            Forms.Common_Forms.frm_Admin_Control obj = new frm_Admin_Control();
            obj.Show();
            this.Hide();
        }

        private void pb_Logout_Button_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
        }
    }
}
