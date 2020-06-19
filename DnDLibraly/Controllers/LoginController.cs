using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using DnDLibraly.Data;
using DnDLibraly.Models;
using DnDLibraly.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace DnDLibraly.Controllers
{
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _context;
        UserService userService;
        private readonly IConfiguration config;

        public LoginController(ApplicationDbContext context, IConfiguration config)
        {
            _context = context;
            userService = new UserService(_context);
            this.config = config;
        }

        [HttpPost]
        public IActionResult Login([FromBody] User user)
        {
            User resultUser = AuthenticateUser(user);

            if (resultUser != null)
            {
                var token = GenerateJsonWebToken(resultUser);

                return Ok(token);
            }

            return Unauthorized();
        }

        private string GenerateJsonWebToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(config["Jwt:SecretKey"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]{}),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
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
                    Username = foundUser.Username,
                    Password = foundUser.Password,
                    Email = foundUser.Email, 
                    FName = foundUser.FName,
                    LName = foundUser.LName,
                    Age = foundUser.Age
                };
            }

            return null;
        }
    }
}