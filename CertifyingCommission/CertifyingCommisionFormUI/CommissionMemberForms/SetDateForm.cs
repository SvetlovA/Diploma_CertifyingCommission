using System;
using System.Windows.Forms;

namespace CertifyingCommisionFormUI.CommissionMemberForms
{
	public partial class SetDateForm : Form
	{
		public SetDateForm()
		{
			InitializeComponent();
			monthCalendar.MinDate = DateTime.Now;
		}

		public DateTime DateTime => monthCalendar.SelectionStart;
	}
}
