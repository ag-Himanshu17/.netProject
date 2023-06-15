using CollegeProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollegeProject.Data
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
		
		public DbSet<DataModel> Data { get; set; }
		public DbSet<ShareModel> Share { get; set; }
	}
    public class ApplicationUser : IdentityUser<Guid>
    {

    }

    public class ApplicationRole : IdentityRole<Guid>
    {

    }
}
