using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work_with_db
{

    public partial class Form2 : Form
    {
        public string load  { get; set; }
        THONGTINNHANVIEN infor = new THONGTINNHANVIEN();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            QuanLyNhanVienEntities1 db2 = new QuanLyNhanVienEntities1();
            try
            {
                if (textBoxManv.Text != "" &&
                    textBoxTennv.Text != "" &&
                    textBoxDiachi.Text != ""
)
                {
                infor.Manv = textBoxManv.Text;
                infor.Tennv = textBoxTennv.Text;
                infor.Diachi = textBoxDiachi.Text;
                db2.THONGTINNHANVIENs.Add(infor);
                db2.SaveChanges();
                MessageBox.Show("Add Success !");

                }
                else
                {
                    MessageBox.Show("Missing data !");
                }

            }
            catch (Exception ex)
                {MessageBox.Show(ex.Message);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxManv.Text = "";
            textBoxTennv.Text = "";
            textBoxDiachi.Text = "";
            textBoxManv.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            (this.Owner as Form1).reloadData();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
