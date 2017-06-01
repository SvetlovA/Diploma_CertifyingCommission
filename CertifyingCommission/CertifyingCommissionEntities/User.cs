using System.ComponentModel;

namespace CertifyingCommissionEntities
{
	public class User
	{
		[Browsable(false)]
		public int UserId { get; set; }
		public string Login { get; set; }
		[Browsable(false)]
		public int PasswordHash { get; set; }
		public string Surname { get; set; }
		public string Name { get; set; }
		public string Patronymic { get; set; }

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
	}
}
