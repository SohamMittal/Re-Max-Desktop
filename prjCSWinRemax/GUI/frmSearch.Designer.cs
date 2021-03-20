namespace prjCSWinRemax.GUI
{
    partial class frmSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            this.rdHouses = new MetroFramework.Controls.MetroRadioButton();
            this.rdAgents = new MetroFramework.Controls.MetroRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtKeyword = new MetroFramework.Controls.MetroTextBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.grdResult = new MetroFramework.Controls.MetroGrid();
            this.remaxDatabaseDataSet = new prjCSWinRemax.RemaxDatabaseDataSet();
            this.employeesTableAdapter = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.EmployeesTableAdapter();
            this.housesTableAdapter = new prjCSWinRemax.RemaxDatabaseDataSetTableAdapters.HousesTableAdapter();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnMoreInfo = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remaxDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rdHouses
            // 
            this.rdHouses.AutoSize = true;
            this.rdHouses.Location = new System.Drawing.Point(6, 21);
            this.rdHouses.Name = "rdHouses";
            this.rdHouses.Size = new System.Drawing.Size(62, 15);
            this.rdHouses.TabIndex = 0;
            this.rdHouses.Text = "Houses";
            this.rdHouses.UseSelectable = true;
            this.rdHouses.CheckedChanged += new System.EventHandler(this.rdHouses_CheckedChanged);
            // 
            // rdAgents
            // 
            this.rdAgents.AutoSize = true;
            this.rdAgents.Location = new System.Drawing.Point(6, 42);
            this.rdAgents.Name = "rdAgents";
            this.rdAgents.Size = new System.Drawing.Size(60, 15);
            this.rdAgents.TabIndex = 1;
            this.rdAgents.Text = "Agents";
            this.rdAgents.UseSelectable = true;
            this.rdAgents.CheckedChanged += new System.EventHandler(this.rdAgents_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdHouses);
            this.groupBox1.Controls.Add(this.rdAgents);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 68);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtKeyword);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(134, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(552, 68);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Keyword";
            // 
            // txtKeyword
            // 
            // 
            // 
            // 
            this.txtKeyword.CustomButton.Image = null;
            this.txtKeyword.CustomButton.Location = new System.Drawing.Point(518, 1);
            this.txtKeyword.CustomButton.Name = "";
            this.txtKeyword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKeyword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKeyword.CustomButton.TabIndex = 1;
            this.txtKeyword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKeyword.CustomButton.UseSelectable = true;
            this.txtKeyword.CustomButton.Visible = false;
            this.txtKeyword.Lines = new string[0];
            this.txtKeyword.Location = new System.Drawing.Point(6, 28);
            this.txtKeyword.MaxLength = 32767;
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.PasswordChar = '\0';
            this.txtKeyword.PromptText = "Enter the keyword to search (ID, Phone, Name, etc...)";
            this.txtKeyword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKeyword.SelectedText = "";
            this.txtKeyword.SelectionLength = 0;
            this.txtKeyword.SelectionStart = 0;
            this.txtKeyword.ShortcutsEnabled = true;
            this.txtKeyword.Size = new System.Drawing.Size(540, 23);
            this.txtKeyword.TabIndex = 0;
            this.txtKeyword.UseSelectable = true;
            this.txtKeyword.WaterMark = "Enter the keyword to search (ID, Phone, Name, etc...)";
            this.txtKeyword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKeyword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtKeyword.TextChanged += new System.EventHandler(this.txtKeyword_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::prjCSWinRemax.Properties.Resources.icons8_view_50;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.Location = new System.Drawing.Point(710, 78);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(142, 51);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grdResult
            // 
            this.grdResult.AllowUserToResizeRows = false;
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
            this.grdResult.Location = new System.Drawing.Point(13, 137);
            this.grdResult.Name = "grdResult";
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
            this.grdResult.Size = new System.Drawing.Size(839, 261);
            this.grdResult.TabIndex = 13;
            // 
            // remaxDatabaseDataSet
            // 
            this.remaxDatabaseDataSet.DataSetName = "RemaxDatabaseDataSet";
            this.remaxDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // housesTableAdapter
            // 
            this.housesTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = this.remaxDatabaseDataSet;
            this.bindingSource.Position = 0;
            // 
            // btnMoreInfo
            // 
            this.btnMoreInfo.BackgroundImage = global::prjCSWinRemax.Properties.Resources.icons8_info_35;
            this.btnMoreInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMoreInfo.Location = new System.Drawing.Point(376, 404);
            this.btnMoreInfo.Name = "btnMoreInfo";
            this.btnMoreInfo.Size = new System.Drawing.Size(90, 36);
            this.btnMoreInfo.TabIndex = 22;
            this.btnMoreInfo.Text = "More\r\nInfo";
            this.btnMoreInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMoreInfo.UseSelectable = true;
            this.btnMoreInfo.Click += new System.EventHandler(this.btnMoreInfo_Click);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 445);
            this.Controls.Add(this.btnMoreInfo);
            this.Controls.Add(this.grdResult);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSearch";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remaxDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton rdHouses;
        private MetroFramework.Controls.MetroRadioButton rdAgents;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroTextBox txtKeyword;
        private RemaxDatabaseDataSet remaxDatabaseDataSet;
        private RemaxDatabaseDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private RemaxDatabaseDataSetTableAdapters.HousesTableAdapter housesTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource;
        private MetroFramework.Controls.MetroButton btnMoreInfo;
        public MetroFramework.Controls.MetroGrid grdResult;
    }
}