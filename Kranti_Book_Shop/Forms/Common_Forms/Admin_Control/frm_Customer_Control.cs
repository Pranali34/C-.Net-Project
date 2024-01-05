using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kranti_Book_Shop.Forms.Common_Forms.Admin_Control
{
    public partial class frm_Customer_Control : Form
    {
        public frm_Customer_Control()
        {
            InitializeComponent();
        }

        private void btn_Add_Customer_Click(object sender, EventArgs e)
        {
            Forms.Customer_Forms.Add_New_Customer obj = new Customer_Forms.Add_New_Customer();
            obj.Show();
            this.Hide();
        }

        private void btn_View_Book_List_Click(object sender, EventArgs e)
        {
            Forms.Customer_Forms.frm_View_Customer_List obj = new Customer_Forms.frm_View_Customer_List();
            obj.Show();
            this.Hide();
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
