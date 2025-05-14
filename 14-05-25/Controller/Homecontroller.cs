using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public string index ()
        {
            return "This is index action";
        }
        public string method1()
        {
            return "This is method1";
        }
        public string method2()
        {
            return "This is method2";
        }
    }
}
