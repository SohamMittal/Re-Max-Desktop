using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace prjCSWinRemax.GUI
{
    public partial class frmAgentInfo : MetroFramework.Forms.MetroForm
    {

        private frmAdmAgents frm1;
        private frmSearch frm2;
        public frmAgentInfo(frmAdmAgents frm)
        {
            InitializeComponent();
            frm1 = frm;
        }

        public frmAgentInfo(frmSearch frm)
        {
            InitializeComponent();
            frm2 = frm;
        }

        private string Abcd;
        private void frmAgentInfo_Load(object sender, EventArgs e)
        {
            txtComment.Enabled = false;
            picAgent.SizeMode = PictureBoxSizeMode.StretchImage;
            // TODO: This line of code loads data into the 'remaxDatabaseDataSet1.EmployeeSkills' table. You can move, or remove it, as needed.
            this.employeeSkillsTableAdapter.Fill(this.remaxDatabaseDataSet1.EmployeeSkills);
            this.skillsTableAdapter.Fill(this.remaxDatabaseDataSet1.Skills);
            this.employeesTableAdapter1.Fill(this.remaxDatabaseDataSet1.Employees);

            if (Application.OpenForms.OfType<frmAdmAgents>().Count() == 1)
            {
                Abcd = frm1.grdResult.SelectedRows[0].Cells[3].Value.ToString();
            }
            if(Application.OpenForms.OfType<frmSearch>().Count() == 1)
            {
                Abcd = frm2.grdResult.SelectedRows[0].Cells[2].Value.ToString();
            }

            int refnumber = 0;
            foreach (DataRow Cr in remaxDatabaseDataSet1.Employees.Rows)
            {
                if (Cr.Field<String>("Phone") == Abcd)
                {
                    txtName.Text = Cr["Name"].ToString();
                    txtPhone.Text = Cr["Phone"].ToString();
                    txtEmail.Text = Cr["Email"].ToString();
                    cmbGender.Text = Cr["Gender"].ToString();
                    cmbPosition.Text = Cr["Position"].ToString();
                    txtComment.Text = Cr["Comment"].ToString();
                    refnumber = Convert.ToInt32(Cr["refEmployee"].ToString());

                    string imgpath = Cr["Picture"].ToString();

                    if (imgpath.Length != 0 && (System.IO.File.Exists(@"..\..\Images\" + imgpath)))
                    {
                        picAgent.Image = System.Drawing.Image.FromFile(@"..\..\Images\" + imgpath);
                    }
                    else
                    {
                        picAgent.Image = System.Drawing.Image.FromFile(@"..\..\Images\sorry.png");
                    }
                }
            }
            foreach (DataRow ab in remaxDatabaseDataSet1.EmployeeSkills.Rows)
            {
                if (ab.Field<Int32>("refEmployee") == refnumber)
                {
                    foreach (DataRow cd in remaxDatabaseDataSet1.Skills.Rows)
                    {
                        if (ab.Field<Int32>("refSkill") == cd.Field<Int32>("refSkill"))
                        {
                            string[] row = { ab.Field<Int32>("refSkill").ToString(), cd.Field<String>("SkillName") };
                            var listViewItem = new ListViewItem(row);
                            listSkills.Items.Add(listViewItem);
                        }
                    }
                }
            }



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
