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
            this.appointmentsGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.addApptButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.apptViewType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentsGrid
            // 
            this.appointmentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentsGrid.Location = new System.Drawing.Point(12, 295);
            this.appointmentsGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.appointmentsGrid.Name = "appointmentsGrid";
            this.appointmentsGrid.Size = new System.Drawing.Size(589, 377);
            this.appointmentsGrid.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Appointments";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 696);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 57);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // addApptButton
            // 
            this.addApptButton.Location = new System.Drawing.Point(351, 696);
            this.addApptButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addApptButton.Name = "addApptButton";
            this.addApptButton.Size = new System.Drawing.Size(121, 57);
            this.addApptButton.TabIndex = 8;
            this.addApptButton.Text = "Add";
            this.addApptButton.UseVisualStyleBackColor = true;
            this.addApptButton.Click += new System.EventHandler(this.addApptButton_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(480, 696);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 57);
            this.button5.TabIndex = 9;
            this.button5.Text = "Modify";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // apptViewType
            // 
            this.apptViewType.FormattingEnabled = true;
            this.apptViewType.Items.AddRange(new object[] {
            "Month",
            "Week"});
            this.apptViewType.Location = new System.Drawing.Point(461, 258);
            this.apptViewType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.apptViewType.Name = "apptViewType";
            this.apptViewType.Size = new System.Drawing.Size(140, 24);
            this.apptViewType.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(406, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "View:";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 216);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Next Appointment";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 773);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.apptViewType);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.addApptButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.appointmentsGrid);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Dashboard";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView appointmentsGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addApptButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox apptViewType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}