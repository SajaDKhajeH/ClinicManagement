using System;
using System.IO;
using System.Windows.Forms;

namespace ClinicManagement
{
    public partial class FrmAddPatient : Form
    {
        public FrmAddPatient()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtMobileNumber.Text) || string.IsNullOrWhiteSpace(txtNationalCode.Text))
            {
                MessageBox.Show("Please Enter the information completely..!");
                return;
            }
            Patient Patient = new Patient();
            Patient.FirstName = txtName.Text;
            Patient.LastName = txtLastName.Text;
            Patient.NationalCode = txtNationalCode.Text;
            Patient.MobileNumber = txtMobileNumber.Text;

            PatientManager PatientManager = new PatientManager();
            try
            {
                PatientManager.AddPatient(Patient);
            }
            catch(InvalidDataException)
            {
                MessageBox.Show("a user with this national code already exists.");
            }
        }

    }
}
