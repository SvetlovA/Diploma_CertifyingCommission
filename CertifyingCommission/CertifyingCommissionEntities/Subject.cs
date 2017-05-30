using System.Collections.Generic;

namespace CertifyingCommissionEntities
{
	public class Subject
	{
		public Subject()
		{
			Teachers = new List<Teacher>();
		}

		public int SubjectId { get; set; }
		public string SubjectName { get; set; }
		public ICollection<Teacher> Teachers { get; set; }

		protected bool Equals(Subject other)
		{
			return string.Equals(SubjectName, other.SubjectName);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != GetType()) return false;
			return Equals((Subject) obj);
		}

		public override int GetHashCode()
		{
			return (SubjectName != null ? SubjectName.GetHashCode() : 0);
		}
	}
}
