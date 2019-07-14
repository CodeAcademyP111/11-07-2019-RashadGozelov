using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class Form1 : Form
    {
        private Form _login;
        private Pharmacy _pharmacy;
        private DataGridView dgv;
        public Form1(Form f)
        {
            InitializeComponent();
            _login = f;
            f.Hide();
            Pharmacy zeferan = new Pharmacy("zeferan");
            _pharmacy = zeferan;
            dgv = dgvList;
            dgvList.DataSource = _pharmacy.GetMedicines();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string medicine = txtMedicine.Text;
            string price = txtPrice.Text;
            string TypeMedicine = txtTypeMedicine.Text;

            if (medicine == "" || price=="" || TypeMedicine == "")
            {
                MessageBox.Show("Xanani doldurun", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Medicine medicine1 = new Medicine { Name = medicine, Price=price, Typemedicine = TypeMedicine };
            _pharmacy.AddMedicine(medicine1);
            dgvList.DataSource = _pharmacy.GetMedicines();
            dgvList.DataSource = null;
            dgvList.DataSource = _pharmacy.GetMedicines();
            txtMedicine.Text = null;
            txtTypeMedicine.Text = null;

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete(_pharmacy, dgv);
            delete.Show();
        }

        private int ID = 0;

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.Visible = true;
            btnCreate.Visible = false;
            int id = (int)dgv.Rows[e.RowIndex].Cells[0].Value;
            ID = id;
            Medicine medicine = _pharmacy.GetMedicine(id);
            txtMedicine.Text = medicine.Name;
            txtPrice.Text = medicine.Price;
            txtTypeMedicine.Text = medicine.Typemedicine;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string medicine = txtMedicine.Text;
            string price = txtPrice.Text;
            string typemedicine = txtTypeMedicine.Text;
            if (medicine == "" || price=="" || typemedicine == "")
            {
                MessageBox.Show("Xanani doldurun", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            _pharmacy.EditMedicine(ID, medicine, price, typemedicine);
            dgvList.DataSource = null;
            dgvList.DataSource = _pharmacy.GetMedicines();
            txtMedicine.Text = null;
            txtPrice.Text = null;
            txtTypeMedicine.Text = null;
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {

            btnEdit.Visible = false;
            btnCreate.Visible = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }
    }
}
