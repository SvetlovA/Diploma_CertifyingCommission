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
			_context.Entry(user).State = EntityState.Added;
			_context.SaveChanges();
		}

		public void CreateSubject(Subject subject)
		{
			if (subject == null)
				throw new ArgumentNullException(nameof(subject));
			_context.Entry(subject).State = EntityState.Added;
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

		public IEnumerable<Teacher> ReadAllTeachers() =>
			_context.Teachers.AsNoTracking();

		public IEnumerable<CommissionMember> ReadAllCommisionMembers() =>
			_context.CommisionMembers.AsNoTracking();

		public IEnumerable<Secretary> ReadAllSecretaries() =>
			_context.Secretaries.AsNoTracking();

		public IEnumerable<Subject> ReadAllSubjects() =>
			_context.Subjects.AsNoTracking();

		public IEnumerable<Meeting> ReadAllMeetings() =>
			_context.Meetings.AsNoTracking();

		public void UpdateTeacher(Teacher teacher)
		{
			if (teacher == null)
				throw new ArgumentNullException(nameof(teacher));
		}

		public void UpdateCommisionMember(CommissionMember commisionMember)
		{
			throw new System.NotImplementedException();
		}

		public void UpdateSecretary(Secretary secretary)
		{
			throw new System.NotImplementedException();
		}

		public void UpdateSubject(Subject subject)
		{
			throw new System.NotImplementedException();
		}

		public void UpdateMeeting(Meeting meeting)
		{
			if (meeting == null)
				throw new ArgumentNullException(nameof(meeting));

			_context.Entry(meeting).State = EntityState.Modified;
			_context.SaveChanges();
		}

		public void DeleteTeacher(Teacher teacher)
		{
			_context.Entry(teacher).State = EntityState.Deleted;
			_context.SaveChanges();
		}

		public void DeleteCommisionMember(CommissionMember commisionMember)
		{
			throw new System.NotImplementedException();
		}

		public void DeleteSecretary(Secretary secretary)
		{
			throw new System.NotImplementedException();
		}

		public void DeleteSubject(Subject subject)
		{
			throw new System.NotImplementedException();
		}

		public void Dispose() =>
			_context?.Dispose();
	}
}
