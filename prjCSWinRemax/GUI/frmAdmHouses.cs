using System;
using System.Data;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using prjCSWinRemax.BUSINESS;
using System.Linq;

namespace prjCSWinRemax.GUI
{
    public partial class frmAdmHouses : MetroForm
    {
        public frmAdmHouses()
        {
            InitializeComponent();
        }

        public void select ()
        {
            if (clsGlobal.power != "Admin")
            {
                var Employees = from DataRow Cr in remaxDatabaseDataSet1.Houses.Rows
                                where Cr.Field<Int32>("refEmployee") == clsGlobal.loggedId
                                select new
                                {
                                    refHouse = Cr.Field<Int32>("refHouse"),
                                    Bathrooms = Cr.Field<string>("Bathrooms"),
                                    NumberOfRooms = Cr.Field<string>("NumberOfRooms"),
                                    LivingArea = Cr.Field<string>("LivingArea"),
                                    ParkingSpot = Cr.Field<string>("ParkingSpot"),
                                    BuiltDate = Cr.Field<string>("BuiltDate"),
                                    Bedrooms = Cr.Field<string>("Bedrooms"),
                                    Price = Cr.Field<string>("Price"),
                                    Address = Cr.Field<string>("Address"),
                                    Comments = Cr.Field<string>("Comments")
                                };
                grdResult.DataSource = Employees.ToList();
            }
            else
            {
                this.housesTableAdapter1.Fill(this.remaxDatabaseDataSet1.Houses);
            }
        }

        private void frmAdmHouses_Load(object sender, EventArgs e)
        {
            this.housesTableAdapter1.Fill(this.remaxDatabaseDataSet1.Houses);
            select();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            clsGlobal.mode = "add";
            frmHouseAddEdit fs = new frmHouseAddEdit(this);
            fs.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            clsGlobal.mode = "edit";
            frmHouseAddEdit fs = new frmHouseAddEdit(this);
            fs.ShowDialog();
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
                this.tableAdapterManager.UpdateAll(remaxDatabaseDataSet1);
                select();
            }
        }

        private void btnMoreInfo_Click(object sender, EventArgs e)
        {
            frmHousesInfo frz = new frmHousesInfo(this);
            frz.Show();
        }
    }
}
