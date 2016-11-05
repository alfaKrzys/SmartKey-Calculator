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
        KeysDbContext db = new KeysDbContext();

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
        public ActionResult Index(KeysModel model)
        {
            if (ModelState.IsValid)
            {
                int key = Int32.Parse(model.Key);
                model.Licence = CalculatorEngine.Calculate(key).ToString();
                model.CalcDate = DateTime.Now;
                db.keyModels.Add(model);
                db.SaveChanges();
                return View("Calc", model);
            }
            else return View();
        }

        [Authorize]
        public ActionResult History()
        {
            return View(db.keyModels.ToList());
        }
    }
}