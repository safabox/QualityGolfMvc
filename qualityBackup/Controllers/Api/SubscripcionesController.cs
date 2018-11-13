using AutoMapper;
using qualityBackup.Persistance;
using qualityBackup.Resource;
using qualityBackup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace qualityBackup.Controllers.Api
{
    public class SubscripcionesController : ApiController
    {
        private AppDbContext _context;
        private IMapper mapper;
        public SubscripcionesController() {
            _context = AppDbContext.Create();
            mapper = Mapper.Instance;
        }

        [HttpGet]
        public IEnumerable<SubscripcionResource> GetSubscripcions() {

            return _context.Subscriptions.ToList().Select(Mapper.Map<Subscripcion, SubscripcionResource>);
        }
        [HttpGet]
        [Route("Api/subscripciones/{userId}")]
        public IEnumerable<SubscripcionResource> GetSubscripcions(string userId)
        {

            return _context.Subscriptions.ToList().Select(Mapper.Map<Subscripcion, SubscripcionResource>);
        }

        [HttpGet]
        [Route("Api/subscripciones/{Id:int}")]
        public SubscripcionResource GetSubscripcion(int Id) {

            var subscripcion = _context.Subscriptions.SingleOrDefault(s => s.Id == Id);
            if (subscripcion == null) return null;

            return Mapper.Map<Subscripcion, SubscripcionResource>(subscripcion);
        }

        [HttpPost]
        public IHttpActionResult CreateSubscription(SubscripcionResource subscriptionResource) {
            try
            {
                var subscripcion = Mapper.Map<SubscripcionResource, Subscripcion>(subscriptionResource);
                _context.Subscriptions.Add(subscripcion);
                _context.SaveChanges();
            }
            catch {
                return BadRequest();
            }
            
            return Ok();
        }

        [HttpPost]
        [Route("api/Subscripciones/{userId}/{planId:int}")]
        public IHttpActionResult createSubscription(string userId, int planId)
        {
            try
            {
                var user = _context.Users.SingleOrDefault(s => s.Id == userId);
                if (user == null)
                {
                    throw new HttpResponseException(HttpStatusCode.NotFound);
                }
                var plan = _context.Planes.SingleOrDefault(p => p.Id == planId);
                if (plan == null)
                {
                    throw new HttpResponseException(HttpStatusCode.NotFound);
                }
                var subscripcion = new Subscripcion() {
                    ApplicationUserId=userId,
                    PlanId=plan.Id,
                    AmountOfClasses=plan.AmountOfClasses,
                    AmountClasessPerMonth= plan.AmountofClassesPerMonth,
                    PendingAmountOfClasses= plan.AmountOfClasses,
                    StartDate= DateTime.Now,
                    EndDate = DateTime.Now.AddDays(plan.DurationInDays)

                };

                _context.Subscriptions.Add(subscripcion);
                _context.SaveChanges();

            }
            catch
            {
                return BadRequest();
            }

            return Ok();
        }


        [HttpPut]
        public IHttpActionResult updateSubscription(int id, SubscripcionResource subscriptionResource)
        {
            try
            {
                var subscripcion = _context.Subscriptions.SingleOrDefault(s => s.Id == id);

                if (subscripcion == null) {
                    return NotFound();
                }


                Mapper.Map<SubscripcionResource, Subscripcion>(subscriptionResource,subscripcion);
                subscripcion.Id = id;
                
                _context.SaveChanges();
            }
            catch
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpDelete]
        public void deleteSubcription(int id) {
            var subscripcion = _context.Subscriptions.SingleOrDefault(s => s.Id == id);
            if (subscripcion == null) {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            _context.Subscriptions.Remove(subscripcion);
            _context.SaveChanges();

        }



    }
}
