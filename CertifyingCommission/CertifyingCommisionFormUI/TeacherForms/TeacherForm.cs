using System;
using System.Windows.Forms;
using CertifyingCommisionBl;
using CertifyingCommissionEntities;

namespace CertifyingCommisionFormUI.TeacherForms
{
	public partial class TeacherForm : Form
	{
		private const string InformationTitle = "Information";
		private const string SetSubjectMessage = "Subject was succefully seted. You current subject is:";

		private const string ErrorTitle = "Error";
		private const string UnselectedSubjectMessage = "Subject wasn't selected.";

		private const string UnselectedPortfolioFileMessage = "Portfoli wasn't selected.";

		private const string CreateMeetingSuccessMessage = "Meeting was succesfully created and send to secretary for consideration.";

		private readonly CertifyingCommission _certifyingCommission;
		private readonly User _currentUser;

		public TeacherForm(User user, CertifyingCommission certifyingCommission)
		{
			InitializeComponent();
			_currentUser = user;
			_certifyingCommission = certifyingCommission;
		}

		private void TeacherForm_Load(object sender, EventArgs e)
		{
			labelHelloMessage.Text += _currentUser.Name;
		}

		private void buttonMeetings_Click(object sender, EventArgs e)
		{
			ShowMeetings();
		}

		private void ShowMeetings()
		{
			var meetingsForm = new MeetingsForm(_currentUser, _certifyingCommission);
			meetingsForm.Show();
		}

		private void buttonCreateMeeting_Click(object sender, EventArgs e)
		{
			CreateMeeting();
		}

		private void CreateMeeting()
		{
			var createMeetingForm = new CreateMeetingForm();

			if (createMeetingForm.ShowDialog() == DialogResult.OK)
			{
				var meeting = new Meeting
				{
					TeacherId = _currentUser.UserId,
					Teacher = (Teacher) _currentUser,
					MeetingCreationDateTime = DateTime.Now
				};

				var portfolio = createMeetingForm.Portfolio;
				if (portfolio == null)
				{
					MessageBox.Show(UnselectedPortfolioFileMessage, ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				meeting.File = createMeetingForm.Portfolio;
				_certifyingCommission.AddMeeting(meeting);

				MessageBox.Show(CreateMeetingSuccessMessage, InformationTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void buttonSetSubject_Click(object sender, EventArgs e)
		{
			SetSubject();
		}

		private void SetSubject()
		{
			var setSubjectForm = new SetSubjectForm(_certifyingCommission);

			if (setSubjectForm.ShowDialog() == DialogResult.OK)
			{
				var teacher = (Teacher)_currentUser;
				var selectedSubject = setSubjectForm.Subject;
				if (selectedSubject == null)
				{
					MessageBox.Show(UnselectedSubjectMessage, ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				teacher.SubjectId = selectedSubject.SubjectId;
				teacher.Subject = selectedSubject;
				_certifyingCommission.UpdateUser(teacher);
				MessageBox.Show($"{SetSubjectMessage} {selectedSubject}", InformationTitle, MessageBoxButtons.OK,
					MessageBoxIcon.Information);
			}
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void TeacherForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
