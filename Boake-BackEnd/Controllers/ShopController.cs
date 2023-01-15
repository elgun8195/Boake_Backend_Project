using Boake_BackEnd.DAL;
using Boake_BackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Boake_BackEnd.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;
        public ShopController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int sortId, int page = 1)
        {
            ViewBag.CurrentPage = page;
            ViewBag.TotalPage = Math.Ceiling((decimal)_context.Books.Count() / 3);

            List<Book> model = _context.Books.Skip((page - 1) * 3).Take(3).ToList(); 
            
            ViewBag.id = sortId;

            switch (sortId)
            {
                case 1:
                    model = _context.Books.ToList();
                    break;
                case 2:
                    model = _context.Books.OrderByDescending(s => s.Name).ToList();
                    break;
                case 3:
                    model = _context.Books.OrderBy(s => s.Name).ToList();
                    break;
                case 4:
                    model = _context.Books.OrderByDescending(s => s.Price).ToList();
                    break;
                case 5:
                    model = _context.Books.OrderBy(s => s.Price).ToList();
                    break;
                default:

                    break;
            }
            return View(model);
        }
    }
}
