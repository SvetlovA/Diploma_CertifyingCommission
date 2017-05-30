using System;
using System.Collections.Generic;
using System.Data.Entity;
using CertifyingCommissionEntities;

namespace CertifyingCommissionDal
{
	public class SecretaryDataBaseDao : ISecretaryDao
	{
		private readonly CertifyingCommissionContext _context;

		public SecretaryDataBaseDao()
		{
			_context = ConnectionCreator.Instance;
		}

		public SecretaryDataBaseDao(string connectionString)
		{
			_context = ConnectionCreator.GetInstance(connectionString);
		}

		public void CreateTeacher(Teacher teacher)
		{
			if (teacher == null)
				throw new ArgumentNullException(nameof(teacher));
			_context.Entry(teacher).State = EntityState.Added;
			_context.SaveChanges();
		}

		public void CreateCommisionMember(CommissionMember commisionMember)
		{
			if (commisionMember == null)
				throw new ArgumentNullException(nameof(commisionMember));
			_context.Entry(commisionMember).State = EntityState.Added;
			_context.SaveChanges();
		}

		public void CreateSecretary(Secretary secretary)
		{
			if (secretary == null)
				throw new ArgumentNullException(nameof(secretary));
			_context.Entry(secretary).State = EntityState.Added;
			_context.SaveChanges();
		}

		public void CreateSubject(Subject subject)
		{
			if (subject == null)
				throw new ArgumentNullException(nameof(subject));
			_context.Entry(subject).State = EntityState.Added;
			_context.SaveChanges();
		}

		public IEnumerable<Teacher> ReadAllTeachers() =>
			_context.Teachers.AsNoTracking();

		public IEnumerable<CommissionMember> ReadAllCommisionMembers() =>
			_context.CommisionMembers.AsNoTracking();

		public IEnumerable<Secretary> ReadAllSecretaries() =>
			_context.Secretaries.AsNoTracking();

		public IEnumerable<Subject> ReadAllSubjects() =>
			_context.Subjects.AsNoTracking();

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

		public void Dispose()
		{
			throw new System.NotImplementedException();
		}
	}
}
