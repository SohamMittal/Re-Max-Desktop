namespace prjCSWinRemax.GUI
{
    partial class frmAgentInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgentInfo));
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.listSkills = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.remaxDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remaxDatabaseDataSet1 = new prjCSWinRemax.RemaxDatabaseDataSet();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cmbPosition = new MetroFramework.Controls.MetroComboBox();
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
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.employeeSkillsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skillsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.skillsTableAdapter = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.SkillsTableAdapter();
            this.employeesTableAdapter1 = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.EmployeesTableAdapter();
            this.tableAdapterManager1 = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.TableAdapterManager();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skillsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeSkillsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeSkillsTableAdapter = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.EmployeeSkillsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remaxDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remaxDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSkillsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSkillsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(116, 121);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(206, 25);
            this.txtPhone.TabIndex = 90;
            // 
            // listSkills
            // 
            this.listSkills.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listSkills.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSkills.FullRowSelect = true;
            this.listSkills.GridLines = true;
            this.listSkills.Location = new System.Drawing.Point(344, 299);
            this.listSkills.MultiSelect = false;
            this.listSkills.Name = "listSkills";
            this.listSkills.Size = new System.Drawing.Size(313, 170);
            this.listSkills.TabIndex = 89;
            this.listSkills.UseCompatibleStateImageBehavior = false;
            this.listSkills.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Skill ID";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 200;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::prjCSWinRemax.Properties.Resources.icons8_delete_35;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Location = new System.Drawing.Point(561, 475);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 36);
            this.btnClose.TabIndex = 86;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Employees";
            this.bindingSource1.DataSource = this.remaxDatabaseDataSetBindingSource;
            // 
            // remaxDatabaseDataSetBindingSource
            // 
            this.remaxDatabaseDataSetBindingSource.DataSource = this.remaxDatabaseDataSet1;
            this.remaxDatabaseDataSetBindingSource.Position = 0;
            // 
            // remaxDatabaseDataSet1
            // 
            this.remaxDatabaseDataSet1.DataSetName = "RemaxDatabaseDataSet";
            this.remaxDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(23, 187);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(57, 19);
            this.metroLabel7.TabIndex = 83;
            this.metroLabel7.Text = "Position:";
            // 
            // cmbPosition
            // 
            this.cmbPosition.Enabled = false;
            this.cmbPosition.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.ItemHeight = 19;
            this.cmbPosition.Items.AddRange(new object[] {
            "Admin",
            "Agent"});
            this.cmbPosition.Location = new System.Drawing.Point(116, 181);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(208, 25);
            this.cmbPosition.TabIndex = 82;
            this.cmbPosition.UseSelectable = true;
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
            this.txtEmail.Enabled = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(116, 152);
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
            this.metroLabel3.Location = new System.Drawing.Point(23, 156);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(50, 19);
            this.metroLabel3.TabIndex = 76;
            this.metroLabel3.Text = "E-Mail:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 127);
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
            this.txtName.Enabled = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(116, 63);
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
            this.txtComment.CustomButton.Location = new System.Drawing.Point(87, 1);
            this.txtComment.CustomButton.Name = "";
            this.txtComment.CustomButton.Size = new System.Drawing.Size(229, 229);
            this.txtComment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtComment.CustomButton.TabIndex = 1;
            this.txtComment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtComment.CustomButton.UseSelectable = true;
            this.txtComment.CustomButton.Visible = false;
            this.txtComment.DisplayIcon = true;
            this.txtComment.Lines = new string[0];
            this.txtComment.Location = new System.Drawing.Point(7, 238);
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
            this.txtComment.Size = new System.Drawing.Size(317, 231);
            this.txtComment.TabIndex = 73;
            this.txtComment.UseSelectable = true;
            this.txtComment.WaterMark = "Comments";
            this.txtComment.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtComment.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(7, 216);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(76, 19);
            this.metroLabel13.TabIndex = 72;
            this.metroLabel13.Text = "Comments:";
            this.metroLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(23, 67);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(48, 19);
            this.metroLabel10.TabIndex = 71;
            this.metroLabel10.Text = "Name:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 98);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 67;
            this.metroLabel1.Text = "Gender:";
            // 
            // cmbGender
            // 
            this.cmbGender.Enabled = false;
            this.cmbGender.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.ItemHeight = 19;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(116, 92);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(206, 25);
            this.cmbGender.TabIndex = 66;
            this.cmbGender.UseSelectable = true;
            // 
            // picAgent
            // 
            this.picAgent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAgent.Location = new System.Drawing.Point(344, 63);
            this.picAgent.Name = "picAgent";
            this.picAgent.Size = new System.Drawing.Size(313, 208);
            this.picAgent.TabIndex = 65;
            this.picAgent.TabStop = false;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(344, 277);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(78, 19);
            this.metroLabel6.TabIndex = 68;
            this.metroLabel6.Text = "Agent Skills:";
            // 
            // skillsTableAdapter
            // 
            this.skillsTableAdapter.ClearBeforeFill = true;
            // 
            // employeesTableAdapter1
            // 
            this.employeesTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ClientsTableAdapter = null;
            this.tableAdapterManager1.EmployeeSkillsTableAdapter = null;
            this.tableAdapterManager1.EmployeesTableAdapter = this.employeesTableAdapter1;
            this.tableAdapterManager1.FeaturesTableAdapter = null;
            this.tableAdapterManager1.HousesFeaturesTableAdapter = null;
            this.tableAdapterManager1.HousesPicturesTableAdapter = null;
            this.tableAdapterManager1.HousesTableAdapter = null;
            this.tableAdapterManager1.HouseTypeTableAdapter = null;
            this.tableAdapterManager1.ListingTableAdapter = null;
            this.tableAdapterManager1.PicturesTableAdapter = null;
            this.tableAdapterManager1.SkillsTableAdapter = this.skillsTableAdapter;
            this.tableAdapterManager1.UpdateOrder = prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.remaxDatabaseDataSet1;
            // 
            // skillsBindingSource
            // 
            this.skillsBindingSource.DataMember = "Skills";
            this.skillsBindingSource.DataSource = this.remaxDatabaseDataSet1;
            // 
            // employeeSkillsBindingSource1
            // 
            this.employeeSkillsBindingSource1.DataMember = "EmployeeSkills";
            this.employeeSkillsBindingSource1.DataSource = this.remaxDatabaseDataSet1;
            // 
            // employeeSkillsTableAdapter
            // 
            this.employeeSkillsTableAdapter.ClearBeforeFill = true;
            // 
            // frmAgentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 521);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.listSkills);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.cmbPosition);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.picAgent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgentInfo";
            this.Text = "Agent Info";
            this.Load += new System.EventHandler(this.frmAgentInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remaxDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remaxDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSkillsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSkillsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RemaxDatabaseDataSetTableAdapters.SkillsTableAdapter skillsTableAdapter;
        private System.Windows.Forms.BindingSource remaxDatabaseDataSetBindingSource;
        private RemaxDatabaseDataSet remaxDatabaseDataSet1;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.ListView listSkills;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MetroFramework.Controls.MetroButton btnClose;
        private RemaxDatabaseDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter1;
        private RemaxDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox cmbPosition;
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
        private System.Windows.Forms.BindingSource employeeSkillsBindingSource;
        private System.Windows.Forms.BindingSource skillsBindingSource1;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private System.Windows.Forms.BindingSource skillsBindingSource;
        private System.Windows.Forms.BindingSource employeeSkillsBindingSource1;
        private RemaxDatabaseDataSetTableAdapters.EmployeeSkillsTableAdapter employeeSkillsTableAdapter;
    }
}