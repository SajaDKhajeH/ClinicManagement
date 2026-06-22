using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Windows.Forms.VisualStyles;

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
                MessageBox.Show(e.RowIndex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            dgvPatient.DataSource = PatientManager.GetPatients().ToList();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<Patient> searchedList = new List<Patient>();

            foreach (Patient item in PatientManager.GetPatients())
            {
                if (txtSearch.Text.Trim() == item.NationalCode)
                    searchedList.Add(item);
            }

            dgvPatient.DataSource = searchedList;
        }
    }
}