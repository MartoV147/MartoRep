using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DnDLibraly.Data;
using DnDLibraly.Models;
using DnDLibraly.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;
using IdentityServer3.Core.Configuration.Hosting;

namespace DnDLibraly.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        UserService userService;
        private readonly IConfiguration config;

        public UsersController(ApplicationDbContext context, IConfiguration config)
        {
            _context = context;
            userService = new UserService(_context);
            this.config = config;
        }


        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers([FromQuery]string username = null, [FromQuery] string password = null)
        {
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                var users = userService.GetAll().Where(u => u.Username == username && u.Password == password).ToList();
                return users;
            }

            var result = userService.GetAll().ToList();
            return result;
        }


        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            var user = userService.GetById(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }


        [HttpPut("{id}")]
        public IActionResult PutUser(int id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            if (userService.Update(user))
            {
                return Content("User Updated Successfully");
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpPost]
        public IActionResult PostUser(User user)
        {
            if (userService.Create(user))
            {
                return Content("User Created Successfully");
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            if (userService.Delete(id))
            {
                return Content("Deleted successfully");
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
