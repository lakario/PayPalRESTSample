using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PayPal.Api.Payments;
using PayPal.Exception;
using PayPal.Manager;
using PayPal.Models;

namespace PayPal.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View(new PayPalViewData());
        }
    }
}
