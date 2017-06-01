using System.Collections.Generic;
using System.ComponentModel;

namespace CertifyingCommissionEntities
{
	public class Secretary : User
	{
		public Secretary()
		{
			Meetings = new List<Meeting>();
		}

		[Browsable(false)]
		public ICollection<Meeting> Meetings { get; set; }
	}
}
