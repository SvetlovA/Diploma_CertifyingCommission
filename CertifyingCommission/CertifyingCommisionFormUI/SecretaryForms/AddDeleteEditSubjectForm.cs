using System;
using System.Windows.Forms;
using CertifyingCommisionBl;
using CertifyingCommissionEntities;

namespace CertifyingCommisionFormUI.SecretaryForms
{
	public partial class AddDeleteEditSubjectForm : Form, IValidatableForm
	{
		private const string AddFormText = "Add Subject";
		private const string AddButtonText = "Add";
		private const string DeleteFormText = "Delete Subject";
		private const string DeleteButtonText = "Delete";
		private const string EditFormText = "Edit Subject";
		private const string EditButtonText = "Edit";

		private const string ValidationFailedMessage = "Validation failed.";
		private const string ValidationFailedTitle = "Validation";

		private const string SubjectNameFieldEmptyMessage = "Subject name can't be empty.";
		private const string EmptyFieldMessage = "can't be empty.";
		private const string ErrorTitle = "Error";

		public AddDeleteEditSubjectForm()
		{
			InitializeComponent();
		}

		public bool IsValid { get; set; }

		public static void AddSubject(CertifyingCommission certifyingCommission)
		{
			var addSubjectForm = new AddDeleteEditSubjectForm();
			SetFormIncriptions(addSubjectForm, AddFormText, AddButtonText);

			if (addSubjectForm.ShowDialog() == DialogResult.OK)
			{
				try
				{
					certifyingCommission.AddSubject(new Subject
					{
						SubjectName = addSubjectForm.textBoxSubjectName.Text
					});
				}
				catch (ArgumentNullException ex)
				{
					MessageBox.Show($"{ex.ParamName} {EmptyFieldMessage}", ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		public static void DeleteSubject(Subject deletedSubject, CertifyingCommission certifyingCommission)
		{
			var deleteSubjectForm = new AddDeleteEditSubjectForm();
			SetFormIncriptions(deleteSubjectForm, DeleteFormText, DeleteButtonText);
			deleteSubjectForm.textBoxSubjectName.Text = deletedSubject.SubjectName;
			deleteSubjectForm.textBoxSubjectName.Enabled = false;
			deleteSubjectForm.IsValid = true;

			if (deleteSubjectForm.ShowDialog() == DialogResult.OK)
			{
				
				try
				{
					certifyingCommission.DeleteSubject(deletedSubject);
				}
				catch (ArgumentNullException ex)
				{
					MessageBox.Show($"{ex.ParamName} {EmptyFieldMessage}", ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		public static void EditSubject(Subject editedSubject, CertifyingCommission certifyingCommission)
		{
			var editSubjectForm = new AddDeleteEditSubjectForm();
			SetFormIncriptions(editSubjectForm, EditFormText, EditButtonText);
			editSubjectForm.textBoxSubjectName.Text = editedSubject.SubjectName;

			if (editSubjectForm.ShowDialog() == DialogResult.OK)
			{
				editedSubject.SubjectName = editSubjectForm.textBoxSubjectName.Text;
				try
				{
					certifyingCommission.UpdateSubject(editedSubject);
				}
				catch (ArgumentNullException ex)
				{
					MessageBox.Show($"{ex.ParamName} {EmptyFieldMessage}", ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private static void SetFormIncriptions(AddDeleteEditSubjectForm addDeleteEditSubjectValidatableForm, string formText,
			string submitButtonText)
		{
			addDeleteEditSubjectValidatableForm.Text = formText;
			addDeleteEditSubjectValidatableForm.buttonSubmit.Text = submitButtonText;
		}

		private void textBoxSubjectName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxSubjectName.Text) || string.IsNullOrWhiteSpace(textBoxSubjectName.Text))
			{
				errorProvider.SetError(textBoxSubjectName, SubjectNameFieldEmptyMessage);
				IsValid = false;
			}
			else
			{
				errorProvider.Clear();
				IsValid = true;
			}
		}

		private void buttonSubmit_Click(object sender, EventArgs e)
		{
			if (!IsValid)
				MessageBox.Show(ValidationFailedMessage, ValidationFailedTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
				DialogResult = DialogResult.OK;
		}
	}
}
