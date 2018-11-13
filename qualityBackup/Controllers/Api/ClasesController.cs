using AutoMapper;
using qualityBackup.Persistance;
using qualityBackup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using qualityBackup.Resource;

namespace qualityBackup.Controllers.Api
{
    public class ClasesController : ApiController
    {
        private AppDbContext _context;
        private IMapper mapper;
        public ClasesController() {
            _context = AppDbContext.Create();
            mapper = Mapper.Instance;
        }

        [HttpGet]
        public IEnumerable<Clase> GetClases() {

            return _context.Clases.ToList();
        }
        [HttpGet]
        public Clase GetClases(int Id)
        {

            return _context.Clases.SingleOrDefault(c=>c.Id==Id);
        }

        [HttpPost]
        public IHttpActionResult CreateClase (ClaseResource claseResource)
        {
            var clase = Mapper.Map<ClaseResource, Clase>(claseResource);
            _context.Clases.Add(clase);
            _context.SaveChanges();
            return Ok();
        }



    }
}
