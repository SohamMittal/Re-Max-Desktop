using prjCSWinRemax.BUSINESS;
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
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.employeesTableAdapter.Fill(this.remaxDatabaseDataSet.Employees);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            foreach (DataRow ab in remaxDatabaseDataSet.Employees)
            {
                if ((ab.Field<String>("Email") == txtUser.Text) && (ab.Field<String>("Password") == txtPass.Text))
                {
                    clsGlobal.power = ab.Field<String>("Position");
                    clsGlobal.loggedId = ab.Field<Int32>("refEmployee");
                    MetroFramework.MetroMessageBox.Show(this, "Welcome to the system, " + ab.Field<String>("Name"));
                    frmMain.ab.Visible = true;
                    if (ab.Field<String>("Position") == "Admin")
                    {
                        frmMain.bc.Visible = true;
                    }
                    else
                    {
                        frmMain.bc.Visible = false;
                    }
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
