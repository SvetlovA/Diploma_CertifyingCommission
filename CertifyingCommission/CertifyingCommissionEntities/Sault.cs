namespace CertifyingCommissionEntities
{
	public class Sault
	{
		public int UserId { get; set; }
		public int SaultValue { get; set; }

		public User User { get; set; }
	}
}
