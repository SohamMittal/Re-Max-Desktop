using System;
using System.Data;
using System.Windows.Forms;

namespace prjCSWinRemax.GUI
{
    public partial class frmClientInfo : MetroFramework.Forms.MetroForm
    {
        private frmAdmClients frm1;

        public frmClientInfo(frmAdmClients frm)
        {
            InitializeComponent();
            frm1 = frm;
        }

        private string Abcd;

        private void frmClientInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'remaxDatabaseDataSet1.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.remaxDatabaseDataSet1.Clients);
            txtComment.Enabled = false;
            picAgent.SizeMode = PictureBoxSizeMode.StretchImage;

            this.employeeSkillsTableAdapter.Fill(this.remaxDatabaseDataSet1.EmployeeSkills);
            this.skillsTableAdapter.Fill(this.remaxDatabaseDataSet1.Skills);
            this.employeesTableAdapter1.Fill(this.remaxDatabaseDataSet1.Employees);
            this.clientsTableAdapter.Fill(this.remaxDatabaseDataSet1.Clients);

            Abcd = frm1.grdResult.SelectedRows[0].Cells[2].Value.ToString();

            int refnumber = 0;
            foreach (DataRow Cr in remaxDatabaseDataSet1.Clients.Rows)
            {
                if (Cr.Field<String>("Phone") == Abcd)
                {
                    txtName.Text = Cr["Name"].ToString();
                    txtPhone.Text = Cr["Phone"].ToString();
                    txtEmail.Text = Cr["Email"].ToString();
                    cmbGender.Text = Cr["Gender"].ToString();
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
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
