using System.Collections.Generic;

namespace CertifyingCommissionEntities
{
	public class Teacher : User
	{
		public Teacher()
		{
			Meetings = new List<Meeting>();
		}

		public int SubjectId { get; set; }
		public byte[] File { get; set; }

		public Subject Subject { get; set; }
		public ICollection<Meeting> Meetings { get; set; }
	}
}
