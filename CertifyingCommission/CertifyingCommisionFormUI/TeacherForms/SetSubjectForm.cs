using System.Linq;
using System.Windows.Forms;
using CertifyingCommisionBl;
using CertifyingCommissionEntities;

namespace CertifyingCommisionFormUI.TeacherForms
{
	public partial class SetSubjectForm : Form
	{
		public SetSubjectForm(CertifyingCommission certifyingCommission)
		{
			InitializeComponent();
			comboBoxSubjects.Items.AddRange(certifyingCommission.GetAllSubjects().ToArray());
		}

		public Subject Subject => comboBoxSubjects.SelectedItem as Subject;
	}
}
