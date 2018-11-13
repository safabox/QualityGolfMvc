using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace qualityBackup.Models
{
    public class Clase
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser User { get; set; }


    }
}