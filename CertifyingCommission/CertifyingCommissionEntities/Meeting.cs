using System;

namespace CertifyingCommissionEntities
{
	public class Meeting
	{
		public int MeetingId { get; set; }
		public int TeacherId { get; set; }
		public int CommissionMemberId { get; set; }
		public int SecretaryId { get; set; }
		public DateTime MeetingDateTime { get; set; }

		public Secretary Secretary { get; set; }
		public CommissionMember CommissionMember { get; set; }
		public Teacher Teacher { get; set; }

		protected bool Equals(Meeting other)
		{
			return MeetingDateTime.Equals(other.MeetingDateTime) && Equals(Secretary, other.Secretary) && Equals(CommissionMember, other.CommissionMember) && Equals(Teacher, other.Teacher);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != GetType()) return false;
			return Equals((Meeting) obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = MeetingDateTime.GetHashCode();
				hashCode = (hashCode * 397) ^ (Secretary != null ? Secretary.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (CommissionMember != null ? CommissionMember.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (Teacher != null ? Teacher.GetHashCode() : 0);
				return hashCode;
			}
		}
	}
}
