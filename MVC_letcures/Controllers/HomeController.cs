using Microsoft.AspNetCore.Mvc;
using MVC_letcures.Models;
using System.Diagnostics;

namespace MVC_letcures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //public string Index() { 

        //    return "AOA Pakistan";
        //}

        //public string Index1()
        //{

        //    return "AOA Pakistan Index!";
        //}

    }
}
