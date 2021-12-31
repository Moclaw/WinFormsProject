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


        #region Events

        protected void HandleLogin(string username, string password)
        {
            var user =  from c in context.Wfusers select c;
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                foreach (var item in user)
                {
                    if (txtUsername.Text.Equals(item.UserName)  && txtPassword.Text.Equals(item.Password))
                    {
                        new Home().Show();
                        this.Hide();
                        break;
                      
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password");
                        break;
                    }
                }
            }
            else if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Username empty");
            }
            else if(string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Password empty");
            }

        }


        #endregion


        #region Method
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckEnterKeyPressPasword(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)

            {
                txtPassword.Focus();
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();

        }
        private void linkForgotPwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ForgotPassword().ShowDialog();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            HandleLogin(txtUsername.Text, txtPassword.Text);
        }
        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
