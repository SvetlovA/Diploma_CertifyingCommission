namespace CertifyingCommisionFormUI.SecretaryForms
{
	partial class UsersForm<TUser>
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
			this.groupBoxUsers = new System.Windows.Forms.GroupBox();
			this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
			this.groupBoxActions = new System.Windows.Forms.GroupBox();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.groupBoxFinder = new System.Windows.Forms.GroupBox();
			this.labelFinder = new System.Windows.Forms.Label();
			this.textBoxSurname = new System.Windows.Forms.TextBox();
			this.buttonFind = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.groupBoxUsers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
			this.groupBoxActions.SuspendLayout();
			this.groupBoxFinder.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxUsers
			// 
			this.groupBoxUsers.Controls.Add(this.dataGridViewUsers);
			this.groupBoxUsers.Location = new System.Drawing.Point(0, 62);
			this.groupBoxUsers.Name = "groupBoxUsers";
			this.groupBoxUsers.Size = new System.Drawing.Size(794, 270);
			this.groupBoxUsers.TabIndex = 0;
			this.groupBoxUsers.TabStop = false;
			this.groupBoxUsers.Text = "Secretaries";
			// 
			// dataGridViewUsers
			// 
			this.dataGridViewUsers.AllowUserToAddRows = false;
			this.dataGridViewUsers.AllowUserToDeleteRows = false;
			this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewUsers.Location = new System.Drawing.Point(3, 16);
			this.dataGridViewUsers.Name = "dataGridViewUsers";
			this.dataGridViewUsers.ReadOnly = true;
			this.dataGridViewUsers.Size = new System.Drawing.Size(788, 251);
			this.dataGridViewUsers.TabIndex = 0;
			// 
			// groupBoxActions
			// 
			this.groupBoxActions.Controls.Add(this.buttonEdit);
			this.groupBoxActions.Controls.Add(this.buttonDelete);
			this.groupBoxActions.Controls.Add(this.buttonAdd);
			this.groupBoxActions.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBoxActions.Location = new System.Drawing.Point(0, 338);
			this.groupBoxActions.Name = "groupBoxActions";
			this.groupBoxActions.Size = new System.Drawing.Size(794, 45);
			this.groupBoxActions.TabIndex = 1;
			this.groupBoxActions.TabStop = false;
			this.groupBoxActions.Text = "Actions";
			// 
			// buttonEdit
			// 
			this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonEdit.Location = new System.Drawing.Point(174, 16);
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
			this.buttonDelete.Location = new System.Drawing.Point(93, 16);
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
			this.buttonAdd.Location = new System.Drawing.Point(12, 16);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(75, 23);
			this.buttonAdd.TabIndex = 0;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// groupBoxFinder
			// 
			this.groupBoxFinder.Controls.Add(this.buttonCancel);
			this.groupBoxFinder.Controls.Add(this.buttonFind);
			this.groupBoxFinder.Controls.Add(this.textBoxSurname);
			this.groupBoxFinder.Controls.Add(this.labelFinder);
			this.groupBoxFinder.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBoxFinder.Location = new System.Drawing.Point(0, 0);
			this.groupBoxFinder.Name = "groupBoxFinder";
			this.groupBoxFinder.Size = new System.Drawing.Size(794, 56);
			this.groupBoxFinder.TabIndex = 2;
			this.groupBoxFinder.TabStop = false;
			this.groupBoxFinder.Text = "Finder";
			// 
			// labelFinder
			// 
			this.labelFinder.AutoSize = true;
			this.labelFinder.Location = new System.Drawing.Point(7, 13);
			this.labelFinder.Name = "labelFinder";
			this.labelFinder.Size = new System.Drawing.Size(110, 13);
			this.labelFinder.TabIndex = 0;
			this.labelFinder.Text = "Input part of surname:";
			// 
			// textBoxSurname
			// 
			this.textBoxSurname.Location = new System.Drawing.Point(13, 30);
			this.textBoxSurname.Name = "textBoxSurname";
			this.textBoxSurname.Size = new System.Drawing.Size(155, 20);
			this.textBoxSurname.TabIndex = 1;
			// 
			// buttonFind
			// 
			this.buttonFind.Location = new System.Drawing.Point(174, 28);
			this.buttonFind.Name = "buttonFind";
			this.buttonFind.Size = new System.Drawing.Size(75, 23);
			this.buttonFind.TabIndex = 2;
			this.buttonFind.Text = "Find";
			this.buttonFind.UseVisualStyleBackColor = true;
			this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(255, 28);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// UsersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(794, 383);
			this.Controls.Add(this.groupBoxFinder);
			this.Controls.Add(this.groupBoxActions);
			this.Controls.Add(this.groupBoxUsers);
			this.Name = "UsersForm";
			this.Text = "Users";
			this.groupBoxUsers.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
			this.groupBoxActions.ResumeLayout(false);
			this.groupBoxFinder.ResumeLayout(false);
			this.groupBoxFinder.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxUsers;
		private System.Windows.Forms.DataGridView dataGridViewUsers;
		private System.Windows.Forms.GroupBox groupBoxActions;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.GroupBox groupBoxFinder;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonFind;
		private System.Windows.Forms.TextBox textBoxSurname;
		private System.Windows.Forms.Label labelFinder;
	}
}