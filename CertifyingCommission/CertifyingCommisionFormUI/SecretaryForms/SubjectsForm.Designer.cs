﻿namespace CertifyingCommisionFormUI.SecretaryForms
{
	partial class SubjectsForm
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
			this.groupBoxSubjects = new System.Windows.Forms.GroupBox();
			this.dataGridViewSubjects = new System.Windows.Forms.DataGridView();
			this.groupBoxActions = new System.Windows.Forms.GroupBox();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.groupBoxSubjects.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjects)).BeginInit();
			this.groupBoxActions.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxSubjects
			// 
			this.groupBoxSubjects.Controls.Add(this.dataGridViewSubjects);
			this.groupBoxSubjects.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBoxSubjects.Location = new System.Drawing.Point(0, 0);
			this.groupBoxSubjects.Name = "groupBoxSubjects";
			this.groupBoxSubjects.Size = new System.Drawing.Size(543, 204);
			this.groupBoxSubjects.TabIndex = 0;
			this.groupBoxSubjects.TabStop = false;
			this.groupBoxSubjects.Text = "Subjects";
			// 
			// dataGridViewSubjects
			// 
			this.dataGridViewSubjects.AllowUserToAddRows = false;
			this.dataGridViewSubjects.AllowUserToDeleteRows = false;
			this.dataGridViewSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewSubjects.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewSubjects.Location = new System.Drawing.Point(3, 16);
			this.dataGridViewSubjects.Name = "dataGridViewSubjects";
			this.dataGridViewSubjects.ReadOnly = true;
			this.dataGridViewSubjects.Size = new System.Drawing.Size(537, 185);
			this.dataGridViewSubjects.TabIndex = 0;
			// 
			// groupBoxActions
			// 
			this.groupBoxActions.Controls.Add(this.buttonEdit);
			this.groupBoxActions.Controls.Add(this.buttonDelete);
			this.groupBoxActions.Controls.Add(this.buttonAdd);
			this.groupBoxActions.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBoxActions.Location = new System.Drawing.Point(0, 210);
			this.groupBoxActions.Name = "groupBoxActions";
			this.groupBoxActions.Size = new System.Drawing.Size(543, 51);
			this.groupBoxActions.TabIndex = 1;
			this.groupBoxActions.TabStop = false;
			this.groupBoxActions.Text = "Actions";
			// 
			// buttonEdit
			// 
			this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonEdit.Location = new System.Drawing.Point(175, 16);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(75, 23);
			this.buttonEdit.TabIndex = 2;
			this.buttonEdit.Text = "Edit";
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonDelete.Location = new System.Drawing.Point(94, 16);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(75, 23);
			this.buttonDelete.TabIndex = 1;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonAdd.Location = new System.Drawing.Point(13, 16);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(75, 23);
			this.buttonAdd.TabIndex = 0;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// SubjectsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(543, 261);
			this.Controls.Add(this.groupBoxActions);
			this.Controls.Add(this.groupBoxSubjects);
			this.Name = "SubjectsForm";
			this.Text = "Subjects";
			this.groupBoxSubjects.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjects)).EndInit();
			this.groupBoxActions.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxSubjects;
		private System.Windows.Forms.DataGridView dataGridViewSubjects;
		private System.Windows.Forms.GroupBox groupBoxActions;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonAdd;
	}
}