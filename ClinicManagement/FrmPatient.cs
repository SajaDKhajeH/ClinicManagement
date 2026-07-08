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
            //var ali = new Patient();
            //ali.FirstName = "ali";
            //ali.LastName = "alavi";

            //var reza = new Patient();
            //reza.FirstName = "ali";
            //reza.LastName = "alavi";

           

        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient(txtName.Text, txtLastName.Text);
            
            PrintData(patient);
            //Patient.FirstName = txtName.Text;
            //Patient.LastName = txtLastName.Text;
            //Patient.NationalCode = txtNationalCode.Text;
            //Patient.MobileNumber = txtMobileNumber.Text;

            PatientManager PatientManager = new PatientManager();

            var result = PatientManager.AddPatient(patient);

            if (result.Success)
            {
                MessageBox.Show("success");
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void PrintData(Patient patient)
        {
            MessageBox.Show($"{patient.FirstName} {patient.LastName}");
        }
    }
}
