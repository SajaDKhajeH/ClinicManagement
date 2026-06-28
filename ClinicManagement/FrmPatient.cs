using System;
using System.Linq;
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
            Patient patient = new Patient
            {
                FirstName = txtName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                NationalCode = txtNationalCode.Text.Trim(),
                MobileNumber = txtMobileNumber.Text.Trim()
            };

            PatientManager patientManager = new PatientManager();

            string error = patientManager.AddPatient(patient);

            if (error != null)
            {
                MessageBox.Show(error, "خطا",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("بیمار با موفقیت ثبت شد.");
            this.Close();
        }

    }
}
