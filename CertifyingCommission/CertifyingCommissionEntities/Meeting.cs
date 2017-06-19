using System;
using System.ComponentModel;

namespace CertifyingCommissionEntities
{
	public class Meeting
	{
		/// <summary>
		/// Meeting id
		/// </summary>
		[Browsable(false)]
		public int MeetingId { get; set; }
		/// <summary>
		/// Teacher id
		/// </summary>
		[Browsable(false)]
		public int? TeacherId { get; set; }
		/// <summary>
		/// Commision member id
		/// </summary>
		[Browsable(false)]
		public int? CommissionMemberId { get; set; }
		/// <summary>
		/// Secretary id
		/// </summary>
		[Browsable(false)]
		public int? SecretaryId { get; set; }
		/// <summary>
		/// Date of meeting creation
		/// </summary>
		public DateTime? MeetingCreationDateTime { get; set; }
		/// <summary>
		/// Date of meeting
		/// </summary>
		public DateTime? MeetingDateTime { get; set; }
		/// <summary>
		/// Status of meeting
		/// </summary>
		public MeetingStatus MeetingStatus { get; set; }
		/// <summary>
		/// File for meeting
		/// </summary>
		[Browsable(false)]
		public byte[] File { get; set; }

		/// <summary>
		/// Scretary
		/// </summary>
		public Secretary Secretary { get; set; }
		/// <summary>
		/// Commisiion member
		/// </summary>
		public CommissionMember CommissionMember { get; set; }
		/// <summary>
		/// Teacher
		/// </summary>
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
