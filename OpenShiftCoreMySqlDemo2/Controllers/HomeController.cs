using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OpenShiftCoreMySqlDemo2.Database;
using OpenShiftCoreMySqlDemo2.Models;

namespace OpenShiftCoreMySqlDemo2.Controllers
{
    public class HomeController : Controller
    {
        private readonly TestDbContext _context;

        public HomeController(TestDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Test.ToList();

            return View(data);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
