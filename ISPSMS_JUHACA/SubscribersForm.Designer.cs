namespace ISPSMS_JUHACA
{
    partial class SubscribersForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            dashboardPage = new TabPage();
            subscribersPage = new TabPage();
            connectedsubscribersGridView = new DataGridView();
            addBtn = new MaterialSkin.Controls.MaterialButton();
            billingPage = new TabPage();
            transactionsPage = new TabPage();
            accountsPage = new TabPage();
            activitiesPage = new TabPage();
            materialTabControl1.SuspendLayout();
            subscribersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)connectedsubscribersGridView).BeginInit();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(dashboardPage);
            materialTabControl1.Controls.Add(subscribersPage);
            materialTabControl1.Controls.Add(billingPage);
            materialTabControl1.Controls.Add(transactionsPage);
            materialTabControl1.Controls.Add(accountsPage);
            materialTabControl1.Controls.Add(activitiesPage);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1896, 966);
            materialTabControl1.TabIndex = 0;
            // 
            // dashboardPage
            // 
            dashboardPage.Location = new Point(4, 29);
            dashboardPage.Name = "dashboardPage";
            dashboardPage.Padding = new Padding(3);
            dashboardPage.Size = new Size(1888, 933);
            dashboardPage.TabIndex = 0;
            dashboardPage.Text = "Dashboard";
            dashboardPage.UseVisualStyleBackColor = true;
            // 
            // subscribersPage
            // 
            subscribersPage.Controls.Add(connectedsubscribersGridView);
            subscribersPage.Controls.Add(addBtn);
            subscribersPage.Location = new Point(4, 29);
            subscribersPage.Name = "subscribersPage";
            subscribersPage.Padding = new Padding(3);
            subscribersPage.Size = new Size(1888, 933);
            subscribersPage.TabIndex = 1;
            subscribersPage.Text = "Subscribers";
            subscribersPage.UseVisualStyleBackColor = true;
            // 
            // connectedsubscribersGridView
            // 
            connectedsubscribersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            connectedsubscribersGridView.Location = new Point(0, 45);
            connectedsubscribersGridView.Name = "connectedsubscribersGridView";
            connectedsubscribersGridView.RowHeadersWidth = 51;
            connectedsubscribersGridView.Size = new Size(1888, 888);
            connectedsubscribersGridView.TabIndex = 1;
            connectedsubscribersGridView.CellContentClick += connectedsubscribersGridView_CellContentClick;
            // 
            // addBtn
            // 
            addBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            addBtn.Depth = 0;
            addBtn.HighEmphasis = true;
            addBtn.Icon = null;
            addBtn.Location = new Point(0, 0);
            addBtn.Margin = new Padding(4, 6, 4, 6);
            addBtn.MouseState = MaterialSkin.MouseState.HOVER;
            addBtn.Name = "addBtn";
            addBtn.NoAccentTextColor = Color.Empty;
            addBtn.Size = new Size(64, 36);
            addBtn.TabIndex = 0;
            addBtn.Text = "add";
            addBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            addBtn.UseAccentColor = false;
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // billingPage
            // 
            billingPage.Location = new Point(4, 29);
            billingPage.Name = "billingPage";
            billingPage.Size = new Size(1888, 933);
            billingPage.TabIndex = 2;
            billingPage.Text = "Billing";
            billingPage.UseVisualStyleBackColor = true;
            // 
            // transactionsPage
            // 
            transactionsPage.Location = new Point(4, 29);
            transactionsPage.Name = "transactionsPage";
            transactionsPage.Size = new Size(1888, 933);
            transactionsPage.TabIndex = 3;
            transactionsPage.Text = "Transactions";
            transactionsPage.UseVisualStyleBackColor = true;
            // 
            // accountsPage
            // 
            accountsPage.Location = new Point(4, 29);
            accountsPage.Name = "accountsPage";
            accountsPage.Size = new Size(1888, 933);
            accountsPage.TabIndex = 4;
            accountsPage.Text = "Accounts";
            accountsPage.UseVisualStyleBackColor = true;
            // 
            // activitiesPage
            // 
            activitiesPage.Location = new Point(4, 29);
            activitiesPage.Name = "activitiesPage";
            activitiesPage.Size = new Size(1888, 933);
            activitiesPage.TabIndex = 5;
            activitiesPage.Text = "Activities";
            activitiesPage.UseVisualStyleBackColor = true;
            // 
            // SubscribersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(materialTabControl1);
            DrawerAutoHide = false;
            DrawerTabControl = materialTabControl1;
            Name = "SubscribersForm";
            Text = "Form1";
            Load += SubscribersForm_Load;
            materialTabControl1.ResumeLayout(false);
            subscribersPage.ResumeLayout(false);
            subscribersPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)connectedsubscribersGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage dashboardPage;
        private TabPage subscribersPage;
        private TabPage billingPage;
        private TabPage transactionsPage;
        private TabPage accountsPage;
        private MaterialSkin.Controls.MaterialButton addBtn;
        private TabPage activitiesPage;
        public DataGridView connectedsubscribersGridView;
    }
}
