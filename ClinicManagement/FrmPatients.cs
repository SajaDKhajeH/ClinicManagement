using System;
using System.Linq;
using System.Windows.Forms;

namespace ClinicManagement
{
    public partial class FrmPatients : Form
    {
        public FrmPatients()
        {
            InitializeComponent();
        }

        private void FrmPatient_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddPatient frm = new FrmAddPatient();

            frm.ShowDialog();
            PatientManager PatientManager = new PatientManager();
            dgvPatient.DataSource = PatientManager.GetPatients().ToList();
        }

        private void dgvPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPatient.Columns["ColDelete"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show(
                    "آیا از حذف این بیمار مطمئن هستید؟",
                    "تأیید حذف",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Patient patient = (Patient)dgvPatient.Rows[e.RowIndex].DataBoundItem;

                    PatientManager patientManager = new PatientManager();
                    patientManager.DeletePatient(patient);
                  
                    dgvPatient.AutoGenerateColumns = false; // برای اینه که بعد از دیلیت یک رکورد ترتیب فیلد ها بهم میریخت
                    dgvPatient.DataSource = null;
                    dgvPatient.DataSource = patientManager.GetPatients().ToList();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PatientManager patientManager = new PatientManager();

            dgvPatient.AutoGenerateColumns = false;
            dgvPatient.DataSource = patientManager.SearchPatient(txtSearch.Text);
        }
    }
}