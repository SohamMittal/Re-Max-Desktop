using System;
using System.Windows.Forms;
using MetroFramework;
using prjCSWinRemax.BUSINESS;

namespace prjCSWinRemax.GUI
{
    public partial class frmAdmAgents : MetroFramework.Forms.MetroForm
    {
        public frmAdmAgents()
        {
            InitializeComponent();
        }

        private void frmAdmAgents_Load(object sender, EventArgs e)
        {
            this.employeesTableAdapter.Fill(this.remaxDatabaseDataSet.Employees);
        }    

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult ab = MetroMessageBox.Show(this, "Are you sure you want to delete the selected agent?", "Confirm delete.", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (ab == DialogResult.Yes)
            {
                Int32 selected = -1;
                if (grdResult.CurrentCell != null)
                {
                    selected = grdResult.CurrentCell.RowIndex;
                }
                if (selected > -1)
                {
                    grdResult.Rows.RemoveAt(selected);
                }
                else
                {
                    MetroMessageBox.Show(this, "The records are empty. There is nothing to delete.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.tableAdapterManager.UpdateAll(this.remaxDatabaseDataSet);
            }
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            clsGlobal.mode = "add";
            frmNewAgent fr = new frmNewAgent(this);
            fr.Show();
        }

        private void btnMoreInfo_Click(object sender, EventArgs e)
        {
            frmAgentInfo frz = new frmAgentInfo(this);
            frz.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            clsGlobal.mode = "edit";
            frmNewAgent fr = new frmNewAgent(this);
            fr.Show();
        }
    }
}
