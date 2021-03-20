namespace prjCSWinRemax.GUI
{
    partial class frmFeatMgmt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFeatMgmt));
            this.remaxDatabaseDataSet = new prjCSWinRemax.RemaxDatabaseDataSet();
            this.skillsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skillsTableAdapter = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.SkillsTableAdapter();
            this.tableAdapterManager = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.TableAdapterManager();
            this.employeeSkillsTableAdapter = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.EmployeeSkillsTableAdapter();
            this.remaxDatabaseDataSet1 = new prjCSWinRemax.RemaxDatabaseDataSet();
            this.grdResult = new MetroFramework.Controls.MetroGrid();
            this.refFeatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.featureNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.featureDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.featuresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnCreate = new MetroFramework.Controls.MetroButton();
            this.skillsEmployeeSkillsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.featuresTableAdapter = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.FeaturesTableAdapter();
            this.txtDetails = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.remaxDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remaxDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.featuresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillsEmployeeSkillsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // remaxDatabaseDataSet
            // 
            this.remaxDatabaseDataSet.DataSetName = "RemaxDatabaseDataSet";
            this.remaxDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // skillsBindingSource
            // 
            this.skillsBindingSource.DataMember = "Skills";
            this.skillsBindingSource.DataSource = this.remaxDatabaseDataSet;
            // 
            // skillsTableAdapter
            // 
            this.skillsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.EmployeeSkillsTableAdapter = this.employeeSkillsTableAdapter;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.FeaturesTableAdapter = null;
            this.tableAdapterManager.HousesFeaturesTableAdapter = null;
            this.tableAdapterManager.HousesPicturesTableAdapter = null;
            this.tableAdapterManager.HousesTableAdapter = null;
            this.tableAdapterManager.HouseTypeTableAdapter = null;
            this.tableAdapterManager.ListingTableAdapter = null;
            this.tableAdapterManager.PicturesTableAdapter = null;
            this.tableAdapterManager.SkillsTableAdapter = this.skillsTableAdapter;
            this.tableAdapterManager.UpdateOrder = prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeeSkillsTableAdapter
            // 
            this.employeeSkillsTableAdapter.ClearBeforeFill = true;
            // 
            // remaxDatabaseDataSet1
            // 
            this.remaxDatabaseDataSet1.DataSetName = "RemaxDatabaseDataSet";
            this.remaxDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdResult
            // 
            this.grdResult.AllowUserToAddRows = false;
            this.grdResult.AllowUserToDeleteRows = false;
            this.grdResult.AllowUserToResizeRows = false;
            this.grdResult.AutoGenerateColumns = false;
            this.grdResult.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdResult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.refFeatureDataGridViewTextBoxColumn,
            this.featureNameDataGridViewTextBoxColumn,
            this.featureDetailsDataGridViewTextBoxColumn});
            this.grdResult.DataSource = this.featuresBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdResult.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdResult.EnableHeadersVisualStyles = false;
            this.grdResult.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdResult.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdResult.Location = new System.Drawing.Point(14, 166);
            this.grdResult.MultiSelect = false;
            this.grdResult.Name = "grdResult";
            this.grdResult.ReadOnly = true;
            this.grdResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdResult.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdResult.Size = new System.Drawing.Size(372, 269);
            this.grdResult.TabIndex = 49;
            this.grdResult.SelectionChanged += new System.EventHandler(this.grdResult_SelectionChanged);
            // 
            // refFeatureDataGridViewTextBoxColumn
            // 
            this.refFeatureDataGridViewTextBoxColumn.DataPropertyName = "refFeature";
            this.refFeatureDataGridViewTextBoxColumn.HeaderText = "Feature ID";
            this.refFeatureDataGridViewTextBoxColumn.Name = "refFeatureDataGridViewTextBoxColumn";
            this.refFeatureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // featureNameDataGridViewTextBoxColumn
            // 
            this.featureNameDataGridViewTextBoxColumn.DataPropertyName = "FeatureName";
            this.featureNameDataGridViewTextBoxColumn.HeaderText = "Feature Name";
            this.featureNameDataGridViewTextBoxColumn.Name = "featureNameDataGridViewTextBoxColumn";
            this.featureNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // featureDetailsDataGridViewTextBoxColumn
            // 
            this.featureDetailsDataGridViewTextBoxColumn.DataPropertyName = "FeatureDetails";
            this.featureDetailsDataGridViewTextBoxColumn.HeaderText = "Feature Details";
            this.featureDetailsDataGridViewTextBoxColumn.Name = "featureDetailsDataGridViewTextBoxColumn";
            this.featureDetailsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // featuresBindingSource
            // 
            this.featuresBindingSource.DataMember = "Features";
            this.featuresBindingSource.DataSource = this.remaxDatabaseDataSet;
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(234, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.DisplayIcon = true;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(116, 68);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PromptText = "Please insert a name for the feature";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.ShowClearButton = true;
            this.txtName.Size = new System.Drawing.Size(256, 23);
            this.txtName.TabIndex = 54;
            this.txtName.Tag = "Skill name";
            this.txtName.UseSelectable = true;
            this.txtName.WaterMark = "Please insert a name for the feature";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(14, 72);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(93, 19);
            this.metroLabel10.TabIndex = 53;
            this.metroLabel10.Text = "Feature name:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::prjCSWinRemax.Properties.Resources.deleteskill;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Location = new System.Drawing.Point(248, 122);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 36);
            this.btnDelete.TabIndex = 52;
            this.btnDelete.Text = "Delete\r\nSelected";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = global::prjCSWinRemax.Properties.Resources.icons8_compose_35;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEdit.Location = new System.Drawing.Point(146, 122);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(96, 36);
            this.btnEdit.TabIndex = 51;
            this.btnEdit.Text = "Edit\r\nSelected";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackgroundImage = global::prjCSWinRemax.Properties.Resources.newskill;
            this.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCreate.Location = new System.Drawing.Point(44, 122);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(96, 36);
            this.btnCreate.TabIndex = 50;
            this.btnCreate.Text = "Add\r\nNew";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.UseSelectable = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // skillsEmployeeSkillsBindingSource
            // 
            this.skillsEmployeeSkillsBindingSource.DataMember = "SkillsEmployeeSkills";
            this.skillsEmployeeSkillsBindingSource.DataSource = this.skillsBindingSource;
            // 
            // featuresTableAdapter
            // 
            this.featuresTableAdapter.ClearBeforeFill = true;
            // 
            // txtDetails
            // 
            // 
            // 
            // 
            this.txtDetails.CustomButton.Image = null;
            this.txtDetails.CustomButton.Location = new System.Drawing.Point(234, 1);
            this.txtDetails.CustomButton.Name = "";
            this.txtDetails.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDetails.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDetails.CustomButton.TabIndex = 1;
            this.txtDetails.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDetails.CustomButton.UseSelectable = true;
            this.txtDetails.CustomButton.Visible = false;
            this.txtDetails.DisplayIcon = true;
            this.txtDetails.Lines = new string[0];
            this.txtDetails.Location = new System.Drawing.Point(116, 93);
            this.txtDetails.MaxLength = 32767;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.PasswordChar = '\0';
            this.txtDetails.PromptText = "Please insert the feature details";
            this.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDetails.SelectedText = "";
            this.txtDetails.SelectionLength = 0;
            this.txtDetails.SelectionStart = 0;
            this.txtDetails.ShortcutsEnabled = true;
            this.txtDetails.ShowClearButton = true;
            this.txtDetails.Size = new System.Drawing.Size(256, 23);
            this.txtDetails.TabIndex = 56;
            this.txtDetails.Tag = "Skill name";
            this.txtDetails.UseSelectable = true;
            this.txtDetails.WaterMark = "Please insert the feature details";
            this.txtDetails.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDetails.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(14, 97);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(97, 19);
            this.metroLabel1.TabIndex = 55;
            this.metroLabel1.Text = "Feature details:";
            // 
            // frmFeatMgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 443);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.grdResult);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.metroLabel10);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFeatMgmt";
            this.Text = "House Features Management";
            this.Load += new System.EventHandler(this.frmFeatMgmt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.remaxDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remaxDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.featuresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillsEmployeeSkillsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RemaxDatabaseDataSet remaxDatabaseDataSet;
        private System.Windows.Forms.BindingSource skillsBindingSource;
        private RemaxDatabaseDataSetTableAdapters.SkillsTableAdapter skillsTableAdapter;
        private RemaxDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private RemaxDatabaseDataSetTableAdapters.EmployeeSkillsTableAdapter employeeSkillsTableAdapter;
        private RemaxDatabaseDataSet remaxDatabaseDataSet1;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnCreate;
        private MetroFramework.Controls.MetroGrid grdResult;
        private System.Windows.Forms.BindingSource skillsEmployeeSkillsBindingSource;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.BindingSource featuresBindingSource;
        private RemaxDatabaseDataSetTableAdapters.FeaturesTableAdapter featuresTableAdapter;
        private MetroFramework.Controls.MetroTextBox txtDetails;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn refFeatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn featureNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn featureDetailsDataGridViewTextBoxColumn;
    }
}