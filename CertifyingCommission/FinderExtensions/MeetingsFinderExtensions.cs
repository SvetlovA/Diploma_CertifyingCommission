using System;
using System.Collections.Generic;
using System.Linq;
using CertifyingCommissionEntities;

namespace FinderExtensions
{
	/// <summary>
	/// Extensions for meetings finder
	/// </summary>
	public static class MeetingsFinderExtensions
	{
		/// <summary>
		/// Find meetings
		/// </summary>
		/// <param name="meetings"> List of meetings</param>
		/// <param name="fromDate"> From date to find</param>
		/// <param name="toDate"> To date to find</param>
		/// <returns> Finded meetings</returns>
		public static IEnumerable<Meeting> Find(this IEnumerable<Meeting> meetings, DateTime fromDate, DateTime toDate) =>
			meetings.Where(meeting => meeting.MeetingDateTime > fromDate && meeting.MeetingDateTime < toDate);
	}
}
