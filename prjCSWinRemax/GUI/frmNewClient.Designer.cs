namespace prjCSWinRemax.GUI
{
    partial class frmNewClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewClient));
            this.employeeSkillsTableAdapter = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.EmployeeSkillsTableAdapter();
            this.skillsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remaxDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remaxDatabaseDataSet = new prjCSWinRemax.RemaxDatabaseDataSet();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.btnBrowsePic = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnCreate = new MetroFramework.Controls.MetroButton();
            this.employeesTableAdapter = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.EmployeesTableAdapter();
            this.tableAdapterManager = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.TableAdapterManager();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.txtComment = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbGender = new MetroFramework.Controls.MetroComboBox();
            this.picAgent = new System.Windows.Forms.PictureBox();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.ClientsTableAdapter();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cmbAgent = new MetroFramework.Controls.MetroComboBox();
            this.employeesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.skillsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remaxDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remaxDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeSkillsTableAdapter
            // 
            this.employeeSkillsTableAdapter.ClearBeforeFill = true;
            // 
            // skillsBindingSource
            // 
            this.skillsBindingSource.DataMember = "Skills";
            this.skillsBindingSource.DataSource = this.remaxDatabaseDataSetBindingSource;
            // 
            // remaxDatabaseDataSetBindingSource
            // 
            this.remaxDatabaseDataSetBindingSource.DataSource = this.remaxDatabaseDataSet;
            this.remaxDatabaseDataSetBindingSource.Position = 0;
            // 
            // remaxDatabaseDataSet
            // 
            this.remaxDatabaseDataSet.DataSetName = "RemaxDatabaseDataSet";
            this.remaxDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(125, 120);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(206, 25);
            this.txtPhone.TabIndex = 90;
            // 
            // btnBrowsePic
            // 
            this.btnBrowsePic.BackgroundImage = global::prjCSWinRemax.Properties.Resources.icons8_browse_folder_24;
            this.btnBrowsePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBrowsePic.Location = new System.Drawing.Point(463, 55);
            this.btnBrowsePic.Name = "btnBrowsePic";
            this.btnBrowsePic.Size = new System.Drawing.Size(32, 30);
            this.btnBrowsePic.TabIndex = 88;
            this.btnBrowsePic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowsePic.UseSelectable = true;
            this.btnBrowsePic.Click += new System.EventHandler(this.btnBrowsePic_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(360, 66);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(97, 19);
            this.metroLabel8.TabIndex = 87;
            this.metroLabel8.Text = "Display Picture:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::prjCSWinRemax.Properties.Resources.icons8_delete_35;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Location = new System.Drawing.Point(577, 434);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 36);
            this.btnDelete.TabIndex = 86;
            this.btnDelete.Text = "Cancel \r\nChanges";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseSelectable = true;
            // 
            // btnCreate
            // 
            this.btnCreate.BackgroundImage = global::prjCSWinRemax.Properties.Resources.icons8_user_35;
            this.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCreate.Location = new System.Drawing.Point(463, 434);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(96, 36);
            this.btnCreate.TabIndex = 85;
            this.btnCreate.Text = "Add New";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.UseSelectable = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.EmployeeSkillsTableAdapter = this.employeeSkillsTableAdapter;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.FeaturesTableAdapter = null;
            this.tableAdapterManager.HousesFeaturesTableAdapter = null;
            this.tableAdapterManager.HousesPicturesTableAdapter = null;
            this.tableAdapterManager.HousesTableAdapter = null;
            this.tableAdapterManager.HouseTypeTableAdapter = null;
            this.tableAdapterManager.ListingTableAdapter = null;
            this.tableAdapterManager.PicturesTableAdapter = null;
            this.tableAdapterManager.SkillsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.remaxDatabaseDataSetBindingSource;
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.DisplayIcon = true;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(125, 209);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PromptText = "Please enter the password";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.ShowClearButton = true;
            this.txtPassword.Size = new System.Drawing.Size(206, 23);
            this.txtPassword.TabIndex = 81;
            this.txtPassword.Tag = "Living area";
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMark = "Please enter the password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(16, 213);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(66, 19);
            this.metroLabel5.TabIndex = 80;
            this.metroLabel5.Text = "Password:";
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
            this.txtAddress.Location = new System.Drawing.Point(125, 180);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PromptText = "Please insert the address";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.ShowClearButton = true;
            this.txtAddress.Size = new System.Drawing.Size(206, 23);
            this.txtAddress.TabIndex = 79;
            this.txtAddress.Tag = "Living area";
            this.txtAddress.UseSelectable = true;
            this.txtAddress.WaterMark = "Please insert the address";
            this.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(16, 184);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(59, 19);
            this.metroLabel4.TabIndex = 78;
            this.metroLabel4.Text = "Address:";
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.DisplayIcon = true;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(125, 151);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PromptText = "Please insert the e-mail";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.ShowClearButton = true;
            this.txtEmail.Size = new System.Drawing.Size(206, 23);
            this.txtEmail.TabIndex = 77;
            this.txtEmail.Tag = "Living area";
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMark = "Please insert the e-mail";
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(16, 155);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(47, 19);
            this.metroLabel3.TabIndex = 76;
            this.metroLabel3.Text = "E-Mail";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(16, 126);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.TabIndex = 75;
            this.metroLabel2.Text = "Phone:";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.DisplayIcon = true;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(125, 62);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PromptText = "Please insert agent name";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.ShowClearButton = true;
            this.txtName.Size = new System.Drawing.Size(206, 23);
            this.txtName.TabIndex = 74;
            this.txtName.Tag = "Living area";
            this.txtName.UseSelectable = true;
            this.txtName.WaterMark = "Please insert agent name";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtComment
            // 
            // 
            // 
            // 
            this.txtComment.CustomButton.Image = null;
            this.txtComment.CustomButton.Location = new System.Drawing.Point(149, 2);
            this.txtComment.CustomButton.Name = "";
            this.txtComment.CustomButton.Size = new System.Drawing.Size(165, 165);
            this.txtComment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtComment.CustomButton.TabIndex = 1;
            this.txtComment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtComment.CustomButton.UseSelectable = true;
            this.txtComment.CustomButton.Visible = false;
            this.txtComment.DisplayIcon = true;
            this.txtComment.Lines = new string[0];
            this.txtComment.Location = new System.Drawing.Point(16, 300);
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
            this.txtComment.Size = new System.Drawing.Size(317, 170);
            this.txtComment.TabIndex = 73;
            this.txtComment.UseSelectable = true;
            this.txtComment.WaterMark = "Comments";
            this.txtComment.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtComment.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(16, 278);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(76, 19);
            this.metroLabel13.TabIndex = 72;
            this.metroLabel13.Text = "Comments:";
            this.metroLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(16, 66);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(48, 19);
            this.metroLabel10.TabIndex = 71;
            this.metroLabel10.Text = "Name:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(14, 97);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 67;
            this.metroLabel1.Text = "Gender:";
            // 
            // cmbGender
            // 
            this.cmbGender.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.ItemHeight = 19;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(125, 91);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(206, 25);
            this.cmbGender.TabIndex = 66;
            this.cmbGender.UseSelectable = true;
            // 
            // picAgent
            // 
            this.picAgent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAgent.Location = new System.Drawing.Point(360, 91);
            this.picAgent.Name = "picAgent";
            this.picAgent.Size = new System.Drawing.Size(313, 337);
            this.picAgent.TabIndex = 65;
            this.picAgent.TabStop = false;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.remaxDatabaseDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(14, 244);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(105, 19);
            this.metroLabel6.TabIndex = 92;
            this.metroLabel6.Text = "Agent in charge:";
            // 
            // cmbAgent
            // 
            this.cmbAgent.DataSource = this.employeesBindingSource1;
            this.cmbAgent.DisplayMember = "Name";
            this.cmbAgent.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbAgent.FormattingEnabled = true;
            this.cmbAgent.ItemHeight = 19;
            this.cmbAgent.Location = new System.Drawing.Point(125, 238);
            this.cmbAgent.Name = "cmbAgent";
            this.cmbAgent.Size = new System.Drawing.Size(206, 25);
            this.cmbAgent.TabIndex = 91;
            this.cmbAgent.UseSelectable = true;
            this.cmbAgent.ValueMember = "refEmployee";
            // 
            // employeesBindingSource1
            // 
            this.employeesBindingSource1.DataMember = "Employees";
            this.employeesBindingSource1.DataSource = this.remaxDatabaseDataSetBindingSource;
            // 
            // frmNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 486);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.cmbAgent);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.btnBrowsePic);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.picAgent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNewClient";
            this.Text = "New Client";
            this.Load += new System.EventHandler(this.frmNewClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skillsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remaxDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remaxDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RemaxDatabaseDataSetTableAdapters.EmployeeSkillsTableAdapter employeeSkillsTableAdapter;
        private System.Windows.Forms.BindingSource skillsBindingSource;
        private System.Windows.Forms.BindingSource remaxDatabaseDataSetBindingSource;
        private RemaxDatabaseDataSet remaxDatabaseDataSet;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private MetroFramework.Controls.MetroButton btnBrowsePic;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnCreate;
        private RemaxDatabaseDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtComment;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbGender;
        private System.Windows.Forms.PictureBox picAgent;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox cmbAgent;
        public RemaxDatabaseDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        public RemaxDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.BindingSource clientsBindingSource;
        private System.Windows.Forms.BindingSource employeesBindingSource1;
    }
}