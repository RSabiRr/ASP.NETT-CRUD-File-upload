using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Dataa;
using WebApplication2.Models;

namespace WebApplication3.Areas.adminn.Controllers
{
    [Area("adminn")]

     
    public class blogCategoryController : Controller
    {
        private readonly AppDbContext _context;

        public blogCategoryController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Categories.ToList());
        }
        public IActionResult create()
        {
            return View( );
        }
        [HttpPost]
        public IActionResult create(Category model)
        {
            _context.Categories.Add(model);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult create(Category model)
        {
            _context.Categories.Add(model);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
