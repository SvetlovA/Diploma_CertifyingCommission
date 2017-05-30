using System.Configuration;
using System.Data.Entity;

namespace CertifyingCommissionEntities
{
	public class CertifyingCommissionContext : DbContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<Teacher> Teachers { get; set; }
		public DbSet<Secretary> Secretaries { get; set; }
		public DbSet<CommissionMember> CommisionMembers { get; set; }
		public DbSet<Meeting> Meetings { get; set; }
		public DbSet<Subject> Subjects { get; set; }

		public CertifyingCommissionContext() : this(ConfigurationManager.ConnectionStrings["CertifyingCommision"].ConnectionString)
		{ }

		public CertifyingCommissionContext(string connectionString) : base(connectionString)
		{ }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Teacher>().ToTable("Teachers");
			modelBuilder.Entity<Secretary>().ToTable("Secretaries");
			modelBuilder.Entity<CommissionMember>().ToTable("CommisionMembers");

			modelBuilder.Entity<Meeting>()
				.HasRequired(m => m.Teacher)
				.WithMany(t => t.Meetings)
				.HasForeignKey(m => m.TeacherId)
				.WillCascadeOnDelete();

			modelBuilder.Entity<Meeting>()
				.HasRequired(m => m.CommissionMember)
				.WithMany(c => c.Meetings)
				.HasForeignKey(m => m.CommissionMemberId)
				.WillCascadeOnDelete();

			modelBuilder.Entity<Meeting>()
				.HasRequired(m => m.Secretary)
				.WithMany(s => s.Meetings)
				.HasForeignKey(m => m.SecretaryId)
				.WillCascadeOnDelete();

			modelBuilder.Entity<Teacher>()
				.HasRequired(t => t.Subject)
				.WithMany(s => s.Teachers)
				.HasForeignKey(t => t.SubjectId)
				.WillCascadeOnDelete();

			base.OnModelCreating(modelBuilder);
		}
	}
}
