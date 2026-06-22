using System;
using System.Linq;
using System.Windows.Forms;

namespace ClinicManagement
{
    public partial class FrmPatients : Form
    {
        public FrmPatients()
        {
            InitializeComponent();
        }

        private void FrmPatient_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddPatient frm = new FrmAddPatient();

            frm.ShowDialog();
            PatientManager PatientManager = new PatientManager();
            dgvPatient.DataSource = PatientManager.GetPatients().ToList();
        }

        private void dgvPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPatient.Columns["ColDelete"].Index)
            {
                MessageBox.Show(e.RowIndex.ToString());
            }
        }

        private void txtNational_TextChanged(object sender, EventArgs e)
        {
            PatientManager PatientManager = new PatientManager();
            if (txtNational.Text == "")
            {
                dgvPatient.DataSource = PatientManager.GetPatients().ToList();
            }
            else
            {
                PatientManager.Search(txtNational.Text);
                dgvPatient.DataSource = PatientManager.Search(txtNational.Text).ToList();
            }
        }
    }
}