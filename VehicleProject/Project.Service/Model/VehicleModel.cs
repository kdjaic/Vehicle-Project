using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Service.Model
{
    public interface IVehicleModel
    {
        int Id { get; set; }

        int MakeId { get; set; }

        string Name { get; set; }

        string Abrv { get; set; }
    }

    public abstract class VehicleModel:IVehicleModel
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("MakeId")]
        public int MakeId { get; set; }

        [Required(ErrorMessage = "Enter Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter Abrv")]
        [Display(Name = "Abrv")]
        public string Abrv { get; set; }
    }
}
