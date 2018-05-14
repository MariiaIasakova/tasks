namespace FitnessCenter.PL.WinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ctlMainMenu = new System.Windows.Forms.MenuStrip();
            this.ctlFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddUserMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddSubscriptionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlPages = new System.Windows.Forms.TabControl();
            this.ctlUser = new System.Windows.Forms.TabPage();
            this.ctlUserGrid = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subscriptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctlUserContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditUserContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlSubscription = new System.Windows.Forms.TabPage();
            this.ctlSubscriptionGrid = new System.Windows.Forms.DataGridView();
            this.NameService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctlSubscriptionContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAddSubscription = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteSubscription = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSubscriptionContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlMainMenu.SuspendLayout();
            this.ctlPages.SuspendLayout();
            this.ctlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlUserGrid)).BeginInit();
            this.ctlUserContextMenu.SuspendLayout();
            this.ctlSubscription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlSubscriptionGrid)).BeginInit();
            this.ctlSubscriptionContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctlMainMenu
            // 
            this.ctlMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlFileMenu,
            this.ctlEditMenu});
            this.ctlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.ctlMainMenu.Name = "ctlMainMenu";
            this.ctlMainMenu.Size = new System.Drawing.Size(645, 24);
            this.ctlMainMenu.TabIndex = 2;
            this.ctlMainMenu.Text = "menuStrip1";
            // 
            // ctlFileMenu
            // 
            this.ctlFileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit});
            this.ctlFileMenu.Name = "ctlFileMenu";
            this.ctlFileMenu.Size = new System.Drawing.Size(37, 20);
            this.ctlFileMenu.Text = "&File";
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.btnExit.Size = new System.Drawing.Size(134, 22);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ctlEditMenu
            // 
            this.ctlEditMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddUserMenu,
            this.btnAddSubscriptionMenu});
            this.ctlEditMenu.Name = "ctlEditMenu";
            this.ctlEditMenu.Size = new System.Drawing.Size(39, 20);
            this.ctlEditMenu.Text = "Edit";
            // 
            // btnAddUserMenu
            // 
            this.btnAddUserMenu.Name = "btnAddUserMenu";
            this.btnAddUserMenu.Size = new System.Drawing.Size(173, 22);
            this.btnAddUserMenu.Text = "Add user...";
            this.btnAddUserMenu.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnAddSubscriptionMenu
            // 
            this.btnAddSubscriptionMenu.Name = "btnAddSubscriptionMenu";
            this.btnAddSubscriptionMenu.Size = new System.Drawing.Size(173, 22);
            this.btnAddSubscriptionMenu.Text = "Add subscription...";
            this.btnAddSubscriptionMenu.Click += new System.EventHandler(this.btnAddSubscriptionMenu_Click);
            // 
            // ctlPages
            // 
            this.ctlPages.Controls.Add(this.ctlUser);
            this.ctlPages.Controls.Add(this.ctlSubscription);
            this.ctlPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlPages.Location = new System.Drawing.Point(0, 24);
            this.ctlPages.Name = "ctlPages";
            this.ctlPages.SelectedIndex = 0;
            this.ctlPages.Size = new System.Drawing.Size(645, 212);
            this.ctlPages.TabIndex = 3;
            // 
            // ctlUser
            // 
            this.ctlUser.Controls.Add(this.ctlUserGrid);
            this.ctlUser.Location = new System.Drawing.Point(4, 22);
            this.ctlUser.Name = "ctlUser";
            this.ctlUser.Padding = new System.Windows.Forms.Padding(3);
            this.ctlUser.Size = new System.Drawing.Size(637, 186);
            this.ctlUser.TabIndex = 0;
            this.ctlUser.Text = "User";
            this.ctlUser.UseVisualStyleBackColor = true;
            // 
            // ctlUserGrid
            // 
            this.ctlUserGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlUserGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.Birthdate,
            this.Age,
            this.Subscriptions,
            this.UserID});
            this.ctlUserGrid.ContextMenuStrip = this.ctlUserContextMenu;
            this.ctlUserGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlUserGrid.Location = new System.Drawing.Point(3, 3);
            this.ctlUserGrid.Name = "ctlUserGrid";
            this.ctlUserGrid.RowHeadersVisible = false;
            this.ctlUserGrid.Size = new System.Drawing.Size(631, 180);
            this.ctlUserGrid.TabIndex = 0;
            this.ctlUserGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ctlUserGrid_ColumnHeaderMouseClick);
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.Frozen = true;
            this.FirstName.HeaderText = "First name";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.Frozen = true;
            this.LastName.HeaderText = "Last name";
            this.LastName.Name = "LastName";
            // 
            // Birthdate
            // 
            this.Birthdate.DataPropertyName = "Birthdate";
            this.Birthdate.Frozen = true;
            this.Birthdate.HeaderText = "Birthdate";
            this.Birthdate.Name = "Birthdate";
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.Frozen = true;
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            // 
            // Subscriptions
            // 
            this.Subscriptions.DataPropertyName = "Subscription";
            this.Subscriptions.Frozen = true;
            this.Subscriptions.HeaderText = "Subscriptions";
            this.Subscriptions.Name = "Subscriptions";
            this.Subscriptions.Width = 230;
            // 
            // UserID
            // 
            this.UserID.Frozen = true;
            this.UserID.HeaderText = "UserID";
            this.UserID.Name = "UserID";
            this.UserID.Visible = false;
            // 
            // ctlUserContextMenu
            // 
            this.ctlUserContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddUser,
            this.btnDeleteUser,
            this.btnEditUserContextMenu});
            this.ctlUserContextMenu.Name = "ctlUserContextMenu";
            this.ctlUserContextMenu.Size = new System.Drawing.Size(108, 70);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(107, 22);
            this.btnAddUser.Text = "Add...";
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(107, 22);
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnEditUserContextMenu
            // 
            this.btnEditUserContextMenu.Name = "btnEditUserContextMenu";
            this.btnEditUserContextMenu.Size = new System.Drawing.Size(107, 22);
            this.btnEditUserContextMenu.Text = "Edit...";
            this.btnEditUserContextMenu.Click += new System.EventHandler(this.btnEditUserContextMenu_Click);
            // 
            // ctlSubscription
            // 
            this.ctlSubscription.Controls.Add(this.ctlSubscriptionGrid);
            this.ctlSubscription.Location = new System.Drawing.Point(4, 22);
            this.ctlSubscription.Name = "ctlSubscription";
            this.ctlSubscription.Padding = new System.Windows.Forms.Padding(3);
            this.ctlSubscription.Size = new System.Drawing.Size(637, 186);
            this.ctlSubscription.TabIndex = 1;
            this.ctlSubscription.Text = "Subscription";
            this.ctlSubscription.UseVisualStyleBackColor = true;
            // 
            // ctlSubscriptionGrid
            // 
            this.ctlSubscriptionGrid.AllowUserToDeleteRows = false;
            this.ctlSubscriptionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlSubscriptionGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameService,
            this.Description});
            this.ctlSubscriptionGrid.ContextMenuStrip = this.ctlSubscriptionContextMenu;
            this.ctlSubscriptionGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlSubscriptionGrid.Location = new System.Drawing.Point(3, 3);
            this.ctlSubscriptionGrid.Name = "ctlSubscriptionGrid";
            this.ctlSubscriptionGrid.ReadOnly = true;
            this.ctlSubscriptionGrid.RowHeadersVisible = false;
            this.ctlSubscriptionGrid.Size = new System.Drawing.Size(631, 180);
            this.ctlSubscriptionGrid.TabIndex = 0;
            // 
            // NameService
            // 
            this.NameService.DataPropertyName = "NameService";
            this.NameService.Frozen = true;
            this.NameService.HeaderText = "Name service";
            this.NameService.Name = "NameService";
            this.NameService.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.Frozen = true;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // ctlSubscriptionContextMenu
            // 
            this.ctlSubscriptionContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddSubscription,
            this.btnDeleteSubscription,
            this.btnSubscriptionContextMenu});
            this.ctlSubscriptionContextMenu.Name = "ctlSubscriptionContextMenu";
            this.ctlSubscriptionContextMenu.Size = new System.Drawing.Size(108, 70);
            // 
            // btnAddSubscription
            // 
            this.btnAddSubscription.Name = "btnAddSubscription";
            this.btnAddSubscription.Size = new System.Drawing.Size(107, 22);
            this.btnAddSubscription.Text = "Add...";
            this.btnAddSubscription.Click += new System.EventHandler(this.btnAddSubscriptionMenu_Click);
            // 
            // btnDeleteSubscription
            // 
            this.btnDeleteSubscription.Name = "btnDeleteSubscription";
            this.btnDeleteSubscription.Size = new System.Drawing.Size(107, 22);
            this.btnDeleteSubscription.Text = "Delete";
            this.btnDeleteSubscription.Click += new System.EventHandler(this.btnDeleteSubscription_Click);
            // 
            // btnSubscriptionContextMenu
            // 
            this.btnSubscriptionContextMenu.Name = "btnSubscriptionContextMenu";
            this.btnSubscriptionContextMenu.Size = new System.Drawing.Size(107, 22);
            this.btnSubscriptionContextMenu.Text = "Edit...";
            this.btnSubscriptionContextMenu.Click += new System.EventHandler(this.btnSubscriptionContextMenu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 236);
            this.Controls.Add(this.ctlPages);
            this.Controls.Add(this.ctlMainMenu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Fitness center";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ctlMainMenu.ResumeLayout(false);
            this.ctlMainMenu.PerformLayout();
            this.ctlPages.ResumeLayout(false);
            this.ctlUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctlUserGrid)).EndInit();
            this.ctlUserContextMenu.ResumeLayout(false);
            this.ctlSubscription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctlSubscriptionGrid)).EndInit();
            this.ctlSubscriptionContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip ctlMainMenu;
        private System.Windows.Forms.ToolStripMenuItem ctlFileMenu;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem ctlEditMenu;
        private System.Windows.Forms.ToolStripMenuItem btnAddUserMenu;
        private System.Windows.Forms.ToolStripMenuItem btnAddSubscriptionMenu;
        private System.Windows.Forms.TabControl ctlPages;
        private System.Windows.Forms.TabPage ctlUser;
        private System.Windows.Forms.DataGridView ctlUserGrid;
        private System.Windows.Forms.TabPage ctlSubscription;
        private System.Windows.Forms.ContextMenuStrip ctlUserContextMenu;
        private System.Windows.Forms.ToolStripMenuItem btnAddUser;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteUser;
        private System.Windows.Forms.ContextMenuStrip ctlSubscriptionContextMenu;
        private System.Windows.Forms.ToolStripMenuItem btnAddSubscription;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteSubscription;
        private System.Windows.Forms.ToolStripMenuItem btnEditUserContextMenu;
        private System.Windows.Forms.ToolStripMenuItem btnSubscriptionContextMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subscriptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridView ctlSubscriptionGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameService;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}

