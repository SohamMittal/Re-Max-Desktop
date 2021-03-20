using MetroFramework;
using prjCSWinRemax.BUSINESS;
using System;
using System.Data;
using System.Windows.Forms;

namespace prjCSWinRemax.GUI
{

    public partial class frmHouseAddEdit : MetroFramework.Forms.MetroForm
    {

        public static string mode;

        private frmAdmHouses frm1;

        public frmHouseAddEdit(frmAdmHouses frm)
        {
            InitializeComponent();
            frm1 = frm;
        }

        public string imgpath;
        public int refHouse;
        public int refEmployee;
        public int refListing;
        public int refType;
        public int refClient;
        public string Abcd;


        private void frmHouseAddEdit_Load(object sender, EventArgs e)
        {
            this.housesPicturesTableAdapter.Fill(this.remaxDatabaseDataSet.HousesPictures);
            this.featuresTableAdapter.Fill(this.remaxDatabaseDataSet.Features);
            this.houseTypeTableAdapter.Fill(this.remaxDatabaseDataSet.HouseType);
            this.listingTableAdapter.Fill(this.remaxDatabaseDataSet.Listing);
            this.clientsTableAdapter.Fill(this.remaxDatabaseDataSet.Clients);
            this.employeesTableAdapter.Fill(this.remaxDatabaseDataSet.Employees);
            this.housesFeaturesTableAdapter.Fill(this.remaxDatabaseDataSet.HousesFeatures);
            this.picturesTableAdapter.Fill(this.remaxDatabaseDataSet.Pictures);
            this.housesTableAdapter.Fill(this.remaxDatabaseDataSet.Houses);
            if (clsGlobal.mode == "edit")
            {
                if (frm1.grdResult.SelectedRows.Count <= 0)
                {
                    MetroMessageBox.Show(this, "You did not select any house to modify.\nThe form is being executed in the ADD mode.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clsGlobal.mode = "add";
                    return;
                }

                Abcd = frm1.grdResult.SelectedRows[0].Cells[8].Value.ToString();

                foreach (DataRow Cr in remaxDatabaseDataSet.Houses.Rows)
                {
                    if (Cr.Field<String>("Address") == Abcd)
                    {
                        refHouse = Convert.ToInt32(Cr["refHouse"].ToString());
                        refEmployee = Convert.ToInt32(Cr["refEmployee"].ToString());
                        refListing = Convert.ToInt32(Cr["refListing"].ToString());
                        refType = Convert.ToInt32(Cr["refType"].ToString());
                        refClient = Convert.ToInt32(Cr["refClient"].ToString());

                        this.Text = "Editing the house: " + Cr["Address"].ToString();
                        btnCreate.Text = "Confirm\nEdit";
                        cmbEmployee.SelectedValue = Cr["refEmployee"].ToString();
                        cmbListing.SelectedValue = Cr["refListing"].ToString();
                        cmbType.SelectedValue = Cr["refType"].ToString();
                        cmbClient.SelectedValue = Cr["refClient"].ToString();
                        cmbBathroom.Text = Cr["Bathrooms"].ToString();
                        cmbTotalRoom.Text = Cr["NumberOfRooms"].ToString();
                        txtLivingArea.Text = Cr["LivingArea"].ToString();
                        cmbParkingSpot.Text = Cr["ParkingSpot"].ToString();
                        cmbDate.Text = Cr["BuiltDate"].ToString();
                        txtAddress.Text = Cr["Address"].ToString();
                        cmbBedroom.Text = Cr["Bedrooms"].ToString();
                        txtComment.Text = Cr["Comments"].ToString();
                        txtPrice.Text = Cr["Price"].ToString();
                    }
                }
                foreach (DataRow ab in remaxDatabaseDataSet.HousesFeatures.Rows)
                {
                    if (ab.Field<Int32>("refHouse") == refHouse)
                    {
                        foreach (DataRow cd in remaxDatabaseDataSet.Features.Rows)
                        {
                            if (ab.Field<Int32>("refFeature") == cd.Field<Int32>("refFeature"))
                            {
                                string[] row = { ab.Field<Int32>("refFeature").ToString(), cd.Field<String>("FeatureName") };
                                var listViewItem = new ListViewItem(row);
                                listSkills.Items.Add(listViewItem);
                            }
                        }
                    }
                }
                foreach (DataRow ab in remaxDatabaseDataSet.HousesPictures.Rows)
                {
                    if (ab.Field<Int32>("refHouse") == refHouse)
                    {
                        foreach (DataRow cd in remaxDatabaseDataSet.Pictures.Rows)
                        {
                            if (ab.Field<Int32>("refPicture") == cd.Field<Int32>("refPicture"))
                            {
                                string[] row = { cd.Field<String>("PicturePath").ToString(), cd.Field<String>("PictureComment") };
                                var listViewItem = new ListViewItem(row);
                                listPic.Items.Add(listViewItem);
                            }
                        }
                    }
                }
            }            
        }

        private void btnAddFeature_Click(object sender, EventArgs e)
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

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.FilterIndex = 1;
            dlg.Multiselect = false;
            dlg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.bmp) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.bmp";
            dlg.ShowDialog();

