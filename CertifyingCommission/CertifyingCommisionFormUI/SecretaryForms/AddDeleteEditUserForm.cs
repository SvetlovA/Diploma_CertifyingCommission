using System.Windows.Forms;
using CertifyingCommisionBl;
using CertifyingCommissionEntities;

namespace CertifyingCommisionFormUI.SecretaryForms
{
	public partial class AddDeleteEditUserForm : Form
	{
		private const string AddText = "Add";
		private const string DeleteText = "Delete";
		private const string EditText = "Edit";
		private const string EditPasswordMessage = "Start input to change password";

		private static bool _isChangedPassword; 

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
	}
}
