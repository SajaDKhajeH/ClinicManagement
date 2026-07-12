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
<<<<<<< HEAD
            PatientManager PatientManager = new PatientManager();
            foreach (Control item in this.Controls)
            {
                if (item is TextBox&& string.IsNullOrWhiteSpace(((TextBox)item).Text))
                {
                    MessageBox.Show("لطفاً همه موارد را وارد کنید","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
            }
            if(txtNationalCode.TextLength!=10)
            {
                MessageBox.Show("کدملی 10 رقمی است ","خطا",MessageBoxButtons.OK);
                txtNationalCode.Focus();
                return;
            }
            if(PatientManager.NationalCodeExist(txtNationalCode.Text))
            {
                MessageBox.Show("کدملی وارد شده تکراری است");
                return;
            }
            Patient Patient = new Patient(txtName.Text,txtLastName.Text,txtNationalCode.Text,txtMobileNumber.Text);
           
            PatientManager.AddPatient(Patient);
            foreach (Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
            }
            MessageBox.Show("ذخیره شد","پیام",MessageBoxButtons.OK,MessageBoxIcon.Information);


            
=======
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
>>>>>>> 8b155cce0448b0d328e0146ea79ca62241b7f8a0
        }

        private void PrintData(Patient patient)
        {
            MessageBox.Show($"{patient.FirstName} {patient.LastName}");
        }
    }
}
