using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Areas.adminn.Controllers
{
    public class HomeController : Controller
    {
        [Area("adminn")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
