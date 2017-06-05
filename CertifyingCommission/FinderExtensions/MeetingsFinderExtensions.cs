using System;
using System.Collections.Generic;
using System.Linq;
using CertifyingCommissionEntities;

namespace FinderExtensions
{
	public static class MeetingsFinderExtensions
	{
		public static IEnumerable<Meeting> Find(this IEnumerable<Meeting> meetings, DateTime fromDate, DateTime toDate) =>
			meetings.Where(meeting => meeting.MeetingDateTime > fromDate && meeting.MeetingDateTime < toDate);
	}
}
