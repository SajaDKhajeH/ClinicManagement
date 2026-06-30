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
            if (e.ColumnIndex == dgvPatient.Columns["ColDelete"].Index)
            {
                MessageBox.Show(e.RowIndex.ToString());
            }
        }
        
        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtsearch.Text))
            {
                MessageBox.Show("متن جسجتو رو وارد کن");
                return;
            }
            bool found=false;
            
            for (int i = 0; i < dgvPatient.RowCount; i++)
            {
                var cellValue = dgvPatient.Rows[i].Cells["NationalCode"].Value;
                if (cellValue != null && txtsearch.Text.Trim() == cellValue.ToString())
                {
                    found=true; 
                    dgvPatient.FirstDisplayedScrollingRowIndex = i;
                    dgvPatient.Rows[i].Selected = true;
                    break;
                }
            }

            if (!found)
                MessageBox.Show("کدملی پیدا نشد");
        }
    }

}