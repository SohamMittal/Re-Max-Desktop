namespace prjCSWinRemax.GUI
{
    partial class frmHouseAddEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHouseAddEdit));
            this.cmbEmployee = new MetroFramework.Controls.MetroComboBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remaxDatabaseDataSet = new prjCSWinRemax.RemaxDatabaseDataSet();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cmbListing = new MetroFramework.Controls.MetroComboBox();
            this.listingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cmbType = new MetroFramework.Controls.MetroComboBox();
            this.houseTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cmbClient = new MetroFramework.Controls.MetroComboBox();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cmbBathroom = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cmbBedroom = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.cmbTotalRoom = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.cmbParkingSpot = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.cmbDate = new MetroFramework.Controls.MetroDateTime();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.txtComment = new MetroFramework.Controls.MetroTextBox();
            this.txtLivingArea = new MetroFramework.Controls.MetroTextBox();
            this.txtPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.btnRemImage = new MetroFramework.Controls.MetroButton();
            this.btnAddImage = new MetroFramework.Controls.MetroButton();
            this.picHouse = new System.Windows.Forms.PictureBox();
            this.btnDeleteFeature = new MetroFramework.Controls.MetroButton();
            this.btnAddFeature = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnCreate = new MetroFramework.Controls.MetroButton();
            this.listSkills = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbSkill = new MetroFramework.Controls.MetroComboBox();
            this.featuresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.listPic = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.housesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.housesTableAdapter = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.HousesTableAdapter();
            this.tableAdapterManager = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.TableAdapterManager();
            this.picturesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.picturesTableAdapter = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.PicturesTableAdapter();
            this.housesFeaturesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.housesFeaturesTableAdapter = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.HousesFeaturesTableAdapter();
            this.employeesTableAdapter = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.EmployeesTableAdapter();
            this.clientsTableAdapter = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.ClientsTableAdapter();
            this.listingTableAdapter = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.ListingTableAdapter();
            this.houseTypeTableAdapter = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.HouseTypeTableAdapter();
            this.featuresTableAdapter = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.FeaturesTableAdapter();
            this.housesPicturesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.housesPicturesTableAdapter = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.HousesPicturesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remaxDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.featuresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.housesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.housesFeaturesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.housesPicturesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.DataSource = this.employeesBindingSource;
            this.cmbEmployee.DisplayMember = "Name";
            this.cmbEmployee.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.ItemHeight = 19;
            this.cmbEmployee.Location = new System.Drawing.Point(134, 61);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(206, 25);
            this.cmbEmployee.TabIndex = 0;
            this.cmbEmployee.UseSelectable = true;
            this.cmbEmployee.ValueMember = "refEmployee";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.remaxDatabaseDataSet;
            // 
            // remaxDatabaseDataSet
            // 
            this.remaxDatabaseDataSet.DataSetName = "RemaxDatabaseDataSet";
            this.remaxDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(105, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Agent in charge:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 129);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Listing for:";
            // 
            // cmbListing
            // 
            this.cmbListing.DataSource = this.listingBindingSource;
            this.cmbListing.DisplayMember = "ListingStatus";
            this.cmbListing.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbListing.FormattingEnabled = true;
            this.cmbListing.ItemHeight = 19;
            this.cmbListing.Location = new System.Drawing.Point(134, 123);
            this.cmbListing.Name = "cmbListing";
            this.cmbListing.Size = new System.Drawing.Size(206, 25);
            this.cmbListing.TabIndex = 2;
            this.cmbListing.UseSelectable = true;
            this.cmbListing.ValueMember = "refListing";
            // 
            // listingBindingSource
            // 
            this.listingBindingSource.DataMember = "Listing";
            this.listingBindingSource.DataSource = this.remaxDatabaseDataSet;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 160);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(77, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "House type:";
            // 
            // cmbType
            // 
            this.cmbType.DataSource = this.houseTypeBindingSource;
            this.cmbType.DisplayMember = "TypeName";
            this.cmbType.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.ItemHeight = 19;
            this.cmbType.Location = new System.Drawing.Point(134, 154);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(206, 25);
            this.cmbType.TabIndex = 4;
            this.cmbType.UseSelectable = true;
            this.cmbType.ValueMember = "refType";
            // 
            // houseTypeBindingSource
            // 
            this.houseTypeBindingSource.DataMember = "HouseType";
            this.houseTypeBindingSource.DataSource = this.remaxDatabaseDataSet;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 98);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(103, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Client in charge:";
            // 
            // cmbClient
            // 
            this.cmbClient.DataSource = this.clientsBindingSource;
            this.cmbClient.DisplayMember = "Name";
            this.cmbClient.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.ItemHeight = 19;
            this.cmbClient.Location = new System.Drawing.Point(134, 92);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(206, 25);
            this.cmbClient.TabIndex = 6;
            this.cmbClient.UseSelectable = true;
            this.cmbClient.ValueMember = "refClient";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.remaxDatabaseDataSet;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 191);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(76, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Bathrooms:";
            // 
            // cmbBathroom
            // 
            this.cmbBathroom.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbBathroom.FormattingEnabled = true;
            this.cmbBathroom.ItemHeight = 19;
            this.cmbBathroom.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5 or more"});
            this.cmbBathroom.Location = new System.Drawing.Point(134, 185);
            this.cmbBathroom.Name = "cmbBathroom";
            this.cmbBathroom.Size = new System.Drawing.Size(206, 25);
            this.cmbBathroom.TabIndex = 8;
            this.cmbBathroom.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 435);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(101, 19);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "House Features:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(23, 222);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(73, 19);
            this.metroLabel7.TabIndex = 15;
            this.metroLabel7.Text = "Bedrooms:";
            // 
            // cmbBedroom
            // 
            this.cmbBedroom.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbBedroom.FormattingEnabled = true;
            this.cmbBedroom.ItemHeight = 19;
            this.cmbBedroom.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5 or more"});
            this.cmbBedroom.Location = new System.Drawing.Point(134, 216);
            this.cmbBedroom.Name = "cmbBedroom";
            this.cmbBedroom.Size = new System.Drawing.Size(206, 25);
            this.cmbBedroom.TabIndex = 14;
            this.cmbBedroom.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(23, 253);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(81, 19);
            this.metroLabel8.TabIndex = 17;
            this.metroLabel8.Text = "Total rooms:";
            // 
            // cmbTotalRoom
            // 
            this.cmbTotalRoom.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbTotalRoom.FormattingEnabled = true;
            this.cmbTotalRoom.ItemHeight = 19;
            this.cmbTotalRoom.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10 or more"});
            this.cmbTotalRoom.Location = new System.Drawing.Point(134, 247);
            this.cmbTotalRoom.Name = "cmbTotalRoom";
            this.cmbTotalRoom.Size = new System.Drawing.Size(206, 25);
            this.cmbTotalRoom.TabIndex = 16;
            this.cmbTotalRoom.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(23, 284);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(84, 19);
            this.metroLabel9.TabIndex = 19;
            this.metroLabel9.Text = "Parking spot:";
            // 
            // cmbParkingSpot
            // 
            this.cmbParkingSpot.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbParkingSpot.FormattingEnabled = true;
            this.cmbParkingSpot.ItemHeight = 19;
            this.cmbParkingSpot.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5 or more"});
            this.cmbParkingSpot.Location = new System.Drawing.Point(134, 278);
            this.cmbParkingSpot.Name = "cmbParkingSpot";
            this.cmbParkingSpot.Size = new System.Drawing.Size(206, 25);
            this.cmbParkingSpot.TabIndex = 18;
            this.cmbParkingSpot.UseSelectable = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(23, 313);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(75, 19);
            this.metroLabel10.TabIndex = 21;
            this.metroLabel10.Text = "Living area:";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(23, 344);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(67, 19);
            this.metroLabel11.TabIndex = 23;
            this.metroLabel11.Text = "Built date:";
            // 
            // cmbDate
            // 
            this.cmbDate.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.cmbDate.Location = new System.Drawing.Point(134, 338);
            this.cmbDate.MinimumSize = new System.Drawing.Size(0, 25);
            this.cmbDate.Name = "cmbDate";
            this.cmbDate.Size = new System.Drawing.Size(205, 25);
            this.cmbDate.TabIndex = 24;
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.CustomButton.Image = null;
            this.txtAddress.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txtAddress.CustomButton.Name = "";
            this.txtAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddress.CustomButton.TabIndex = 1;
            this.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress.CustomButton.UseSelectable = true;
            this.txtAddress.CustomButton.Visible = false;
            this.txtAddress.DisplayIcon = true;
            this.txtAddress.Lines = new string[0];
            this.txtAddress.Location = new System.Drawing.Point(134, 369);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PromptText = "Address";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = false;
            this.txtAddress.ShowClearButton = true;
            this.txtAddress.Size = new System.Drawing.Size(206, 23);
            this.txtAddress.TabIndex = 27;
            this.txtAddress.Tag = "Address";
            this.txtAddress.UseSelectable = true;
            this.txtAddress.WaterMark = "Address";
            this.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(23, 373);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(59, 19);
            this.metroLabel12.TabIndex = 26;
            this.metroLabel12.Text = "Address:";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(369, 60);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(76, 19);
            this.metroLabel13.TabIndex = 28;
            this.metroLabel13.Text = "Comments:";
            this.metroLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtComment
            // 
            // 
            // 
            // 
            this.txtComment.CustomButton.Image = null;
            this.txtComment.CustomButton.Location = new System.Drawing.Point(419, 1);
            this.txtComment.CustomButton.Name = "";
            this.txtComment.CustomButton.Size = new System.Drawing.Size(157, 157);
            this.txtComment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtComment.CustomButton.TabIndex = 1;
            this.txtComment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtComment.CustomButton.UseSelectable = true;
            this.txtComment.CustomButton.Visible = false;
            this.txtComment.DisplayIcon = true;
            this.txtComment.Lines = new string[0];
            this.txtComment.Location = new System.Drawing.Point(369, 82);
            this.txtComment.MaxLength = 32767;
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.PasswordChar = '\0';
            this.txtComment.PromptText = "Comments";
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtComment.SelectedText = "";
            this.txtComment.SelectionLength = 0;
            this.txtComment.SelectionStart = 0;
            this.txtComment.ShortcutsEnabled = true;
            this.txtComment.ShowClearButton = true;
            this.txtComment.Size = new System.Drawing.Size(577, 159);
            this.txtComment.TabIndex = 29;
            this.txtComment.UseSelectable = true;
            this.txtComment.WaterMark = "Comments";
            this.txtComment.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtComment.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLivingArea
            // 
            // 
            // 
            // 
            this.txtLivingArea.CustomButton.Image = null;
            this.txtLivingArea.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txtLivingArea.CustomButton.Name = "";
            this.txtLivingArea.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLivingArea.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLivingArea.CustomButton.TabIndex = 1;
            this.txtLivingArea.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLivingArea.CustomButton.UseSelectable = true;
            this.txtLivingArea.CustomButton.Visible = false;
            this.txtLivingArea.DisplayIcon = true;
            this.txtLivingArea.Lines = new string[0];
            this.txtLivingArea.Location = new System.Drawing.Point(134, 309);
            this.txtLivingArea.MaxLength = 32767;
            this.txtLivingArea.Name = "txtLivingArea";
            this.txtLivingArea.PasswordChar = '\0';
            this.txtLivingArea.PromptText = "Living area";
            this.txtLivingArea.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLivingArea.SelectedText = "";
            this.txtLivingArea.SelectionLength = 0;
            this.txtLivingArea.SelectionStart = 0;
            this.txtLivingArea.ShortcutsEnabled = true;
            this.txtLivingArea.ShowClearButton = true;
            this.txtLivingArea.Size = new System.Drawing.Size(206, 23);
            this.txtLivingArea.TabIndex = 30;
            this.txtLivingArea.Tag = "Living area";
            this.txtLivingArea.UseSelectable = true;
            this.txtLivingArea.WaterMark = "Living area";
            this.txtLivingArea.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLivingArea.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPrice
            // 
            // 
            // 
            // 
            this.txtPrice.CustomButton.Image = null;
            this.txtPrice.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txtPrice.CustomButton.Name = "";
            this.txtPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrice.CustomButton.TabIndex = 1;
            this.txtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrice.CustomButton.UseSelectable = true;
            this.txtPrice.CustomButton.Visible = false;
            this.txtPrice.DisplayIcon = true;
            this.txtPrice.Lines = new string[0];
            this.txtPrice.Location = new System.Drawing.Point(134, 398);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PromptText = "Price";
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.ShortcutsEnabled = false;
            this.txtPrice.ShowClearButton = true;
            this.txtPrice.Size = new System.Drawing.Size(206, 23);
            this.txtPrice.TabIndex = 33;
            this.txtPrice.Tag = "Price";
            this.txtPrice.UseSelectable = true;
            this.txtPrice.WaterMark = "Price";
            this.txtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(23, 402);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(41, 19);
            this.metroLabel14.TabIndex = 32;
            this.metroLabel14.Text = "Price:";
            // 
            // btnRemImage
            // 
            this.btnRemImage.BackgroundImage = global::prjCSWinRemax.Properties.Resources.icons8_minus_24;
            this.btnRemImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRemImage.Location = new System.Drawing.Point(615, 262);
            this.btnRemImage.Name = "btnRemImage";
            this.btnRemImage.Size = new System.Drawing.Size(36, 36);
            this.btnRemImage.TabIndex = 35;
            this.btnRemImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemImage.UseSelectable = true;
            this.btnRemImage.Click += new System.EventHandler(this.btnRemImage_Click);
            // 
            // btnAddImage
            // 
            this.btnAddImage.BackgroundImage = global::prjCSWinRemax.Properties.Resources.icons8_plus_math_24;
            this.btnAddImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddImage.Location = new System.Drawing.Point(573, 262);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(36, 36);
            this.btnAddImage.TabIndex = 34;
            this.btnAddImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddImage.UseSelectable = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // picHouse
            // 
            this.picHouse.Location = new System.Drawing.Point(657, 262);
            this.picHouse.Name = "picHouse";
            this.picHouse.Size = new System.Drawing.Size(289, 322);
            this.picHouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHouse.TabIndex = 31;
            this.picHouse.TabStop = false;
            // 
            // btnDeleteFeature
            // 
            this.btnDeleteFeature.BackgroundImage = global::prjCSWinRemax.Properties.Resources.icons8_minus_24;
            this.btnDeleteFeature.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteFeature.Location = new System.Drawing.Point(304, 456);
            this.btnDeleteFeature.Name = "btnDeleteFeature";
            this.btnDeleteFeature.Size = new System.Drawing.Size(36, 36);
            this.btnDeleteFeature.TabIndex = 13;
            this.btnDeleteFeature.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteFeature.UseSelectable = true;
            this.btnDeleteFeature.Click += new System.EventHandler(this.btnDeleteFeature_Click);
            // 
            // btnAddFeature
            // 
            this.btnAddFeature.BackgroundImage = global::prjCSWinRemax.Properties.Resources.icons8_plus_math_24;
            this.btnAddFeature.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddFeature.Location = new System.Drawing.Point(262, 456);
            this.btnAddFeature.Name = "btnAddFeature";
            this.btnAddFeature.Size = new System.Drawing.Size(36, 36);
            this.btnAddFeature.TabIndex = 12;
            this.btnAddFeature.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddFeature.UseSelectable = true;
            this.btnAddFeature.Click += new System.EventHandler(this.btnAddFeature_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::prjCSWinRemax.Properties.Resources.icons8_delete_35;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Location = new System.Drawing.Point(819, 590);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 36);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Cancel Changes";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackgroundImage = global::prjCSWinRemax.Properties.Resources.icons8_home_35;
            this.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCreate.Location = new System.Drawing.Point(717, 590);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(96, 36);
            this.btnCreate.TabIndex = 38;
            this.btnCreate.Text = "Add New";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.UseSelectable = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // listSkills
            // 
            this.listSkills.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listSkills.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSkills.FullRowSelect = true;
            this.listSkills.GridLines = true;
            this.listSkills.Location = new System.Drawing.Point(23, 498);
            this.listSkills.MultiSelect = false;
            this.listSkills.Name = "listSkills";
            this.listSkills.Size = new System.Drawing.Size(316, 128);
            this.listSkills.TabIndex = 65;
            this.listSkills.UseCompatibleStateImageBehavior = false;
            this.listSkills.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Feature ID";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Feature Name";
            this.columnHeader2.Width = 200;
            // 
            // cmbSkill
            // 
            this.cmbSkill.DataSource = this.featuresBindingSource;
            this.cmbSkill.DisplayMember = "FeatureName";
            this.cmbSkill.FormattingEnabled = true;
            this.cmbSkill.ItemHeight = 23;
            this.cmbSkill.Location = new System.Drawing.Point(23, 463);
            this.cmbSkill.Name = "cmbSkill";
            this.cmbSkill.Size = new System.Drawing.Size(233, 29);
            this.cmbSkill.TabIndex = 64;
            this.cmbSkill.UseSelectable = true;
            this.cmbSkill.ValueMember = "refFeature";
            // 
            // featuresBindingSource
            // 
            this.featuresBindingSource.DataMember = "Features";
            this.featuresBindingSource.DataSource = this.remaxDatabaseDataSet;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(369, 262);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(97, 19);
            this.metroLabel15.TabIndex = 66;
            this.metroLabel15.Text = "House Pictures:";
            // 
            // listPic
            // 
            this.listPic.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.listPic.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPic.FullRowSelect = true;
            this.listPic.GridLines = true;
            this.listPic.Location = new System.Drawing.Point(369, 304);
            this.listPic.MultiSelect = false;
            this.listPic.Name = "listPic";
            this.listPic.Size = new System.Drawing.Size(282, 280);
            this.listPic.TabIndex = 68;
            this.listPic.UseCompatibleStateImageBehavior = false;
            this.listPic.View = System.Windows.Forms.View.Details;
            this.listPic.SelectedIndexChanged += new System.EventHandler(this.listPic_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Path";
            this.columnHeader4.Width = 75;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Added in:";
            this.columnHeader5.Width = 150;
            // 
            // housesBindingSource
            // 
            this.housesBindingSource.DataMember = "Houses";
            this.housesBindingSource.DataSource = this.remaxDatabaseDataSet;
            // 
            // housesTableAdapter
            // 
            this.housesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.EmployeeSkillsTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.FeaturesTableAdapter = null;
            this.tableAdapterManager.HousesFeaturesTableAdapter = null;
            this.tableAdapterManager.HousesPicturesTableAdapter = null;
            this.tableAdapterManager.HousesTableAdapter = this.housesTableAdapter;
            this.tableAdapterManager.HouseTypeTableAdapter = null;
            this.tableAdapterManager.ListingTableAdapter = null;
            this.tableAdapterManager.PicturesTableAdapter = null;
            this.tableAdapterManager.SkillsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // picturesBindingSource
            // 
            this.picturesBindingSource.DataMember = "Pictures";
            this.picturesBindingSource.DataSource = this.remaxDatabaseDataSet;
            // 
            // picturesTableAdapter
            // 
            this.picturesTableAdapter.ClearBeforeFill = true;
            // 
            // housesFeaturesBindingSource
            // 
            this.housesFeaturesBindingSource.DataMember = "HousesFeatures";
            this.housesFeaturesBindingSource.DataSource = this.remaxDatabaseDataSet;
            // 
            // housesFeaturesTableAdapter
            // 
            this.housesFeaturesTableAdapter.ClearBeforeFill = true;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // listingTableAdapter
            // 
            this.listingTableAdapter.ClearBeforeFill = true;
            // 
            // houseTypeTableAdapter
            // 
            this.houseTypeTableAdapter.ClearBeforeFill = true;
            // 
            // featuresTableAdapter
            // 
            this.featuresTableAdapter.ClearBeforeFill = true;
            // 
            // housesPicturesBindingSource
            // 
            this.housesPicturesBindingSource.DataMember = "HousesPictures";
            this.housesPicturesBindingSource.DataSource = this.remaxDatabaseDataSet;
            // 
            // housesPicturesTableAdapter
            // 
            this.housesPicturesTableAdapter.ClearBeforeFill = true;
            // 
            // frmHouseAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 646);
            this.Controls.Add(this.listPic);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.listSkills);
            this.Controls.Add(this.cmbSkill);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnRemImage);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.picHouse);
            this.Controls.Add(this.txtLivingArea);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.cmbDate);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.cmbParkingSpot);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.cmbTotalRoom);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.cmbBedroom);
            this.Controls.Add(this.btnDeleteFeature);
            this.Controls.Add(this.btnAddFeature);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.cmbBathroom);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cmbListing);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmbEmployee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHouseAddEdit";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Add/Edit House";
            this.Load += new System.EventHandler(this.frmHouseAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remaxDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.featuresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.housesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.housesFeaturesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.housesPicturesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbEmployee;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cmbListing;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cmbType;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cmbClient;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cmbBathroom;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton btnDeleteFeature;
        private MetroFramework.Controls.MetroButton btnAddFeature;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox cmbBedroom;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroComboBox cmbTotalRoom;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroComboBox cmbParkingSpot;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroDateTime cmbDate;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox txtComment;
        private MetroFramework.Controls.MetroTextBox txtLivingArea;
        private System.Windows.Forms.PictureBox picHouse;
        private MetroFramework.Controls.MetroTextBox txtPrice;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroButton btnRemImage;
        private MetroFramework.Controls.MetroButton btnAddImage;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnCreate;
        private System.Windows.Forms.ListView listSkills;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MetroFramework.Controls.MetroComboBox cmbSkill;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private System.Windows.Forms.ListView listPic;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private RemaxDatabaseDataSet remaxDatabaseDataSet;
        private System.Windows.Forms.BindingSource housesBindingSource;
        private RemaxDatabaseDataSetTableAdapters.HousesTableAdapter housesTableAdapter;
        private RemaxDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource picturesBindingSource;
        private RemaxDatabaseDataSetTableAdapters.PicturesTableAdapter picturesTableAdapter;
        private System.Windows.Forms.BindingSource housesFeaturesBindingSource;
        private RemaxDatabaseDataSetTableAdapters.HousesFeaturesTableAdapter housesFeaturesTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private RemaxDatabaseDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private RemaxDatabaseDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource listingBindingSource;
        private RemaxDatabaseDataSetTableAdapters.ListingTableAdapter listingTableAdapter;
        private System.Windows.Forms.BindingSource houseTypeBindingSource;
        private RemaxDatabaseDataSetTableAdapters.HouseTypeTableAdapter houseTypeTableAdapter;
        private System.Windows.Forms.BindingSource featuresBindingSource;
        private RemaxDatabaseDataSetTableAdapters.FeaturesTableAdapter featuresTableAdapter;
        private System.Windows.Forms.BindingSource housesPicturesBindingSource;
        private RemaxDatabaseDataSetTableAdapters.HousesPicturesTableAdapter housesPicturesTableAdapter;
    }
}