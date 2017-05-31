namespace CertifyingCommisionFormUI.SecretaryForms
{
	partial class SecretaryForm
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
			this.labelHelloMessage = new System.Windows.Forms.Label();
			this.buttonMeetings = new System.Windows.Forms.Button();
			this.buttonSecretaries = new System.Windows.Forms.Button();
			this.buttonTeachers = new System.Windows.Forms.Button();
			this.buttonCommissionMembers = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelHelloMessage
			// 
			this.labelHelloMessage.AutoSize = true;
			this.labelHelloMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelHelloMessage.Location = new System.Drawing.Point(75, 9);
			this.labelHelloMessage.Name = "labelHelloMessage";
			this.labelHelloMessage.Size = new System.Drawing.Size(73, 25);
			this.labelHelloMessage.TabIndex = 0;
			this.labelHelloMessage.Text = "Hello ";
			// 
			// buttonMeetings
			// 
			this.buttonMeetings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonMeetings.Location = new System.Drawing.Point(79, 49);
			this.buttonMeetings.Name = "buttonMeetings";
			this.buttonMeetings.Size = new System.Drawing.Size(141, 30);
			this.buttonMeetings.TabIndex = 1;
			this.buttonMeetings.Text = "Meetings";
			this.buttonMeetings.UseVisualStyleBackColor = true;
			this.buttonMeetings.Click += new System.EventHandler(this.buttonMeetings_Click);
			// 
			// buttonSecretaries
			// 
			this.buttonSecretaries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonSecretaries.Location = new System.Drawing.Point(79, 85);
			this.buttonSecretaries.Name = "buttonSecretaries";
			this.buttonSecretaries.Size = new System.Drawing.Size(141, 30);
			this.buttonSecretaries.TabIndex = 2;
			this.buttonSecretaries.Text = "Secretaries";
			this.buttonSecretaries.UseVisualStyleBackColor = true;
			// 
			// buttonTeachers
			// 
			this.buttonTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonTeachers.Location = new System.Drawing.Point(79, 121);
			this.buttonTeachers.Name = "buttonTeachers";
			this.buttonTeachers.Size = new System.Drawing.Size(141, 30);
			this.buttonTeachers.TabIndex = 3;
			this.buttonTeachers.Text = "Teachers";
			this.buttonTeachers.UseVisualStyleBackColor = true;
			// 
			// buttonCommissionMembers
			// 
			this.buttonCommissionMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonCommissionMembers.Location = new System.Drawing.Point(79, 157);
			this.buttonCommissionMembers.Name = "buttonCommissionMembers";
			this.buttonCommissionMembers.Size = new System.Drawing.Size(141, 56);
			this.buttonCommissionMembers.TabIndex = 4;
			this.buttonCommissionMembers.Text = "Commission Members";
			this.buttonCommissionMembers.UseVisualStyleBackColor = true;
			// 
			// buttonExit
			// 
			this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonExit.Location = new System.Drawing.Point(79, 261);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(141, 30);
			this.buttonExit.TabIndex = 5;
			this.buttonExit.Text = "Exit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// SecretaryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(330, 303);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonCommissionMembers);
			this.Controls.Add(this.buttonTeachers);
			this.Controls.Add(this.buttonSecretaries);
			this.Controls.Add(this.buttonMeetings);
			this.Controls.Add(this.labelHelloMessage);
			this.Name = "SecretaryForm";
			this.Text = "Menu";
			this.Load += new System.EventHandler(this.SecretaryForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelHelloMessage;
		private System.Windows.Forms.Button buttonMeetings;
		private System.Windows.Forms.Button buttonSecretaries;
		private System.Windows.Forms.Button buttonTeachers;
		private System.Windows.Forms.Button buttonCommissionMembers;
		private System.Windows.Forms.Button buttonExit;
	}
}