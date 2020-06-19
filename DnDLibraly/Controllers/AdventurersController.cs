using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DnDLibraly.Data;
using DnDLibraly.Models;
using DnDLibraly.Services;
using System.Reflection.Metadata.Ecma335;
using Microsoft.SqlServer.Dac.Model;
using Microsoft.AspNetCore.Authorization;

namespace DnDLibraly.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AdventurersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        AdventurerService adventurerService;


        public AdventurersController(ApplicationDbContext context)
        {
            _context = context;
            adventurerService = new AdventurerService(_context);
        }
        

        [HttpGet]
        public ActionResult<IEnumerable<Adventurer>> GetAdventurers([FromQuery]string name = null)
        {
            if (!string.IsNullOrEmpty(name))
            {
                return new List<Adventurer> {
                    adventurerService.GetByName(name),
                };
            }
            var result = adventurerService.GetAll().ToList();
            return result;
        }


        [HttpGet("{id}")]
        public ActionResult<Adventurer> GetAdventurer(int id)
        {
            var adventurer = adventurerService.GetById(id);
            //var adventurer = _context.Adventurers.Find(id);

            if (adventurer == null)
            {
                return NotFound();
            }
            return adventurer;
        }

        [HttpPut("{id}")]
        public IActionResult PutAdventurer(int id, Adventurer adventurer)
        {
            if (id != adventurer.AdventurerId)
            {
                return BadRequest();
            }

            if (adventurerService.Update(adventurer))
            {
                return Content("Adventurer Updated Successfully");
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpPost]
        public IActionResult PostAdventurer(Adventurer adventurer)
        {
            if (adventurerService.Create(adventurer) && adventurer.Name.Length < 200)
            {
                return Content("Adrventurer Created Successfully");
            }
            else
            {
                return BadRequest(); 
            }
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteAdventurer(int id)
        {
            if (adventurerService.Delete(id))
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
