using Smartkey_Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Smartkey_Calculator.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        // POST: /Calculator/Index
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Calc(KeysModel model)
        {
            int key;
            if (Int32.TryParse(model.Key, out key))
            {
                model.Licence = CalculatorEngine.Calculate(key).ToString();
                return View(model);
            }
            else
                return View("Error");
        }
    }
}