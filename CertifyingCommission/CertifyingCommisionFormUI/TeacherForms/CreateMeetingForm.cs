using System;
using System.IO;
using System.Windows.Forms;

namespace CertifyingCommisionFormUI.TeacherForms
{
	public partial class CreateMeetingForm : Form
	{
		public CreateMeetingForm()
		{
			InitializeComponent();
		}

		public byte[] Portfolio { get; private set; }

		private void buttonSelect_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				Portfolio = File.ReadAllBytes(openFileDialog.FileName);
				labelSelectedFileName.Text += openFileDialog.SafeFileName;
			}
		}
	}
}
