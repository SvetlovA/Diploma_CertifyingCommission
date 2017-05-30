using CertifyingCommissionEntities;

namespace CertifyingCommissionDal
{
	public static class ConnectionCreator
	{
		private static CertifyingCommissionContext _instance;

		public static CertifyingCommissionContext Instance
		{
			get
			{
				if (_instance == null)
					_instance = new CertifyingCommissionContext();
				return _instance;
			}
		}

		public static CertifyingCommissionContext GetInstance(string connectionString)
		{
			if (_instance == null)
				_instance = new CertifyingCommissionContext(connectionString);
			return _instance;
		}
	}
}
