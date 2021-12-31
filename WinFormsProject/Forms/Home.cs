using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace WinFormsProject.Forms
{
    public partial class Home : Form
    {
        private Form _childForm;
        private IconButton _iconbutton;
        private int mov;
        private int movX;
        private int movY;

        public Home()
        {
            InitializeComponent();
            CustomDesign();
        }

        #region Events
        private void CustomDesign()
        {
            panelAdmin.Visible = false;
            panelDashboard.Visible = false;
            panelMedia.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panelAdmin.Visible == true)
                panelAdmin.Visible = false;
            if (panelDashboard.Visible == true)
                panelDashboard.Visible = false;
            if (panelMedia.Visible == true)
                panelMedia.Visible = false;
        }

        private void ShowSubMenu(Panel subPanel)
        {
            if (subPanel.Visible == false)
            {
                HideSubMenu();
                subPanel.Visible = true;
            }
            else
            {
                subPanel.Visible = true;
            }
        }

        private void OpenChildForm(Form form)
        {
            if (_iconbutton != null)
            {
                _childForm.Close();
            }

            _childForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelDisplay.Controls.Add(form);
            panelDisplay.Tag = form;
            form.BringToFront();
            form.Show();
        }
        #endregion

        #region Method
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelDashboard);
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelMedia);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelAdmin);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new UserManagement());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
          
        }
        private void Home_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[0].WorkingArea.Location;
            this.StartPosition = FormStartPosition.CenterParent;
        }
        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        private void panelDestop_MouseMove(object sender, MouseEventArgs e)
        {

            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }


        private void panelDestop_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        #endregion

    }
}
