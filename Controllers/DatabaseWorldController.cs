using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCDatabase.Controllers
{
    public class DatabaseWorldController : Controller
    {
        // 
        // GET: /DatabaseWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /DatabaseWorld/Welcome/ 

        public IActionResult Welcome()
        {
            return View();
        }
    }
}
