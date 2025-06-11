using CustomerFeedbackPortal.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using System;
using CustomerFeedbackPortal.Models;


namespace CustomerFeedbackPortal.Controllers
{
    public class AdminController : Controller
    {
        // Hardcoded admin credentials
        private readonly string adminUsername = "Ramya";
        private readonly string adminPassword = "Ramya123";

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Admin admin)
        {
            if (admin.Username == adminUsername && admin.Password == adminPassword)
            {
                HttpContext.Session.SetString("Admin", "true");
                return RedirectToAction("Dashboard", "Admin");
            }

            ViewBag.Message = "Invalid credentials";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("Admin");
            return RedirectToAction("Login");
        }
        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetString("Admin") != "true")
                return RedirectToAction("Login");

            return View();
        }
    }
}