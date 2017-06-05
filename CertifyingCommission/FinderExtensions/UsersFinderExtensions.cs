using System.Collections.Generic;
using System.Linq;
using CertifyingCommissionEntities;

namespace FinderExtensions
{
	public static class UsersFinderExtensions
	{
		public static IEnumerable<User> Find(this IEnumerable<User> users, string surname) =>
			users.Where(user => user.Surname.StartsWith(surname));
	}
}
