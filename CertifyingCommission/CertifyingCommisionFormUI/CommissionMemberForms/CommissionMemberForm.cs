using System.Windows.Forms;
using CertifyingCommisionBl;
using CertifyingCommissionEntities;

namespace CertifyingCommisionFormUI.CommissionMemberForms
{
	public partial class CommissionMemberForm : Form
	{
		private readonly CertifyingCommission _certifyingCommission;
		private readonly User _currentUser;

		public CommissionMemberForm(User user, CertifyingCommission certifyingCommission)
		{
			InitializeComponent();
			_certifyingCommission = certifyingCommission;
			_currentUser = user;
		}

		private void CommissionMemberForm_Load(object sender, System.EventArgs e)
		{
			labelHelloMessage.Text += _currentUser.Name;
		}

		private void buttonConfirmedMeetings_Click(object sender, System.EventArgs e)
		{
			var confirmedMeetingsForm = new ConfirmedMeetingsForm(_currentUser, _certifyingCommission);
			confirmedMeetingsForm.Show();
		}

		private void buttonExit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void CommissionMemberForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
