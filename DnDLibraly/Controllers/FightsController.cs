using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DnDLibraly.Data;
using DnDLibraly.Models;
using DnDLibraly.Services;
using Microsoft.AspNetCore.Authorization;

namespace DnDLibraly.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class FightsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        FightService fightService;


        public FightsController(ApplicationDbContext context)
        {
            _context = context;
            fightService = new FightService(_context);
        }


        [HttpGet]
        public ActionResult<IEnumerable<Fight>> GetFights()
        {
            var result = fightService.GetAll().ToList();
            return result;
        }


        [HttpGet("{id}")]
        public ActionResult<Fight> GetFight(int id)
        {
            //var fight = await _context.Fights.FindAsync(id);
            var fight = fightService.GetById(id);

            if (fight == null)
            {
                return NotFound();
            }
            return fight;
        }

        
        [HttpPut("{id}")]
        public IActionResult PutFight(int id, Fight fight)
        {
            if (id != fight.FightId)
            {
                return BadRequest();
            }

            if (fightService.Update(fight))
            {
                return Content("Fught Updated Successfully");
            }
            else
            {
                return BadRequest();
            }
        }

        
        [HttpPost]
        public ActionResult PostFight(Fight fight)
        {
            if (fightService.Create(fight) && fight.Terrain.Length < 200)
            {
                return Content("Fight Created Successfully");
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteFight(int id)
        {
            if (fightService.Delete(id))
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
