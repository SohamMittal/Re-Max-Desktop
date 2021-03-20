using MetroFramework;
using prjCSWinRemax.BUSINESS;
using System;
using System.Data;
using System.Windows.Forms;

namespace prjCSWinRemax.GUI
{
    public partial class frmNewClient : MetroFramework.Forms.MetroForm
    {
        private frmAdmClients frm1;
        public frmNewClient(frmAdmClients frm)
        {
            InitializeComponent();
            frm1 = frm;
        }


        public string imgpath;
        public int refnumber;
        public int refagent;

        private void frmNewClient_Load(object sender, EventArgs e)
        {            
            this.clientsTableAdapter.Fill(this.remaxDatabaseDataSet.Clients);
            this.employeesTableAdapter.Fill(this.remaxDatabaseDataSet.Employees);
            picAgent.SizeMode = PictureBoxSizeMode.StretchImage;
            imgpath = @"..\..\Images\sorry.png";
            refnumber = 0;

            if (clsGlobal.mode == "edit")
            {
                if (frm1.grdResult.SelectedRows.Count <= 0)
                {
                    MetroMessageBox.Show(this, "You did not select any client to modify.\nThe form is being executed in the ADD mode.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clsGlobal.mode = "add";
                    return;
                }
                btnCreate.Text = "Confirm\nEdit";
                
                String Abcd = frm1.grdResult.SelectedRows[0].Cells[2].Value.ToString();

                foreach (DataRow Cr in remaxDatabaseDataSet.Clients.Rows)
                {
                    if (Cr.Field<String>("Phone") == Abcd)
                    {
                        this.Text = "Editing the client: " + Cr["Name"].ToString();
                        txtName.Text = Cr["Name"].ToString();
                        txtPhone.Text = Cr["Phone"].ToString();
                        txtEmail.Text = Cr["Email"].ToString();
                        cmbGender.Text = Cr["Gender"].ToString();
                        txtComment.Text = Cr["Comment"].ToString();
                        imgpath = Cr["Picture"].ToString();
                        refnumber = Convert.ToInt32(Cr["refClient"].ToString());
                        refagent = Convert.ToInt32(Cr["refEmployee"].ToString());
                        txtAddress.Text = Cr["Address"].ToString();
                        txtPassword.Text = Cr["Password"].ToString();

                        cmbAgent.SelectedValue = Cr["refEmployee"].ToString();

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
                        this.clientsTableAdapter.Insert(txtName.Text, txtPhone.Text, txtEmail.Text, txtPassword.Text, txtAddress.Text, txtComment.Text, img, cmbGender.Text, Convert.ToInt32(cmbAgent.SelectedValue.ToString()));
                       
                        frm1.clientsTableAdapter.Fill(frm1.remaxDatabaseDataSet.Clients);
                        frm1.select();
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
                        this.clientsTableAdapter.Update(txtName.Text, txtPhone.Text, txtEmail.Text, txtPassword.Text, txtAddress.Text, txtComment.Text, img, cmbGender.Text, Convert.ToInt32(cmbAgent.SelectedValue.ToString()), refnumber, refagent);


                        frm1.clientsTableAdapter.Fill(frm1.remaxDatabaseDataSet.Clients);
                        frm1.select();
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
