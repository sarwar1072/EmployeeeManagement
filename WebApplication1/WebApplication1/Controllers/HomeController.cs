using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
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
            ViewBag.firstName = "sarwar";
            ViewBag.lastname = "milon";
            ViewBag.address = "solarchar munshigonj";

               
            return View();
        }
        public IActionResult EmployeeView()
        {
            var employee = new List<Employee>()
            {
                new Employee{Id=1,name="sarwar",address="m",datetime=DateTime.Today,maritialStatus=false,salary=2000000},
                  new Employee{Id=2,name="jamal",address="s",datetime=DateTime.Today,maritialStatus=false,salary=10000},
                 new Employee{Id=3,name="masud",address="l",datetime=DateTime.Today,maritialStatus=true,salary=300000},
                   new Employee{Id=4,name="aslam",address="a",datetime=DateTime.Today,maritialStatus=true,salary=400000},
                new Employee{Id=1,name="tanvir",address="t",datetime=DateTime.Today,maritialStatus=true,salary=2500000},


            };
            ViewBag.Employee = employee;
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
