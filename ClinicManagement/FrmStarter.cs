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
    public partial class FrmStarter : Form
    {
        public FrmStarter()
        {
            InitializeComponent();
        }
        private void FrmStarter_Load(object sender, EventArgs e)
        {
            //var doctor = new Doctor("123456");


            var doctor2 = new Doctor("123456", "14655");


        }
        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new FrmPatients();

            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new FrmDoctors();

            frm.Show();
        }


    }
}
