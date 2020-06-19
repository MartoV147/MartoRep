using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DnDLibraly.Data;
using DnDLibraly.Models;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using DnDLibraly.Services;
using Microsoft.Extensions.Configuration;

namespace DnDLibraly.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        UserService userService;
        private readonly IConfiguration config;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
            userService = new UserService(_context);
        }


        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
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

        private object GenerateJsonWebToken(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Jwt:SecretKey"]));

            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new Claim[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Username),
                new Claim(JwtRegisteredClaimNames.NameId, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(
                issuer: config["Jwt:Issuer"],
                audience: config["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(60),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private User AuthenticateUser(User user)
        {
            var users = userService.GetAll();

            var foundUser = users.FirstOrDefault(u => u.Username == user.Username && u.Password == user.Password);

            if (foundUser != null)
            {
                return new User
                {
                    Id = foundUser.Id,
                    FName = foundUser.FName,
                    LName = foundUser.LName,
                    Age = foundUser.Age,
                    Email = foundUser.Email,
                    Username = foundUser.Username,
                    Password = foundUser.Password
                };
            }
            return null;
        }
    }
}
