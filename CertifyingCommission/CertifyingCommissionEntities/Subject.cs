using System.Collections.Generic;
using System.ComponentModel;

namespace CertifyingCommissionEntities
{
	/// <summary>
	/// Subject
	/// </summary>
	public class Subject
	{
		/// <summary>
		/// Constructor of subject
		/// </summary>
		public Subject()
		{
			Teachers = new List<Teacher>();
		}

		/// <summary>
		/// Subject id
		/// </summary>
		[Browsable(false)]
		public int SubjectId { get; set; }
		/// <summary>
		/// Subject name
		/// </summary>
		public string SubjectName { get; set; }
		/// <summary>
		/// Subject teachers
		/// </summary>
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
