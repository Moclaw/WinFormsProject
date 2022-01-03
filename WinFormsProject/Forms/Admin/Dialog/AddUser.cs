using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinFormsProject.Models;

namespace WinFormsProject.Forms.Admin.Dialog
{
    public partial class AddUser : Form
    {
        WpfprojectContext context = new WpfprojectContext();
        public AddUser()
        {
            InitializeComponent();
        }
        public void HandleUser(string username, string password, string repassword)
        {
            int count = 0;
            var accountcount = context.Wfusers.Count();
            if (password.Equals(repassword))
            {
                foreach (var item in context.Wfusers)
                {
                    count += 1;
                    if (username != item.UserName)
                    {
                        Wfuser wfuser = new Wfuser()
                        {
                            UserName = username,
                            Password = password,
                            BirthDay = DateTime.Now,
                            CreateTime = DateTime.Now,
                            FisrtName = "",
                            LastName = "",
                            Gender = true,
                            Status = false,
                            RoleId = 2,
                        };
                        using (var context = new WpfprojectContext())
                        {
                            context.Wfusers.Add(wfuser);
                            context.SaveChanges();
                        }
                        MessageBox.Show("Done!");
                    }
                    else
                    {
                        MessageBox.Show("User already exits!");
                        if (count == accountcount)
                        {
                            MessageBox.Show("Invaild username or passdword");
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Confirm password incorrect");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HandleUser(txtUser.Text, txtPassword.Text, txtpassword2.Text);
        }
    }
}
