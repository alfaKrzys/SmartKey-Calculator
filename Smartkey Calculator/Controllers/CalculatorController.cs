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
    }
}