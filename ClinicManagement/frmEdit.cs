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
    public partial class frmEdit : Form
    { 
        public Doctor dr {  get; set; }
        public frmEdit()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
           
            dr.Specialties = txtSpecialties2.Text;
            dr.LastName = txtLastName2.Text;
            dr.Name = txtName2.Text;
            dr.MedicalCouncil= txtMedicalCouncil2.Text;
            this.Close();
        }
    }
}
