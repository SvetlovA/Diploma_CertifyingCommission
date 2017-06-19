using System;
using System.Collections.Generic;
using CertifyingCommissionEntities;

namespace CertifyingCommissionDal
{
	public interface ICertifyingCommissionDao : IDisposable
	{	 
		/// <summary>
		/// Create user
		/// </summary>
		/// <param name="user"> User</param>
		void CreateUser(User user);
		/// <summary>
		/// Create subject
		/// </summary>
		/// <param name="subject"> Subject</param>
		void CreateSubject(Subject subject);
		/// <summary>
		/// Create meeting
		/// </summary>
		/// <param name="meeting"> Meeting</param>
		void CreateMeeting(Meeting meeting);

		/// <summary>
		/// Read user
		/// </summary>
		/// <param name="login"> Login</param>
		/// <returns> User</returns>
		User ReadUser(string login);
		/// <summary>
		/// Read sault
		/// </summary>
		/// <param name="userId"> User id</param>
		/// <returns> User sault</returns>
		Sault ReadSault(int userId);
		/// <summary>
		/// Read all teachers
		/// </summary>
		/// <returns> All teachers</returns>
		IEnumerable<Teacher> ReadAllTeachers();
		/// <summary>
		/// Read all commision members
		/// </summary>
		/// <returns> All commision members</returns>
		IEnumerable<CommissionMember> ReadAllCommisionMembers();
		/// <summary>
		/// Read secretaries
		/// </summary>
		/// <param name="secretary"> Secretary</param>
		/// <returns>Secretaries</returns>
		IEnumerable<Secretary> ReadSecretaries(Secretary secretary);
		/// <summary>
		/// Read all subjects
		/// </summary>
		/// <returns> All subjects</returns>
		IEnumerable<Subject> ReadAllSubjects();
		/// <summary>
		/// Read all meetings
		/// </summary>
		/// <returns> All meetings</returns>
		IEnumerable<Meeting> ReadAllMeetings();
		/// <summary>
		/// Read teacher meetings
		/// </summary>
		/// <param name="user"> User</param>
		/// <returns> Teacher meetings</returns>
		IEnumerable<Meeting> ReadTeacherMeetings(User user);
		/// <summary>
		/// Read confirmed meetings
		/// </summary>
		/// <returns> Confirmed meetings</returns>
		IEnumerable<Meeting> ReadConfirmedMeetings();
		/// <summary>
		/// Read not actual meetings
		/// </summary>
		/// <returns> Not actual meetings</returns>
		IEnumerable<Meeting> ReadNotActualMeetings();

		/// <summary>
		/// Update user
		/// </summary>
		/// <param name="user"> User for update</param>
		void UpdateUser(User user);
		/// <summary>
		/// Update subject
		/// </summary>
		/// <param name="subject"> Subject for update</param>
		void UpdateSubject(Subject subject);
		/// <summary>
		/// Update meeting
		/// </summary>
		/// <param name="meeting"> Meeting for update</param>
		void UpdateMeeting(Meeting meeting);

		/// <summary>
		/// Delete user
		/// </summary>
		/// <param name="user"> User for delete</param>
		void DeleteUser(User user);
		/// <summary>
		/// Delete meeting
		/// </summary>
		/// <param name="meeting"> Meeting for delete</param>
		void DeleteMeeting(Meeting meeting);
		/// <summary>
		/// Delete subject
		/// </summary>
		/// <param name="subject">subject for delete</param>
		void DeleteSubject(Subject subject);
	}
}
