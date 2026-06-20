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
            foreach (Control item in this.Controls)
            {
                if (item is TextBox && string.IsNullOrWhiteSpace(((TextBox)item).Text))
                {
                    MessageBox.Show("لطفا همه موارد را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (txtNationalCode.TextLength != 10)
            {
                MessageBox.Show("کدملی 10 رقمی است");
                return;
            }
            Patient Patient = new Patient();
            Patient.FirstName = txtName.Text;
            Patient.LastName = txtLastName.Text;
            Patient.NationalCode = txtNationalCode.Text;
            Patient.MobileNumber = txtMobileNumber.Text;

            PatientManager PatientManager = new PatientManager();
            PatientManager.AddPatient(Patient);
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";

                }
            }
            MessageBox.Show("دخیره شد");
        }
    }
    
}

