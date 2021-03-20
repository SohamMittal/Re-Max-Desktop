using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCSWinRemax.GUI
{
    public partial class frmInventory : MetroFramework.Forms.MetroForm
    {
        public frmInventory()
        {
            InitializeComponent();
        }


        private void frmInventory_Load(object sender, EventArgs e)
        {
            this.listingTableAdapter.Fill(this.remaxDatabaseDataSet.Listing);
            this.employeesTableAdapter.Fill(this.remaxDatabaseDataSet.Employees);
            this.clientsTableAdapter.Fill(this.remaxDatabaseDataSet.Clients);
            this.housesTableAdapter.Fill(this.remaxDatabaseDataSet.Houses);

            int count = 0;

            foreach (DataRow ab in remaxDatabaseDataSet.Houses.Rows)
            {
                count++;
            }
            txtHouses.Text = count.ToString();

            count = 0;
            foreach (DataRow ab in remaxDatabaseDataSet.Employees.Rows)
            {
                count++;
            }
            txtEmp.Text = count.ToString();

            count = 0;
            foreach (DataRow ab in remaxDatabaseDataSet.Clients.Rows)
            {
                count++;
            }
            txtClients.Text = count.ToString();
        }

        private void cmbHouses_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = 0;

            if (cmbHouses.SelectedIndex > -1)
            {
                foreach (DataRow ab in remaxDatabaseDataSet.Houses.Rows)
                {
                    if (ab.Field<Int32>("refListing").ToString() == cmbHouses.SelectedValue.ToString())
                    {
                        count++;
                    }
                }
            }
            txtQtt.Text = count.ToString();
        }
    }
}
