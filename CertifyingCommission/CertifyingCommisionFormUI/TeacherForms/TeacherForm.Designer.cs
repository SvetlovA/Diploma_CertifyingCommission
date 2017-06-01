namespace CertifyingCommisionFormUI.TeacherForms
{
	partial class TeacherForm
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
			this.buttonCreateMeeting = new System.Windows.Forms.Button();
			this.buttonSetSubject = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.buttonMeetings = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelHelloMessage
			// 
			this.labelHelloMessage.AutoSize = true;
			this.labelHelloMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelHelloMessage.Location = new System.Drawing.Point(64, 9);
			this.labelHelloMessage.Name = "labelHelloMessage";
			this.labelHelloMessage.Size = new System.Drawing.Size(73, 25);
			this.labelHelloMessage.TabIndex = 1;
			this.labelHelloMessage.Text = "Hello ";
			// 
			// buttonCreateMeeting
			// 
			this.buttonCreateMeeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonCreateMeeting.Location = new System.Drawing.Point(69, 82);
			this.buttonCreateMeeting.Name = "buttonCreateMeeting";
			this.buttonCreateMeeting.Size = new System.Drawing.Size(141, 30);
			this.buttonCreateMeeting.TabIndex = 2;
			this.buttonCreateMeeting.Text = "Create meeting";
			this.buttonCreateMeeting.UseVisualStyleBackColor = true;
			this.buttonCreateMeeting.Click += new System.EventHandler(this.buttonCreateMeeting_Click);
			// 
			// buttonSetSubject
			// 
			this.buttonSetSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonSetSubject.Location = new System.Drawing.Point(69, 118);
			this.buttonSetSubject.Name = "buttonSetSubject";
			this.buttonSetSubject.Size = new System.Drawing.Size(141, 30);
			this.buttonSetSubject.TabIndex = 3;
			this.buttonSetSubject.Text = "Set subject";
			this.buttonSetSubject.UseVisualStyleBackColor = true;
			this.buttonSetSubject.Click += new System.EventHandler(this.buttonSetSubject_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonExit.Location = new System.Drawing.Point(69, 182);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(141, 30);
			this.buttonExit.TabIndex = 4;
			this.buttonExit.Text = "Exit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// buttonMeetings
			// 
			this.buttonMeetings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonMeetings.Location = new System.Drawing.Point(69, 46);
			this.buttonMeetings.Name = "buttonMeetings";
			this.buttonMeetings.Size = new System.Drawing.Size(141, 30);
			this.buttonMeetings.TabIndex = 5;
			this.buttonMeetings.Text = "My meetings";
			this.buttonMeetings.UseVisualStyleBackColor = true;
			this.buttonMeetings.Click += new System.EventHandler(this.buttonMeetings_Click);
			// 
			// TeacherForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(290, 224);
			this.Controls.Add(this.buttonMeetings);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonSetSubject);
			this.Controls.Add(this.buttonCreateMeeting);
			this.Controls.Add(this.labelHelloMessage);
			this.Name = "TeacherForm";
			this.Text = "TeacherForm";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeacherForm_FormClosed);
			this.Load += new System.EventHandler(this.TeacherForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelHelloMessage;
		private System.Windows.Forms.Button buttonCreateMeeting;
		private System.Windows.Forms.Button buttonSetSubject;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Button buttonMeetings;
	}
}