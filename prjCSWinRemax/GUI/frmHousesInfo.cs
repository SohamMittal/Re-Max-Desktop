using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace prjCSWinRemax.GUI
{
    public partial class frmHousesInfo : MetroFramework.Forms.MetroForm
    {
        private frmAdmHouses frm1;

        public frmHousesInfo(frmAdmHouses frm)
        {
            InitializeComponent();
            frm1 = frm;
        }

        private frmSearch frm2;
        public frmHousesInfo(frmSearch frm)
        {
            InitializeComponent();
            frm2 = frm;
        }

        public int refHouse;

        public string Abcd;

        private void frmHousesInfo_Load(object sender, EventArgs e)
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

            if (Application.OpenForms.OfType<frmAdmHouses>().Count() == 1)
            {
                Abcd = frm1.grdResult.SelectedRows[0].Cells[8].Value.ToString();
            }
            if (Application.OpenForms.OfType<frmSearch>().Count() == 1)
            {
                Abcd = frm2.grdResult.SelectedRows[0].Cells[8].Value.ToString();
            }
            foreach (DataRow Cr in remaxDatabaseDataSet.Houses.Rows)
                {
                    if (Cr.Field<String>("Address") == Abcd)
                    {
                        refHouse = Convert.ToInt32(Cr["refHouse"].ToString());
                        this.Text = "Info on house: " + Cr["Address"].ToString();
                        cmbListing.SelectedValue = Cr["refListing"].ToString();
                        cmbType.SelectedValue = Cr["refType"].ToString();
                        cmbClient.SelectedValue = Cr["refClient"].ToString();
                        cmbEmployee.SelectedValue = Cr["refEmployee"].ToString();
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
        private void listPic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPic.SelectedItems.Count > 0)
            {
                int listSelect = listPic.SelectedIndices[0];
                picHouse.Image = System.Drawing.Image.FromFile(@"..\..\Images\" + listPic.Items[listSelect].SubItems[0].Text);
            }
        }
    }
}
