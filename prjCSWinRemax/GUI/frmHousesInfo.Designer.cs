namespace prjCSWinRemax.GUI
{
    partial class frmHousesInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHousesInfo));
            this.housesPicturesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remaxDatabaseDataSet = new prjCSWinRemax.RemaxDatabaseDataSet();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.featuresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.housesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.housesTableAdapter = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.HousesTableAdapter();
            this.tableAdapterManager = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.TableAdapterManager();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.picturesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.housesFeaturesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.housesFeaturesTableAdapter = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.HousesFeaturesTableAdapter();
            this.employeesTableAdapter = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.EmployeesTableAdapter();
            this.clientsTableAdapter = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.ClientsTableAdapter();
            this.listingTableAdapter = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.ListingTableAdapter();
            this.houseTypeTableAdapter = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.HouseTypeTableAdapter();
            this.featuresTableAdapter = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.FeaturesTableAdapter();
            this.picturesTableAdapter = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.PicturesTableAdapter();
            this.housesPicturesTableAdapter = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.HousesPicturesTableAdapter();
            this.listPic = new System.Windows.Forms.ListView();
            this.listSkills = new System.Windows.Forms.ListView();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.houseTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.txtPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.picHouse = new System.Windows.Forms.PictureBox();
            this.txtLivingArea = new MetroFramework.Controls.MetroTextBox();
            this.txtComment = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.cmbDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.cmbParkingSpot = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.cmbTotalRoom = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cmbBedroom = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cmbBathroom = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cmbClient = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cmbType = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cmbListing = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbEmployee = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.housesPicturesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remaxDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.featuresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.housesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.housesFeaturesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHouse)).BeginInit();
            this.SuspendLayout();
            // 
            // housesPicturesBindingSource
            // 
            this.housesPicturesBindingSource.DataMember = "HousesPictures";
            this.housesPicturesBindingSource.DataSource = this.remaxDatabaseDataSet;
            // 
            // remaxDatabaseDataSet
            // 
            this.remaxDatabaseDataSet.DataSetName = "RemaxDatabaseDataSet";
            this.remaxDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Feature Name";
            this.columnHeader2.Width = 200;
            // 
            // featuresBindingSource
            // 
            this.featuresBindingSource.DataMember = "Features";
            this.featuresBindingSource.DataSource = this.remaxDatabaseDataSet;
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
            // columnHeader1
            // 
            this.columnHeader1.Text = "Feature ID";
            this.columnHeader1.Width = 80;
            // 
            // picturesBindingSource
            // 
            this.picturesBindingSource.DataMember = "Pictures";
            this.picturesBindingSource.DataSource = this.remaxDatabaseDataSet;
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
            // picturesTableAdapter
            // 
            this.picturesTableAdapter.ClearBeforeFill = true;
            // 
            // housesPicturesTableAdapter
            // 
            this.housesPicturesTableAdapter.ClearBeforeFill = true;
            // 
            // listPic
            // 
            this.listPic.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.listPic.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPic.FullRowSelect = true;
            this.listPic.GridLines = true;
            this.listPic.HideSelection = false;
            this.listPic.Location = new System.Drawing.Point(499, 348);
            this.listPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listPic.MultiSelect = false;
            this.listPic.Name = "listPic";
            this.listPic.Size = new System.Drawing.Size(375, 368);
            this.listPic.TabIndex = 106;
            this.listPic.UseCompatibleStateImageBehavior = false;
            this.listPic.View = System.Windows.Forms.View.Details;
            this.listPic.SelectedIndexChanged += new System.EventHandler(this.listPic_SelectedIndexChanged);
            // 
            // listSkills
            // 
            this.listSkills.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listSkills.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSkills.FullRowSelect = true;
            this.listSkills.GridLines = true;
            this.listSkills.HideSelection = false;
            this.listSkills.Location = new System.Drawing.Point(39, 561);
            this.listSkills.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listSkills.MultiSelect = false;
            this.listSkills.Name = "listSkills";
            this.listSkills.Size = new System.Drawing.Size(420, 157);
            this.listSkills.TabIndex = 104;
            this.listSkills.UseCompatibleStateImageBehavior = false;
            this.listSkills.View = System.Windows.Forms.View.Details;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.remaxDatabaseDataSet;
            // 
            // listingBindingSource
            // 
            this.listingBindingSource.DataMember = "Listing";
            this.listingBindingSource.DataSource = this.remaxDatabaseDataSet;
            // 
            // houseTypeBindingSource
            // 
            this.houseTypeBindingSource.DataMember = "HouseType";
            this.houseTypeBindingSource.DataSource = this.remaxDatabaseDataSet;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.remaxDatabaseDataSet;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(499, 321);
            this.metroLabel15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(105, 20);
            this.metroLabel15.TabIndex = 105;
            this.metroLabel15.Text = "House Pictures:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::prjCSWinRemax.Properties.Resources.icons8_delete_35;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Location = new System.Drawing.Point(1163, 725);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 44);
            this.btnDelete.TabIndex = 102;
            this.btnDelete.Text = "Close";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseSelectable = true;
            // 
            // txtPrice
            // 
            // 
            // 
            // 
            this.txtPrice.CustomButton.Image = null;
            this.txtPrice.CustomButton.Location = new System.Drawing.Point(332, 2);
            this.txtPrice.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrice.CustomButton.Name = "";
            this.txtPrice.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrice.CustomButton.TabIndex = 1;
            this.txtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrice.CustomButton.UseSelectable = true;
            this.txtPrice.CustomButton.Visible = false;
            this.txtPrice.DisplayIcon = true;
            this.txtPrice.Enabled = false;
            this.txtPrice.Lines = new string[0];
            this.txtPrice.Location = new System.Drawing.Point(185, 489);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.txtPrice.Size = new System.Drawing.Size(275, 28);
            this.txtPrice.TabIndex = 98;
            this.txtPrice.Tag = "Price";
            this.txtPrice.UseSelectable = true;
            this.txtPrice.WaterMark = "Price";
            this.txtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(37, 494);
            this.metroLabel14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(43, 20);
            this.metroLabel14.TabIndex = 97;
            this.metroLabel14.Text = "Price:";
            // 
            // picHouse
            // 
            this.picHouse.Location = new System.Drawing.Point(883, 321);
            this.picHouse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picHouse.Name = "picHouse";
            this.picHouse.Size = new System.Drawing.Size(385, 396);
            this.picHouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHouse.TabIndex = 96;
            this.picHouse.TabStop = false;
            // 
            // txtLivingArea
            // 
            // 
            // 
            // 
            this.txtLivingArea.CustomButton.Image = null;
            this.txtLivingArea.CustomButton.Location = new System.Drawing.Point(332, 2);
            this.txtLivingArea.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLivingArea.CustomButton.Name = "";
            this.txtLivingArea.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtLivingArea.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLivingArea.CustomButton.TabIndex = 1;
            this.txtLivingArea.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLivingArea.CustomButton.UseSelectable = true;
            this.txtLivingArea.CustomButton.Visible = false;
            this.txtLivingArea.DisplayIcon = true;
            this.txtLivingArea.Enabled = false;
            this.txtLivingArea.Lines = new string[0];
            this.txtLivingArea.Location = new System.Drawing.Point(185, 379);
            this.txtLivingArea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.txtLivingArea.Size = new System.Drawing.Size(275, 28);
            this.txtLivingArea.TabIndex = 95;
            this.txtLivingArea.Tag = "Living area";
            this.txtLivingArea.UseSelectable = true;
            this.txtLivingArea.WaterMark = "Living area";
            this.txtLivingArea.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLivingArea.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtComment
            // 
            // 
            // 
            // 
            this.txtComment.CustomButton.Image = null;
            this.txtComment.CustomButton.Location = new System.Drawing.Point(769, 2);
            this.txtComment.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtComment.CustomButton.Name = "";
            this.txtComment.CustomButton.Size = new System.Drawing.Size(252, 233);
            this.txtComment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtComment.CustomButton.TabIndex = 1;
            this.txtComment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtComment.CustomButton.UseSelectable = true;
            this.txtComment.CustomButton.Visible = false;
            this.txtComment.DisplayIcon = true;
            this.txtComment.Enabled = false;
            this.txtComment.Lines = new string[0];
            this.txtComment.Location = new System.Drawing.Point(499, 101);
            this.txtComment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.txtComment.Size = new System.Drawing.Size(769, 194);
            this.txtComment.TabIndex = 94;
            this.txtComment.UseSelectable = true;
            this.txtComment.WaterMark = "Comments";
            this.txtComment.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtComment.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(499, 74);
            this.metroLabel13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(79, 20);
            this.metroLabel13.TabIndex = 93;
            this.metroLabel13.Text = "Comments:";
            this.metroLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.CustomButton.Image = null;
            this.txtAddress.CustomButton.Location = new System.Drawing.Point(332, 2);
            this.txtAddress.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.CustomButton.Name = "";
            this.txtAddress.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddress.CustomButton.TabIndex = 1;
            this.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress.CustomButton.UseSelectable = true;
            this.txtAddress.CustomButton.Visible = false;
            this.txtAddress.DisplayIcon = true;
            this.txtAddress.Enabled = false;
            this.txtAddress.Lines = new string[0];
            this.txtAddress.Location = new System.Drawing.Point(185, 453);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.txtAddress.Size = new System.Drawing.Size(275, 28);
            this.txtAddress.TabIndex = 92;
            this.txtAddress.Tag = "Address";
            this.txtAddress.UseSelectable = true;
            this.txtAddress.WaterMark = "Address";
            this.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(37, 458);
            this.metroLabel12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(62, 20);
            this.metroLabel12.TabIndex = 91;
            this.metroLabel12.Text = "Address:";
            // 
            // cmbDate
            // 
            this.cmbDate.Enabled = false;
            this.cmbDate.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.cmbDate.Location = new System.Drawing.Point(185, 415);
            this.cmbDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDate.MinimumSize = new System.Drawing.Size(0, 27);
            this.cmbDate.Name = "cmbDate";
            this.cmbDate.Size = new System.Drawing.Size(272, 27);
            this.cmbDate.TabIndex = 90;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(37, 422);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(69, 20);
            this.metroLabel11.TabIndex = 89;
            this.metroLabel11.Text = "Built date:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(37, 384);
            this.metroLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(79, 20);
            this.metroLabel10.TabIndex = 88;
            this.metroLabel10.Text = "Living area:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(37, 348);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(87, 20);
            this.metroLabel9.TabIndex = 87;
            this.metroLabel9.Text = "Parking spot:";
            // 
            // cmbParkingSpot
            // 
            this.cmbParkingSpot.Enabled = false;
            this.cmbParkingSpot.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbParkingSpot.FormattingEnabled = true;
            this.cmbParkingSpot.ItemHeight = 21;
            this.cmbParkingSpot.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5 or more"});
            this.cmbParkingSpot.Location = new System.Drawing.Point(185, 341);
            this.cmbParkingSpot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbParkingSpot.Name = "cmbParkingSpot";
            this.cmbParkingSpot.Size = new System.Drawing.Size(273, 27);
            this.cmbParkingSpot.TabIndex = 86;
            this.cmbParkingSpot.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(37, 310);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(83, 20);
            this.metroLabel8.TabIndex = 85;
            this.metroLabel8.Text = "Total rooms:";
            // 
            // cmbTotalRoom
            // 
            this.cmbTotalRoom.Enabled = false;
            this.cmbTotalRoom.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbTotalRoom.FormattingEnabled = true;
            this.cmbTotalRoom.ItemHeight = 21;
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
            this.cmbTotalRoom.Location = new System.Drawing.Point(185, 303);
            this.cmbTotalRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTotalRoom.Name = "cmbTotalRoom";
            this.cmbTotalRoom.Size = new System.Drawing.Size(273, 27);
            this.cmbTotalRoom.TabIndex = 84;
            this.cmbTotalRoom.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(37, 272);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(75, 20);
            this.metroLabel7.TabIndex = 83;
            this.metroLabel7.Text = "Bedrooms:";
            // 
            // cmbBedroom
            // 
            this.cmbBedroom.Enabled = false;
            this.cmbBedroom.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbBedroom.FormattingEnabled = true;
            this.cmbBedroom.ItemHeight = 21;
            this.cmbBedroom.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5 or more"});
            this.cmbBedroom.Location = new System.Drawing.Point(185, 265);
            this.cmbBedroom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBedroom.Name = "cmbBedroom";
            this.cmbBedroom.Size = new System.Drawing.Size(273, 27);
            this.cmbBedroom.TabIndex = 82;
            this.cmbBedroom.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(37, 534);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(109, 20);
            this.metroLabel6.TabIndex = 79;
            this.metroLabel6.Text = "House Features:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(37, 234);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(78, 20);
            this.metroLabel5.TabIndex = 78;
            this.metroLabel5.Text = "Bathrooms:";
            // 
            // cmbBathroom
            // 
            this.cmbBathroom.Enabled = false;
            this.cmbBathroom.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbBathroom.FormattingEnabled = true;
            this.cmbBathroom.ItemHeight = 21;
            this.cmbBathroom.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5 or more"});
            this.cmbBathroom.Location = new System.Drawing.Point(185, 226);
            this.cmbBathroom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBathroom.Name = "cmbBathroom";
            this.cmbBathroom.Size = new System.Drawing.Size(273, 27);
            this.cmbBathroom.TabIndex = 77;
            this.cmbBathroom.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(37, 119);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(109, 20);
            this.metroLabel4.TabIndex = 76;
            this.metroLabel4.Text = "Client in charge:";
            // 
            // cmbClient
            // 
            this.cmbClient.DataSource = this.clientsBindingSource;
            this.cmbClient.DisplayMember = "Name";
            this.cmbClient.Enabled = false;
            this.cmbClient.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.ItemHeight = 21;
            this.cmbClient.Location = new System.Drawing.Point(185, 112);
            this.cmbClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(273, 27);
            this.cmbClient.TabIndex = 75;
            this.cmbClient.UseSelectable = true;
            this.cmbClient.ValueMember = "refClient";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(37, 196);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(83, 20);
            this.metroLabel3.TabIndex = 74;
            this.metroLabel3.Text = "House type:";
            // 
            // cmbType
            // 
            this.cmbType.DataSource = this.houseTypeBindingSource;
            this.cmbType.DisplayMember = "TypeName";
            this.cmbType.Enabled = false;
            this.cmbType.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.ItemHeight = 21;
            this.cmbType.Location = new System.Drawing.Point(185, 188);
            this.cmbType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(273, 27);
            this.cmbType.TabIndex = 73;
            this.cmbType.UseSelectable = true;
            this.cmbType.ValueMember = "refType";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(37, 158);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 20);
            this.metroLabel2.TabIndex = 72;
            this.metroLabel2.Text = "Listing for:";
            // 
            // cmbListing
            // 
            this.cmbListing.DataSource = this.listingBindingSource;
            this.cmbListing.DisplayMember = "ListingStatus";
            this.cmbListing.Enabled = false;
            this.cmbListing.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbListing.FormattingEnabled = true;
            this.cmbListing.ItemHeight = 21;
            this.cmbListing.Location = new System.Drawing.Point(185, 150);
            this.cmbListing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbListing.Name = "cmbListing";
            this.cmbListing.Size = new System.Drawing.Size(273, 27);
            this.cmbListing.TabIndex = 71;
            this.cmbListing.UseSelectable = true;
            this.cmbListing.ValueMember = "refListing";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(37, 81);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(111, 20);
            this.metroLabel1.TabIndex = 70;
            this.metroLabel1.Text = "Agent in charge:";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.DataSource = this.employeesBindingSource;
            this.cmbEmployee.DisplayMember = "Name";
            this.cmbEmployee.Enabled = false;
            this.cmbEmployee.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.ItemHeight = 21;
            this.cmbEmployee.Location = new System.Drawing.Point(185, 74);
            this.cmbEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(273, 27);
            this.cmbEmployee.TabIndex = 69;
            this.cmbEmployee.UseSelectable = true;
            this.cmbEmployee.ValueMember = "refEmployee";
            // 
            // frmHousesInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 788);
            this.Controls.Add(this.listPic);
            this.Controls.Add(this.listSkills);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.btnDelete);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmHousesInfo";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "frmHousesInfo";
            this.Load += new System.EventHandler(this.frmHousesInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.housesPicturesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remaxDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.featuresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.housesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.housesFeaturesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource housesPicturesBindingSource;
        private RemaxDatabaseDataSet remaxDatabaseDataSet;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.BindingSource featuresBindingSource;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.BindingSource housesBindingSource;
        private RemaxDatabaseDataSetTableAdapters.HousesTableAdapter housesTableAdapter;
        private RemaxDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.BindingSource picturesBindingSource;
        private System.Windows.Forms.BindingSource housesFeaturesBindingSource;
        private RemaxDatabaseDataSetTableAdapters.HousesFeaturesTableAdapter housesFeaturesTableAdapter;
        private RemaxDatabaseDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private RemaxDatabaseDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private RemaxDatabaseDataSetTableAdapters.ListingTableAdapter listingTableAdapter;
        private RemaxDatabaseDataSetTableAdapters.HouseTypeTableAdapter houseTypeTableAdapter;
        private RemaxDatabaseDataSetTableAdapters.FeaturesTableAdapter featuresTableAdapter;
        private RemaxDatabaseDataSetTableAdapters.PicturesTableAdapter picturesTableAdapter;
        private RemaxDatabaseDataSetTableAdapters.HousesPicturesTableAdapter housesPicturesTableAdapter;
        private System.Windows.Forms.ListView listPic;
        private System.Windows.Forms.ListView listSkills;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private System.Windows.Forms.BindingSource listingBindingSource;
        private System.Windows.Forms.BindingSource houseTypeBindingSource;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroTextBox txtPrice;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private System.Windows.Forms.PictureBox picHouse;
        private MetroFramework.Controls.MetroTextBox txtLivingArea;
        private MetroFramework.Controls.MetroTextBox txtComment;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroDateTime cmbDate;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroComboBox cmbParkingSpot;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroComboBox cmbTotalRoom;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox cmbBedroom;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cmbBathroom;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cmbClient;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cmbType;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cmbListing;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbEmployee;
    }
}