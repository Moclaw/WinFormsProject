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
    public partial class Form3 : Form
    {
        //QuanLyNhanVienEntities1 db = new QuanLyNhanVienEntities1();
        public int id { get; set; }
        public string tennv { get; set; }
        public string manv { get; set; }
        public string diachi { get; set; }
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var obj = (this.Owner as Form1).db.THONGTINNHANVIENs.Where(alias => alias.ID.Equals(id)).FirstOrDefault();
            obj.Tennv = textTennv.Text ;
            obj.Manv = textManv.Text ;
            obj.Diachi = textDiachi.Text;
            (this.Owner as Form1).db.SaveChanges();
            (this.Owner as Form1).reloadData();
            MessageBox.Show("Update Success !");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textManv.Text = manv;
            textTennv.Text = tennv;
            textDiachi.Text = diachi;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textManv.Text = manv;
            textTennv.Text = tennv;
            textDiachi.Text = diachi;
        }
    }
}
