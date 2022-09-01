﻿using Microsoft.EntityFrameworkCore;
using Profile.Model;

namespace Profile.Data
{
	/// <summary>
	/// Database Entities
	/// </summary>
	public class ProfileContext : DbContext

	{
		protected readonly IConfiguration Configuration;

		public ProfileContext(IConfiguration configuration)
		{
			Configuration = configuration;

		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(Configuration.GetConnectionString("AZURE_SQL_CONNECTIONSTRING"));
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
