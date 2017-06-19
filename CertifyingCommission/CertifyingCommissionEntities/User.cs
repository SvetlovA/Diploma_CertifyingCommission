using System.ComponentModel;

namespace CertifyingCommissionEntities
{
	/// <summary>
	/// User
	/// </summary>
	public class User
	{
		/// <summary>
		/// User id
		/// </summary>
		[Browsable(false)]
		public int UserId { get; set; }
		/// <summary>
		/// Login
		/// </summary>
		public string Login { get; set; }
		/// <summary>
		/// Password hash code
		/// </summary>
		[Browsable(false)]
		public int PasswordHash { get; set; }
		/// <summary>
		/// Surname
		/// </summary>
		public string Surname { get; set; }
		/// <summary>
		/// Name
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Patronymic
		/// </summary>
		public string Patronymic { get; set; }

		/// <summary>
		/// Sault
		/// </summary>
		[Browsable(false)]
		public Sault Sault { get; set; }

		protected bool Equals(User other)
		{
			return string.Equals(Login, other.Login) && string.Equals(Surname, other.Surname) && string.Equals(Name, other.Name) && string.Equals(Patronymic, other.Patronymic);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != GetType()) return false;
			return Equals((User) obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = (Login != null ? Login.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (Surname != null ? Surname.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (Name != null ? Name.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (Patronymic != null ? Patronymic.GetHashCode() : 0);
				return hashCode;
			}
		}

		public override string ToString()
		{
			return $"{Surname} {Name[0]}. {Patronymic[0]}.";
		}
	}
}
