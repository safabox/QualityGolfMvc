using qualityBackup.Models;
using qualityBackup.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace qualityBackup.Controllers.Api
{
    public class PlanesController : ApiController
    {
        private AppDbContext _contex;
        public PlanesController() {
            _contex = AppDbContext.Create();
        }

        [HttpGet]

        public IEnumerable<Planes> GetPlans() {

            return _contex.Planes.ToList();
        }
    }
}
