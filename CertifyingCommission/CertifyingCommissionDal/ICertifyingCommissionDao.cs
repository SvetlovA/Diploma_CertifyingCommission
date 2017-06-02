using System;
using System.Collections.Generic;
using CertifyingCommissionEntities;

namespace CertifyingCommissionDal
{
	public interface ICertifyingCommissionDao : IDisposable
	{
		void CreateUser(User user);
		void CreateSubject(Subject subject);
		void CreateMeeting(Meeting meeting);

		User ReadUser(string login);
		Sault ReadSault(int userId);
		IEnumerable<Teacher> ReadAllTeachers();
		IEnumerable<CommissionMember> ReadAllCommisionMembers();
		IEnumerable<Secretary> ReadSecretaries(Secretary secretary);
		IEnumerable<Subject> ReadAllSubjects();
		IEnumerable<Meeting> ReadAllMeetings();
		IEnumerable<Meeting> ReadTeacherMeetings(User user);
		IEnumerable<Meeting> ReadConfirmedMeetings();
		IEnumerable<Meeting> ReadNotActualMeetings();

		void UpdateUser(User user);
		void UpdateSubject(Subject subject);
		void UpdateMeeting(Meeting meeting);

		void DeleteUser(User user);
		void DeleteMeeting(Meeting meeting);
		void DeleteSubject(Subject subject);
	}
}
