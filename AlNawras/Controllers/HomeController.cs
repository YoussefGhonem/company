using AlNawras.Data;
using AlNawras.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AlNawras.Controllers
{
    public class HomeController : Controller
    {


        private readonly DataContext _context;
        private readonly IWebHostEnvironment _env;

        public HomeController(DataContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult InstallationTeam()
        {
            return View();
        }
        public IActionResult Events()
        {
            return View();
        }
        public IActionResult Markets()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Solutions()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Products()
        {
            return View();
        }


        public IActionResult licenses()
        {
            return View();
        }
        public IActionResult MyProfile()
        {
            return View();
        }
    }
}
