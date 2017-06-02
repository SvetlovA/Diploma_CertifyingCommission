using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CertifyingCommisionBl;
using CertifyingCommissionEntities;

namespace CertifyingCommisionFormUI.SecretaryForms
{
	public partial class MeetingsForm : Form
	{
		private const string DeleteMeetingMessage = "Are you sure to delete selected meeting?";
		private const string DeleteMeetingTitle = "Delete meeting";

		private const string EmptyFieldErrorMessage = "can't be empty.";
		private const string ErrorTitle = "Error";

		private readonly CertifyingCommission _certifyingCommision;
		private readonly User _currentUser;

		public MeetingsForm(User user, CertifyingCommission certifyingCommision)
		{
			InitializeComponent();
			_certifyingCommision = certifyingCommision;
			_currentUser = user;
			UpdateData();
		}

		private void buttonConfirm_Click(object sender, EventArgs e)
		{
			ChangeMeetingStatus(MeetingStatus.Confirmed);
		}

		private void buttonReject_Click(object sender, EventArgs e)
		{
			ChangeMeetingStatus(MeetingStatus.Rejected);
		}

		private void ChangeMeetingStatus(MeetingStatus meetingStatus)
		{
			var meeting = GetSelectedMeeting(dataGridViewMeetings.CurrentRow);
			meeting.MeetingStatus = meetingStatus;
			meeting.SecretaryId = _currentUser.UserId;
			meeting.Secretary = (Secretary) _currentUser;
			_certifyingCommision.UpdateMeeting(meeting);
			UpdateData();
		}

		private void buttonGetFile_Click(object sender, EventArgs e)
		{
			GetFile();
		}

		private void GetFile()
		{
			var meeting = GetSelectedMeeting(dataGridViewMeetings.CurrentRow);

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
				File.WriteAllBytes(saveFileDialog.FileName, meeting.File);
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			DeletMeeting();
		}

		private void DeletMeeting()
		{
			var selectedMeeting = GetSelectedMeeting(dataGridViewMeetings.CurrentRow);
			if (MessageBox.Show(DeleteMeetingMessage, DeleteMeetingTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				try
				{
					_certifyingCommision.DeleteMeeting(selectedMeeting);
				}
				catch (ArgumentNullException ex)
				{
					MessageBox.Show($"{ex.ParamName} {EmptyFieldErrorMessage}", ErrorTitle, MessageBoxButtons.OK,
						MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private Meeting GetSelectedMeeting(DataGridViewRow row)
		{
			if (row == null)
				throw new ArgumentNullException(nameof(row));

			return (Meeting) row.DataBoundItem;
		}

		private void UpdateData() =>
			dataGridViewMeetings.DataSource = _certifyingCommision.GetAllMeetings().ToList();
	}
}
