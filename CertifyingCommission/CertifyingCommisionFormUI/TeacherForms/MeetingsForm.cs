using System.Linq;
using System.Windows.Forms;
using CertifyingCommisionBl;
using CertifyingCommissionEntities;

namespace CertifyingCommisionFormUI.TeacherForms
{
	public partial class MeetingsForm : Form
	{
		public MeetingsForm(User user, CertifyingCommission certifyingCommission)
		{
			InitializeComponent();
			dataGridViewMeetings.DataSource = certifyingCommission.GetTeacherMeetings(user).ToList();
		}
	}
}
