using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using WinFormsProject.Forms;
using WinFormsProject.Models;

namespace WinFormsProject
{

    public partial class Login : Form
    {
        public WpfprojectContext context = new WpfprojectContext();
        public Login()
        {
            InitializeComponent();
            txtUsername.Focus();
        }

        #region Method
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();

        }


        #endregion

        #region Events

        protected void HandleLogin(string username, string password)
        {
            var user =  from c in context.Wfusers select c;
            if (!string.IsNullOrEmpty(txtUsername.Text))
            {
                foreach (var item in user)
                {
                    if (txtUsername.Text != item.UserName && txtPassword.Text != item.Password)
                    {
                        MessageBox.Show("Check input");
                    }
                    else
                    {
                        new Home().Show();
                        this.Hide();
                        break;
                    }
                }
            }

        }        

        #endregion
    }
}
