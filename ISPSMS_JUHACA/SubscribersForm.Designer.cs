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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubscribersForm));
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            dashboardPage = new TabPage();
            subscribersPage = new TabPage();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            connectedsubscribersGridView = new DataGridView();
            connectedSubscribersBindingSource = new BindingSource(components);
            addBtn = new MaterialSkin.Controls.MaterialButton();
            billingPage = new TabPage();
            transactionsPage = new TabPage();
            accountsPage = new TabPage();
            activitiesPage = new TabPage();
            subsidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contactNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            planDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            duedateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            currentDuedateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            installationDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            chargeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            balanceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            monthlyChargeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            EditButton = new DataGridViewButtonColumn();
            DisconnectButton = new DataGridViewImageColumn();
            materialTabControl1.SuspendLayout();
            subscribersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)connectedsubscribersGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)connectedSubscribersBindingSource).BeginInit();
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
            subscribersPage.Controls.Add(materialButton1);
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
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(77, 5);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(130, 36);
            materialButton1.TabIndex = 2;
            materialButton1.Text = "disconnected";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // connectedsubscribersGridView
            // 
            connectedsubscribersGridView.AllowUserToResizeColumns = false;
            connectedsubscribersGridView.AllowUserToResizeRows = false;
            connectedsubscribersGridView.AutoGenerateColumns = false;
            connectedsubscribersGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            connectedsubscribersGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            connectedsubscribersGridView.BackgroundColor = SystemColors.ButtonHighlight;
            connectedsubscribersGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            connectedsubscribersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            connectedsubscribersGridView.ColumnHeadersHeight = 29;
            connectedsubscribersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            connectedsubscribersGridView.Columns.AddRange(new DataGridViewColumn[] { subsidDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, contactNumberDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, planDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, duedateDataGridViewTextBoxColumn, currentDuedateDataGridViewTextBoxColumn, installationDateDataGridViewTextBoxColumn, chargeDataGridViewTextBoxColumn, balanceDataGridViewTextBoxColumn, monthlyChargeDataGridViewTextBoxColumn, EditButton, DisconnectButton });
            connectedsubscribersGridView.DataSource = connectedSubscribersBindingSource;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.NullValue = "***";
            dataGridViewCellStyle5.Padding = new Padding(3);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            connectedsubscribersGridView.DefaultCellStyle = dataGridViewCellStyle5;
            connectedsubscribersGridView.EditMode = DataGridViewEditMode.EditOnKeystroke;
            connectedsubscribersGridView.EnableHeadersVisualStyles = false;
            connectedsubscribersGridView.GridColor = SystemColors.ActiveBorder;
            connectedsubscribersGridView.ImeMode = ImeMode.NoControl;
            connectedsubscribersGridView.Location = new Point(0, 45);
            connectedsubscribersGridView.Name = "connectedsubscribersGridView";
            connectedsubscribersGridView.ReadOnly = true;
            connectedsubscribersGridView.RightToLeft = RightToLeft.No;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.DarkSlateBlue;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.InactiveBorder;
            dataGridViewCellStyle6.SelectionBackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            connectedsubscribersGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            connectedsubscribersGridView.RowHeadersWidth = 60;
            connectedsubscribersGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(64, 64, 64);
            connectedsubscribersGridView.RowsDefaultCellStyle = dataGridViewCellStyle7;
            connectedsubscribersGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            connectedsubscribersGridView.Size = new Size(1888, 888);
            connectedsubscribersGridView.TabIndex = 1;
            connectedsubscribersGridView.UseWaitCursor = true;
            connectedsubscribersGridView.CellContentClick += connectedsubscribersGridView_CellContentClick;
            // 
            // connectedSubscribersBindingSource
            // 
            connectedSubscribersBindingSource.DataSource = typeof(Domain.Models.ConnectedSubscribers);
            // 
            // addBtn
            // 
            addBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            addBtn.Depth = 0;
            addBtn.HighEmphasis = true;
            addBtn.Icon = null;
            addBtn.Location = new Point(5, 5);
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
            // subsidDataGridViewTextBoxColumn
            // 
            subsidDataGridViewTextBoxColumn.DataPropertyName = "subs_id";
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            subsidDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            subsidDataGridViewTextBoxColumn.FillWeight = 43.78387F;
            subsidDataGridViewTextBoxColumn.HeaderText = "subs_id";
            subsidDataGridViewTextBoxColumn.MinimumWidth = 6;
            subsidDataGridViewTextBoxColumn.Name = "subsidDataGridViewTextBoxColumn";
            subsidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.FillWeight = 149.732635F;
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 20;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            contactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber";
            contactNumberDataGridViewTextBoxColumn.FillWeight = 114.329826F;
            contactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber";
            contactNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            contactNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.FillWeight = 114.329826F;
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 30;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // planDataGridViewTextBoxColumn
            // 
            planDataGridViewTextBoxColumn.DataPropertyName = "Plan";
            planDataGridViewTextBoxColumn.FillWeight = 114.329826F;
            planDataGridViewTextBoxColumn.HeaderText = "Plan";
            planDataGridViewTextBoxColumn.MinimumWidth = 6;
            planDataGridViewTextBoxColumn.Name = "planDataGridViewTextBoxColumn";
            planDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.FillWeight = 114.329826F;
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // duedateDataGridViewTextBoxColumn
            // 
            duedateDataGridViewTextBoxColumn.DataPropertyName = "Duedate";
            duedateDataGridViewTextBoxColumn.FillWeight = 114.329826F;
            duedateDataGridViewTextBoxColumn.HeaderText = "Duedate";
            duedateDataGridViewTextBoxColumn.MinimumWidth = 6;
            duedateDataGridViewTextBoxColumn.Name = "duedateDataGridViewTextBoxColumn";
            duedateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currentDuedateDataGridViewTextBoxColumn
            // 
            currentDuedateDataGridViewTextBoxColumn.DataPropertyName = "CurrentDuedate";
            currentDuedateDataGridViewTextBoxColumn.FillWeight = 114.329826F;
            currentDuedateDataGridViewTextBoxColumn.HeaderText = "CurrentDuedate";
            currentDuedateDataGridViewTextBoxColumn.MinimumWidth = 6;
            currentDuedateDataGridViewTextBoxColumn.Name = "currentDuedateDataGridViewTextBoxColumn";
            currentDuedateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // installationDateDataGridViewTextBoxColumn
            // 
            installationDateDataGridViewTextBoxColumn.DataPropertyName = "InstallationDate";
            installationDateDataGridViewTextBoxColumn.FillWeight = 114.329826F;
            installationDateDataGridViewTextBoxColumn.HeaderText = "InstallationDate";
            installationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            installationDateDataGridViewTextBoxColumn.Name = "installationDateDataGridViewTextBoxColumn";
            installationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chargeDataGridViewTextBoxColumn
            // 
            chargeDataGridViewTextBoxColumn.DataPropertyName = "Charge";
            chargeDataGridViewTextBoxColumn.FillWeight = 114.329826F;
            chargeDataGridViewTextBoxColumn.HeaderText = "Charge";
            chargeDataGridViewTextBoxColumn.MinimumWidth = 6;
            chargeDataGridViewTextBoxColumn.Name = "chargeDataGridViewTextBoxColumn";
            chargeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            balanceDataGridViewTextBoxColumn.FillWeight = 114.329826F;
            balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            balanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            balanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monthlyChargeDataGridViewTextBoxColumn
            // 
            monthlyChargeDataGridViewTextBoxColumn.DataPropertyName = "MonthlyCharge";
            monthlyChargeDataGridViewTextBoxColumn.FillWeight = 114.329826F;
            monthlyChargeDataGridViewTextBoxColumn.HeaderText = "MonthlyCharge";
            monthlyChargeDataGridViewTextBoxColumn.MinimumWidth = 6;
            monthlyChargeDataGridViewTextBoxColumn.Name = "monthlyChargeDataGridViewTextBoxColumn";
            monthlyChargeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EditButton
            // 
            EditButton.DataPropertyName = "subs_id";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = Color.White;
            EditButton.DefaultCellStyle = dataGridViewCellStyle3;
            EditButton.FillWeight = 32.48716F;
            EditButton.FlatStyle = FlatStyle.Popup;
            EditButton.HeaderText = "";
            EditButton.MinimumWidth = 4;
            EditButton.Name = "EditButton";
            EditButton.ReadOnly = true;
            EditButton.Resizable = DataGridViewTriState.False;
            EditButton.SortMode = DataGridViewColumnSortMode.Automatic;
            EditButton.Text = "";
            EditButton.UseColumnTextForButtonValue = true;
            // 
            // DisconnectButton
            // 
            DisconnectButton.DataPropertyName = "subs_id";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.NullValue = resources.GetObject("dataGridViewCellStyle4.NullValue");
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DisconnectButton.DefaultCellStyle = dataGridViewCellStyle4;
            DisconnectButton.FillWeight = 30F;
            DisconnectButton.HeaderText = "";
            DisconnectButton.Image = Properties.Resources.remove;
            DisconnectButton.MinimumWidth = 4;
            DisconnectButton.Name = "DisconnectButton";
            DisconnectButton.ReadOnly = true;
            DisconnectButton.Resizable = DataGridViewTriState.False;
            DisconnectButton.ToolTipText = "Disconnect";
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
            ((System.ComponentModel.ISupportInitialize)connectedSubscribersBindingSource).EndInit();
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
        private BindingSource connectedSubscribersBindingSource;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private DataGridViewTextBoxColumn subsidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn planDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn duedateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn currentDuedateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn installationDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn chargeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn monthlyChargeDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn EditButton;
        private DataGridViewImageColumn DisconnectButton;
    }
}
