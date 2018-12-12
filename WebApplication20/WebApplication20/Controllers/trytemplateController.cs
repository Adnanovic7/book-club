using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication20.Controllers
{
    public class trytemplateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}