using Boake_BackEnd.DAL;
using Boake_BackEnd.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Boake_BackEnd.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private UserManager<AppUser> _userManager;
        public BlogController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Blog> blogs =await _context.Blog.Where(b=>!b.IsDeleted).ToListAsync();
            return View(blogs);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            Blog blog =await _context.Blog.FirstOrDefaultAsync(b => !b.IsDeleted &&b.Id==id);
            return View(blog);
        }

        [AutoValidateAntiforgeryToken]
        [HttpPost]
        public async Task<IActionResult> AddComment(Comment comment)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (!ModelState.IsValid) return RedirectToAction("Detail", "Blog", new { id = comment.BlogId });
            if (!_context.Blog.Any(f => f.Id == comment.BlogId)) return NotFound();
            Comment cmnt = new Comment
            {
                Message = comment.Message,
                BlogId = comment.BlogId,
                Date = DateTime.Now,
                AppUserId = user.Id,
                IsAccess = true,
            };
            _context.Comments.Add(cmnt);
            _context.SaveChanges();
            return RedirectToAction("Detail", "Blog", new { id = comment.BlogId });
        }

        public async Task<IActionResult> DeleteComment(int id)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (!ModelState.IsValid) return RedirectToAction("Index", "Blog");
            if (!_context.Comments.Any(c => c.Id == id && c.IsAccess == true && c.AppUserId == user.Id)) return NotFound();
            Comment comment = _context.Comments.FirstOrDefault(c => c.Id == id && c.AppUserId == user.Id);
            _context.Comments.Remove(comment);
            _context.SaveChanges();
            return RedirectToAction("Detail", "Blog", new { id = comment.BlogId });
        }
    }
}
