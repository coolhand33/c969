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
            this.label2 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.apptViewType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.appointmentGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.apptTab = new System.Windows.Forms.TabPage();
            this.custTab = new System.Windows.Forms.TabPage();
            this.customersDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.apptTab.SuspendLayout();
            this.custTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 242);
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
            this.apptViewType.Location = new System.Drawing.Point(916, 242);
            this.apptViewType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.apptViewType.Name = "apptViewType";
            this.apptViewType.Size = new System.Drawing.Size(140, 24);
            this.apptViewType.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(869, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "View:";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1045, 216);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Next Appointment";
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
            this.appointmentGridView.Location = new System.Drawing.Point(9, 281);
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
            this.appointmentGridView.Size = new System.Drawing.Size(1047, 383);
            this.appointmentGridView.TabIndex = 14;
            this.appointmentGridView.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.apptTab);
            this.tabControl1.Controls.Add(this.custTab);
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
            this.apptTab.Controls.Add(this.groupBox1);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.ComboBox apptViewType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView appointmentGridView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage apptTab;
        private System.Windows.Forms.TabPage custTab;
        private System.Windows.Forms.DataGridView customersDataGrid;
    }
}