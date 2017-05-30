using System.Linq;
using CertifyingCommisionBl;
using CertifyingCommissionEntities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CertifyingCommissionBlTest
{
	[TestClass]
	public class CertifyingCommisionTests
	{
		private const string ConnectionString = "Data Source=EPRURYAW0378;AttachDbFilename=C:\\Users\\Artem_Svetlov\\Desktop\\CertifyingCommission\\CaertifyingCommisionDataBase\\CertifyingCommision.mdf;Integrated Security=True;User Instance=True";

		private static SertifyingCommision _sertifyingCommision;
		private static CertifyingCommissionContext _sertifyingCommisionContext;

		private static Subject _subject;

		private static Teacher _teacher;

		[ClassInitialize]
		public static void Initialize(TestContext testContext)
		{
			_subject = new Subject
			{
				SubjectName = "Test subject"
			};
			_teacher = new Teacher
			{
				Login = "testLogin",
				PasswordHash = 1234567,
				Surname = "TestSurname",
				Name = "TestName",
				Patronymic = "TestPatronymic",
				File = new byte[] { },
				Subject = _subject
			};

			_sertifyingCommision = new SertifyingCommision(ConnectionString);
			_sertifyingCommisionContext = new CertifyingCommissionContext(ConnectionString);
		}

		[TestInitialize]
		public void InitializeTest()
		{
			_sertifyingCommisionContext.Teachers.Add(_teacher);
			_sertifyingCommisionContext.SaveChanges();
		}

		[TestMethod]
		public void TestGetAllTeachers()
		{
			var teachers = _sertifyingCommision.GetAllTeachers();
			Assert.IsTrue(teachers.Any(techer => techer.Login == _teacher.Login));
		}

		[TestCleanup]
		public void Cleanup()
		{
			_sertifyingCommisionContext.Teachers.Remove(_teacher);
			_sertifyingCommisionContext.Subjects.Remove(_subject);
			_sertifyingCommisionContext.SaveChanges();
		}
	}
}
