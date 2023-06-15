using CollegeProject.Data;
using CollegeProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;
using System.Net.WebSockets;
using System.Security.Claims;

namespace CollegeProject.Controllers
{
    [Authorize]
    public class DataController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
		private readonly IWebHostEnvironment _hostingEnvironment;

		public DataController(ApplicationDbContext context, UserManager<ApplicationUser> userManager,
			IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _userManager = userManager;
			_hostingEnvironment = hostingEnvironment;
		}
		public IActionResult Index()
        {
			var currentLoginInuserId = new Guid(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
			var fileList = _context.Data.Where(a => a.CreatedBy == currentLoginInuserId).ToList();
            return View(fileList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(DataModel data, IFormFile ImagePath)
        {
			string fileName = string.Empty;
			if (ImagePath != null && ImagePath.Length > 0)
			{
				var uploadPath = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");
				if (!Directory.Exists(uploadPath))
				{
					Directory.CreateDirectory(uploadPath);
				}
				fileName = $"{Guid.NewGuid().ToString().Substring(0, 5)}_{ImagePath.FileName}";
				string filePath = Path.Combine(uploadPath, fileName);
				ImagePath.CopyTo(new FileStream(filePath, FileMode.Create));

			}
			DataModel dt = new DataModel
            {
                Title = data.Title,
                FileName = fileName,
                CreatedBy = new Guid(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value),
                CreationDate = DateTime.Now
		    };
			_context.Data.Add(dt);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var dataVM = _context.Data.Where(a=>a.Id == id).FirstOrDefault(); 
            return View(dataVM);
        }
        [HttpPost]
        public IActionResult Edit(DataModel datavm)
        {
			var dvm = _context.Data.Where(a => a.Id == datavm.Id).FirstOrDefault();
            dvm.Title = datavm.Title;
			_context.Data.Update(dvm);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
        public IActionResult Delete(int id)
        {
			var dataVM = _context.Data.Where(a => a.Id == id).FirstOrDefault();
            _context.Data.Remove(dataVM);
            _context.SaveChanges();
            return RedirectToAction("Index");
		}

        // SHare a file to another user
        public IActionResult Share(int id)
        {
			var currentLoginInuserId = new Guid(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
			ViewBag.FileId = id;
            ViewBag.AllUser = _userManager.Users.Where(a => !a.Id.Equals(currentLoginInuserId)).ToList();
            return View();
        }

        public IActionResult Send(Guid id,int fileId)
        {
            var reciver = _userManager.Users.Where(a=>a.Id == id).First();
            var sender = new Guid(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
			var fileInfo = _context.Data.Where(a=>a.Id==fileId).FirstOrDefault();

            if (fileInfo != null && reciver != null)
            {
                ShareModel share = new ShareModel
                {
                    Fileid = fileId,
                    IsCompleted = false,
                    ReciverId = id,
                    CreatedBy = sender,
					CreationDate = DateTime.Now,
				};
                _context.Share.Add(share);
                _context.SaveChanges();
            }
			TempData["SuccessMessage"] = "File Sent. Wait for admin approval";
			return RedirectToAction("Share", new { id = fileId,});
        }

        public IActionResult ShareInfo()
        {
			var currentLoginInuserId = new Guid(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
			var shareData = _context.Share.Include(a=>a.Data).Include(a => a.Reciever).Where(a => a.CreatedBy == currentLoginInuserId).ToList();
            return View(shareData);
        }

		[Authorize(Roles = RoleTypes.Administrator)]
		public IActionResult ShareApproval()
        {
			var shareData = _context.Share.Include(a => a.Data).Include(a => a.Reciever).Where(a=>a.IsCompleted == false).ToList();
			return View(shareData);
		}


        [Authorize(Roles = RoleTypes.Administrator)]
        public IActionResult Approved(int id)
        {
            var share = _context.Share.Where(a => a.Id == id).SingleOrDefault();
            if (share != null)
            {
                share.IsCompleted = true;
                _context.Share.Update(share);
                _context.SaveChanges();
            }
			TempData["SuccessMessage"] = "File Approved";
			return RedirectToAction("ShareApproval");
        }

        public IActionResult Inbox()
        {
            var currentLoginInuserId = new Guid(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var inboxList = _context.Share.Include(a => a.Data).Include(a => a.CreatedUser).Where(a => a.ReciverId == currentLoginInuserId && a.IsCompleted).ToList();
            return View(inboxList);
        }
    }
}
