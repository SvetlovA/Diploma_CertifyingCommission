using System;
using System.Linq;
using System.Windows.Forms;
using CertifyingCommisionBl;
using CertifyingCommissionEntities;

namespace CertifyingCommisionFormUI.SecretaryForms
{
	public partial class SubjectsForm : Form
	{
		private readonly CertifyingCommission _certifyingCommission;

		public SubjectsForm(CertifyingCommission certifyingCommission)
		{
			InitializeComponent();
			_certifyingCommission = certifyingCommission;
			UpdateData();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			AddDeleteEditSubjectForm.AddSubject(_certifyingCommission);
			UpdateData();
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			var subject = GetSelectedSubject(dataGridViewSubjects.CurrentRow);
			AddDeleteEditSubjectForm.DeleteSubject(subject, _certifyingCommission);
			UpdateData();
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			var subject = GetSelectedSubject(dataGridViewSubjects.CurrentRow);
			AddDeleteEditSubjectForm.EditSubject(subject, _certifyingCommission);
			UpdateData();
		}

		private Subject GetSelectedSubject(DataGridViewRow row)
		{
			if (row == null)
				throw new ArgumentNullException(nameof(row));

			return (Subject) row.DataBoundItem;
		}

		private void UpdateData() =>
			dataGridViewSubjects.DataSource = _certifyingCommission.GetAllSubjects().ToList();
	}
}
