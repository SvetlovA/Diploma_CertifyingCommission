using System;
using System.Collections.Generic;
using System.Linq;
using CertifyingCommissionDal;
using CertifyingCommissionEntities;

namespace CertifyingCommisionBl
{
	public class CertifyingCommission : IDisposable
	{
		private const int RandomMaxValue = 999999999;
		private const string NotExistsUserMessage = "That user isn't exists.";

		private static readonly Random Random = new Random();

		private readonly ICertifyingCommissionDao _certifyingCommissionDao;

		public CertifyingCommission()
		{
			_certifyingCommissionDao = new CertifyingCommissionDataBaseDao();
		}

		public CertifyingCommission(string connectionString)
		{
			_certifyingCommissionDao = new CertifyingCommissionDataBaseDao(connectionString);
		}

		public bool CheckAutentification(string login, string password)
		{
			if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
				return false;

			var user = _certifyingCommissionDao.ReadUser(login);

			if (user == null)
				return false;

			var saultValue = user.Sault.SaultValue;
			var saultPasswordHash = CalculateSaultPasswordHash(password, saultValue);

			return user.PasswordHash == saultPasswordHash;
		}

		public void AddUser(User user, string password)
		{
			var saultValue = Random.Next(RandomMaxValue);
			var saultPasswordHash = CalculateSaultPasswordHash(password, saultValue);
			user.PasswordHash = saultPasswordHash;
			user.Sault = new Sault
			{
				User = user,
				SaultValue = saultValue
			};
			_certifyingCommissionDao.CreateUser(user);
		}

		public void AddSubject(Subject subject) =>
			_certifyingCommissionDao.CreateSubject(subject);

		public void AddMeeting(Meeting meeting) =>
			_certifyingCommissionDao.CreateMeeting(meeting);

		public IEnumerable<Meeting> GetAllMeetings() =>
			_certifyingCommissionDao.ReadAllMeetings();

		public IEnumerable<Secretary> GetSecretaries(Secretary secretary) =>
			_certifyingCommissionDao.ReadSecretaries(secretary);

		public IEnumerable<CommissionMember> GetAllCommissionMembers() =>
			_certifyingCommissionDao.ReadAllCommisionMembers();

		public User GetUser(string login) =>
			_certifyingCommissionDao.ReadUser(login);

		public IEnumerable<Teacher> GetAllTeachers() =>
			_certifyingCommissionDao.ReadAllTeachers();

		public IEnumerable<Subject> GetAllSubjects() =>
			_certifyingCommissionDao.ReadAllSubjects();

		public IEnumerable<Meeting> GetTeacherMeetings(User user) =>
			_certifyingCommissionDao.ReadTeacherMeetings(user);

		public IEnumerable<Meeting> GetConfirmedMeetings() =>
			_certifyingCommissionDao.ReadConfirmedMeetings();

		public void UpdateUser(User user, string password)
		{
			var sault = _certifyingCommissionDao.ReadSault(user.UserId);
			if (sault == null)
				throw new Exception(NotExistsUserMessage);

			var saultPassword = CalculateSaultPasswordHash(password, sault.SaultValue);
			user.PasswordHash = saultPassword;
			_certifyingCommissionDao.UpdateUser(user);
		}

		public void UpdateUser(User user) =>
			_certifyingCommissionDao.UpdateUser(user);

		public void UpdateSubject(Subject subject) =>
			_certifyingCommissionDao.UpdateSubject(subject);

		public void UpdateMeeting(Meeting meeting) =>
			_certifyingCommissionDao.UpdateMeeting(meeting);

		public void DeleteUser(User user) =>
			_certifyingCommissionDao.DeleteUser(user);

		public void DeleteSubject(Subject subject) =>
			_certifyingCommissionDao.DeleteSubject(subject);

		public void DeleteMeeting(Meeting meeting) =>
			_certifyingCommissionDao.DeleteMeeting(meeting);

		public void Dispose() =>
			_certifyingCommissionDao?.Dispose();

		public void ClearNotActualMeetings()
		{
			var notActualMeetings = _certifyingCommissionDao.ReadNotActualMeetings();
			foreach (var meeting in notActualMeetings.ToList())
				_certifyingCommissionDao.DeleteMeeting(meeting);
		}

		private int CalculateSaultPasswordHash(string password, int saultValue)
		{
			var passwordHash = password.GetHashCode();
			return passwordHash * saultValue;
		}
	}
}
