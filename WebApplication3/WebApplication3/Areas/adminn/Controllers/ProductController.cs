using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Dataa;
using WebApplication2.Models;

namespace WebApplication3.Areas.adminn.Controllers
{
    [Area("adminn")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;


        public ProductController(AppDbContext context,IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Products.Include(v=>v.Valuation).Include(c=>c.Category).ToList());
        }

        public IActionResult create()
        {
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Valuations = _context.Valuations.ToList();
            return View( );
        }


        [HttpPost]
        public IActionResult create(Product model)
        {
            if (ModelState.IsValid)
            {
                //if (model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/png")
                //{
                //    if (model.ImageFile.Length<=3145728)
                //    {
                string fileName = Guid.NewGuid() + "-" + model.ImageFile.FileName;
                string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                        using (var stream=new FileStream(filePath, FileMode.Create))
                        {
                            model.ImageFile.CopyTo(stream);
                        }

                model.Image = fileName;
                _context.Products.Add(model);
                        _context.SaveChanges();
                        return RedirectToAction("index");
            //        }
            //        else
            //        {
            //            ModelState.AddModelError("", "You can upload max 3 mb file!");
            //            return View(model);
            //        }
            //    }
            //    else
            //    {
            //        ModelState.AddModelError("", "You can upload image file!");
            //        return View(model);
            //    }
            }
            else
            {
                return View(model);

            }

        }
    }
}
