using System;
using System.Windows.Forms;

namespace ClinicManagement
{
    public partial class FrmAddBimar : Form
    {
        public FrmAddBimar()
        {
            InitializeComponent();
        }

        private void FrmAddBimar_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Bimar bimar = new Bimar();
            bimar.FirstName = txtName.Text;
            bimar.LastName = txtLastName.Text;
            bimar.NationalCode = txtNationalCode.Text;
            bimar.MobileNumber = txtMobileNumber.Text;

            BimarManager bimarManager = new BimarManager();
            bimarManager.AddBimar(bimar);
        }

    }
}
