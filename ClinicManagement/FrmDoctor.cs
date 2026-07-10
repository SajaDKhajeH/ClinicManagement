using ClinicManagement.ClinicManagement;
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
    public partial class FrmDoctor : Form
    {
        public FrmDoctor()
        {
            this.doctor = doctor;
            InitializeComponent();
        }

        private void FrmDoctor_Load(object sender, EventArgs e)
        {
            string[] errors = DoctorManager.Validation(
                firstName: txtName.Text,
                lastName: txtLastName.Text,
                medicalCouncilNumber: txtMedicalCouncilNumber.Text
            );

        }

        private void btnSave_Click(object sender, EventArgs e)
            {
            Doctor doctor = new Doctor(txtMedicalCouncilNumber.Text.Trim());
            doctor.FirstName = txtName.Text.Trim();
            doctor.LastName = txtLastName.Text.Trim();
            doctor.Specialty = txtSpecialty.Text.Trim();

            
            DoctorManager doctorManager = new DoctorManager();
            Result result = doctorManager.AddDoctor(doctor);
           // var result = DoctorManager.AddDoctor(doctor);

            if (result.Success) {
                MessageBox.Show("اطلاعات با موفیقت ثبت شد");
                this.Close();
            }

            Doctor Doctor = new Doctor(txtMedicalCouncilNumber.Text);
            Doctor.FirstName = txtName.Text;
            Doctor.LastName = txtLastName.Text;
            Doctor.Specialties = richTextBox1.Text.Split('\n');

            if (this.doctor == null)
                DoctorManager.AddDoctor(Doctor);
            else
                MessageBox.Show(result.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            

        private void FrmDoctor_Load(object sender, EventArgs e)
        {
            if (doctor != null)
            {
                txtName.Text = doctor.FirstName;
                txtLastName.Text = doctor.LastName;
                txtMedicalCouncilNumber.Text = doctor.MedicalCouncilNumber;
                richTextBox1.Text = string.Join(Environment.NewLine, doctor.Specialties);
            }
        }
    }
}
