using System;
using MetroFramework.Forms;
using prjCSWinRemax.GUI;

namespace prjCSWinRemax
{
    public partial class frmMain : MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public static System.Windows.Forms.ToolStripMenuItem ab;
        public static System.Windows.Forms.ToolStripMenuItem bc;

        private void frmMain_Load(object sender, EventArgs e)
        {
            ab = menuAdd;
            ab.Visible = false;
            bc = mngAgents;
            bc.Visible = false;
        }

        private void addNewSkillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSkillsMgmt frm = new frmSkillsMgmt();
            frm.ShowDialog();
        }

        private void viewAgentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmAgents fra = new frmAdmAgents();
            fra.MdiParent = this;
            fra.Show();
        }

        private void featuresManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFeatMgmt frm = new frmFeatMgmt();
            frm.ShowDialog();
        }

        private void viewHousesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmHouses frm = new frmAdmHouses();
            frm.MdiParent = this;
            frm.Show();
        }

        private void viewClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmClients fra = new frmAdmClients();
            fra.ShowDialog();
        }

        private void menuDisplay_Click(object sender, EventArgs e)
        {
            frmSearch fs = new frmSearch();
            fs.ShowDialog();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult ab = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to quit?", "Quit?", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Asterisk);
            if (ab == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLogin abcd = new frmLogin();
            abcd.Show();
        }

        private void menuInfo_Click(object sender, EventArgs e)
        {
            frmInfo fi = new frmInfo();
            fi.Show();
        }

        private void inventoryStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventory fi = new frmInventory();
            fi.Show();
        }
    }
}
