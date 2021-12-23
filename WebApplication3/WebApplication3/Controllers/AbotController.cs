using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Dataa;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class AbotController : Controller
    {
        private readonly AppDbContext _context;

        public AbotController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Member> members = _context.Members.Include("Positsion").ToList();
            return View(members);
        }
    }
}
