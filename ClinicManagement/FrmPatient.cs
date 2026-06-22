using System;
using System.Windows.Forms;

namespace ClinicManagement
{
    public partial class FrmAddPatient : Form
    {
        public FrmAddPatient()
        {
            InitializeComponent();
        }

        private void FrmAddPatient_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Patient Patient = new Patient();
            Patient.FirstName = txtName.Text;
            Patient.LastName = txtLastName.Text;
            Patient.NationalCode = txtNationalCode.Text;
            Patient.MobileNumber = txtMobileNumber.Text;

            PatientManager PatientManager = new PatientManager();
            PatientManager.AddPatient(Patient);
            
        }

    }
}
