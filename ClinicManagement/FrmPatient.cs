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
         bool NationalCodeExist(string Text)
        {
            PatientManager PatientManager = new PatientManager();
            if (PatientManager.NationalCodeExist(Text))
            {
                MessageBox.Show("کدملی وارد شده تکراری است", "خطا", MessageBoxButtons.OK);
                return true;
            }
            return false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
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
            if(NationalCodeExist(txtNationalCode.Text))
            {
                return;
            }
            Patient Patient = new Patient();
            Patient.FirstName = txtName.Text;
            Patient.LastName = txtLastName.Text;
            Patient.NationalCode = txtNationalCode.Text;
            Patient.MobileNumber = txtMobileNumber.Text;

           
            PatientManager.AddPatient(Patient);
<<<<<<< HEAD
            foreach (Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
            }
            MessageBox.Show("ذخیره شد","پیام",MessageBoxButtons.OK,MessageBoxIcon.Information);

=======
            
>>>>>>> main
        }

    }
}
