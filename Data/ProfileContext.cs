using Microsoft.EntityFrameworkCore;
using Profile.Model;

namespace Profile.Data
{
	/// <summary>
	/// Database Entities
	/// </summary>
	public class ProfileContext : DbContext

	{

		public ProfileContext(DbContextOptions<ProfileContext> options) : base(options)
		{

		}

		public DbSet<About> About => Set<About>();
		public DbSet<Personal> Personal => Set<Personal>();
		/// <summary>
		/// Education Table
		/// </summary>
		public DbSet<Education> Education => Set<Education>();
		/// <summary>
		/// Experiences Table
		/// </summary>
		public DbSet<Experience> Experiences => Set<Experience>();
		/// <summary>
		/// Projects Table
		/// </summary>
		public DbSet<Projects> Projects => Set<Projects>();
		/// <summary>
		/// Skills Table
		/// </summary>
		public DbSet<Skills> Skills => Set<Skills>();
		/// <summary>
		/// Contact Tables
		/// </summary>
		public DbSet<Contact> Contact => Set<Contact>();
	}
}
