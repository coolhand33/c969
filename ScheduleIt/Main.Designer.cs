namespace ScheduleIt
{
    partial class Main
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
            this.label2 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.apptViewType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.appointmentGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.apptTab = new System.Windows.Forms.TabPage();
            this.custTab = new System.Windows.Forms.TabPage();
            this.customersDataGrid = new System.Windows.Forms.DataGridView();
            this.reportsTab = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.reportResultBox = new System.Windows.Forms.GroupBox();
            this.runReport = new System.Windows.Forms.Button();
            this.reportList = new System.Windows.Forms.ListBox();
            this.reminderTimer = new System.Windows.Forms.Timer(this.components);
            this.reportResultsGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.apptTab.SuspendLayout();
            this.custTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGrid)).BeginInit();
            this.reportsTab.SuspendLayout();
            this.reportResultBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportResultsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Appointments";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(12, 703);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(121, 57);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(810, 703);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(121, 57);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.modifyButton.Location = new System.Drawing.Point(937, 703);
            this.modifyButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(121, 57);
            this.modifyButton.TabIndex = 9;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // apptViewType
            // 
            this.apptViewType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.apptViewType.FormattingEnabled = true;
            this.apptViewType.Items.AddRange(new object[] {
            "Month",
            "Week"});
            this.apptViewType.Location = new System.Drawing.Point(914, 12);
            this.apptViewType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.apptViewType.Name = "apptViewType";
            this.apptViewType.Size = new System.Drawing.Size(140, 24);
            this.apptViewType.TabIndex = 11;
            this.apptViewType.SelectedIndexChanged += new System.EventHandler(this.apptViewType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(867, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "View:";
            // 
            // appointmentGridView
            // 
            this.appointmentGridView.AllowUserToAddRows = false;
            this.appointmentGridView.AllowUserToDeleteRows = false;
            this.appointmentGridView.AllowUserToResizeRows = false;
            this.appointmentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.appointmentGridView.CausesValidation = false;
            this.appointmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.appointmentGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.appointmentGridView.Location = new System.Drawing.Point(9, 43);
            this.appointmentGridView.MultiSelect = false;
            this.appointmentGridView.Name = "appointmentGridView";
            this.appointmentGridView.ReadOnly = true;
            this.appointmentGridView.RowHeadersVisible = false;
            this.appointmentGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.appointmentGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointmentGridView.ShowCellErrors = false;
            this.appointmentGridView.ShowCellToolTips = false;
            this.appointmentGridView.ShowEditingIcon = false;
            this.appointmentGridView.ShowRowErrors = false;
            this.appointmentGridView.Size = new System.Drawing.Size(1047, 621);
            this.appointmentGridView.TabIndex = 14;
            this.appointmentGridView.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.apptTab);
            this.tabControl1.Controls.Add(this.custTab);
            this.tabControl1.Controls.Add(this.reportsTab);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1070, 696);
            this.tabControl1.TabIndex = 15;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // apptTab
            // 
            this.apptTab.Controls.Add(this.apptViewType);
            this.apptTab.Controls.Add(this.label3);
            this.apptTab.Controls.Add(this.label2);
            this.apptTab.Controls.Add(this.appointmentGridView);
            this.apptTab.Location = new System.Drawing.Point(4, 25);
            this.apptTab.Name = "apptTab";
            this.apptTab.Padding = new System.Windows.Forms.Padding(3);
            this.apptTab.Size = new System.Drawing.Size(1062, 667);
            this.apptTab.TabIndex = 0;
            this.apptTab.Text = "Appointments";
            this.apptTab.UseVisualStyleBackColor = true;
            // 
            // custTab
            // 
            this.custTab.Controls.Add(this.customersDataGrid);
            this.custTab.Location = new System.Drawing.Point(4, 25);
            this.custTab.Name = "custTab";
            this.custTab.Padding = new System.Windows.Forms.Padding(3);
            this.custTab.Size = new System.Drawing.Size(1062, 667);
            this.custTab.TabIndex = 1;
            this.custTab.Text = "Customers";
            this.custTab.UseVisualStyleBackColor = true;
            // 
            // customersDataGrid
            // 
            this.customersDataGrid.AllowUserToAddRows = false;
            this.customersDataGrid.AllowUserToDeleteRows = false;
            this.customersDataGrid.AllowUserToResizeRows = false;
            this.customersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customersDataGrid.CausesValidation = false;
            this.customersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.customersDataGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.customersDataGrid.Location = new System.Drawing.Point(3, 3);
            this.customersDataGrid.MultiSelect = false;
            this.customersDataGrid.Name = "customersDataGrid";
            this.customersDataGrid.RowHeadersVisible = false;
            this.customersDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customersDataGrid.Size = new System.Drawing.Size(1056, 661);
            this.customersDataGrid.TabIndex = 0;
            // 
            // reportsTab
            // 
            this.reportsTab.Controls.Add(this.textBox1);
            this.reportsTab.Controls.Add(this.reportResultBox);
            this.reportsTab.Controls.Add(this.runReport);
            this.reportsTab.Controls.Add(this.reportList);
            this.reportsTab.Location = new System.Drawing.Point(4, 25);
            this.reportsTab.Name = "reportsTab";
            this.reportsTab.Size = new System.Drawing.Size(1062, 667);
            this.reportsTab.TabIndex = 2;
            this.reportsTab.Text = "Reports";
            this.reportsTab.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(8, 83);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(391, 97);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "Welcome to the report viewer!\r\n\r\nPlease select a report from the list then click " +
    "the \'Run Report\' button.";
            // 
            // reportResultBox
            // 
            this.reportResultBox.Controls.Add(this.reportResultsGrid);
            this.reportResultBox.Location = new System.Drawing.Point(413, 19);
            this.reportResultBox.Name = "reportResultBox";
            this.reportResultBox.Size = new System.Drawing.Size(640, 628);
            this.reportResultBox.TabIndex = 17;
            this.reportResultBox.TabStop = false;
            this.reportResultBox.Text = "Report Results";
            // 
            // runReport
            // 
            this.runReport.Enabled = false;
            this.runReport.Location = new System.Drawing.Point(100, 552);
            this.runReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.runReport.Name = "runReport";
            this.runReport.Size = new System.Drawing.Size(206, 67);
            this.runReport.TabIndex = 16;
            this.runReport.Text = "Run Report";
            this.runReport.UseVisualStyleBackColor = true;
            this.runReport.Click += new System.EventHandler(this.runReport_Click);
            // 
            // reportList
            // 
            this.reportList.FormattingEnabled = true;
            this.reportList.ItemHeight = 16;
            this.reportList.Items.AddRange(new object[] {
            "Appointment types by month",
            "Schedule for each consultant",
            "Total number of appointments per month"});
            this.reportList.Location = new System.Drawing.Point(8, 243);
            this.reportList.Name = "reportList";
            this.reportList.Size = new System.Drawing.Size(391, 276);
            this.reportList.TabIndex = 0;
            this.reportList.SelectedIndexChanged += new System.EventHandler(this.reportList_SelectedIndexChanged);
            // 
            // reminderTimer
            // 
            this.reminderTimer.Enabled = true;
            this.reminderTimer.Interval = 1000;
            this.reminderTimer.Tick += new System.EventHandler(this.reminderTimer_Tick);
            // 
            // reportResultsGrid
            // 
            this.reportResultsGrid.AllowUserToAddRows = false;
            this.reportResultsGrid.AllowUserToDeleteRows = false;
            this.reportResultsGrid.AllowUserToResizeRows = false;
            this.reportResultsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reportResultsGrid.CausesValidation = false;
            this.reportResultsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.reportResultsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.reportResultsGrid.Location = new System.Drawing.Point(6, 22);
            this.reportResultsGrid.MultiSelect = false;
            this.reportResultsGrid.Name = "reportResultsGrid";
            this.reportResultsGrid.ReadOnly = true;
            this.reportResultsGrid.RowHeadersVisible = false;
            this.reportResultsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.reportResultsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reportResultsGrid.ShowCellErrors = false;
            this.reportResultsGrid.ShowCellToolTips = false;
            this.reportResultsGrid.ShowEditingIcon = false;
            this.reportResultsGrid.ShowRowErrors = false;
            this.reportResultsGrid.Size = new System.Drawing.Size(628, 600);
            this.reportResultsGrid.TabIndex = 15;
            this.reportResultsGrid.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 773);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.apptTab.ResumeLayout(false);
            this.apptTab.PerformLayout();
            this.custTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGrid)).EndInit();
            this.reportsTab.ResumeLayout(false);
            this.reportsTab.PerformLayout();
            this.reportResultBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportResultsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.ComboBox apptViewType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView appointmentGridView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage apptTab;
        private System.Windows.Forms.TabPage custTab;
        private System.Windows.Forms.DataGridView customersDataGrid;
        private System.Windows.Forms.Timer reminderTimer;
        private System.Windows.Forms.TabPage reportsTab;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox reportResultBox;
        private System.Windows.Forms.Button runReport;
        private System.Windows.Forms.ListBox reportList;
        private System.Windows.Forms.DataGridView reportResultsGrid;
    }
}