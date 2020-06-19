using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DnDLibraly.Data;
using DnDLibraly.Models.MIdWareTables;
using DnDLibraly.Services;
using System.Web.Helpers;
using Microsoft.AspNetCore.Authorization;

namespace DnDLibraly.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AdventurerFightsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        AdventureFightService adventureFightService;

        public AdventurerFightsController(ApplicationDbContext context)
        {
            _context = context;
            adventureFightService = new AdventureFightService(_context);
        }


        [HttpGet]
        public ActionResult<IEnumerable<AdventurerFight>> GetAdventurerFights()
        {
            var result = adventureFightService.GetAll().ToList();
            return result;
        }


        [HttpGet("{adventurerId}/{fightId}")]
        public ActionResult<AdventurerFight> GetAdventurerFight(int adventurerId, int fightId)
        {
            var adventurerFight = adventureFightService.GetById(adventurerId, fightId);

            if (adventurerFight == null)
            {
                return NotFound();
            }

            return adventurerFight;
        }


        [HttpPut("{adventurerId}/{fightId}")]
        public IActionResult PutAdventurerFight(int adventurerId, int fightId, AdventurerFight adventurerFight)
        {
            if (adventurerId != adventurerFight.AdventurerId && fightId != adventurerFight.FightId)
            {
                return Content("No Such Adventurer and Fight Found");
            }

            DeleteAdventurerFight(adventurerId, fightId);
            return PostAdventurerFight(adventurerFight);

        }


        [HttpPost]
        public IActionResult PostAdventurerFight(AdventurerFight adventurerFight)
        {
            if (adventureFightService.Create(adventurerFight))
            {
                return Content("Adrventurer Successfully Sent to Battle");
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpDelete("{adventurerId}/{fightId}")]
        public IActionResult DeleteAdventurerFight(int adventurerId, int fightId)
        {
            if (adventureFightService.Delete(adventurerId, fightId))
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
