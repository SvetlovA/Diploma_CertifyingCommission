using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CertifyingCommisionBl;
using CertifyingCommissionEntities;

namespace CertifyingCommisionFormUI.SecretaryForms
{
	public partial class AddDeleteEditUserForm : Form, IValidatableForm
	{
		private const string AddText = "Add";
		private const string DeleteText = "Delete";
		private const string EditText = "Edit";
		private const string EditPasswordMessage = "Start input to change password";

		private const string EmptyLoginFieldMessage = "Login field should be filled.";
		private const string EmptyPasswordFieldMessage = "Password field should be filled.";
		private const string InvalidCharactersMessage = "Invalid characters";
		private const string EmptySurnameFieldMessage = "Surname field should be filled";
		private const string EmptyNameFieldMessage = "Name field should be filled";
		private const string EmptyPatronymicFieldMessage = "PAtronymic field should be filled";

		private const string ValidationFailedMessage = "Validation failed.";
		private const string ValidationFailedTitle = "Validation";

		private static bool _isChangedPassword;

		public bool IsValid { get; set; }

		public AddDeleteEditUserForm()
		{
			InitializeComponent();
		}

		public static void Add<TUser>(CertifyingCommission certifyingCommission) where TUser : User, new()
		{
			var addUserForm = new AddDeleteEditUserForm();
			SetFromInscriptions(addUserForm, $"{AddText} {typeof(TUser).Name}", AddText);

			if (addUserForm.ShowDialog() == DialogResult.OK)
			{
				certifyingCommission.AddUser(new TUser
				{
					Login = addUserForm.textBoxLogin.Text,
					Surname = addUserForm.textBoxSurname.Text,
					Name = addUserForm.textBoxName.Text,
					Patronymic = addUserForm.textBoxPatronymic.Text
				}, addUserForm.textBoxPassword.Text);
			}
		}

		public static void Delete(User deletedUser, CertifyingCommission certifyingCommission)
		{
			var deleteUserForm = new AddDeleteEditUserForm();
			SetFromInscriptions(deleteUserForm, $"{DeleteText} {deletedUser.GetType().Name}", DeleteText);
			DisableInputs(deleteUserForm);
			SetInputs(deletedUser, deleteUserForm);
			HidePasswordBlocks(deleteUserForm);
			deleteUserForm.IsValid = true;

			if (deleteUserForm.ShowDialog() == DialogResult.OK)
				certifyingCommission.DeleteUser(deletedUser);
		}

		public static void Edit(User editedUser, CertifyingCommission certifyingCommission)
		{
			var editUserForm = new AddDeleteEditUserForm();
			SetFromInscriptions(editUserForm, $"{EditText} {editedUser.GetType().Name}", EditText);
			SetInputs(editedUser, editUserForm);
			editUserForm.textBoxPassword.GotFocus += TextBoxPassword_GotFocus;
			editUserForm.textBoxPassword.LostFocus += TextBoxPassword_LostFocus;

			if (editUserForm.ShowDialog() == DialogResult.OK)
			{
				editedUser.Login = editUserForm.textBoxLogin.Text;
				editedUser.Surname = editUserForm.textBoxSurname.Text;
				editedUser.Name = editUserForm.textBoxName.Text;
				editedUser.Patronymic = editUserForm.textBoxPatronymic.Text;

				if (_isChangedPassword)
					certifyingCommission.UpdateUser(editedUser, editUserForm.textBoxPassword.Text);
				else
					certifyingCommission.UpdateUser(editedUser);
			}
		}

		private static void TextBoxPassword_LostFocus(object sender, System.EventArgs e)
		{
			var textBoxPassword = (TextBox)sender;
			if (!string.IsNullOrEmpty(textBoxPassword.Text))
				_isChangedPassword = true;
			else
				textBoxPassword.Text = EditPasswordMessage;
		}

		private static void TextBoxPassword_GotFocus(object sender, System.EventArgs e)
		{
			var textBoxPassword = (TextBox) sender;
			if (!_isChangedPassword)
				textBoxPassword.Text = string.Empty;
		}

		private static void SetFromInscriptions(AddDeleteEditUserForm addDeleteEditUserForm, string formText, string submitButtonText)
		{
			addDeleteEditUserForm.Text = formText;
			addDeleteEditUserForm.buttonSubmit.Text = submitButtonText;
		}

		private static void DisableInputs(AddDeleteEditUserForm addDeleteEditUserForm)
		{
			addDeleteEditUserForm.textBoxLogin.Enabled = false;
			addDeleteEditUserForm.textBoxPassword.Enabled = false;
			addDeleteEditUserForm.textBoxSurname.Enabled = false;
			addDeleteEditUserForm.textBoxName.Enabled = false;
			addDeleteEditUserForm.textBoxPatronymic.Enabled = false;
		}

		private static void SetInputs(User user, AddDeleteEditUserForm addDeleteEditUserForm)
		{
			addDeleteEditUserForm.textBoxLogin.Text = user.Login;
			addDeleteEditUserForm.textBoxSurname.Text = user.Surname;
			addDeleteEditUserForm.textBoxName.Text = user.Name;
			addDeleteEditUserForm.textBoxPatronymic.Text = user.Patronymic;
			addDeleteEditUserForm.textBoxPassword.Text = EditPasswordMessage;
		}

		private static void HidePasswordBlocks(AddDeleteEditUserForm addDeleteEditUserForm)
		{
			addDeleteEditUserForm.labelPassword.Visible = false;
			addDeleteEditUserForm.textBoxPassword.Visible = false;
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

		private void textBoxSurname_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxSurname.Text) || string.IsNullOrWhiteSpace(textBoxSurname.Text))
			{
				errorProvider.SetError(textBoxSurname, EmptySurnameFieldMessage);
				IsValid = false;
			}
			else
			{
				errorProvider.Clear();
				IsValid = true;
			}
		}

		private void textBoxName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxName.Text))
			{
				errorProvider.SetError(textBoxName, EmptyNameFieldMessage);
				IsValid = false;
			}
			else
			{
				errorProvider.Clear();
				IsValid = true;
			}
		}

		private void textBoxPatronymic_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxPatronymic.Text) || string.IsNullOrWhiteSpace(textBoxPatronymic.Text))
			{
				errorProvider.SetError(textBoxPatronymic, EmptyPatronymicFieldMessage);
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
			if (!_isChangedPassword)
				return;

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

		private void buttonSubmit_Click(object sender, EventArgs e)
		{
			if (IsValid)
				DialogResult = DialogResult.OK;
			else
				MessageBox.Show(ValidationFailedTitle, ValidationFailedMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
