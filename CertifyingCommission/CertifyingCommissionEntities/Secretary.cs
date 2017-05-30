using System.Collections.Generic;

namespace CertifyingCommissionEntities
{
	public class Secretary : User
	{
		public Secretary()
		{
			Meetings = new List<Meeting>();
		}

		public ICollection<Meeting> Meetings { get; set; }
	}
}
