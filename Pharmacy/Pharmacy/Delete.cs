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
    public partial class Delete : Form
    {
        private Pharmacy _pharmacy;
        private DataGridView _dgv;
        public Delete(Pharmacy p, DataGridView d)
        {
            InitializeComponent();
            _dgv = d;
            _pharmacy = p;
            cmbDelete.DataSource = _pharmacy.GetMedicines();
        }

        private void btnComboDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(cmbDelete.SelectedValue.ToString().Substring(0, 2).Trim());
            _pharmacy.DeleteMedicine(id);
            cmbDelete.DataSource = null;
            cmbDelete.DataSource = _pharmacy.GetMedicines();
            _dgv.DataSource = null;
            _dgv.DataSource = _pharmacy.GetMedicines();
        }
    }
}
