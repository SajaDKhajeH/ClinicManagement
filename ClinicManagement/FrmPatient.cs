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
            var ali = new Patient();
            ali.FirstName = "ali";
            ali.LastName = "alavi";

            var reza = new Patient();
            reza.FirstName = "ali";
            reza.LastName = "alavi";

            if (ali == reza)
            {

            }

            var a = 0;
            var frm = new FrmAddPatient();

            int i;

            var aa = a == 0 ? "1" : "9";
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

        private void PrintData(Patient patient)
        {
            MessageBox.Show($"{patient.FirstName} {patient.LastName}");
        }
    }
}
