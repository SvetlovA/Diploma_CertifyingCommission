﻿using System;
using System.Linq;
using System.Windows.Forms;
using CertifyingCommisionBl;
using CertifyingCommissionEntities;
using FinderExtensions;

namespace CertifyingCommisionFormUI.CommissionMemberForms
{
	public partial class ConfirmedMeetingsForm : Form
	{
		private const string SetDateSuccessMessage = "Date was sated.";
		private const string InformationTitle = "Information";

		private readonly CertifyingCommission _certifyingCommission;
		private readonly User _currentUser;

		private bool _isFind;

		public ConfirmedMeetingsForm(User user, CertifyingCommission certifyingCommission)
		{
			InitializeComponent();
			_certifyingCommission = certifyingCommission;
			_currentUser = user;
			UpdateData();
		}

		private void UpdateData() =>
			dataGridViewMeetings.DataSource = _isFind
				? _certifyingCommission.GetAllMeetings().Find(dateTimePickerFromDate.Value, dateTimePickerToDate.Value).ToList()
				: _certifyingCommission.GetConfirmedMeetings().ToList();

		private void buttonSetDate_Click(object sender, EventArgs e)
		{
			SetDate();
		}

		private void SetDate()
		{
			var selectedMeeting = SelectMeeting(dataGridViewMeetings.CurrentRow);
			var setDateForm = new SetDateForm();

			if (setDateForm.ShowDialog() == DialogResult.OK)
			{
				selectedMeeting.CommissionMember = (CommissionMember) _currentUser;
				selectedMeeting.CommissionMemberId = _currentUser.UserId;
				selectedMeeting.MeetingDateTime = setDateForm.DateTime;
				_certifyingCommission.UpdateMeeting(selectedMeeting);
				UpdateData();
				MessageBox.Show(SetDateSuccessMessage, InformationTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private Meeting SelectMeeting(DataGridViewRow row)
		{
			if (row == null)
				throw new ArgumentNullException(nameof(row));

			return (Meeting) row.DataBoundItem;
		}

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
