namespace CertifyingCommissionEntities
{
	/// <summary>
	/// sault
	/// </summary>
	public class Sault
	{
		/// <summary>
		/// User id
		/// </summary>
		public int UserId { get; set; }
		/// <summary>
		/// Value of sault
		/// </summary>
		public int SaultValue { get; set; }

		/// <summary>
		/// User
		/// </summary>
		public User User { get; set; }
	}
}
