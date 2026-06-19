using System;
using System.Linq;
using System.Windows.Forms;

namespace ClinicManagement
{
    public partial class FrmBimaran : Form
    {
        public FrmBimaran()
        {
            InitializeComponent();
        }

        private void FrmBimar_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddBimar frm = new FrmAddBimar();

            frm.ShowDialog();
            BimarManager bimarManager = new BimarManager();
            dgvBimar.DataSource = bimarManager.GetBimaran().ToList();
        }

        private void dgvBimar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvBimar.Columns["ColDelete"].Index)
            {
                MessageBox.Show(e.RowIndex.ToString());
            }
        }
    }
}