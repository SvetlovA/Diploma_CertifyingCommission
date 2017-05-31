using System;
using System.Collections.Generic;
using CertifyingCommissionDal;
using CertifyingCommissionEntities;

namespace CertifyingCommisionBl
{
	public class CertifyingCommission : IDisposable
	{
		private const int RandomMaxValue = 999999999;

		private static readonly Random Random = new Random();

		private readonly ICertifyingCommissionDao _secretaryDao;

		public CertifyingCommission()
		{
			_secretaryDao = new CertifyingCommissionDataBaseDao();
		}

		public CertifyingCommission(string connectionString)
		{
			_secretaryDao = new CertifyingCommissionDataBaseDao(connectionString);
		}

		public bool CheckAutentification(string login, string password)
		{
			if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
				return false;

			var user = _secretaryDao.ReadUser(login);

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
			_secretaryDao.CreateUser(user);
		}

		public IEnumerable<Meeting> GetAllMeetings() =>
			_secretaryDao.ReadAllMeetings();

		public void UpdateMeeting(Meeting meeting) =>
			_secretaryDao.UpdateMeeting(meeting);

		public User GetUser(string login) =>
			_secretaryDao.ReadUser(login);

		public IEnumerable<Teacher> GetAllTeachers() =>
			_secretaryDao.ReadAllTeachers();

		public void Dispose() =>
			_secretaryDao?.Dispose();

		private int CalculateSaultPasswordHash(string password, int saultValue)
		{
			var passwordHash = password.GetHashCode();
			return passwordHash * saultValue;
		}
	}
}
