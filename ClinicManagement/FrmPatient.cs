using System;
using System.Windows.Forms;

namespace ClinicManagement
{
    public partial class FrmAddPatient : Form
    {
        PatientManager patientManager = new PatientManager();

        public FrmAddPatient()
        {
            InitializeComponent();
        }

        private void FrmAddPatient_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string[] errors = patientManager.PatientValidation(
                firstName: txtName.Text,
                lastName: txtLastName.Text,
                nationalCode: txtNationalCode.Text,
                mobileNumber: txtMobileNumber.Text
            );

            if (errors.Length > 0)
            {
                MessageBox.Show(
                    errors[0],
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            Patient Patient = new Patient();
            Patient.FirstName = txtName.Text;
            Patient.LastName = txtLastName.Text;
            Patient.NationalCode = txtNationalCode.Text;
            Patient.MobileNumber = txtMobileNumber.Text;

            patientManager.AddPatient(Patient);
        }
    }
}
