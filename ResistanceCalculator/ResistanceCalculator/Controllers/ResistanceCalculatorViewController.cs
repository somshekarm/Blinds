using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResistanceCalculator.Controllers
{
    public class ResistanceCalculatorViewController : Controller
    {
        // GET: ResistanceCalculator
        public ActionResult Calculate()
        {
            return View();
        }


        // GET: ResistanceCalculator
        public ActionResult Home()
        {
            return View();
        }
    }
}