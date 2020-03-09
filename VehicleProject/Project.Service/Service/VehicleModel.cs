using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlTypes;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Project.Service.Service
{
    public interface IVehicleModel
    {
        IEnumerable<VehicleModel> GetAll();

        VehicleModel GetModelByID(int Id);

        void Create(VehicleModel vehiclemodel);
        void Read(VehicleModel vehiclemodel);
        void Update(VehicleModel vehiclemodel);
        void Delete(int Id);
        void Save();
    }
    public abstract class VehicleModel
    {
        private readonly VehicleModel vehiclemodel;

        public VehicleModel(VehicleModel vehiclemodel)
        {
            this.vehiclemodel = vehiclemodel;
        }

        /*public IEnumerable<VehicleModel> GetAll()
        {
            
        }

        public VehicleModel GetModelByID(int Id)
        {
            
        }*/

        public void Create(VehicleModel vehiclemodel)
        {
            
        }
        public void Read(VehicleModel vehiclemodel)
        {

        }
        public void Update(VehicleModel vehiclemodel)
        {
            
        }
        public void Delete(int Id)
        {
            
        }
        public void Save()
        {
            
        }
    }
}
