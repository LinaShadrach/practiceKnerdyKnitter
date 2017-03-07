using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KnerdyKnitter.Models;
using System.Diagnostics;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace KnerdyKnitter.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            Rules.MakeRules();
            ViewBag.AllRules = Rules.AllRules;
            Garment newGarment = new Garment(Rules.AllRules[30], 100);
            string[] currentRow = new string[] {"0", "0", "0", "1", "1", "1", "0", "0", "0", "0", "0", "0"};
            newGarment.MakeGarment(currentRow, 100);
            ViewBag.AllRows = newGarment.AllRows;
            return View();
        }
    }
}
