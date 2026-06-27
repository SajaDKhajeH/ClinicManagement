using System;
using System.IO;
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

        void FillGrid()
        {
            PatientManager PatientManager = new PatientManager();
            dgvPatient.DataSource = PatientManager.GetPatients().ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddPatient frm = new FrmAddPatient();
            frm.ShowDialog();
            FillGrid();
        }

        private void dgvPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPatient.Columns["ColDelete"].Index)
            {
                string idCodeForDelete = dgvPatient.Rows[e.RowIndex].Cells["NationalCode"].Value.ToString();
                PatientManager PatientManager = new PatientManager();
                try
                {
                    PatientManager.RemovePatient(idCodeForDelete);
                }
                catch(InvalidDataException)
                {
                    MessageBox.Show("There isn't any patient with this national code..!");
                }
                FillGrid();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                FillGrid();
                return;
            }
            PatientManager PatientManager = new PatientManager();
            dgvPatient.DataSource = PatientManager.GetPatient(txtSearch.Text).ToList();
        }
    }
}