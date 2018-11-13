using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace qualityBackup.Resource
{
    public class SubscripcionResource
    {

        public int Id { get; set; }
        public string ApplicationUserId { get; set; }
        public int PlanId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int AmountOfClasses { get; set; }

        public int AmountClasessPerMonth { get; set; }

        public int PendingAmountOfClasses { get; set; }
    }
}