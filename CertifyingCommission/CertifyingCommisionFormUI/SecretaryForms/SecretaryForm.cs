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
	}
}
