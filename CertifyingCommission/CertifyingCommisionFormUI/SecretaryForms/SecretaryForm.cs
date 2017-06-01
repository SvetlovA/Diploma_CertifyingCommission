using System.Windows.Forms;
using CertifyingCommisionBl;
using CertifyingCommissionEntities;

namespace CertifyingCommisionFormUI.SecretaryForms
{
	public partial class SecretaryForm : Form
	{
		private readonly CertifyingCommission _sertifyingCommission;
		private readonly User _currentUser;

		public SecretaryForm(User user, CertifyingCommission sertifyingCommission)
		{
			InitializeComponent();
			_sertifyingCommission = sertifyingCommission;
			_currentUser = user;
		}

		private void SecretaryForm_Load(object sender, System.EventArgs e)
		{
			labelHelloMessage.Text += _currentUser.Name;
		}

		private void buttonExit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void buttonMeetings_Click(object sender, System.EventArgs e)
		{
			var meetingsForm = new MeetingsForm(_currentUser, _sertifyingCommission);
			meetingsForm.Show();
		}

		private void buttonSecretaries_Click(object sender, System.EventArgs e)
		{
			var secretariesForm = new UsersForm<Secretary>(_currentUser, _sertifyingCommission);
			secretariesForm.Show();
		}

		private void buttonTeachers_Click(object sender, System.EventArgs e)
		{
			var teachersForm = new UsersForm<Teacher>(_currentUser, _sertifyingCommission);
			teachersForm.Show();
		}

		private void buttonCommissionMembers_Click(object sender, System.EventArgs e)
		{
			var commissionMembersForm = new UsersForm<CommissionMember>(_currentUser, _sertifyingCommission);
			commissionMembersForm.Show();
		}

		private void buttonSubjects_Click(object sender, System.EventArgs e)
		{
			var subjectsForm = new SubjectsForm(_sertifyingCommission);
			subjectsForm.Show();
		}

		private void SecretaryForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
