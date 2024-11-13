using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TagHelpersDemo.Models;

namespace TagHelpersDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Employee emp)
        {
            if (ModelState.IsValid) {
                //return "Name : "+emp.Name+" Gender : "+emp.Gender+" Age : "+emp.Age+" Designation : "+emp.Designation+" Salary : "+emp.Salary+" Maaried : "+emp.Married+" Description"+emp.Description;
                ModelState.Clear();
                return View();
            }
            else
            {
                return View(emp);
            }
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact(int id)
        {
            return View();
        }
        public String Details(int id,string name)
        {
            return "Id : "+id+" Name : "+name;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
