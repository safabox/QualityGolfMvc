using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace qualityBackup.Resource
{
    public class ClaseResource
    {


        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }
        //profesor assigned
        public string ApplicationUserId { get; set; }


    }
}