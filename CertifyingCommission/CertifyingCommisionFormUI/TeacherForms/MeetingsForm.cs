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

		private bool _isFind;

		public MeetingsForm(CertifyingCommission certifyingCommission)
		{
			InitializeComponent();
			_certifyingCommision = certifyingCommission;
			UpdateData();
		}

		private void UpdateData() =>
			dataGridViewMeetings.DataSource = _isFind
				? _certifyingCommision.GetAllMeetings().Find(dateTimePickerFromDate.Value, dateTimePickerToDate.Value).ToList()
				: _certifyingCommision.GetAllMeetings().ToList();

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
