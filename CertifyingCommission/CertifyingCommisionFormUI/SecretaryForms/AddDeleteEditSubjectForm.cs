using System.Windows.Forms;
using CertifyingCommisionBl;
using CertifyingCommissionEntities;

namespace CertifyingCommisionFormUI.SecretaryForms
{
	public partial class AddDeleteEditSubjectForm : Form
	{
		private const string AddFormText = "Add Subject";
		private const string AddButtonText = "Add";
		private const string DeleteFormText = "Delete Subject";
		private const string DeleteButtonText = "Delete";
		private const string EditFormText = "Edit Subject";
		private const string EditButtonText = "Edit";

		public AddDeleteEditSubjectForm()
		{
			InitializeComponent();
		}

		public static void AddSubject(CertifyingCommission certifyingCommission)
		{
			var addSubjectForm = new AddDeleteEditSubjectForm();
			SetFormIncriptions(addSubjectForm, AddFormText, AddButtonText);

			if (addSubjectForm.ShowDialog() == DialogResult.OK)
				certifyingCommission.AddSubject(new Subject
				{
					SubjectName = addSubjectForm.textBoxSubjectName.Text
				});
		}

		public static void DeleteSubject(Subject deletedSubject, CertifyingCommission certifyingCommission)
		{
			var deleteSubjectForm = new AddDeleteEditSubjectForm();
			SetFormIncriptions(deleteSubjectForm, DeleteFormText, DeleteButtonText);
			deleteSubjectForm.textBoxSubjectName.Text = deletedSubject.SubjectName;
			deleteSubjectForm.textBoxSubjectName.Enabled = false;

			if (deleteSubjectForm.ShowDialog() == DialogResult.OK)
				certifyingCommission.DeleteSubject(deletedSubject);
		}

		public static void EditSubject(Subject editedSubject, CertifyingCommission certifyingCommission)
		{
			var editSubjectForm = new AddDeleteEditSubjectForm();
			SetFormIncriptions(editSubjectForm, EditFormText, EditButtonText);
			editSubjectForm.textBoxSubjectName.Text = editedSubject.SubjectName;

			if (editSubjectForm.ShowDialog() == DialogResult.OK)
			{
				editedSubject.SubjectName = editSubjectForm.textBoxSubjectName.Text;
				certifyingCommission.UpdateSubject(editedSubject);
			}
		}

		private static void SetFormIncriptions(AddDeleteEditSubjectForm addDeleteEditSubjectForm, string formText,
			string submitButtonText)
		{
			addDeleteEditSubjectForm.Text = formText;
			addDeleteEditSubjectForm.buttonSubmit.Text = submitButtonText;
		}
	}
}
