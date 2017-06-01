using System.Collections.Generic;
using System.ComponentModel;

namespace CertifyingCommissionEntities
{
	public class Teacher : User
	{
		public Teacher()
		{
			Meetings = new List<Meeting>();
		}

		[Browsable(false)]
		public int? SubjectId { get; set; }

		public Subject Subject { get; set; }
		[Browsable(false)]
		public ICollection<Meeting> Meetings { get; set; }
	}
}
