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
    public partial class Frmdoctors : Form
    {
        public Frmdoctors()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            frmadddoctors frm=new frmadddoctors();
            frm.ShowDialog();
            var drmanager=new DrManager();
          
            dgvDrs.DataSource = drmanager.GetDr().ToList();
           
        }

        private void dgvDrs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var drManager = new DrManager();
            if (e.RowIndex < 0)
                return;
            int idValue = Convert.ToInt32(dgvDrs.Rows[e.RowIndex].Cells[6].Value);
            if (dgvDrs.Rows[e.RowIndex].Cells[6].Value!=null)
            {
                if (e.ColumnIndex == dgvDrs.Columns["coldelet"].Index)
                {
                    drManager.DeleteDr(idValue);
                    dgvDrs.DataSource = drManager.GetDr().ToList();
                }
            }

                if (e.ColumnIndex == dgvDrs.Columns["coledit"].Index)
                {
                
                var frmEdit = new frmEdit();
                frmEdit.ShowDialog();
              
                dgvDrs.Refresh();
            }
            
        }

        private void Frmdoctors_Load(object sender, EventArgs e)
        {
            dgvDrs.Refresh();
        }
    }
}
