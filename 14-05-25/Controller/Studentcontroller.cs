using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        public string Index()
        {
            return "This is student index";
        }
        public string Getstudentname()
        {
            return "Ramya Ane";
        }
        public string Getstudentphone()
        {
            return "9381222025";
        }
    }
}
