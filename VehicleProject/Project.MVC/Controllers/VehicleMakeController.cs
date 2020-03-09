using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.Service;
using Project.Service.Model;

namespace Project.MVC.Controllers
{
    public abstract class VehicleMakeController : Controller
    {
        private IVehicleMake _vehiclemake;

        public VehicleMakeController(IVehicleMake vehiclemake)
        {
            _vehiclemake = vehiclemake;
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
        public ActionResult Create(IVehicleMake model)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Update(int Id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Update(IVehicleMake model)
        {
                return View();
        }

        [HttpGet]
        public ActionResult Delete(int Id)
        {
            return View();
        }
       /* [HttpPost]
        public ActionResult Delete(int Id)
        {
            return View();
        }*/
    }
}