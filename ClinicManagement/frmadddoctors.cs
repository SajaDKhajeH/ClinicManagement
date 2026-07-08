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
    public partial class frmadddoctors : Form
    {
        
        public frmadddoctors()
        {
            InitializeComponent();
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            Doctor dr = new Doctor();
            dr.Specialties = txtSpecialties.Text;
            dr.MedicalCouncil= txtMedicalCouncil.Text;
            dr.LastName= txtLastName.Text;
            dr.Name = txtName.Text;
            var drmanager = new DrManager();
            var result = drmanager.AddDr(dr);
             
            if(result.Succsed)
                MessageBox.Show("succsed");
            else
                MessageBox.Show(result.Msg);
        }
    }
}
