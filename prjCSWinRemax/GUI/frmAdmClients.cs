using MetroFramework;
using prjCSWinRemax.BUSINESS;
using System;
using System.Windows.Forms;
using System.Linq;
using System.Data;

namespace prjCSWinRemax.GUI
{
    public partial class frmAdmClients : MetroFramework.Forms.MetroForm
    {
        public frmAdmClients()
        {
            InitializeComponent();
        }

        public void select ()
        {
            if (clsGlobal.power != "Admin")
            {
                var Employees = from DataRow Cr in remaxDatabaseDataSet.Clients.Rows
                                where Cr.Field<Int32>("refEmployee") == clsGlobal.loggedId
                                select new
                                {
                                    Name = Cr.Field<string>("Name"),
                                    Gender = Cr.Field<string>("Gender"),
                                    Phone = Cr.Field<string>("Phone"),
                                    Email = Cr.Field<string>("Email"),
                                };
                grdResult.DataSource = Employees.ToList();
            }
            else
            {
                this.clientsTableAdapter.Fill(this.remaxDatabaseDataSet.Clients);
                this.employeesTableAdapter.Fill(this.remaxDatabaseDataSet.Employees);
            }
        }
        private void frmAdmClients_Load(object sender, EventArgs e)
        {
            this.clientsTableAdapter.Fill(this.remaxDatabaseDataSet.Clients);
            this.employeesTableAdapter.Fill(this.remaxDatabaseDataSet.Employees);
            select();           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult ab = MetroMessageBox.Show(this, "Are you sure you want to delete the selected client?", "Confirm delete.", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
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
            frmNewClient fr = new frmNewClient(this);
            fr.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            clsGlobal.mode = "edit";
            frmNewClient fr = new frmNewClient(this);
            fr.Show();
        }

        private void btnMoreInfo_Click(object sender, EventArgs e)
        {
            frmClientInfo frz = new frmClientInfo(this);
            frz.Show();
        }
    }
}
