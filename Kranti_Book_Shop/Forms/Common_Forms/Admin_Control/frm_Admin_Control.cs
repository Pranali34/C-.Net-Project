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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Kranti_Book_Shop.Forms.Common_Forms
{
    public partial class frm_Admin_Control : Form
    {
        public frm_Admin_Control()
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
        private void pb_Logout_Button_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            Forms.Common_Forms.Admin_Control.frm_Customer_Control obj = new Admin_Control.frm_Customer_Control();
            obj.Show();
            this.Hide();
        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            Forms.Common_Forms.Admin_Control.frm_Employee_Control obj = new Admin_Control.frm_Employee_Control();
            obj.Show();
            this.Hide();
        }

        private void btn_Book_Click(object sender, EventArgs e)
        {
            Forms.Common_Forms.Admin_Control.frm_Product_Control obj = new Admin_Control.frm_Product_Control();
            obj.Show();
            this.Hide();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            Forms.Common_Forms.Admin_Control.frm_Report_Control obj = new Admin_Control.frm_Report_Control();
            obj.Show();
            this.Hide();
        }
    }
}
