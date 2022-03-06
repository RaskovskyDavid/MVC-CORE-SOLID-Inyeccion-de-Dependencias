using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCCOREInyeccionDeDependencia.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCOREInyeccionDeDependencia.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private Models.DB.MVCCoreContext _db;
        public HomeController(ILogger<HomeController> logger, Models.DB.MVCCoreContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            var lst = _db.Users.ToList();
            return View(lst);
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
