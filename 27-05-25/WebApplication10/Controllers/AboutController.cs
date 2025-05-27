using Microsoft.AspNetCore.Mvc;

namespace WebApplication10.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
