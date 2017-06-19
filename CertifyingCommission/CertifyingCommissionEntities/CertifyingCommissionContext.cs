using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;

namespace CertifyingCommissionEntities
{
	public class CertifyingCommissionContext : DbContext
	{
		/// <summary>
		/// Users
		/// </summary>
		public DbSet<User> Users { get; set; }
		/// <summary>
		/// Teachers
		/// </summary>
		public DbSet<Teacher> Teachers { get; set; }
		/// <summary>
		/// Secretaries
		/// </summary>
		public DbSet<Secretary> Secretaries { get; set; }
		/// <summary>
		/// Commision members
		/// </summary>
		public DbSet<CommissionMember> CommisionMembers { get; set; }
		/// <summary>
		/// Meetings
		/// </summary>
		public DbSet<Meeting> Meetings { get; set; }
		/// <summary>
		/// Subjects
		/// </summary>
		public DbSet<Subject> Subjects { get; set; }
		/// <summary>
		/// Saults
		/// </summary>
		public DbSet<Sault> Saults { get; set; }

		/// <summary>
		/// Contructor of context
		/// </summary>
		public CertifyingCommissionContext() : this(ConfigurationManager.ConnectionStrings["CertifyingCommision"].ConnectionString)
		{ }

		/// <summary>
		/// Contructor of context
		/// </summary>
		/// <param name="connectionString"> Connetion string</param>
		public CertifyingCommissionContext(string connectionString) : base(connectionString)
		{
			Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CertifyingCommissionContext>());
		}

		/// <summary>
		/// Create data base rules
		/// </summary>
		/// <param name="modelBuilder"> Model builder</param>
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Teacher>().ToTable("Teachers");
			modelBuilder.Entity<Secretary>().ToTable("Secretaries");
			modelBuilder.Entity<CommissionMember>().ToTable("CommisionMembers");

			modelBuilder.Entity<Meeting>()
				.HasOptional(m => m.Teacher)
				.WithMany(t => t.Meetings)
				.HasForeignKey(m => m.TeacherId)
				.WillCascadeOnDelete();

			modelBuilder.Entity<Meeting>()
				.HasOptional(m => m.CommissionMember)
				.WithMany(c => c.Meetings)
				.HasForeignKey(m => m.CommissionMemberId)
				.WillCascadeOnDelete();

			modelBuilder.Entity<Meeting>()
				.HasOptional(m => m.Secretary)
				.WithMany(s => s.Meetings)
				.HasForeignKey(m => m.SecretaryId)
				.WillCascadeOnDelete();

			modelBuilder.Entity<Teacher>()
				.HasOptional(t => t.Subject)
				.WithMany(s => s.Teachers)
				.HasForeignKey(t => t.SubjectId);

			modelBuilder.Entity<Sault>()
				.HasKey(s => s.UserId);

			modelBuilder.Entity<User>()
				.HasRequired(u => u.Sault)
				.WithRequiredPrincipal(s => s.User)
				.WillCascadeOnDelete();

			modelBuilder.Entity<User>()
				.Property(u => u.Login)
				.IsRequired()
				.HasMaxLength(50)
				.HasColumnAnnotation(IndexAnnotation.AnnotationName,
					new IndexAnnotation(new IndexAttribute("UK_User_Login") {IsUnique = true}));

			base.OnModelCreating(modelBuilder);
		}
	}
}
