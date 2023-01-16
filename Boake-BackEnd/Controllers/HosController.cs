using Boake_BackEnd.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Linq;

namespace Boake_BackEnd.Controllers
{
    
    public class HosController : Controller
    {
        private readonly AppDbContext _context;

        public HosController(AppDbContext context)
        {
            _context = context;
        }
       
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public JsonResult GetProducts([FromBody] SliderValue value)
        //{

        //    var products = _context.Products.Where(p => p.UnitPrice >= value.Start && p.UnitPrice <= value.End).ToList();
        //    return Json(products);
        //}

        public class SliderValue
        {
            public int Start { get; set; }
            public int End { get; set; }
        }
    }
}
