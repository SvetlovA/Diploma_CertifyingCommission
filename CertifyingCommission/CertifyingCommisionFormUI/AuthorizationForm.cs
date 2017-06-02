using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CertifyingCommisionBl;
using CertifyingCommisionFormUI.CommissionMemberForms;
using CertifyingCommisionFormUI.SecretaryForms;
using CertifyingCommisionFormUI.TeacherForms;
using CertifyingCommissionEntities;

namespace CertifyingCommisionFormUI
{
	public partial class AuthorizationForm : Form, IValidatableForm
	{
		private const string IncorrectLoginPasswordMessage = "Incorrect login/password pair.";
		private const string IncorrectLoginPasswordTitle = "Access denied";
		private const string EmptyFieldErrorMessage = "should be filled.";
		private const string ErrorTitle = "Error";

		private const string EmptyLoginFieldMessage = "Login field should be filled.";
		private const string EmptyPasswordFieldMessage = "Password field should be filled.";
		private const string InvalidCharactersMessage = "Invalid characters";

		private const string ValidationFailedMessage = "Validation failed.";
		private const string ValidationFailedTitle = "Validation";

		private readonly CertifyingCommission _certifyingCommision;

		public bool IsValid { get; set; }

		public AuthorizationForm()
		{
			InitializeComponent();
			_certifyingCommision = new CertifyingCommission();
			_certifyingCommision.ClearNotActualMeetings();
			/*_sertifyingCommision.AddSubject(new Subject
			{
				SubjectName = "Math"
			});
			_sertifyingCommision.AddUser(new Secretary
			{
				Login = "secretary",
				Surname = "Ivanov",
				Name = "Ivan",
				Patronymic = "Ivanovich",
			}, "secretary");
			_sertifyingCommision.AddUser(new Teacher
			{
				Login = "teacher",
				Surname = "Mitrofanov",
				Name = "Kirill",
				Patronymic = "Sergeevich"
			}, "teacher");
			_sertifyingCommision.AddUser(new CommissionMember
			{
				Login = "c_member",
				Surname = "Petrov",
				Name = "Peter",
				Patronymic = "Petrovich",
			}, "c_member");*/
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			Authorize();
		}

		private void Authorize()
		{
			if (!IsValid)
			{
				MessageBox.Show(ValidationFailedMessage, ValidationFailedTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			User user;
			try
			{
				if (!_certifyingCommision.CheckAutentification(textBoxLogin.Text, textBoxPassword.Text))
				{
					MessageBox.Show(IncorrectLoginPasswordMessage, IncorrectLoginPasswordTitle, MessageBoxButtons.OK,
						MessageBoxIcon.Stop);
					return;
				}
				user = _certifyingCommision.GetUser(textBoxLogin.Text);
			}
			catch (ArgumentNullException ex)
			{
				MessageBox.Show($"{ex.ParamName} {EmptyFieldErrorMessage}", ErrorTitle, MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			var form = SelectForm(user);
			ShowForm(form);
		}
		
		private Form SelectForm(User user)
		{
			if (user is Secretary)
				return new SecretaryForm(user, _certifyingCommision);

			if (user is Teacher)
				return new TeacherForm(user, _certifyingCommision);

			if (user is CommissionMember)
				return new CommissionMemberForm(user, _certifyingCommision);

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

		private void textBoxLogin_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxLogin.Text) || string.IsNullOrWhiteSpace(textBoxLogin.Text))
			{
				errorProvider.SetError(textBoxLogin, EmptyLoginFieldMessage);
				IsValid = false;
			}
			else if (!Regex.IsMatch(textBoxLogin.Text, @"^[A-Za-z0-9_]+$"))
			{
				errorProvider.SetError(textBoxLogin, InvalidCharactersMessage);
				IsValid = false;
			}
			else
			{
				errorProvider.Clear();
				IsValid = true;
			}
		}

		private void textBoxPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxPassword.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
			{
				errorProvider.SetError(textBoxPassword, EmptyPasswordFieldMessage);
				IsValid = false;
			}
			else if (!Regex.IsMatch(textBoxPassword.Text, @"^[A-Za-z0-9]+$"))
			{
				errorProvider.SetError(textBoxPassword, InvalidCharactersMessage);
				IsValid = false;
			}
			else
			{
				errorProvider.Clear();
				IsValid = true;
			}
		}
	}
}
