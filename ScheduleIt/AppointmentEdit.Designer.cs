namespace ScheduleIt
{
    partial class AppointmentEdit
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
            this.addApptLabel = new System.Windows.Forms.Label();
            this.modifyApptLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.newCustomer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.contactBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.locationBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.apptEditCancel = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.endTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addApptLabel
            // 
            this.addApptLabel.AutoSize = true;
            this.addApptLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addApptLabel.Location = new System.Drawing.Point(12, 9);
            this.addApptLabel.Name = "addApptLabel";
            this.addApptLabel.Size = new System.Drawing.Size(135, 19);
            this.addApptLabel.TabIndex = 0;
            this.addApptLabel.Text = "Add Appointment";
            // 
            // modifyApptLabel
            // 
            this.modifyApptLabel.AutoSize = true;
            this.modifyApptLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyApptLabel.Location = new System.Drawing.Point(12, 9);
            this.modifyApptLabel.Name = "modifyApptLabel";
            this.modifyApptLabel.Size = new System.Drawing.Size(153, 19);
            this.modifyApptLabel.TabIndex = 1;
            this.modifyApptLabel.Text = "Modify Appointment";
            this.modifyApptLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer:";
            // 
            // customerComboBox
            // 
            this.customerComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.customerComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Items.AddRange(new object[] {
            " "});
            this.customerComboBox.Location = new System.Drawing.Point(85, 62);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(238, 21);
            this.customerComboBox.TabIndex = 3;
            // 
            // newCustomer
            // 
            this.newCustomer.Location = new System.Drawing.Point(341, 61);
            this.newCustomer.Name = "newCustomer";
            this.newCustomer.Size = new System.Drawing.Size(125, 23);
            this.newCustomer.TabIndex = 4;
            this.newCustomer.Text = "New Customer";
            this.newCustomer.UseVisualStyleBackColor = true;
            this.newCustomer.Click += new System.EventHandler(this.newCustomer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.endDate);
            this.groupBox2.Controls.Add(this.endTime);
            this.groupBox2.Controls.Add(this.startDate);
            this.groupBox2.Controls.Add(this.startTime);
            this.groupBox2.Controls.Add(this.contactBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.typeBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.urlBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.descriptionBox);
            this.groupBox2.Controls.Add(this.locationBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.titleBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 490);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appointment Details";
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(74, 194);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(247, 23);
            this.startDate.TabIndex = 7;
            this.startDate.Value = new System.DateTime(2019, 3, 16, 0, 0, 0, 0);
            // 
            // startTime
            // 
            this.startTime.CustomFormat = "hh:mm tt";
            this.startTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTime.Location = new System.Drawing.Point(327, 194);
            this.startTime.Name = "startTime";
            this.startTime.ShowUpDown = true;
            this.startTime.Size = new System.Drawing.Size(108, 23);
            this.startTime.TabIndex = 8;
            // 
            // contactBox
            // 
            this.contactBox.Location = new System.Drawing.Point(72, 27);
            this.contactBox.Name = "contactBox";
            this.contactBox.Size = new System.Drawing.Size(363, 23);
            this.contactBox.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Contact:";
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(72, 66);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(363, 23);
            this.typeBox.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 427);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "URL";
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(12, 446);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(423, 23);
            this.urlBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Description";
            // 
            // descriptionBox
            // 
            this.descriptionBox.AcceptsReturn = true;
            this.descriptionBox.Location = new System.Drawing.Point(12, 318);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(423, 93);
            this.descriptionBox.TabIndex = 11;
            // 
            // locationBox
            // 
            this.locationBox.Location = new System.Drawing.Point(72, 144);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(363, 23);
            this.locationBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Location:";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(72, 106);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(363, 23);
            this.titleBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title:";
            // 
            // apptEditCancel
            // 
            this.apptEditCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.apptEditCancel.Location = new System.Drawing.Point(16, 621);
            this.apptEditCancel.Name = "apptEditCancel";
            this.apptEditCancel.Size = new System.Drawing.Size(121, 45);
            this.apptEditCancel.TabIndex = 16;
            this.apptEditCancel.Text = "Cancel";
            this.apptEditCancel.UseVisualStyleBackColor = true;
            this.apptEditCancel.Click += new System.EventHandler(this.apptEditCancel_Click);
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Location = new System.Drawing.Point(345, 621);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(121, 45);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(74, 247);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(247, 23);
            this.endDate.TabIndex = 9;
            this.endDate.Value = new System.DateTime(2019, 3, 16, 0, 0, 0, 0);
            // 
            // endTime
            // 
            this.endTime.CustomFormat = "hh:mm tt";
            this.endTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTime.Location = new System.Drawing.Point(327, 247);
            this.endTime.Name = "endTime";
            this.endTime.ShowUpDown = true;
            this.endTime.Size = new System.Drawing.Size(108, 23);
            this.endTime.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "End:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Start:";
            // 
            // AppointmentEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 674);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.apptEditCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.newCustomer);
            this.Controls.Add(this.customerComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modifyApptLabel);
            this.Controls.Add(this.addApptLabel);
            this.Name = "AppointmentEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Appointment";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addApptLabel;
        private System.Windows.Forms.Label modifyApptLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.Button newCustomer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox locationBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button apptEditCancel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox contactBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker startTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.DateTimePicker endTime;
    }
}