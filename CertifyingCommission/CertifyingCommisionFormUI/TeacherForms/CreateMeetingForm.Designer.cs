namespace CertifyingCommisionFormUI.TeacherForms
{
	partial class CreateMeetingForm
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
			this.labelInform = new System.Windows.Forms.Label();
			this.labelSelectPotfolioFile = new System.Windows.Forms.Label();
			this.buttonSelect = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.labelSelectedFileName = new System.Windows.Forms.Label();
			this.buttonCreate = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelInform
			// 
			this.labelInform.AutoSize = true;
			this.labelInform.Location = new System.Drawing.Point(13, 13);
			this.labelInform.Name = "labelInform";
			this.labelInform.Size = new System.Drawing.Size(267, 13);
			this.labelInform.TabIndex = 0;
			this.labelInform.Text = "To create meeting you need to attach your portfolio file.";
			// 
			// labelSelectPotfolioFile
			// 
			this.labelSelectPotfolioFile.AutoSize = true;
			this.labelSelectPotfolioFile.Location = new System.Drawing.Point(13, 50);
			this.labelSelectPotfolioFile.Name = "labelSelectPotfolioFile";
			this.labelSelectPotfolioFile.Size = new System.Drawing.Size(96, 13);
			this.labelSelectPotfolioFile.TabIndex = 1;
			this.labelSelectPotfolioFile.Text = "Select portfolio file:";
			// 
			// buttonSelect
			// 
			this.buttonSelect.Location = new System.Drawing.Point(115, 45);
			this.buttonSelect.Name = "buttonSelect";
			this.buttonSelect.Size = new System.Drawing.Size(75, 23);
			this.buttonSelect.TabIndex = 2;
			this.buttonSelect.Text = "Select";
			this.buttonSelect.UseVisualStyleBackColor = true;
			this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
			// 
			// openFileDialog
			// 
			this.openFileDialog.Filter = "\"Text files|*.txt|Doc files|*.doc|Docx files|*.docx\"";
			// 
			// labelSelectedFileName
			// 
			this.labelSelectedFileName.AutoSize = true;
			this.labelSelectedFileName.Location = new System.Drawing.Point(196, 50);
			this.labelSelectedFileName.Name = "labelSelectedFileName";
			this.labelSelectedFileName.Size = new System.Drawing.Size(0, 13);
			this.labelSelectedFileName.TabIndex = 3;
			// 
			// buttonCreate
			// 
			this.buttonCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonCreate.Location = new System.Drawing.Point(125, 90);
			this.buttonCreate.Name = "buttonCreate";
			this.buttonCreate.Size = new System.Drawing.Size(75, 23);
			this.buttonCreate.TabIndex = 4;
			this.buttonCreate.Text = "Create";
			this.buttonCreate.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(206, 90);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// CreateMeetingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(293, 125);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonCreate);
			this.Controls.Add(this.labelSelectedFileName);
			this.Controls.Add(this.buttonSelect);
			this.Controls.Add(this.labelSelectPotfolioFile);
			this.Controls.Add(this.labelInform);
			this.Name = "CreateMeetingForm";
			this.Text = "Create Meeting";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelInform;
		private System.Windows.Forms.Label labelSelectPotfolioFile;
		private System.Windows.Forms.Button buttonSelect;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Label labelSelectedFileName;
		private System.Windows.Forms.Button buttonCreate;
		private System.Windows.Forms.Button buttonCancel;
	}
}