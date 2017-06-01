using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CertifyingCommissionEntities;

namespace CertifyingCommissionDal
{
	public class CertifyingCommissionDataBaseDao : ICertifyingCommissionDao
	{
		private readonly CertifyingCommissionContext _context;

		public CertifyingCommissionDataBaseDao()
		{
			_context = ConnectionCreator.Instance;
		}

		public CertifyingCommissionDataBaseDao(string connectionString)
		{
			_context = ConnectionCreator.GetInstance(connectionString);
		}

		public void CreateUser(User user)
		{
			if (user == null)
				throw new ArgumentNullException(nameof(user));

			var userEntry = _context.Entry(user);
			userEntry.State = EntityState.Added;
			_context.SaveChanges();
			userEntry.State = EntityState.Detached;
			_context.SaveChanges();
		}

		public void CreateSubject(Subject subject)
		{
			if (subject == null)
				throw new ArgumentNullException(nameof(subject));

			var subjectEntry = _context.Entry(subject);
			subjectEntry.State = EntityState.Added;
			_context.SaveChanges();
			subjectEntry.State = EntityState.Detached;
		}

		public void CreateMeeting(Meeting meeting)
		{
			if (meeting == null)
				throw new ArgumentNullException(nameof(meeting));

			var meetingEntry = _context.Entry(meeting);
			meeting.Secretary = _context.Secretaries.Find(meeting.SecretaryId);
			meeting.CommissionMember = _context.CommisionMembers.Find(meeting.CommissionMemberId);
			meeting.Teacher = _context.Teachers.Find(meeting.TeacherId);
			meetingEntry.State = EntityState.Added;
			_context.SaveChanges();
			meetingEntry.State = EntityState.Detached;
			_context.SaveChanges();
		}

		public User ReadUser(string login)
		{
			if (string.IsNullOrEmpty(login))
				throw new ArgumentNullException(nameof(login));
			return _context.Users
				.Include(user => user.Sault)
				.Where(user => user.Login == login)
				.AsNoTracking()
				.FirstOrDefault();
		}

		public Sault ReadSault(int userId) =>
			_context.Saults
				.Where(sault => sault.UserId == userId)
				.AsNoTracking()
				.FirstOrDefault();

		public IEnumerable<Teacher> ReadAllTeachers() =>
			_context.Teachers.AsNoTracking();

		public IEnumerable<CommissionMember> ReadAllCommisionMembers() =>
			_context.CommisionMembers.AsNoTracking();

		public IEnumerable<Secretary> ReadSecretaries(Secretary secretary)
		{
			if (secretary == null)
				throw new ArgumentNullException(nameof(secretary));

			return _context.Secretaries
				.Where(sec => sec.UserId != secretary.UserId)
				.AsNoTracking();
			;
		}

		public IEnumerable<Subject> ReadAllSubjects() =>
			_context.Subjects.AsNoTracking();

		public IEnumerable<Meeting> ReadAllMeetings() =>
			_context.Meetings.AsNoTracking();

		public void UpdateUser(User user)
		{
			if (user == null)
				throw new ArgumentNullException(nameof(user));

			var entryUser = _context.Entry(user);
			entryUser.State = EntityState.Modified;
			_context.SaveChanges();
			entryUser.State = EntityState.Detached;
			_context.SaveChanges();
		}

		public void UpdateSubject(Subject subject)
		{
			if (subject == null)
				throw new ArgumentNullException(nameof(subject));

			var entrySubject = _context.Entry(subject);
			entrySubject.State = EntityState.Modified;
			_context.SaveChanges();
			entrySubject.State= EntityState.Detached;
			_context.SaveChanges();
		}

		public void UpdateMeeting(Meeting meeting)
		{
			if (meeting == null)
				throw new ArgumentNullException(nameof(meeting));

			_context.Entry(meeting).State = EntityState.Modified;
			_context.SaveChanges();
		}

		public void DeleteUser(User user)
		{
			if (user == null)
				throw new ArgumentNullException(nameof(user));

			_context.Entry(user).State = EntityState.Deleted;
			_context.SaveChanges();
		}

		public void DeleteMeeting(Meeting meeting)
		{
			throw new NotImplementedException();
		}

		public void DeleteSubject(Subject subject)
		{
			if (subject == null)
				throw new ArgumentNullException(nameof(subject));

			_context.Entry(subject).State = EntityState.Deleted;
			_context.SaveChanges();
		}

		public void Dispose() =>
			_context?.Dispose();
	}
}