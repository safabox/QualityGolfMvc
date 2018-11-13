using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace qualityBackup.Models
{
    public class Subscripcion
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string ApplicationUserId { get; set; }
        [Required]
        public int PlanId { get; set; }
        public virtual Planes Plan { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public int AmountOfClasses { get; set; }
        [Required]
        public int AmountClasessPerMonth { get; set; }
        [Required]
        public int PendingAmountOfClasses { get; set; }
    }
}