using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CertifyingCommissionEntities;

namespace CertifyingCommissionDal
{
	public class CertifyingCommissionDataBaseDao : ICertifyingCommissionDao
	{
		private const int WeekLength = 1;

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
			_context.Teachers
				.Include(t => t.Subject)
				.AsNoTracking();

		public IEnumerable<CommissionMember> ReadAllCommisionMembers() =>
			_context.CommisionMembers.AsNoTracking();

		public IEnumerable<Secretary> ReadSecretaries(Secretary secretary)
		{
			if (secretary == null)
				throw new ArgumentNullException(nameof(secretary));

			return _context.Secretaries
				.Where(sec => sec.UserId != secretary.UserId)
				.AsNoTracking();
		}

		public IEnumerable<Subject> ReadAllSubjects() =>
			_context.Subjects.AsNoTracking();

		public IEnumerable<Meeting> ReadAllMeetings() =>
			_context.Meetings
				.Include(m => m.Teacher)
				.Include(m => m.Secretary)
				.Include(m => m.CommissionMember)
				.AsNoTracking();

		public IEnumerable<Meeting> ReadTeacherMeetings(User user) =>
			_context.Meetings
				.Include(m => m.Teacher)
				.Include(m => m.Secretary)
				.Include(m => m.CommissionMember)
				.Where(m => m.TeacherId == user.UserId)
				.AsNoTracking();

		public IEnumerable<Meeting> ReadConfirmedMeetings() =>
			_context.Meetings
				.Include(m => m.Teacher)
				.Include(m => m.Secretary)
				.Include(m => m.CommissionMember)
				.Where(m => m.MeetingStatus == MeetingStatus.Confirmed)
				.AsNoTracking();

		public IEnumerable<Meeting> ReadNotActualMeetings() =>
			_context.Meetings
				.Include(m => m.Teacher)
				.Include(m => m.Secretary)
				.Include(m => m.CommissionMember)
				.Where(m => m.MeetingCreationDateTime != null &&
							m.MeetingStatus == MeetingStatus.Rejected &&
							DbFunctions.DiffDays(m.MeetingCreationDateTime.Value, DateTime.Now) > WeekLength ||
							m.MeetingDateTime != null &&
							m.MeetingStatus == MeetingStatus.Confirmed &&
							DbFunctions.DiffDays(m.MeetingDateTime.Value, DateTime.Now) > WeekLength)
				.AsNoTracking();

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

			var entryMeeting = _context.Entry(meeting);
			entryMeeting.State = EntityState.Modified;
			_context.SaveChanges();
			entryMeeting.State = EntityState.Detached;
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
			if (meeting == null)
				throw new ArgumentNullException(nameof(meeting));

			_context.Entry(meeting).State = EntityState.Deleted;
			_context.SaveChanges();
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