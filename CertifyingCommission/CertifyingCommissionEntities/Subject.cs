using System.Collections.Generic;
using System.ComponentModel;

namespace CertifyingCommissionEntities
{
	public class Subject
	{
		public Subject()
		{
			Teachers = new List<Teacher>();
		}

		[Browsable(false)]
		public int SubjectId { get; set; }
		public string SubjectName { get; set; }
		[Browsable(false)]
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

		public override string ToString()
		{
			return SubjectName;
		}
	}
}
