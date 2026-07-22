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
            var ali = new Patient("","");
            ali.FirstName = "ali";
            ali.LastName = "alavi";

            var reza = new Patient("","");
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
            Patient patient = new Patient(txtName.Text, txtLastName.Text);
            patient.NationalCode = txtNationalCode.Text;
            //PrintData(patient);

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
