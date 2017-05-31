using System;
using System.Windows.Forms;
using CertifyingCommisionBl;
using CertifyingCommisionFormUI.SecretaryForms;
using CertifyingCommissionEntities;

namespace CertifyingCommisionFormUI
{
	public partial class AuthorizationForm : Form
	{
		private readonly CertifyingCommission _sertifyingCommision;

		public AuthorizationForm()
		{
			InitializeComponent();
			_sertifyingCommision = new CertifyingCommission();
			/*_sertifyingCommision.AddUser(new Secretary
			{
				Login = "secretary",
				Surname = "Ivanov",
				Name = "Ivan",
				Patronymic = "Ivanovich",
			}, "secretary");*/
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			Authorize();
		}

		private void Authorize()
		{
			if (!_sertifyingCommision.CheckAutentification(textBoxLogin.Text, textBoxPassword.Text))
				return;

			var user = _sertifyingCommision.GetUser(textBoxLogin.Text);
			var form = SelectForm(user);
			ShowForm(form);
		}
		
		private Form SelectForm(User user)
		{
			if (user is Secretary)
				return new SecretaryForm(user, _sertifyingCommision);

			if (user is Teacher)
				return new TeacherForm();

			if (user is CommissionMember)
				return new CommissionMemberForm();

			throw new Exception("Such user not exists.");
		}

		private void ShowForm(Control form)
		{
			form.Show();
			Hide();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
