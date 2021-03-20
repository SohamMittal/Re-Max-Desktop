namespace prjCSWinRemax
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mngClients = new System.Windows.Forms.ToolStripMenuItem();
            this.viewClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mngAgents = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAgentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewSkillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mngHouses = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHousesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.featuresManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.Transparent;
            this.menuBar.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBar.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuAdd,
            this.menuDisplay,
            this.menuInfo});
            this.menuBar.Location = new System.Drawing.Point(20, 60);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(865, 48);
            this.menuBar.Stretch = false;
            this.menuBar.TabIndex = 7;
            this.menuBar.Text = "stripMain";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.menuExit});
            this.menuFile.Image = global::prjCSWinRemax.Properties.Resources.icons8_document_50;
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(79, 44);
            this.menuFile.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItem1.Text = "&Login";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(136, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuExit.Size = new System.Drawing.Size(139, 22);
            this.menuExit.Text = "&Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuAdd
            // 
            this.menuAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mngClients,
            this.mngAgents,
            this.mngHouses,
            this.inventoryStatusToolStripMenuItem});
            this.menuAdd.Image = global::prjCSWinRemax.Properties.Resources.icons8_settings_50;
            this.menuAdd.Name = "menuAdd";
            this.menuAdd.Size = new System.Drawing.Size(135, 44);
            this.menuAdd.Text = "Management";
            // 
            // mngClients
            // 
            this.mngClients.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewClientsToolStripMenuItem});
            this.mngClients.Name = "mngClients";
            this.mngClients.Size = new System.Drawing.Size(186, 22);
            this.mngClients.Text = "&Clients";
            // 
            // viewClientsToolStripMenuItem
            // 
            this.viewClientsToolStripMenuItem.Name = "viewClientsToolStripMenuItem";
            this.viewClientsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.viewClientsToolStripMenuItem.Text = "View clients";
            this.viewClientsToolStripMenuItem.Click += new System.EventHandler(this.viewClientsToolStripMenuItem_Click);
            // 
            // mngAgents
            // 
            this.mngAgents.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAgentsToolStripMenuItem,
            this.addNewSkillToolStripMenuItem});
            this.mngAgents.Name = "mngAgents";
            this.mngAgents.Size = new System.Drawing.Size(186, 22);
            this.mngAgents.Text = "&Agents";
            // 
            // viewAgentsToolStripMenuItem
            // 
            this.viewAgentsToolStripMenuItem.Name = "viewAgentsToolStripMenuItem";
            this.viewAgentsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.viewAgentsToolStripMenuItem.Text = "View agents";
            this.viewAgentsToolStripMenuItem.Click += new System.EventHandler(this.viewAgentsToolStripMenuItem_Click);
            // 
            // addNewSkillToolStripMenuItem
            // 
            this.addNewSkillToolStripMenuItem.Name = "addNewSkillToolStripMenuItem";
            this.addNewSkillToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.addNewSkillToolStripMenuItem.Text = "Skills management";
            this.addNewSkillToolStripMenuItem.Click += new System.EventHandler(this.addNewSkillToolStripMenuItem_Click);
            // 
            // mngHouses
            // 
            this.mngHouses.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHousesToolStripMenuItem,
            this.featuresManagementToolStripMenuItem});
            this.mngHouses.Name = "mngHouses";
            this.mngHouses.Size = new System.Drawing.Size(186, 22);
            this.mngHouses.Text = "&Houses";
            // 
            // viewHousesToolStripMenuItem
            // 
            this.viewHousesToolStripMenuItem.Name = "viewHousesToolStripMenuItem";
            this.viewHousesToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.viewHousesToolStripMenuItem.Text = "View houses";
            this.viewHousesToolStripMenuItem.Click += new System.EventHandler(this.viewHousesToolStripMenuItem_Click);
            // 
            // featuresManagementToolStripMenuItem
            // 
            this.featuresManagementToolStripMenuItem.Name = "featuresManagementToolStripMenuItem";
            this.featuresManagementToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.featuresManagementToolStripMenuItem.Text = "Features management";
            this.featuresManagementToolStripMenuItem.Click += new System.EventHandler(this.featuresManagementToolStripMenuItem_Click);
            // 
            // inventoryStatusToolStripMenuItem
            // 
            this.inventoryStatusToolStripMenuItem.Name = "inventoryStatusToolStripMenuItem";
            this.inventoryStatusToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.inventoryStatusToolStripMenuItem.Text = "&Sales and Inventory";
            this.inventoryStatusToolStripMenuItem.Click += new System.EventHandler(this.inventoryStatusToolStripMenuItem_Click);
            // 
            // menuDisplay
            // 
            this.menuDisplay.Image = global::prjCSWinRemax.Properties.Resources.icons8_view_50;
            this.menuDisplay.Name = "menuDisplay";
            this.menuDisplay.Size = new System.Drawing.Size(98, 44);
            this.menuDisplay.Text = "Search";
            this.menuDisplay.Click += new System.EventHandler(this.menuDisplay_Click);
            // 
            // menuInfo
            // 
            this.menuInfo.Image = global::prjCSWinRemax.Properties.Resources.icons8_info_squared_50;
            this.menuInfo.Name = "menuInfo";
            this.menuInfo.Size = new System.Drawing.Size(81, 44);
            this.menuInfo.Text = "Info";
            this.menuInfo.Click += new System.EventHandler(this.menuInfo_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prjCSWinRemax.Properties.Resources.remax1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(905, 601);
            this.Controls.Add(this.menuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Remax";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem mngClients;
        private System.Windows.Forms.ToolStripMenuItem mngAgents;
        private System.Windows.Forms.ToolStripMenuItem mngHouses;
        private System.Windows.Forms.ToolStripMenuItem menuDisplay;
        private System.Windows.Forms.ToolStripMenuItem menuInfo;
        private System.Windows.Forms.ToolStripMenuItem inventoryStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAgentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewSkillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHousesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem featuresManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.MenuStrip menuBar;
        public System.Windows.Forms.ToolStripMenuItem menuAdd;
    }
}

