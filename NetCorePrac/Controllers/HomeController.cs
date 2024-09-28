using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCorePrac.Models;
using System.Diagnostics;

namespace NetCorePrac.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BindGridDBContext bindGridDBContext;


        public HomeController(ILogger<HomeController> logger , BindGridDBContext bindGridDBContext)
        {
            _logger = logger;
            this.bindGridDBContext = bindGridDBContext;
        }

        public IActionResult Index()
        {
            var employees= bindGridDBContext.Employees.ToList();
            return View(employees);
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
