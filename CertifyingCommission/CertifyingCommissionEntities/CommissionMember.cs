using System.Collections.Generic;
using System.ComponentModel;

namespace CertifyingCommissionEntities
{
	public class CommissionMember : User
	{
		public CommissionMember()
		{
			Meetings = new List<Meeting>();
		}

		[Browsable(false)]
		public ICollection<Meeting> Meetings { get; set; }
	}
}
