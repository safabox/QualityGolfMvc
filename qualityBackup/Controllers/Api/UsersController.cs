using qualityBackup.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using qualityBackup.Models;
namespace qualityBackup.Controllers.Api
{
    public class UsersController : ApiController
    {
        private AppDbContext _context;
        public UsersController() {
            _context = AppDbContext.Create();
        }
        [HttpGet]
        public IEnumerable<ApplicationUser> getUsers() {

            return _context.Users.ToList();
        }

    }
}
