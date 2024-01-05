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

namespace Kranti_Book_Shop
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        private void frm_Login_Load(object sender, EventArgs e)
        {
            lbl_Error.Text = "Enter Valid Username && Password !!";
            lbl_Error.Visible = true;
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {

            if (cmb_Username.Text == "Admin" && tb_Password.Text == "123")
            {
                MessageBox.Show("Login Successful !!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Common_Content.Log_UName  = cmb_Username.Text;

                Forms.Common_Forms.frm_Admin_Control Obj = new Forms.Common_Forms.frm_Admin_Control();
                Obj.Show();
                this.Hide();
            }
            else if (cmb_Username.Text == "User" && tb_Password.Text == "e123")
            {
                MessageBox.Show("Login Successful !!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Common_Content.Log_UName = cmb_Username.Text;

                Forms.Common_Forms.frm_User_Control Obj = new Forms.Common_Forms.frm_User_Control();
                Obj.Show();
                this.Hide();
            }
            else
            {
                lbl_Error.Text = "Incorrect Username && Paasword";
                lbl_Error.ForeColor = Color.Red;
            }

            cmb_Username.SelectedIndex = -1;
            tb_Password.Clear();
            cmb_Username.Focus();
        }
    }
}

