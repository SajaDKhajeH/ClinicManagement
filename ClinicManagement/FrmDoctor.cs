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
            InitializeComponent();
        }

        private void FrmDoctor_Load(object sender, EventArgs e)
        {

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
                
            else
                MessageBox.Show(result.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            

        }
    }
    }
