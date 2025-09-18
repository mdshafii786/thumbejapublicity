
using thumbejapublicity.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace MyWebAPI.Controllers
{
    public class UsersController : ApiController
    {
        // Temporary in-memory storage
        private static List<User> users = new List<User>();

        // GET api/users
        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            return users;
        }

        // POST api/users
        [HttpPost]
        public IHttpActionResult AddUser(User user)
        {
            if (user == null) return BadRequest("Invalid user data");
            users.Add(user);
            return Ok(user);
        }
    }
}