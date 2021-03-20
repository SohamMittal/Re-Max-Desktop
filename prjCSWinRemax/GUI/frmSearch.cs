using MetroFramework;
using System;
using System.Data;
using System.Linq;

namespace prjCSWinRemax.GUI
{
    public partial class frmSearch : MetroFramework.Forms.MetroForm
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            employeesTableAdapter.Fill(remaxDatabaseDataSet.Employees);
            housesTableAdapter.Fill(remaxDatabaseDataSet.Houses);
        }

        private void rdHouses_CheckedChanged(object sender, EventArgs e)
        {
            if (rdHouses.Checked)
            {
                var Employees = from DataRow Cr in remaxDatabaseDataSet.Houses.Rows
                                select new
                                {
                                    ID = Cr.Field<Int32>("refHouse"),
                                    Bathrooms = Cr.Field<string>("Bathrooms"),
                                    Bedrooms = Cr.Field<string>("Bedrooms"),
                                    Rooms = Cr.Field<string>("NumberOfRooms"),
                                    Area = Cr.Field<string>("LivingArea"),
                                    Parking = Cr.Field<string>("ParkingSpot"),
                                    BuiltDate = Cr.Field<string>("BuiltDate"),
                                    Price = Cr.Field<string>("Price"),
                                    Address = Cr.Field<string>("Address"),
                                    Comment = Cr.Field<string>("Comments")
                                };
                grdResult.DataSource = Employees.ToList();
            }
        }

        private void rdAgents_CheckedChanged(object sender, EventArgs e)
        {
            if (rdAgents.Checked)
            {
                var Employees = from DataRow Cr in remaxDatabaseDataSet.Employees.Rows
                              select new
                              {
                                  ID = Cr.Field<Int32>("RefEmployee"),
                                  Name = Cr.Field<string>("Name"),
                                  Phone = Cr.Field<string>("Phone"),
                                  Email = Cr.Field<string>("Email"),
                                  Gender = Cr.Field<string>("Gender"),
                                  Position = Cr.Field<string>("Position"),
                                  Comment = Cr.Field<string>("Comment")
                              };                
                grdResult.DataSource = Employees.ToList();                
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rdAgents.Checked)
            {
                if (txtKeyword.Text != "")
                {
                     var Employees = from DataRow Cr in remaxDatabaseDataSet.Employees.Rows
                                        where (
                                        Convert.ToString(Cr.Field<Int32>("refEmployee")).Contains(txtKeyword.Text) ||
                                        Cr.Field<string>("name").Contains(txtKeyword.Text) ||
                                        Cr.Field<string>("phone").Contains(txtKeyword.Text) ||
                                        Cr.Field<string>("gender").Contains(txtKeyword.Text) ||
                                        Cr.Field<string>("email").Contains(txtKeyword.Text) ||
                                        Cr.Field<string>("position").Contains(txtKeyword.Text) ||
                                        Cr.Field<string>("comment").Contains(txtKeyword.Text)
                                        )
                                        select new
                                        {
                                            ID = Cr.Field<Int32>("RefEmployee"),
                                            Name = Cr.Field<string>("Name"),
                                            Phone = Cr.Field<string>("Phone"),
                                            Email = Cr.Field<string>("Email"),
                                            Gender = Cr.Field<string>("Gender"),
                                            Position = Cr.Field<string>("Position"),
                                            Comment = Cr.Field<string>("Comment")
                                        };
                        grdResult.DataSource = Employees.ToList();
                }     
                else
                {
                    var Employees = from DataRow Cr in remaxDatabaseDataSet.Employees.Rows
                                    select new
                                    {
                                        ID = Cr.Field<Int32>("RefEmployee"),
                                        Name = Cr.Field<string>("Name"),
                                        Phone = Cr.Field<string>("Phone"),
                                        Email = Cr.Field<string>("Email"),
                                        Gender = Cr.Field<string>("Gender"),
                                        Position = Cr.Field<string>("Position"),
                                        Comment = Cr.Field<string>("Comment")
                                    };
                    grdResult.DataSource = Employees.ToList();
                }
            }
            else if (rdHouses.Checked)
            {
                if (txtKeyword.Text != "")
                {
                        var Employees = from DataRow Cr in remaxDatabaseDataSet.Houses.Rows
                                        where (
                                        Convert.ToString(Cr.Field<Int32>("refHouse")).Contains(txtKeyword.Text) ||
                                        Cr.Field<string>("Bathrooms").Contains(txtKeyword.Text) ||
                                        Cr.Field<string>("Bedrooms").Contains(txtKeyword.Text) ||
                                        Cr.Field<string>("NumberOfRooms").Contains(txtKeyword.Text) ||
                                        Cr.Field<string>("LivingArea").Contains(txtKeyword.Text) ||
                                        Cr.Field<string>("ParkingSpot").Contains(txtKeyword.Text) ||
                                        Cr.Field<string>("BuiltDate").Contains(txtKeyword.Text) ||
                                        Cr.Field<string>("Price").Contains(txtKeyword.Text) ||
                                        Cr.Field<string>("Address").Contains(txtKeyword.Text)  ||
                                        Cr.Field<string>("Comments").Contains(txtKeyword.Text)
                                        )
                                        select new
                                        {
                                            ID = Cr.Field<Int32>("refHouse"),
                                            Bathrooms = Cr.Field<string>("Bathrooms"),
                                            Bedrooms = Cr.Field<string>("Bedrooms"),
                                            Rooms = Cr.Field<string>("NumberOfRooms"),
                                            Area = Cr.Field<string>("LivingArea"),
                                            Parking = Cr.Field<string>("ParkingSpot"),
                                            BuiltDate = Cr.Field<string>("BuiltDate"),
                                            Price = Cr.Field<string>("Price"),
                                            Address = Cr.Field<string>("Address"),
                                            Comment = Cr.Field<string>("Comments")
                                        };
                        grdResult.DataSource = Employees.ToList();
                }
                else
                {
                    var Employees = from DataRow Cr in remaxDatabaseDataSet.Houses.Rows
                                    select new
                                    {
                                        ID = Cr.Field<Int32>("refHouse"),
                                        Bathrooms = Cr.Field<string>("Bathrooms"),
                                        Bedrooms = Cr.Field<string>("Bedrooms"),
                                        Rooms = Cr.Field<string>("NumberOfRooms"),
                                        Area = Cr.Field<string>("LivingArea"),
                                        Parking = Cr.Field<string>("ParkingSpot"),
                                        BuiltDate = Cr.Field<string>("BuiltDate"),
                                        Price = Cr.Field<string>("Price"),
                                        Address = Cr.Field<string>("Address"),
                                        Comment = Cr.Field<string>("Comments")
                                    };
                    grdResult.DataSource = Employees.ToList();
                }
            }

            else
            {
                MetroMessageBox.Show(this, "Please select either Houses or Agents to search from.");
            }
        }

        private void btnMoreInfo_Click(object sender, EventArgs e)
        {
            if (rdAgents.Checked)
            {
                frmAgentInfo ab = new frmAgentInfo(this);
                ab.Show();
            }

            if (rdHouses.Checked)
            {
                frmHousesInfo ab = new frmHousesInfo(this);
                ab.Show();
            }
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            if (rdAgents.Checked)
            {
                if (txtKeyword.Text != "")
                {
                    var Employees = from DataRow Cr in remaxDatabaseDataSet.Employees.Rows
                                    where (
                                    Convert.ToString(Cr.Field<Int32>("refEmployee")).Contains(txtKeyword.Text) ||
                                    Cr.Field<string>("name").Contains(txtKeyword.Text) ||
                                    Cr.Field<string>("phone").Contains(txtKeyword.Text) ||
                                    Cr.Field<string>("gender").Contains(txtKeyword.Text) ||
                                    Cr.Field<string>("email").Contains(txtKeyword.Text) ||
                                    Cr.Field<string>("position").Contains(txtKeyword.Text) ||
                                    Cr.Field<string>("comment").Contains(txtKeyword.Text)
                                    )
                                    select new
                                    {
                                        ID = Cr.Field<Int32>("RefEmployee"),
                                        Name = Cr.Field<string>("Name"),
                                        Phone = Cr.Field<string>("Phone"),
                                        Email = Cr.Field<string>("Email"),
                                        Gender = Cr.Field<string>("Gender"),
                                        Position = Cr.Field<string>("Position"),
                                        Comment = Cr.Field<string>("Comment")
                                    };
                    grdResult.DataSource = Employees.ToList();
                }
                else
                {
                    var Employees = from DataRow Cr in remaxDatabaseDataSet.Employees.Rows
                                    select new
                                    {
                                        ID = Cr.Field<Int32>("RefEmployee"),
                                        Name = Cr.Field<string>("Name"),
                                        Phone = Cr.Field<string>("Phone"),
                                        Email = Cr.Field<string>("Email"),
                                        Gender = Cr.Field<string>("Gender"),
                                        Position = Cr.Field<string>("Position"),
                                        Comment = Cr.Field<string>("Comment")
                                    };
                    grdResult.DataSource = Employees.ToList();
                }
            }
            else if (rdHouses.Checked)
            {
                if (txtKeyword.Text != "")
                {
                    var Employees = from DataRow Cr in remaxDatabaseDataSet.Houses.Rows
                                    where (
                                    Convert.ToString(Cr.Field<Int32>("refHouse")).Contains(txtKeyword.Text) ||
                                    Cr.Field<string>("Bathrooms").Contains(txtKeyword.Text) ||
                                    Cr.Field<string>("Bedrooms").Contains(txtKeyword.Text) ||
                                    Cr.Field<string>("NumberOfRooms").Contains(txtKeyword.Text) ||
                                    Cr.Field<string>("LivingArea").Contains(txtKeyword.Text) ||
                                    Cr.Field<string>("ParkingSpot").Contains(txtKeyword.Text) ||
                                    Cr.Field<string>("BuiltDate").Contains(txtKeyword.Text) ||
                                    Cr.Field<string>("Price").Contains(txtKeyword.Text) ||
                                    Cr.Field<string>("Address").Contains(txtKeyword.Text) ||
                                    Cr.Field<string>("Comments").Contains(txtKeyword.Text)
                                    )
                                    select new
                                    {
                                        ID = Cr.Field<Int32>("refHouse"),
                                        Bathrooms = Cr.Field<string>("Bathrooms"),
                                        Bedrooms = Cr.Field<string>("Bedrooms"),
                                        Rooms = Cr.Field<string>("NumberOfRooms"),
                                        Area = Cr.Field<string>("LivingArea"),
                                        Parking = Cr.Field<string>("ParkingSpot"),
                                        BuiltDate = Cr.Field<string>("BuiltDate"),
                                        Price = Cr.Field<string>("Price"),
                                        Address = Cr.Field<string>("Address"),
                                        Comment = Cr.Field<string>("Comments")
                                    };
                    grdResult.DataSource = Employees.ToList();
                }
                else
                {
                    var Employees = from DataRow Cr in remaxDatabaseDataSet.Houses.Rows
                                    select new
                                    {
                                        ID = Cr.Field<Int32>("refHouse"),
                                        Bathrooms = Cr.Field<string>("Bathrooms"),
                                        Bedrooms = Cr.Field<string>("Bedrooms"),
                                        Rooms = Cr.Field<string>("NumberOfRooms"),
                                        Area = Cr.Field<string>("LivingArea"),
                                        Parking = Cr.Field<string>("ParkingSpot"),
                                        BuiltDate = Cr.Field<string>("BuiltDate"),
                                        Price = Cr.Field<string>("Price"),
                                        Address = Cr.Field<string>("Address"),
                                        Comment = Cr.Field<string>("Comments")
                                    };
                    grdResult.DataSource = Employees.ToList();
                }
            }
        }
    }
}
