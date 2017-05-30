using System;
using System.Collections.Generic;
using CertifyingCommissionEntities;

namespace CertifyingCommissionDal
{
	public interface ISecretaryDao : IDisposable
	{
		void CreateTeacher(Teacher teacher);
		void CreateCommisionMember(CommissionMember commisionMember);
		void CreateSecretary(Secretary secretary);
		void CreateSubject(Subject subject);

		IEnumerable<Teacher> ReadAllTeachers();
		IEnumerable<CommissionMember> ReadAllCommisionMembers();
		IEnumerable<Secretary> ReadAllSecretaries();
		IEnumerable<Subject> ReadAllSubjects();

		void UpdateTeacher(Teacher teacher);
		void UpdateCommisionMember(CommissionMember commisionMember);
		void UpdateSecretary(Secretary secretary);
		void UpdateSubject(Subject subject);

		void DeleteTeacher(Teacher teacher);
		void DeleteCommisionMember(CommissionMember commisionMember);
		void DeleteSecretary(Secretary secretary);
		void DeleteSubject(Subject subject);
	}
}
