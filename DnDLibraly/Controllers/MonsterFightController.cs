using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DnDLibraly.Data;
using DnDLibraly.Models.MIdWareTables;
using DnDLibraly.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DnDLibraly.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MonsterFightController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        MonsterFightService monsterFightService;

        public MonsterFightController(ApplicationDbContext context)
        {
            _context = context;
            monsterFightService = new MonsterFightService(_context);
        }


        [HttpGet]
        public ActionResult<IEnumerable<MonsterFight>> GetMonsterFights()
        {
            var result = monsterFightService.GetAll().ToList();
            return result;
        }


        [HttpGet("{monsterId}/{fightId}")]
        public ActionResult<MonsterFight> GetMonsterFight(int monsterId, int fightId)
        {
            var monsterFight = monsterFightService.GetById(monsterId, fightId);

            if (monsterFight == null)
            {
                return NotFound();
            }

            return monsterFight;
        }


        [HttpPut("{monsterId}/{fightId}")]
        public IActionResult PutMonsterFight(int monsterId, int fightId, MonsterFight monsterFight)
        {
            if (monsterId != monsterFight.MonsterId && fightId != monsterFight.FightId)
            {
                return Content("No Such Monster and Fight Found");
            }

            DeleteMonsterFight(monsterId, fightId);
            return PostMonsterFight(monsterFight);

        }


        [HttpPost]
        public IActionResult PostMonsterFight(MonsterFight monsterFight)
        {
            if (monsterFightService.Create(monsterFight))
            {
                return Content("Monster Successfully Sent to Battle");
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpDelete("{monsterId}/{fightId}")]
        public IActionResult DeleteMonsterFight(int monsterId, int fightId)
        {
            if (monsterFightService.Delete(monsterId, fightId))
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
