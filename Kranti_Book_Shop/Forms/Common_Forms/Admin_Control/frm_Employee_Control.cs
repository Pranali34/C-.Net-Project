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
    public partial class frm_Employee_Control : Form
    {
        public frm_Employee_Control()
        {
            InitializeComponent();
        }

        private void btn_Add_Employee_Click(object sender, EventArgs e)
        {
            Forms.Employee.frm_Add_New_Employee obj = new Employee.frm_Add_New_Employee();
            obj.Show();
            this.Hide();
        }

        private void btn_Update_Employee_Click(object sender, EventArgs e)
        {
            Forms.Employee.frm_Update_Employee obj = new Employee.frm_Update_Employee();
            obj.Show();
            this.Hide();
        }

        private void btn_View_Employee_List_Click(object sender, EventArgs e)
        {
            Forms.Employee.frm_View_Employee obj = new Employee.frm_View_Employee();
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
