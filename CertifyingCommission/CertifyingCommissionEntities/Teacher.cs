using System.Collections.Generic;
using System.ComponentModel;

namespace CertifyingCommissionEntities
{
	/// <summary>
	/// Teacher
	/// </summary>
	public class Teacher : User
	{
		/// <summary>
		/// Constructor of teacher
		/// </summary>
		public Teacher()
		{
			Meetings = new List<Meeting>();
		}

		/// <summary>
		/// Subject id
		/// </summary>
		[Browsable(false)]
		public int? SubjectId { get; set; }

		/// <summary>
		/// Teacher Subject
		/// </summary>
		public Subject Subject { get; set; }
		/// <summary>
		/// Teacher Meetings
		/// </summary>
		[Browsable(false)]
		public ICollection<Meeting> Meetings { get; set; }
	}
}
