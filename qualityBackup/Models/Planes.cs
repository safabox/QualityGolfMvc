using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace qualityBackup.Models
{
    public class Planes
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int PlanTypeId { get; set; }
        public virtual PlanType PlanType { get; set; }
        [Required]
        public int AmountOfClasses { get; set; }
        [Required]
        public int AmountofClassesPerMonth { get; set; }
        [Required]
        public bool Active { get; set; }
        [Required]
        public int DurationInDays { get; set; }
        [Required]
        public double Price { get; set; }
    }
}