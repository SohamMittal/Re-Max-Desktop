using MetroFramework;
using System;
using System.Windows.Forms;

namespace prjCSWinRemax.GUI
{
    public partial class frmFeatMgmt : MetroFramework.Forms.MetroForm
    {
        public frmFeatMgmt()
        {
            InitializeComponent();
        }

        private void frmFeatMgmt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'remaxDatabaseDataSet.Features' table. You can move, or remove it, as needed.
            this.featuresTableAdapter.Fill(this.remaxDatabaseDataSet.Features);

        }

        public int refFeature;

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
                this.featuresTableAdapter.Update(this.remaxDatabaseDataSet);
                txtName.Clear();
                txtDetails.Clear();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtName.Text != null && txtDetails.Text != null)
            {
                this.featuresTableAdapter.Insert(txtName.Text,txtDetails.Text);
                this.featuresTableAdapter.Fill(this.remaxDatabaseDataSet.Features);
                txtName.Clear();
                txtDetails.Clear();
            }
            else
            {
                MetroMessageBox.Show(this, "The feature name and its details can not be left blank", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtName.Text != null && txtDetails.Text != null)
            {
                if (grdResult.SelectedRows.Count > 0)
                {
                    this.featuresTableAdapter.Update(txtName.Text, txtDetails.Text, refFeature);
                    this.featuresTableAdapter.Fill(this.remaxDatabaseDataSet.Features);
                    txtName.Clear();
                    txtDetails.Clear();
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

        private void grdResult_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                refFeature = Convert.ToInt32(grdResult.SelectedRows[0].Cells[0].Value.ToString());
                txtName.Text = grdResult.SelectedRows[0].Cells[1].Value.ToString();
                txtDetails.Text = grdResult.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch
            {
                return;
            }
        }
    }
}
