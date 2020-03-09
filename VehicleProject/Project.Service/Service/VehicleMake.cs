using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Project.Service.Service;

namespace Project.Service.Service
{
    public interface IVehicleMake
    {
        IEnumerable<VehicleMake> GetAll();

        VehicleMake GetMakeByID(int Id);

        void Create(VehicleMake vehiclemake);
        void Read(VehicleMake vehiclemake);
        void Update(VehicleMake vehiclemake);
        void Delete(int Id);
        void Save();
    }
    public abstract class VehicleMake
    {
        private readonly VehicleMake vehiclemake;
        

        public VehicleMake(VehicleMake vehiclemake)
        {
            this.vehiclemake = vehiclemake;
        }

        /*public IEnumerable<VehicleMake> GetAll()
        {
           
        }

        public VehicleMake GetMakeByID(int Id)
        {
           
        }*/

        public void Create(VehicleMake vehiclemake)
        {
            
        }
        public void Read(VehicleMake vehiclemake)
        {

        }
        public void Update(VehicleMake vehiclemake)
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
