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
            var b = new Patient("ali", "alavi");
            //var doctor = new Doctor("123456");


            //var doctor2 = new Doctor("123456", "14655");


            //var p = new Person();


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

        private void button3_Click(object sender, EventArgs e)
        {
            int i = textBox1.Text.ToInt();


            var today = DateTime.Now.ToShamsiDate();

            MessageBox.Show(today);
        }
    }
}
