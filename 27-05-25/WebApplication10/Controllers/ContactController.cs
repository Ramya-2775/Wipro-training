using Microsoft.AspNetCore.Mvc;

namespace WebApplication10.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