            imgpath = dlg.FileName;

            if (imgpath.Length != 0)
            {
                picHouse.Image = System.Drawing.Image.FromFile(imgpath);
                if (!System.IO.File.Exists(@"..\..\Images\" + System.IO.Path.GetFileName(imgpath)))
                {
                    System.IO.File.Copy(imgpath, @"..\..\Images\" + System.IO.Path.GetFileName(imgpath));
                }
                string[] row = { System.IO.Path.GetFileName(imgpath), DateTime.Now.ToString() };
                var listViewItem = new ListViewItem(row);
                listPic.Items.Add(listViewItem);
            }
            else
            {
                MetroMessageBox.Show(this,"Please select a valid image format.\nYou can leave it in blank for no image display.");
            }           
    }

        private void btnRemImage_Click(object sender, EventArgs e)
        {
            if (listPic.SelectedItems.Count > 0)
            {
                int listSelect = listPic.SelectedIndices[0];
                var confirmResult = MetroMessageBox.Show(this, "Are you sure to delete this picture ?", "Confirm Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (confirmResult == DialogResult.Yes)
                {
                    this.listPic.Items.RemoveAt(listSelect);
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Please select a picture before deleting.", "Delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listPic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPic.SelectedItems.Count > 0)
            {
                int listSelect = listPic.SelectedIndices[0];
                picHouse.Image = System.Drawing.Image.FromFile(@"..\..\Images\" + listPic.Items[listSelect].SubItems[0].Text);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            if (clsGlobal.mode == "add")
            {
                try
                {
                    int id = 0;

                    this.housesTableAdapter.Insert(Convert.ToInt32(cmbEmployee.SelectedValue.ToString()),
                                                    Convert.ToInt32(cmbListing.SelectedValue.ToString()),
                                                    Convert.ToInt32(cmbType.SelectedValue.ToString()),
                                                    Convert.ToInt32(cmbClient.SelectedValue.ToString()),
                                                    cmbBathroom.Text,
                                                    cmbTotalRoom.Text,
                                                    txtLivingArea.Text,
                                                    cmbParkingSpot.Text,
                                                    cmbDate.Text,
                                                    txtAddress.Text,
                                                    cmbBedroom.Text,
                                                    txtComment.Text,
                                                    txtPrice.Text);

                    if (listPic.Items.Count > 0)
                    {
                        foreach (ListViewItem itn in listPic.Items)
                        {
                            this.picturesTableAdapter.Insert(itn.SubItems[0].Text, itn.SubItems[1].Text);
                        }
                    }

                    RemaxDatabaseDataSet dvx = new RemaxDatabaseDataSet();
                    RemaxDatabaseDataSetTableAdapters.HousesTableAdapter emp = new RemaxDatabaseDataSetTableAdapters.HousesTableAdapter();

                    emp.Fill(dvx.Houses);

                    int xd = -1;

                    foreach (DataRow ab in dvx.Houses)
                    {
                        if (ab["Address"].ToString() == txtAddress.Text)
                        {
                            xd = Convert.ToInt32(ab["refHouse"].ToString());
                        }
                    }

                    RemaxDatabaseDataSet data = new RemaxDatabaseDataSet();
                    RemaxDatabaseDataSetTableAdapters.PicturesTableAdapter empadapt = new RemaxDatabaseDataSetTableAdapters.PicturesTableAdapter();

                    empadapt.Fill(data.Pictures);

                    foreach (DataRow ab in data.Pictures)
                    {
                        foreach (ListViewItem itn in listPic.Items)
                        {
                            if (itn.SubItems[0].Text == ab["PicturePath"].ToString()
                                && itn.SubItems[1].Text == ab["PictureComment"].ToString())
                            {
                                id = Convert.ToInt32(ab["refPicture"].ToString());
                                this.housesPicturesTableAdapter.Insert(xd, id);
                            }
                        }
                    }

                    if (listSkills.Items.Count > 0)
                    {
                        foreach (ListViewItem itn in listSkills.Items)
                        {
                            this.housesFeaturesTableAdapter.Insert(xd, Convert.ToInt32(itn.SubItems[0].Text));
                        }
                    }

                    frm1.housesTableAdapter1.Fill(frm1.remaxDatabaseDataSet1.Houses);
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
                    int id = 0;

                    this.housesTableAdapter.Update(Convert.ToInt32(cmbEmployee.SelectedValue.ToString()),
                                                    Convert.ToInt32(cmbListing.SelectedValue.ToString()),
                                                    Convert.ToInt32(cmbType.SelectedValue.ToString()),
                                                    Convert.ToInt32(cmbClient.SelectedValue.ToString()),
                                                    cmbBathroom.Text,
                                                    cmbTotalRoom.Text,
                                                    txtLivingArea.Text,
                                                    cmbParkingSpot.Text,
                                                    cmbDate.Text,
                                                    txtAddress.Text,
                                                    cmbBedroom.Text,
                                                    txtComment.Text,
                                                    txtPrice.Text,
                                                    refHouse,
                                                    refEmployee,
                                                    refListing,
                                                    refType,
                                                    refClient);


                    foreach (DataRow ab in remaxDatabaseDataSet.HousesPictures.Rows)
                    {
                        if (ab.Field<Int32>("refHouse") == refHouse)
                        {
                            this.housesPicturesTableAdapter.Delete(refHouse, ab.Field<Int32>("refPicture"));
                            this.picturesTableAdapter.Delete(ab.Field<Int32>("refPicture"));
                        }                        
                    }

                    if (listPic.Items.Count > 0)
                    {
                        foreach (ListViewItem itn in listPic.Items)
                        {
                            this.picturesTableAdapter.Insert(itn.SubItems[0].Text, itn.SubItems[1].Text);
                        }
                    }
                    picturesTableAdapter.Fill(remaxDatabaseDataSet.Pictures);

                    RemaxDatabaseDataSet data = new RemaxDatabaseDataSet();
                    RemaxDatabaseDataSetTableAdapters.PicturesTableAdapter empadapt = new RemaxDatabaseDataSetTableAdapters.PicturesTableAdapter();

                    empadapt.Fill(data.Pictures);

                    foreach (DataRow ab in data.Pictures)
                    {
                        foreach (ListViewItem itn in listPic.Items)
                        {
                            if(itn.SubItems[0].Text == ab["PicturePath"].ToString()
                                && itn.SubItems[1].Text == ab["PictureComment"].ToString())
                            {
                                id = Convert.ToInt32(ab["refPicture"].ToString());
                                this.housesPicturesTableAdapter.Insert(refHouse, id);
                            }
                        }
                    }

                    housesPicturesTableAdapter.Fill(remaxDatabaseDataSet.HousesPictures);
                    frm1.housesTableAdapter1.Fill(frm1.remaxDatabaseDataSet1.Houses);

                    if (listSkills.Items.Count > 0)
                    {

                        foreach (DataRow ab in remaxDatabaseDataSet.HousesFeatures.Rows)
                        {
                            if (ab.Field<Int32>("refHouse") == refHouse)
                            {
                                this.housesFeaturesTableAdapter.Delete(refHouse, ab.Field<Int32>("refFeature"));
                            }
                        }
                        housesFeaturesTableAdapter.Fill(remaxDatabaseDataSet.HousesFeatures);
                        foreach (ListViewItem itn in listSkills.Items)
                        {
                            this.housesFeaturesTableAdapter.Insert(refHouse, Convert.ToInt32(itn.SubItems[0].Text));
                        }
                    }

                    housesPicturesTableAdapter.Fill(remaxDatabaseDataSet.HousesPictures);
                    frm1.housesTableAdapter1.Fill(frm1.remaxDatabaseDataSet1.Houses);
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

        private void btnDeleteFeature_Click(object sender, EventArgs e)
        {
            if (listSkills.SelectedItems.Count > 0)
            {
                int listSelect = listSkills.SelectedIndices[0];
                var confirmResult = MetroMessageBox.Show(this, "Are you sure to delete this item ?", "Confirm Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (confirmResult == DialogResult.Yes)
                {
                    this.listSkills.Items.RemoveAt(listSelect);
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Please a feature before deleting.", "Delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MetroMessageBox.Show(this, "Are you sure to close this form ?", "Confirm Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
