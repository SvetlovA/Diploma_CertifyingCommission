using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CertifyingCommisionBl;
using CertifyingCommissionEntities;
using FinderExtensions;

namespace CertifyingCommisionFormUI.SecretaryForms
{
	public partial class UsersForm<TUser> : Form where TUser: User, new()
	{
		private const string SelectRowMessage = "Row isn't selected. Please, select row.";
		private const string PluralEnd = "s";

		private readonly CertifyingCommission _certifyingCommision;
		private readonly User _currentUser;

		private bool _isFind;

		public UsersForm(User user, CertifyingCommission certifyingCommission)
		{
			InitializeComponent();
			_certifyingCommision = certifyingCommission;
			_currentUser = user;
			groupBoxUsers.Text = typeof(TUser).Name + PluralEnd;
			UpdateData();
		}

		private IEnumerable<TUser> GetUsers()
		{
			if (typeof(TUser) == typeof(Secretary))
				return (IEnumerable<TUser>) _certifyingCommision.GetSecretaries(_currentUser as Secretary);

			if (typeof(TUser) == typeof(Teacher))
				return _certifyingCommision.GetAllTeachers() as IEnumerable<TUser>;

			return _certifyingCommision.GetAllCommissionMembers() as IEnumerable<TUser>;
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			AddDeleteEditUserForm.Add<TUser>(_certifyingCommision);
			UpdateData();
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			var selectedUser = GetSelectedUser(dataGridViewUsers.CurrentRow);
			AddDeleteEditUserForm.Delete(selectedUser, _certifyingCommision);
			UpdateData();
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			var selectedUser = GetSelectedUser(dataGridViewUsers.CurrentRow);
			AddDeleteEditUserForm.Edit(selectedUser, _certifyingCommision);
			UpdateData();
		}

		private TUser GetSelectedUser(DataGridViewRow row)
		{
			if (row == null)
				throw new Exception(SelectRowMessage);

			return (TUser)row.DataBoundItem;
		}

		private void UpdateData() =>
			dataGridViewUsers.DataSource = _isFind ? GetUsers()
													.Find(textBoxSurname.Text)
													.OfType<TUser>()
													.ToList() 
			: GetUsers().ToList();

		private void buttonFind_Click(object sender, EventArgs e)
		{
			_isFind = true;
			UpdateData();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			_isFind = false;
			UpdateData();
		}
	}
}
