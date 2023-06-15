using CollegeProject.Models;
using Microsoft.AspNetCore.Identity;
using CollegeProject.Data;

namespace CollegeProject.Data
{
	public static class MyIdentityDataInitializer
	{
		public static void SeedData(UserManager<ApplicationUser> userManager,
			RoleManager<ApplicationRole> roleManager)
		{
			SeedRoles(roleManager);
			SeedUsers(userManager);
		}

		public static void SeedUsers(UserManager<ApplicationUser> userManager)
		{
			if (userManager.FindByNameAsync("Administrator").Result == null)
			{
				ApplicationUser user = new ApplicationUser
				{
					UserName = "college@admin.com",
					Email = "college@admin.com",
					PhoneNumberConfirmed = true,
					EmailConfirmed = true,
					PhoneNumber = "9999999999",
				};

				IdentityResult result = userManager.CreateAsync
				(user, "ProjectAdmin@123").Result;

				if (result.Succeeded)
				{
					userManager.AddToRoleAsync(user, RoleTypes.Administrator).Wait();
				}
			}

		}

		public static void SeedRoles(RoleManager<ApplicationRole> roleManager)
		{
			//For Admin
			if (!roleManager.RoleExistsAsync(RoleTypes.Administrator).Result)
			{
				ApplicationRole role = new ApplicationRole
				{
					Name = RoleTypes.Administrator.ToString()
				};
				IdentityResult roleResult = roleManager.
				CreateAsync(role).Result;
			}
			// For User
			if (!roleManager.RoleExistsAsync(RoleTypes.User).Result)
			{
				ApplicationRole role = new ApplicationRole
				{
					Name = RoleTypes.User.ToString()
				};
				IdentityResult roleResult = roleManager.
				CreateAsync(role).Result;
			}
		}
	}
}
