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
    public partial class Form1 : Form
    {
        public QuanLyNhanVienEntities1 db = new QuanLyNhanVienEntities1();
        public Form1()
        {
            InitializeComponent();
        }
        public void reloadData()
        {
            gridNhanVien.DataSource = db.THONGTINNHANVIENs.ToList();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            reloadData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridNhanVien.AutoGenerateColumns = false;
            reloadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxManv.Text = string.Empty;
            textBoxTennv.Text = string.Empty;
            textBoxDiachi.Text = string.Empty;
            textBoxManv.Focus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var data = db.THONGTINNHANVIENs.Where(alias => alias.Tennv.Contains(textBoxTennv.Text));
            gridNhanVien.DataSource = data.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 addForm = new Form2();
            addForm.Owner = this;
            addForm.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (gridNhanVien.CurrentCell != null)
            {
                Form3 update = new Form3();
                update.Owner = this;
                update.id = Int32.Parse(gridNhanVien.CurrentRow.Cells[0].Value.ToString());
                update.manv = gridNhanVien.CurrentRow.Cells[1].Value.ToString();
                update.tennv = gridNhanVien.CurrentRow.Cells[2].Value.ToString();
                update.diachi = gridNhanVien.CurrentRow.Cells[3].Value.ToString();

                update.ShowDialog();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Are you sure to delete data row ID = {numDelete.Value}", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                int num = Int32.Parse(numDelete.Value.ToString());
                var delete = db.THONGTINNHANVIENs.Single(alias => alias.ID.Equals(num));
                db.THONGTINNHANVIENs.Remove(delete);
                db.SaveChanges();
                MessageBox.Show("Delete Success !");
                reloadData();
                }
                catch (Exception)
                {
                    MessageBox.Show($"Something go wrong with {numDelete.Value}");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                numDelete.Value = 0;
            }

        }

        private void numDelete_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
