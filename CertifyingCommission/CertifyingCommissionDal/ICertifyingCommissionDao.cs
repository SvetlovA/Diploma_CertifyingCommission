using System;
using System.Collections.Generic;
using CertifyingCommissionEntities;

namespace CertifyingCommissionDal
{
	public interface ICertifyingCommissionDao : IDisposable
	{
		void CreateUser(User user);
		void CreateSubject(Subject subject);

		User ReadUser(string login);
		IEnumerable<Teacher> ReadAllTeachers();
		IEnumerable<CommissionMember> ReadAllCommisionMembers();
		IEnumerable<Secretary> ReadAllSecretaries();
		IEnumerable<Subject> ReadAllSubjects();
		IEnumerable<Meeting> ReadAllMeetings();

		void UpdateTeacher(Teacher teacher);
		void UpdateCommisionMember(CommissionMember commisionMember);
		void UpdateSecretary(Secretary secretary);
		void UpdateSubject(Subject subject);
		void UpdateMeeting(Meeting meeting);

		void DeleteTeacher(Teacher teacher);
		void DeleteCommisionMember(CommissionMember commisionMember);
		void DeleteSecretary(Secretary secretary);
		void DeleteSubject(Subject subject);
	}
}
