using AutoMapper;
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
    public class EnrollmentsController : ApiController
    {
        private AppDbContext _context;
        private IMapper mapper;
        public EnrollmentsController() {
            _context = AppDbContext.Create();
            mapper = Mapper.Instance;
        }

        [HttpGet]
        public IEnumerable<Enrollment> GetEnrollments() {

            return _context.Enrollments.ToList();
        }

        [HttpGet]
        [Route("api/enrollments/{userId}")]
        public IEnumerable<Enrollment> GetEnrollments(string userId)
        {
            return _context.Enrollments.Where(e => e.ApplicationUserId == userId).ToList();
        }


        [HttpGet]
        [Route("api/enrollments/{Id:int}")]
        public Enrollment GetEnrollments(int Id)
        {
            return _context.Enrollments.SingleOrDefault(e => e.Id == Id);
        }

        [HttpDelete]
        public void DeleteEnrollment(int Id)
        {

            var enrollment = _context.Enrollments.SingleOrDefault(e => e.Id == Id);
            if (enrollment != null) {
                _context.Enrollments.Remove(enrollment);
                _context.SaveChanges();
            }
        }

        [HttpPost]
        [Route("api/enrollments/{userId}/{ClaseId:int}")]
        public IHttpActionResult CreateEnrollment(string userId, int ClaseId) {
            var user = _context.Users.SingleOrDefault(u => u.Id == userId);
            if (user == null) return NotFound();

            var clase = _context.Clases.SingleOrDefault(c => c.Id == ClaseId);
            if (clase == null) return NotFound();

            var enrollment = new Enrollment() {
                ApplicationUserId = user.Id,
                ClaseId = clase.Id,
                Active = true
            };
            int enrollments = _context.Enrollments.Where(e => e.ClaseId == clase.Id).Where(e => e.Active == true).Count();
            if (enrollments > 0) {
                enrollment.Active = false;
            }
            _context.Enrollments.Add(enrollment);
            _context.SaveChanges();

            return Ok();

        }

    }
}
