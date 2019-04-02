namespace ScheduleIt
{
    partial class CustomerEdit
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
            this.custAddLabel = new System.Windows.Forms.Label();
            this.custModifyLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.customerActive = new System.Windows.Forms.CheckBox();
            this.customerCancel = new System.Windows.Forms.Button();
            this.customerSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressBox = new System.Windows.Forms.TextBox();
            this.address2Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.countryBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.postalCodeBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // custAddLabel
            // 
            this.custAddLabel.AutoSize = true;
            this.custAddLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custAddLabel.Location = new System.Drawing.Point(12, 9);
            this.custAddLabel.Name = "custAddLabel";
            this.custAddLabel.Size = new System.Drawing.Size(111, 19);
            this.custAddLabel.TabIndex = 3000;
            this.custAddLabel.Text = "Add Customer";
            this.custAddLabel.Visible = false;
            // 
            // custModifyLabel
            // 
            this.custModifyLabel.AutoSize = true;
            this.custModifyLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custModifyLabel.Location = new System.Drawing.Point(12, 9);
            this.custModifyLabel.Name = "custModifyLabel";
            this.custModifyLabel.Size = new System.Drawing.Size(129, 19);
            this.custModifyLabel.TabIndex = 3000;
            this.custModifyLabel.Text = "Modify Customer";
            this.custModifyLabel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 3000;
            this.label3.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(19, 86);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(392, 23);
            this.nameBox.TabIndex = 2;
            this.nameBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameBox_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 3000;
            this.label5.Text = "Address";
            // 
            // customerActive
            // 
            this.customerActive.AutoSize = true;
            this.customerActive.CausesValidation = false;
            this.customerActive.Checked = true;
            this.customerActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.customerActive.Location = new System.Drawing.Point(344, 12);
            this.customerActive.Name = "customerActive";
            this.customerActive.Size = new System.Drawing.Size(67, 20);
            this.customerActive.TabIndex = 1;
            this.customerActive.Text = "Active?";
            this.customerActive.UseVisualStyleBackColor = true;
            // 
            // customerCancel
            // 
            this.customerCancel.CausesValidation = false;
            this.customerCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.customerCancel.Location = new System.Drawing.Point(19, 457);
            this.customerCancel.Name = "customerCancel";
            this.customerCancel.Size = new System.Drawing.Size(116, 39);
            this.customerCancel.TabIndex = 10;
            this.customerCancel.Text = "Cancel";
            this.customerCancel.UseVisualStyleBackColor = true;
            this.customerCancel.Click += new System.EventHandler(this.customerCancel_Click);
            // 
            // customerSave
            // 
            this.customerSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.customerSave.Location = new System.Drawing.Point(295, 457);
            this.customerSave.Name = "customerSave";
            this.customerSave.Size = new System.Drawing.Size(116, 39);
            this.customerSave.TabIndex = 9;
            this.customerSave.Text = "Save";
            this.customerSave.UseVisualStyleBackColor = true;
            this.customerSave.Click += new System.EventHandler(this.customerSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 9002;
            this.label1.Text = "Phone";
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(19, 210);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(392, 23);
            this.addressBox.TabIndex = 4;
            this.addressBox.Validating += new System.ComponentModel.CancelEventHandler(this.addressBox_Validating);
            // 
            // address2Box
            // 
            this.address2Box.Location = new System.Drawing.Point(19, 269);
            this.address2Box.Name = "address2Box";
            this.address2Box.Size = new System.Drawing.Size(392, 23);
            this.address2Box.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 9004;
            this.label2.Text = "Address2";
            // 
            // cityBox
            // 
            this.cityBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cityBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cityBox.Location = new System.Drawing.Point(19, 329);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(206, 23);
            this.cityBox.TabIndex = 6;
            this.cityBox.Validating += new System.ComponentModel.CancelEventHandler(this.cityBox_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 9006;
            this.label4.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 9008;
            this.label6.Text = "Postal Code";
            // 
            // countryBox
            // 
            this.countryBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.countryBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.countryBox.Location = new System.Drawing.Point(19, 390);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(392, 23);
            this.countryBox.TabIndex = 8;
            this.countryBox.Validating += new System.ComponentModel.CancelEventHandler(this.countryBox_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 9000;
            this.label7.Text = "Country";
            // 
            // postalCodeBox
            // 
            this.postalCodeBox.Location = new System.Drawing.Point(280, 329);
            this.postalCodeBox.Name = "postalCodeBox";
            this.postalCodeBox.Size = new System.Drawing.Size(131, 23);
            this.postalCodeBox.TabIndex = 7;
            this.postalCodeBox.Validating += new System.ComponentModel.CancelEventHandler(this.postalCodeBox_Validating);
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(19, 149);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(392, 23);
            this.phoneBox.TabIndex = 3;
            this.phoneBox.Validating += new System.ComponentModel.CancelEventHandler(this.phoneBox_Validating);
            // 
            // CustomerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 508);
            this.Controls.Add(this.countryBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.postalCodeBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.address2Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerSave);
            this.Controls.Add(this.customerCancel);
            this.Controls.Add(this.customerActive);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.custModifyLabel);
            this.Controls.Add(this.custAddLabel);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CustomerEdit";
            this.Text = "Add/Edit Customer";
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label custAddLabel;
        private System.Windows.Forms.Label custModifyLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox customerActive;
        private System.Windows.Forms.Button customerCancel;
        private System.Windows.Forms.Button customerSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource addressBindingSource;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox address2Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox countryBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox postalCodeBox;
        private System.Windows.Forms.TextBox phoneBox;
    }
}