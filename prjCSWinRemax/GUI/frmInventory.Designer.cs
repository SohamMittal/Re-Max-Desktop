namespace prjCSWinRemax.GUI
{
    partial class frmInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            this.remaxDatabaseDataSet = new prjCSWinRemax.RemaxDatabaseDataSet();
            this.housesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.housesTableAdapter = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.HousesTableAdapter();
            this.tableAdapterManager = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.TableAdapterManager();
            this.clientsTableAdapter = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.ClientsTableAdapter();
            this.employeesTableAdapter = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.EmployeesTableAdapter();
            this.listingTableAdapter = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.ListingTableAdapter();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtHouses = new MetroFramework.Controls.MetroTextBox();
            this.txtEmp = new MetroFramework.Controls.MetroTextBox();
            this.txtClients = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.listingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbHouses = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtQtt = new MetroFramework.Controls.MetroTextBox();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.remaxDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.housesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // remaxDatabaseDataSet
            // 
            this.remaxDatabaseDataSet.DataSetName = "RemaxDatabaseDataSet";
            this.remaxDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.ClientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.EmployeeSkillsTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.FeaturesTableAdapter = null;
            this.tableAdapterManager.HousesFeaturesTableAdapter = null;
            this.tableAdapterManager.HousesPicturesTableAdapter = null;
            this.tableAdapterManager.HousesTableAdapter = this.housesTableAdapter;
            this.tableAdapterManager.HouseTypeTableAdapter = null;
            this.tableAdapterManager.ListingTableAdapter = this.listingTableAdapter;
            this.tableAdapterManager.PicturesTableAdapter = null;
            this.tableAdapterManager.SkillsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // listingTableAdapter
            // 
            this.listingTableAdapter.ClearBeforeFill = true;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.remaxDatabaseDataSet;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.remaxDatabaseDataSet;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(45, 81);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Total Houses:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 110);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(106, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Total Employees:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(48, 139);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(81, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Total Clients:";
            // 
            // txtHouses
            // 
            // 
            // 
            // 
            this.txtHouses.CustomButton.Image = null;
            this.txtHouses.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.txtHouses.CustomButton.Name = "";
            this.txtHouses.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHouses.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHouses.CustomButton.TabIndex = 1;
            this.txtHouses.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHouses.CustomButton.UseSelectable = true;
            this.txtHouses.CustomButton.Visible = false;
            this.txtHouses.Enabled = false;
            this.txtHouses.Lines = new string[0];
            this.txtHouses.Location = new System.Drawing.Point(150, 77);
            this.txtHouses.MaxLength = 32767;
            this.txtHouses.Name = "txtHouses";
            this.txtHouses.PasswordChar = '\0';
            this.txtHouses.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHouses.SelectedText = "";
            this.txtHouses.SelectionLength = 0;
            this.txtHouses.SelectionStart = 0;
            this.txtHouses.ShortcutsEnabled = true;
            this.txtHouses.Size = new System.Drawing.Size(210, 23);
            this.txtHouses.TabIndex = 3;
            this.txtHouses.UseSelectable = true;
            this.txtHouses.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHouses.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEmp
            // 
            // 
            // 
            // 
            this.txtEmp.CustomButton.Image = null;
            this.txtEmp.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.txtEmp.CustomButton.Name = "";
            this.txtEmp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmp.CustomButton.TabIndex = 1;
            this.txtEmp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmp.CustomButton.UseSelectable = true;
            this.txtEmp.CustomButton.Visible = false;
            this.txtEmp.Enabled = false;
            this.txtEmp.Lines = new string[0];
            this.txtEmp.Location = new System.Drawing.Point(150, 106);
            this.txtEmp.MaxLength = 32767;
            this.txtEmp.Name = "txtEmp";
            this.txtEmp.PasswordChar = '\0';
            this.txtEmp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmp.SelectedText = "";
            this.txtEmp.SelectionLength = 0;
            this.txtEmp.SelectionStart = 0;
            this.txtEmp.ShortcutsEnabled = true;
            this.txtEmp.Size = new System.Drawing.Size(210, 23);
            this.txtEmp.TabIndex = 4;
            this.txtEmp.UseSelectable = true;
            this.txtEmp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtClients
            // 
            // 
            // 
            // 
            this.txtClients.CustomButton.Image = null;
            this.txtClients.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.txtClients.CustomButton.Name = "";
            this.txtClients.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtClients.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClients.CustomButton.TabIndex = 1;
            this.txtClients.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClients.CustomButton.UseSelectable = true;
            this.txtClients.CustomButton.Visible = false;
            this.txtClients.Enabled = false;
            this.txtClients.Lines = new string[0];
            this.txtClients.Location = new System.Drawing.Point(150, 135);
            this.txtClients.MaxLength = 32767;
            this.txtClients.Name = "txtClients";
            this.txtClients.PasswordChar = '\0';
            this.txtClients.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClients.SelectedText = "";
            this.txtClients.SelectionLength = 0;
            this.txtClients.SelectionStart = 0;
            this.txtClients.ShortcutsEnabled = true;
            this.txtClients.Size = new System.Drawing.Size(210, 23);
            this.txtClients.TabIndex = 5;
            this.txtClients.UseSelectable = true;
            this.txtClients.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClients.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(54, 202);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(75, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Houses for:";
            // 
            // listingBindingSource
            // 
            this.listingBindingSource.DataMember = "Listing";
            this.listingBindingSource.DataSource = this.remaxDatabaseDataSet;
            // 
            // cmbHouses
            // 
            this.cmbHouses.DataSource = this.listingBindingSource;
            this.cmbHouses.DisplayMember = "ListingStatus";
            this.cmbHouses.FormattingEnabled = true;
            this.cmbHouses.ItemHeight = 23;
            this.cmbHouses.Location = new System.Drawing.Point(150, 192);
            this.cmbHouses.Name = "cmbHouses";
            this.cmbHouses.Size = new System.Drawing.Size(210, 29);
            this.cmbHouses.TabIndex = 7;
            this.cmbHouses.UseSelectable = true;
            this.cmbHouses.ValueMember = "refListing";
            this.cmbHouses.SelectedIndexChanged += new System.EventHandler(this.cmbHouses_SelectedIndexChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(68, 239);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(61, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Quantity:";
            // 
            // txtQtt
            // 
            // 
            // 
            // 
            this.txtQtt.CustomButton.Image = null;
            this.txtQtt.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.txtQtt.CustomButton.Name = "";
            this.txtQtt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQtt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQtt.CustomButton.TabIndex = 1;
            this.txtQtt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQtt.CustomButton.UseSelectable = true;
            this.txtQtt.CustomButton.Visible = false;
            this.txtQtt.Enabled = false;
            this.txtQtt.Lines = new string[0];
            this.txtQtt.Location = new System.Drawing.Point(150, 235);
            this.txtQtt.MaxLength = 32767;
            this.txtQtt.Name = "txtQtt";
            this.txtQtt.PasswordChar = '\0';
            this.txtQtt.PromptText = "Select a \"listing\" category.";
            this.txtQtt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQtt.SelectedText = "";
            this.txtQtt.SelectionLength = 0;
            this.txtQtt.SelectionStart = 0;
            this.txtQtt.ShortcutsEnabled = true;
            this.txtQtt.Size = new System.Drawing.Size(210, 23);
            this.txtQtt.TabIndex = 9;
            this.txtQtt.UseSelectable = true;
            this.txtQtt.WaterMark = "Select a \"listing\" category.";
            this.txtQtt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQtt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::prjCSWinRemax.Properties.Resources.icons8_delete_35;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(285, 264);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.Style = MetroFramework.MetroColorStyle.Brown;
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnClose.UseCustomBackColor = true;
            this.btnClose.UseCustomForeColor = true;
            this.btnClose.UseSelectable = true;
            this.btnClose.UseStyleColors = true;
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(378, 316);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtQtt);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.cmbHouses);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtClients);
            this.Controls.Add(this.txtEmp);
            this.Controls.Add(this.txtHouses);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmInventory";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Sales and Inventory";
            this.Load += new System.EventHandler(this.frmInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.remaxDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.housesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RemaxDatabaseDataSet remaxDatabaseDataSet;
        private System.Windows.Forms.BindingSource housesBindingSource;
        private RemaxDatabaseDataSetTableAdapters.HousesTableAdapter housesTableAdapter;
        private RemaxDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private RemaxDatabaseDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private RemaxDatabaseDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private RemaxDatabaseDataSetTableAdapters.ListingTableAdapter listingTableAdapter;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtHouses;
        private MetroFramework.Controls.MetroTextBox txtEmp;
        private MetroFramework.Controls.MetroTextBox txtClients;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.BindingSource listingBindingSource;
        private MetroFramework.Controls.MetroComboBox cmbHouses;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtQtt;
        private MetroFramework.Controls.MetroButton btnClose;
    }
}