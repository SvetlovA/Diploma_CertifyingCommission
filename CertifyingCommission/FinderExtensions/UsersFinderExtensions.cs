using System.Collections.Generic;
using System.Linq;
using CertifyingCommissionEntities;

namespace FinderExtensions
{
	/// <summary>
	/// Extensions for users finder
	/// </summary>
	public static class UsersFinderExtensions
	{
		/// <summary>
		/// Find user
		/// </summary>
		/// <param name="users"> List of users</param>
		/// <param name="surname"> User surname</param>
		/// <returns> Finded users</returns>
		public static IEnumerable<User> Find(this IEnumerable<User> users, string surname) =>
			users.Where(user => user.Surname.StartsWith(surname));
	}
}
