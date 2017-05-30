using System.Collections.Generic;

namespace CertifyingCommissionEntities
{
	public class CommissionMember : User
	{
		public CommissionMember()
		{
			Meetings = new List<Meeting>();
		}

		public ICollection<Meeting> Meetings { get; set; }
	}
}
