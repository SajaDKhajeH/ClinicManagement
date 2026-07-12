using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagement
{
    public partial class FrmDoctors : Form
    {
        DoctorManager DoctorManager = new DoctorManager();

        Doctor doctor;

        public FrmDoctors()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new FrmDoctor();
            frm.ShowDialog();
            var doc = new DoctorManagement();
            dgvDoctors.DataSource=doc.GetDoctor().ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        DoctorManagement doc = new DoctorManagement();

        private void button1_Click(object sender, EventArgs e)
        {
            if(doc.DeleteDoctor(txtDelete.Text))
            {
                MessageBox.Show("Removed!");
                dgvDoctors.DataSource = doc.GetDoctor().ToList();
            }
            else
            {
                MessageBox.Show("Not Fuond!");
                txtDelete.Focus();
            }
        }

        private void btnEdite_Click(object sender, EventArgs e)
        {
            int id;
            if (!string.IsNullOrWhiteSpace(txtId.Text) && int.TryParse(txtId.Text, out id))
            {
                Doctor doctor = DoctorManagement.GetDoctorById(id);
                if (doctor == null)
                {
                    MessageBox.Show("آیدی وارد شده موجود نیست");
                    txtId.Text = null;
                    txtId.Focus();
                    return;
                }
                FrmDoctor frm = new FrmDoctor(doctor);
                frm.ShowDialog();
                dgvDoctors.DataSource = doc.GetDoctor().ToList();

            }
            else
            {
                MessageBox.Show("آیدی را وارد کنید");
                txtId.Focus();            
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

      }
    }
}
