using System.Collections.Generic;
using System.ComponentModel;

namespace CertifyingCommissionEntities
{
	/// <summary>
	/// Secretary
	/// </summary>
	public class Secretary : User
	{
		/// <summary>
		/// Constructor of secretary
		/// </summary>
		public Secretary()
		{
			Meetings = new List<Meeting>();
		}

		/// <summary>
		/// Secretary meetings
		/// </summary>
		[Browsable(false)]
		public ICollection<Meeting> Meetings { get; set; }
	}
}
