using CollegeProject.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollegeProject.Data;

namespace CollegeProject
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<ApplicationDbContext>(options =>
				options.UseSqlServer(
					Configuration.GetConnectionString("DefaultConnection")));

			//Add Identity registered the Services
			services.AddIdentity<ApplicationUser, ApplicationRole>(
				options =>
				{
					options.SignIn.RequireConfirmedAccount = false;
					options.SignIn.RequireConfirmedPhoneNumber = false;
					options.Password.RequireLowercase = false;
					options.Password.RequireUppercase = false;
					options.Password.RequireNonAlphanumeric = false;
					options.SignIn.RequireConfirmedEmail = false;
				})
				.AddEntityFrameworkStores<ApplicationDbContext>()
				.AddDefaultUI()
				.AddDefaultTokenProviders();

			services.AddAuthentication("CookieAuth")
			   .AddCookie("CookieAuth", config =>
			   {
				   config.Cookie.Name = "_AC.Cookie";
				   config.LoginPath = new PathString("./Identity/Account/Login");
				   config.AccessDeniedPath = new PathString("/");

			   });
			services.AddControllersWithViews();
			services.AddRazorPages();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env,
			UserManager<ApplicationUser> userManager,
			RoleManager<ApplicationRole> roleManager)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseDatabaseErrorPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}
			app.UseCookiePolicy(new CookiePolicyOptions
			{
				HttpOnly = HttpOnlyPolicy.Always,
				Secure = CookieSecurePolicy.SameAsRequest,
				MinimumSameSitePolicy = SameSiteMode.None
			});

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();
			// Adding for Different Roles in User

			app.UseAuthentication();
			MyIdentityDataInitializer.SeedData(userManager, roleManager);
			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");
				endpoints.MapRazorPages();
			});
		}
	}
}
