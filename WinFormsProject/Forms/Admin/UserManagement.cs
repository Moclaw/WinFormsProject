using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsProject.Forms.Admin.Dialog;
using WinFormsProject.Models;

namespace WinFormsProject.Forms
{
    public partial class UserManagement : Form
    {
        WpfprojectContext context = new WpfprojectContext();
        public UserManagement()
        {
            int index = 0;
            InitializeComponent();
            foreach (var user in context.Wfusers)
            {
                index++;
                string status_string = user.Status ? "Lock" : "Active";
                listView1.BorderStyle = BorderStyle.Fixed3D;
                listView1.Items.Add(new ListViewItem(new string[] { index.ToString(), user.UserName, status_string }));
            }
        }
        private void Add(string name, bool status = false)
        {


        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            new AddUser().Show();
        }
    }
}
