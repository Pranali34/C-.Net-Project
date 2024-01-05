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
    public partial class frm_Product_Control : Form
    {
        public frm_Product_Control()
        {
            InitializeComponent();
        }

        private void btn_Add_Book_Click(object sender, EventArgs e)
        {
            Forms.Product_Forms.frm_Add_New_Book obj = new Product_Forms.frm_Add_New_Book();
            obj.Show();
            this.Hide();
        }

        private void btn_Update_Book_Click(object sender, EventArgs e)
        {
            Forms.Product_Forms.frm_Update_Book_Details obj = new Product_Forms.frm_Update_Book_Details();
            obj.Show();
            this.Hide();
        }

        private void btn_View_Book_List_Click(object sender, EventArgs e)
        {
            Forms.Product_Forms.frm_View_Book_List obj = new Product_Forms.frm_View_Book_List();
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
