using System.Linq;
using System.Windows.Forms;
using CertifyingCommisionBl;
using CertifyingCommissionEntities;
using FinderExtensions;

namespace CertifyingCommisionFormUI.TeacherForms
{
	public partial class MeetingsForm : Form
	{
		private readonly CertifyingCommission _certifyingCommision;
		private readonly User _currentUser;

		private bool _isFind;

		public MeetingsForm(User user, CertifyingCommission certifyingCommission)
		{
			InitializeComponent();
			_certifyingCommision = certifyingCommission;
			_currentUser = user;
			UpdateData();
		}

		private void UpdateData() =>
			dataGridViewMeetings.DataSource = _isFind
				? _certifyingCommision.GetTeacherMeetings(_currentUser).Find(dateTimePickerFromDate.Value, dateTimePickerToDate.Value).ToList()
				: _certifyingCommision.GetTeacherMeetings(_currentUser).ToList();

		private void buttonFind_Click(object sender, System.EventArgs e)
		{
			_isFind = true;
			UpdateData();
		}

		private void buttonCancel_Click(object sender, System.EventArgs e)
		{
			_isFind = false;
			UpdateData();
		}
	}
}
