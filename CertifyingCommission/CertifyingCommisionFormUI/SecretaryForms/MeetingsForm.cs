using System.Linq;
using System.Windows.Forms;
using CertifyingCommisionBl;
using CertifyingCommissionEntities;

namespace CertifyingCommisionFormUI.SecretaryForms
{
	public partial class MeetingsForm : Form
	{
		private const string SelectMeetingMessage = "Meeting isn't selected. Please, select meeting.";
		private const string SelectMeetingTitle = "Select meeting";

		private readonly CertifyingCommission _certifyingCommision;
		private readonly User _currentUser;

		public MeetingsForm(User user, CertifyingCommission certifyingCommision)
		{
			InitializeComponent();
			_certifyingCommision = certifyingCommision;
			_currentUser = user;
			dataGridViewMeetings.DataSource = _certifyingCommision.GetAllMeetings().ToList();
		}

		private void buttonConfirm_Click(object sender, System.EventArgs e)
		{
			ChangeMeetingStatus(MeetingStatus.Confirmed);
		}

		private void buttonReject_Click(object sender, System.EventArgs e)
		{
			ChangeMeetingStatus(MeetingStatus.Rejected);
		}

		private void ChangeMeetingStatus(MeetingStatus meetingStatus)
		{
			if (dataGridViewMeetings.CurrentRow == null)
			{
				MessageBox.Show(SelectMeetingMessage, SelectMeetingTitle, MessageBoxButtons.OK,
					MessageBoxIcon.Information);
				return;
			}

			var meeting = (Meeting) dataGridViewMeetings.CurrentRow.DataBoundItem;
			meeting.MeetingStatus = meetingStatus;
			meeting.Secretary = (Secretary) _currentUser;
			_certifyingCommision.UpdateMeeting(meeting);
		}
	}
}
