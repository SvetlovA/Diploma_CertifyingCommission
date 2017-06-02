namespace CertifyingCommisionFormUI.SecretaryForms
{
	partial class AddDeleteEditUserForm
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
			this.labelLogin = new System.Windows.Forms.Label();
			this.labelPassword = new System.Windows.Forms.Label();
			this.labelSurname = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.labelPatronymic = new System.Windows.Forms.Label();
			this.textBoxPatronymic = new System.Windows.Forms.TextBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxSurname = new System.Windows.Forms.TextBox();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.textBoxLogin = new System.Windows.Forms.TextBox();
			this.buttonSubmit = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// labelLogin
			// 
			this.labelLogin.AutoSize = true;
			this.labelLogin.Location = new System.Drawing.Point(13, 13);
			this.labelLogin.Name = "labelLogin";
			this.labelLogin.Size = new System.Drawing.Size(36, 13);
			this.labelLogin.TabIndex = 0;
			this.labelLogin.Text = "Login:";
			// 
			// labelPassword
			// 
			this.labelPassword.AutoSize = true;
			this.labelPassword.Location = new System.Drawing.Point(13, 204);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(56, 13);
			this.labelPassword.TabIndex = 1;
			this.labelPassword.Text = "Password:";
			// 
			// labelSurname
			// 
			this.labelSurname.AutoSize = true;
			this.labelSurname.Location = new System.Drawing.Point(13, 56);
			this.labelSurname.Name = "labelSurname";
			this.labelSurname.Size = new System.Drawing.Size(52, 13);
			this.labelSurname.TabIndex = 2;
			this.labelSurname.Text = "Surname:";
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(13, 99);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(38, 13);
			this.labelName.TabIndex = 3;
			this.labelName.Text = "Name:";
			// 
			// labelPatronymic
			// 
			this.labelPatronymic.AutoSize = true;
			this.labelPatronymic.Location = new System.Drawing.Point(13, 142);
			this.labelPatronymic.Name = "labelPatronymic";
			this.labelPatronymic.Size = new System.Drawing.Size(62, 13);
			this.labelPatronymic.TabIndex = 4;
			this.labelPatronymic.Text = "Patronymic:";
			// 
			// textBoxPatronymic
			// 
			this.textBoxPatronymic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxPatronymic.Location = new System.Drawing.Point(81, 139);
			this.textBoxPatronymic.Name = "textBoxPatronymic";
			this.textBoxPatronymic.Size = new System.Drawing.Size(163, 20);
			this.textBoxPatronymic.TabIndex = 5;
			this.textBoxPatronymic.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPatronymic_Validating);
			// 
			// textBoxName
			// 
			this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxName.Location = new System.Drawing.Point(81, 96);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(163, 20);
			this.textBoxName.TabIndex = 6;
			this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxName_Validating);
			// 
			// textBoxSurname
			// 
			this.textBoxSurname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxSurname.Location = new System.Drawing.Point(81, 53);
			this.textBoxSurname.Name = "textBoxSurname";
			this.textBoxSurname.Size = new System.Drawing.Size(163, 20);
			this.textBoxSurname.TabIndex = 7;
			this.textBoxSurname.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSurname_Validating);
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxPassword.Location = new System.Drawing.Point(81, 201);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(163, 20);
			this.textBoxPassword.TabIndex = 8;
			this.textBoxPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPassword_Validating);
			// 
			// textBoxLogin
			// 
			this.textBoxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxLogin.Location = new System.Drawing.Point(81, 10);
			this.textBoxLogin.Name = "textBoxLogin";
			this.textBoxLogin.Size = new System.Drawing.Size(163, 20);
			this.textBoxLogin.TabIndex = 9;
			this.textBoxLogin.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxLogin_Validating);
			// 
			// buttonSubmit
			// 
			this.buttonSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSubmit.Location = new System.Drawing.Point(94, 240);
			this.buttonSubmit.Name = "buttonSubmit";
			this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
			this.buttonSubmit.TabIndex = 10;
			this.buttonSubmit.Text = "OK";
			this.buttonSubmit.UseVisualStyleBackColor = true;
			this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(175, 240);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 11;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// AddDeleteEditUserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(262, 275);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSubmit);
			this.Controls.Add(this.textBoxLogin);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.textBoxSurname);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.textBoxPatronymic);
			this.Controls.Add(this.labelPatronymic);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.labelSurname);
			this.Controls.Add(this.labelPassword);
			this.Controls.Add(this.labelLogin);
			this.Name = "AddDeleteEditUserForm";
			this.Text = "AddDeleteEditUserForm";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelLogin;
		private System.Windows.Forms.Label labelPassword;
		private System.Windows.Forms.Label labelSurname;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelPatronymic;
		private System.Windows.Forms.TextBox textBoxPatronymic;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxSurname;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.TextBox textBoxLogin;
		private System.Windows.Forms.Button buttonSubmit;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.ErrorProvider errorProvider;
	}
}