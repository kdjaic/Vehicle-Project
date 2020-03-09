using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.Service;
using Project.Service.Service;

namespace Project.MVC.Controllers
{
    public abstract class VehicleModelController : Controller
    {
        private IVehicleModel _vehiclemodel;

        public VehicleModelController(IVehicleModel vehiclemodel)
        {
            _vehiclemodel = vehiclemodel;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(IVehicleModel model)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Update(int Id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Update(IVehicleModel model)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Delete(int Id)
        {
            return View();
        }
        /*[HttpPost]
        public ActionResult Delete(int Id)
        {
            return View();
        }*/
    }
}