using System.Collections.Generic;
using System.ComponentModel;

namespace CertifyingCommissionEntities
{
	/// <summary>
	/// Commission member
	/// </summary>
	public class CommissionMember : User
	{

		/// <summary>
		/// Constructor of commisiion member
		/// </summary>
		public CommissionMember()
		{
			Meetings = new List<Meeting>();
		}

		/// <summary>
		/// Meetings
		/// </summary>
		[Browsable(false)]
		public ICollection<Meeting> Meetings { get; set; }
	}
}
