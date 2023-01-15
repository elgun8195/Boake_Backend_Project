using Boake_BackEnd.DAL;
using Boake_BackEnd.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Boake_BackEnd.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.Books = _context.Books.Where(s => !s.IsDeleted).ToList();

            homeVM.Blogs = _context.Blog.Include(s=>s.Comments).Where(s => !s.IsDeleted).ToList();
            homeVM.Sliders = _context.Sliders.Where(s=>!s.IsDeleted).ToList(); 
            return View(homeVM);
        }
    }
}
