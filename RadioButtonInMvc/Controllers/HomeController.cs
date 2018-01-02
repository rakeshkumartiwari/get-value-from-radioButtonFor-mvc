using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RadioButtonInMvc.Models;

namespace RadioButtonInMvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            TestRadiobutton obj=null;
            if (TempData["MyObj"] != null)
            {
                obj = (TestRadiobutton)TempData["MyObj"];
                
            }

            return View(obj);
        }
        [HttpPost]
        public ActionResult Change(TestRadiobutton obj)
        {
            TempData["MyObj"] = obj;
            return RedirectToAction("Index");
        }
    }
}