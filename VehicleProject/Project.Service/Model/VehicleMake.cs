using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Project.Service.Model
{
    public interface IVehicleMake
    {
        int Id { get; set; }

        string Name { get; set; }

        string Abrv { get; set; }
    }

    public abstract class VehicleMake:IVehicleMake
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter Abrv")]
        [Display(Name = "Abrv")]
        public string Abrv { get; set; }
    }
}
