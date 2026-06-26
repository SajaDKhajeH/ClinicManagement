using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

            PatientManager PatientManager = new PatientManager();
            Patient Patient = new Patient();
            if (PatientManager.GetPatients() != null)
            {
                foreach (var patient in PatientManager.GetPatients())
                {
                    if (patient.NationalCode == txtNationalCode.Text)
                    {
                        MessageBox.Show("کد ملی تکراری است");
                        return;
                    }
                }
            }
            if (string.IsNullOrEmpty(txtNationalCode.Text) ||
                string.IsNullOrEmpty(txtLastName.Text) ||
                string.IsNullOrEmpty(txtMobileNumber.Text) ||
                string.IsNullOrEmpty(txtName.Text)
                )
            {
                MessageBox.Show("لطفا همه را کامل وارد کنید");
                return;
            }
            else
            {
                Patient.FirstName = txtName.Text;
                Patient.LastName = txtLastName.Text;
                Patient.NationalCode = txtNationalCode.Text;
                Patient.MobileNumber = txtMobileNumber.Text;
                PatientManager.AddPatient(Patient);
                MessageBox.Show("اطلاعات ثبت شد");
            }

        }

            
    }
}
