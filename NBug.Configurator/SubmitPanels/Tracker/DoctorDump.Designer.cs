namespace NBug.Configurator.SubmitPanels.Tracker
{
    partial class DoctorDump
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label EmailLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.AppIdTextBox = new System.Windows.Forms.TextBox();
            this.NewIdButton = new System.Windows.Forms.Button();
            this.emailNotValid = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            EmailLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.emailNotValid)).BeginInit();
            this.SuspendLayout();
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new System.Drawing.Point(3, 0);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new System.Drawing.Size(116, 13);
            EmailLabel.TabIndex = 0;
            EmailLabel.Text = "Send a report to e-mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(8, 51);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(111, 13);
            label3.TabIndex = 6;
            label3.Text = "Application unique ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.SystemColors.ControlText;
            label4.Location = new System.Drawing.Point(42, 104);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(406, 13);
            label4.TabIndex = 9;
            label4.Text = "NBug sends a report on next app start after crash. Start app again to send the re" +
    "port.";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailNotValid.SetError(this.EmailTextBox, "Valid e-mail address is required.");
            this.EmailTextBox.Location = new System.Drawing.Point(3, 16);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(579, 20);
            this.EmailTextBox.TabIndex = 1;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // AppIdTextBox
            // 
            this.AppIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppIdTextBox.Location = new System.Drawing.Point(5, 67);
            this.AppIdTextBox.Name = "AppIdTextBox";
            this.AppIdTextBox.ReadOnly = true;
            this.AppIdTextBox.Size = new System.Drawing.Size(474, 20);
            this.AppIdTextBox.TabIndex = 7;
            // 
            // NewIdButton
            // 
            this.NewIdButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewIdButton.Location = new System.Drawing.Point(485, 65);
            this.NewIdButton.Name = "NewIdButton";
            this.NewIdButton.Size = new System.Drawing.Size(99, 23);
            this.NewIdButton.TabIndex = 8;
            this.NewIdButton.Text = "Generate New";
            this.NewIdButton.UseVisualStyleBackColor = true;
            this.NewIdButton.Click += new System.EventHandler(this.NewIdButton_Click);
            // 
            // emailNotValid
            // 
            this.emailNotValid.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(5, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Note:";
            // 
            // DoctorDump
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(label4);
            this.Controls.Add(this.NewIdButton);
            this.Controls.Add(this.AppIdTextBox);
            this.Controls.Add(label3);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(EmailLabel);
            this.Name = "DoctorDump";
            this.Size = new System.Drawing.Size(600, 235);
            ((System.ComponentModel.ISupportInitialize)(this.emailNotValid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox AppIdTextBox;
        private System.Windows.Forms.Button NewIdButton;
        private System.Windows.Forms.ErrorProvider emailNotValid;
        private System.Windows.Forms.Label label5;

    }
}
