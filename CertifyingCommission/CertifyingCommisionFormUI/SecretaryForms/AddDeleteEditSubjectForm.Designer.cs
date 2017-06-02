namespace CertifyingCommisionFormUI.SecretaryForms
{
	partial class AddDeleteEditSubjectForm
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
			this.labelSubjectName = new System.Windows.Forms.Label();
			this.textBoxSubjectName = new System.Windows.Forms.TextBox();
			this.buttonSubmit = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// labelSubjectName
			// 
			this.labelSubjectName.AutoSize = true;
			this.labelSubjectName.Location = new System.Drawing.Point(13, 13);
			this.labelSubjectName.Name = "labelSubjectName";
			this.labelSubjectName.Size = new System.Drawing.Size(87, 13);
			this.labelSubjectName.TabIndex = 0;
			this.labelSubjectName.Text = "Name of subject:";
			// 
			// textBoxSubjectName
			// 
			this.textBoxSubjectName.Location = new System.Drawing.Point(106, 10);
			this.textBoxSubjectName.Name = "textBoxSubjectName";
			this.textBoxSubjectName.Size = new System.Drawing.Size(166, 20);
			this.textBoxSubjectName.TabIndex = 1;
			this.textBoxSubjectName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSubjectName_Validating);
			// 
			// buttonSubmit
			// 
			this.buttonSubmit.Location = new System.Drawing.Point(116, 77);
			this.buttonSubmit.Name = "buttonSubmit";
			this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
			this.buttonSubmit.TabIndex = 2;
			this.buttonSubmit.Text = "OK";
			this.buttonSubmit.UseVisualStyleBackColor = true;
			this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(197, 77);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// AddDeleteEditSubjectValidatableForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(291, 112);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSubmit);
			this.Controls.Add(this.textBoxSubjectName);
			this.Controls.Add(this.labelSubjectName);
			this.Name = "AddDeleteEditSubjectValidatableForm";
			this.Text = "AddDeleteEditSubjectForm";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelSubjectName;
		private System.Windows.Forms.TextBox textBoxSubjectName;
		private System.Windows.Forms.Button buttonSubmit;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.ErrorProvider errorProvider;
	}
}