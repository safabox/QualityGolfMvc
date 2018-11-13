using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace qualityBackup.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser User { get; set; }
        public int ClaseId { get; set; }
        public virtual Clase Clase { get; set; }
        public bool Active { get; set; }
        public string Asistencia { get; set; }
    }
}