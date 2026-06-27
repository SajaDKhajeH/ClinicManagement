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
            PatientManager patientManager = new PatientManager();
            if (e.ColumnIndex == dgvPatient.Columns["ColDelete"].Index)
            {
                Patient patient=dgvPatient.Rows[e.RowIndex].DataBoundItem as Patient;   
                patientManager.RemovePatient(patient);
                dgvPatient.DataSource=patientManager.GetPatients().ToList();
            }
        }
    }
}