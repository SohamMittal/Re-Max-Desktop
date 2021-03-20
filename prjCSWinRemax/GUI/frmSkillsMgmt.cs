using MetroFramework;
using System;
using System.Windows.Forms;

namespace prjCSWinRemax.GUI
{
    public partial class frmSkillsMgmt : MetroFramework.Forms.MetroForm
    {
        public frmSkillsMgmt()
        {
            InitializeComponent();
        }

        public int refSkill;

        private void frmSkillsMgmt_Load(object sender, EventArgs e)
        {
            this.skillsTableAdapter.Fill(this.remaxDatabaseDataSet.Skills);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtName.Text != null)
            {
                this.skillsTableAdapter.Insert(txtName.Text);
                this.skillsTableAdapter.Fill(this.remaxDatabaseDataSet.Skills);
                txtName.Clear();
            }
            else
            {
                MetroMessageBox.Show(this,"The skill name can not be left blank","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtName.Text != null)
            {
                if (grdResult.SelectedRows.Count > 0)
                {
                    this.skillsTableAdapter.Update(txtName.Text,refSkill);
                    this.skillsTableAdapter.Fill(this.remaxDatabaseDataSet.Skills);
                    txtName.Clear();
                }
                else
                {
                    MetroMessageBox.Show(this, "Select a skill before editing!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MetroMessageBox.Show(this, "The skill name can not be left blank", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult ab = MetroMessageBox.Show(this, "Are you sure you want to delete the selected skill?", "Confirm delete.", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
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
                txtName.Clear();
            }
        }

        private void grdResult_SelectionChanged(object sender, EventArgs e)
        {
            refSkill = Convert.ToInt32(grdResult.SelectedRows[0].Cells[0].Value.ToString());
            txtName.Text = grdResult.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
