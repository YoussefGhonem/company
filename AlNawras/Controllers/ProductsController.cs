using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlNawras.Controllers
{
    public class ProductsController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult FireAlarm()
        {
            return View();
        } 

        public IActionResult PUBLICADDRESS()
        {
            return View();
        } 
        public IActionResult BUILDINGMANAGMENT ()
        {
            return View();
        }   
        public IActionResult FirePumb()
        {
            return View();
        }      
        public IActionResult EmergencyLight ()
        {
            return View();
        } 


    
    }
}
