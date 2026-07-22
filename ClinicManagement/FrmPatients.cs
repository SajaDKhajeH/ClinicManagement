using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
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
            PatientManager patientManager = new PatientManager();
            dgvPatient.DataSource = patientManager.GetPatients().ToList();
        }

        private void dgvPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var p = new Patient("", "");

            if (e.ColumnIndex == dgvPatient.Columns["ColDelete"].Index)
            {
                int b = 0;

                MessageBox.Show(e.RowIndex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //var ali = new Patient();
            //ali.FirstName = "ali";
            //ali.LastName = "alavi";
            //ali.NationalCode = "222";
            //ali.MobileNumber = "0912";

            //var reza = new Patient();
            //reza.FirstName = ali.FirstName;
            //reza.LastName = ali.LastName;
            //reza.NationalCode = "444";
            //reza.MobileNumber = ali.MobileNumber;

            //var reza2 = ali;
            //reza.NationalCode = "555";

            //MessageBox.Show("reza:" + reza.FirstName);
            //MessageBox.Show("ali:" + ali.FirstName);
            var sw = Stopwatch.StartNew();
            sw.Start();
            string s = "";
            string a = "", b = "";
            string fullname = a + " " + b;
            string fname = $"{a} {b}";
            for (int i = 0; i < 50000; i++)
            {
                s += i + ",";
            }
            sw.Stop();
            MessageBox.Show(sw.ElapsedMilliseconds.ToString());

            sw = Stopwatch.StartNew();
            sw.Start();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 50000; i++)
            {
                sb.Append($"{i},");
            }
            sw.Stop();
            MessageBox.Show(sw.ElapsedMilliseconds.ToString());

            //MessageBox.Show(sb.ToString());



            string ali = "mohammadalwefwefwefwerfi";
            ali = "ali";
            string reza = ali;

            reza = "reza";

            MessageBox.Show("reza:" + reza);
            MessageBox.Show("ali:" + ali);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PatientManager patientManager = new PatientManager();
            patientManager.GetPatients().Clear();
        }
    }
}