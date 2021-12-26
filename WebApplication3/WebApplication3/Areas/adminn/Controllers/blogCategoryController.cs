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
            if (ModelState.IsValid)
            {
                _context.Categories.Add(model);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            else
            {
                ModelState.AddModelError("", "bos saxlamaq olmaz!");
                return View(model);
            }
            
        }

        public IActionResult update(int id)
        {
            return View(_context.Categories.Find(id));
        }
        [HttpPost]
        public IActionResult update(Category model)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Update(model);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            else
            {
                ModelState.AddModelError("", "bos saxlamaq olmaz!");
                return View(model);
            }
        }
        
        public IActionResult delete(int? id)
        {

            if (id==null)
            {
                return NotFound();
            }
            Category category = _context.Categories.Find(id);

            if (category==null)
            {
                return NotFound();
            }

            _context.Categories.Remove(category);
            _context.SaveChanges();

            return RedirectToAction("index");
        }


    }
}
