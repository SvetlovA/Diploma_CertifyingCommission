using System.Collections.Generic;
using CertifyingCommissionDal;
using CertifyingCommissionEntities;

namespace CertifyingCommisionBl
{
	public class SertifyingCommision
	{
		private readonly ISecretaryDao _secretaryDao;

		public SertifyingCommision()
		{
			_secretaryDao = new SecretaryDataBaseDao();
		}

		public SertifyingCommision(string connectionString)
		{
			_secretaryDao = new SecretaryDataBaseDao(connectionString);
		}

		public IEnumerable<Teacher> GetAllTeachers() =>
			_secretaryDao.ReadAllTeachers();
	}
}
