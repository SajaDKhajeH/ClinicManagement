using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
<<<<<<< HEAD
=======
using System.Text.RegularExpressions;
>>>>>>> 8b155cce0448b0d328e0146ea79ca62241b7f8a0
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
        private Doctor _doctor;
        public FrmDoctor(Doctor doctor)
        {
            InitializeComponent();
            _doctor = doctor;
            txtFirst.Text = doctor.FirstName;
            txtLast.Text= doctor.LastName;
            txtMedicalCode.Text=doctor.MedicalCode;
            txtSpecialty.Text=doctor.Specialty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_doctor == null)
            {
                var doctor = new Doctor(txtFirst.Text,txtLast.Text,txtMedicalCode.Text);
            doctor.Specialty = txtSpecialty.Text;
            
                DoctorManagement manager = new DoctorManagement();

                Result result = manager.AddDoctor(doctor);

                MessageBox.Show(result.Message);
                if (result.Success)
                {
                    foreach (Control item in this.Controls)
                    {
                        if (item is TextBox)
                        {
                            ((TextBox)item).Text = "";
                        }
                    }
                }
            }
            else
            {
                Result res = _doctor.Update(txtFirst.Text, txtLast.Text, txtMedicalCode.Text, txtSpecialty.Text);
                if (res.Success)
                {
                    MessageBox.Show("ویرایش شد");
                    this.Close();
                }
                else
                MessageBox.Show(res.Message);
            }
        }

       



    }
}
