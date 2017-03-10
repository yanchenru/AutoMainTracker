using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMainTracker.Models;

namespace AutoMainTracker.Controllers
{
    public class VehicleController : Controller
    {
        // GET: Vehicle
        public ActionResult Index()
        {
            var vehicle = new Vehicle() { Make = "Honda", Model = "Accord", Year = 1999, Odometer = 171000 };

            return View(vehicle);
        }

        // GET: Gas
        public ActionResult GetGas(int id)
        {
            //var gas = new Gas() {Make="Honda", Model="Accord", Year=1999, Odometer=171000 };
            //return View(gas);
            return Content("id=" + id);
        }

        // GET: Electric
        public ActionResult GetElectric()
        {
            var electric = new Electric() { };
            return View();
        }

        // GET: Diesel
        public ActionResult GetDiesel()
        {
            var diesel = new Diesel() { };
            return View();
        }
    }
}