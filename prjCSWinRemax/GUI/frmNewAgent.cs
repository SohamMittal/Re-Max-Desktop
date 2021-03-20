using MetroFramework;
using prjCSWinRemax.BUSINESS;
using System;
using System.Data;
using System.Windows.Forms;

namespace prjCSWinRemax.GUI
{
    public partial class frmNewAgent : MetroFramework.Forms.MetroForm
    {
        private frmAdmAgents frm1; 
        public frmNewAgent(frmAdmAgents frm)
        {
            InitializeComponent();
            frm1 = frm;
        }

        public string imgpath;
        public int refnumber;

        private void frmNewAgent_Load(object sender, EventArgs e)
        {            
            picAgent.SizeMode = PictureBoxSizeMode.StretchImage;
            this.skillsTableAdapter.Fill(this.remaxDatabaseDataSet.Skills);
            this.employeeSkillsTableAdapter.Fill(this.remaxDatabaseDataSet.EmployeeSkills);
            this.employeesTableAdapter.Fill(this.remaxDatabaseDataSet.Employees);
            imgpath = @"..\..\Images\sorry.png";
            refnumber = 0;

            if (clsGlobal.mode == "edit")
            {
                if (frm1.grdResult.SelectedRows.Count <= 0)
                {
                    MetroMessageBox.Show(this, "You did not select any agent to modify.\nThe form is being executed in the ADD mode.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clsGlobal.mode = "add";
                    return;
                }

                String Abcd = frm1.grdResult.SelectedRows[0].Cells[3].Value.ToString();

                foreach (DataRow Cr in remaxDatabaseDataSet.Employees.Rows)
                {
                    if (Cr.Field<String>("Phone") == Abcd)
                    {
                        this.Text = "Editing the agent: " + Cr["Name"].ToString();
                        btnCreate.Text = "Confirm\nEdit";
                        txtName.Text = Cr["Name"].ToString();
                        txtPhone.Text = Cr["Phone"].ToString();
                        txtEmail.Text = Cr["Email"].ToString();
                        cmbGender.Text = Cr["Gender"].ToString();
                        cmbPosition.Text = Cr["Position"].ToString();
                        txtComment.Text = Cr["Comment"].ToString();
                        imgpath = Cr["Picture"].ToString();
                        refnumber = Convert.ToInt32(Cr["refEmployee"].ToString());
                        txtAddress.Text = Cr["Address"].ToString();
                        txtPassword.Text = Cr["Password"].ToString();

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
            foreach (DataRow ab in remaxDatabaseDataSet.EmployeeSkills.Rows)
            {
                if (ab.Field<Int32>("refEmployee") == refnumber)
                {
                    foreach (DataRow cd in remaxDatabaseDataSet.Skills.Rows)
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

        public int refag;

        private void btnAddSkill_Click(object sender, EventArgs e)
        {
            bool found = false;
            if (listSkills.Items.Count > 0)
            {
                foreach (ListViewItem itn in listSkills.Items)
                {
                    if (itn.SubItems[0].Text.ToString() == cmbSkill.SelectedValue.ToString())
                    {
                        found = true;
                    }
                }
            }
            if (!found)
            {
                string[] row = { cmbSkill.SelectedValue.ToString(), cmbSkill.Text };
                var listViewItem = new ListViewItem(row);
                listSkills.Items.Add(listViewItem);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtPhone.MaskedTextProvider.MaskCompleted)
            {
                if (clsGlobal.mode == "add")
                {
                    try
                    {
                        string img = System.IO.Path.GetFileName(imgpath);
                        this.employeesTableAdapter.Insert(txtName.Text, txtPhone.Text, txtEmail.Text, cmbGender.Text, txtAddress.Text, img, txtPassword.Text, cmbPosition.Text, txtComment.Text);

                        RemaxDatabaseDataSet data = new RemaxDatabaseDataSet();
                        RemaxDatabaseDataSetTableAdapters.EmployeesTableAdapter empadapt = new RemaxDatabaseDataSetTableAdapters.EmployeesTableAdapter();

                        empadapt.Fill(data.Employees);

                        int id = -1;

                        foreach (DataRow ab in data.Employees)
                        {
                            if (ab["Phone"].ToString() == txtPhone.Text)
                            {
                                id = Convert.ToInt32(ab["refEmployee"].ToString());
                            }
                        }

                        if (listSkills.Items.Count > 0)
                        {
                            foreach (ListViewItem itn in listSkills.Items)
                            {
                                this.employeeSkillsTableAdapter.Insert(id, Convert.ToInt32(itn.SubItems[0].Text));
                            }
                        }
                        frm1.employeesTableAdapter.Fill(frm1.remaxDatabaseDataSet.Employees);
                        this.Close();
                    }
                    catch (System.Data.OleDb.OleDbException exc)
                    {
                        string errorMessages = "";

                        for (int i = 0; i < exc.Errors.Count; i++)
                        {
                            errorMessages += "Index #" + i + "\n" +
                                             "Message: " + exc.Errors[i].Message + "\n" +
                                             "NativeError: " + exc.Errors[i].NativeError + "\n" +
                                             "Source: " + exc.Errors[i].Source + "\n" +
                                             "SQLState: " + exc.Errors[i].SQLState + "\n";
                        }

                        MetroMessageBox.Show(this, "Error while inserting the new agent:\n" + errorMessages, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (clsGlobal.mode == "edit")
                {
                    try
                    {
                        string img = System.IO.Path.GetFileName(imgpath);
                        this.employeesTableAdapter.Update(txtName.Text, txtPhone.Text, txtEmail.Text, cmbGender.Text, txtAddress.Text, img, txtPassword.Text, cmbPosition.Text, txtComment.Text, refnumber);

                        RemaxDatabaseDataSet data = new RemaxDatabaseDataSet();
                        RemaxDatabaseDataSetTableAdapters.EmployeesTableAdapter empadapt = new RemaxDatabaseDataSetTableAdapters.EmployeesTableAdapter();

                        empadapt.Fill(data.Employees);

                        int id = -1;

                        foreach (DataRow ab in data.Employees)
                        {
                            if (ab["Phone"].ToString() == txtPhone.Text)
                            {
                                id = Convert.ToInt32(ab["refEmployee"].ToString());
                            }
                        }

                        if (listSkills.Items.Count > 0)
                        {

                            foreach (DataRow ab in remaxDatabaseDataSet.EmployeeSkills.Rows)
                            {
                                if (ab.Field<Int32>("refEmployee") == id)
                                {
                                    this.employeeSkillsTableAdapter.Delete(ab.Field<Int32>("refEmployee"), ab.Field<Int32>("refSkill"));
                                }
                            }
                            employeeSkillsTableAdapter.Fill(remaxDatabaseDataSet.EmployeeSkills);
                            foreach (ListViewItem itn in listSkills.Items)
                            {                                
                                this.employeeSkillsTableAdapter.Insert(id, Convert.ToInt32(itn.SubItems[0].Text));
                            }
                        }
                        frm1.employeesTableAdapter.Fill(frm1.remaxDatabaseDataSet.Employees);
                        this.Close();
                    }
                    catch (System.Data.OleDb.OleDbException exc)
                    {
                        string errorMessages = "";

                        for (int i = 0; i < exc.Errors.Count; i++)
                        {
                            errorMessages += "Index #" + i + "\n" +
                                             "Message: " + exc.Errors[i].Message + "\n" +
                                             "NativeError: " + exc.Errors[i].NativeError + "\n" +
                                             "Source: " + exc.Errors[i].Source + "\n" +
                                             "SQLState: " + exc.Errors[i].SQLState + "\n";
                        }

                        MetroMessageBox.Show(this, "Error while inserting the new agent:\n" + errorMessages, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Check the phone formating! ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveSkill_Click(object sender, EventArgs e)
        {
            if (listSkills.SelectedItems.Count > 0)
            {
                int listSelect = listSkills.SelectedIndices[0];
                var confirmResult = MetroMessageBox.Show(this, "Are you sure to delete this item ?", "Confirm Delete!", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (confirmResult == DialogResult.Yes)
                {
                    this.listSkills.Items.RemoveAt(listSelect);
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Please a skill before deleting.", "Delete error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnBrowsePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.FilterIndex = 1;
            dlg.Multiselect = false;
            dlg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.bmp) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.bmp";
            dlg.ShowDialog();


            imgpath = dlg.FileName;

            if (imgpath.Length != 0)
            {
                picAgent.Image = System.Drawing.Image.FromFile(imgpath);
                if (!System.IO.File.Exists(@"..\..\Images\" + System.IO.Path.GetFileName(imgpath)))
                {
                    System.IO.File.Copy(imgpath, @"..\..\Images\" + System.IO.Path.GetFileName(imgpath));
                }
            }
            else
            {
                MessageBox.Show("Please select a valid image format.\nYou can leave it in blank for no image display.");
            }
        }
    }
}
