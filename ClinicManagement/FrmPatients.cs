using System;
using System.Linq;
using System.Windows.Forms;

namespace ClinicManagement
{
    public partial class FrmPatients : Form
    {
        PatientManager PatientManager = new PatientManager();

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
            dgvPatient.DataSource = PatientManager.GetPatients().ToList();
        }

        private void dgvPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPatient.Columns["ColDelete"].Index)
            {
                if (DialogResult.Yes != MessageBox.Show("آیا از حذف مطمئن هستید؟", "Delete Patient", MessageBoxButtons.YesNo, MessageBoxIcon.Error))
                    return;

                PatientManager.RemovePatient(e.RowIndex);
                dgvPatient.DataSource = PatientManager.GetPatients().ToList();
            }
        }
    }
}