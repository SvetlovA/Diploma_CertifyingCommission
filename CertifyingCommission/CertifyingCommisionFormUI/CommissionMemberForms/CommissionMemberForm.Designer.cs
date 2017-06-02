namespace CertifyingCommisionFormUI.CommissionMemberForms
{
	partial class CommissionMemberForm
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
			this.buttonSubmitedMeetings = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelHelloMessage
			// 
			this.labelHelloMessage.AutoSize = true;
			this.labelHelloMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelHelloMessage.Location = new System.Drawing.Point(89, 9);
			this.labelHelloMessage.Name = "labelHelloMessage";
			this.labelHelloMessage.Size = new System.Drawing.Size(73, 25);
			this.labelHelloMessage.TabIndex = 1;
			this.labelHelloMessage.Text = "Hello ";
			// 
			// buttonSubmitedMeetings
			// 
			this.buttonSubmitedMeetings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonSubmitedMeetings.Location = new System.Drawing.Point(94, 61);
			this.buttonSubmitedMeetings.Name = "buttonSubmitedMeetings";
			this.buttonSubmitedMeetings.Size = new System.Drawing.Size(141, 53);
			this.buttonSubmitedMeetings.TabIndex = 2;
			this.buttonSubmitedMeetings.Text = "Submited Meetings";
			this.buttonSubmitedMeetings.UseVisualStyleBackColor = true;
			this.buttonSubmitedMeetings.Click += new System.EventHandler(this.buttonConfirmedMeetings_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonExit.Location = new System.Drawing.Point(94, 155);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(141, 30);
			this.buttonExit.TabIndex = 3;
			this.buttonExit.Text = "Exit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// CommissionMemberForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(338, 197);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonSubmitedMeetings);
			this.Controls.Add(this.labelHelloMessage);
			this.Name = "CommissionMemberForm";
			this.Text = "Commission Member";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CommissionMemberForm_FormClosed);
			this.Load += new System.EventHandler(this.CommissionMemberForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelHelloMessage;
		private System.Windows.Forms.Button buttonSubmitedMeetings;
		private System.Windows.Forms.Button buttonExit;
	}
}