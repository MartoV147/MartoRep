using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DnDLibraly.Data;
using DnDLibraly.Models;
using DnDLibraly.Services;

namespace DnDLibraly.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonstersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        MonsterService monsterService;


        public MonstersController(ApplicationDbContext context)
        {
            _context = context;
            monsterService = new MonsterService(_context);
        }


        [HttpGet]
        public ActionResult<IEnumerable<Monster>> GetMonsters([FromQuery]string name = null)
        {
            if (!string.IsNullOrEmpty(name))
            {
                return new List<Monster> {
                            monsterService.GetByName(name),
                        };
            }
            var result = monsterService.GetAll().ToList();
            return result;     
        }


        
        //    if (!string.IsNullOrEmpty(name))
        //    {
        //        return new List<Adventurer> {
        //            adventurerService.GetByName(name),
        //        };

        //    }




        [HttpGet("{id}")]
        public ActionResult<Monster> GetMonster(int id)
        {
            //var monster = _context.Monsters.Find(id);
            var monster = monsterService.GetById(id);
            if (monster == null)
            {
                return NotFound();
            }
            return monster;
        }

        [HttpGet("{name}")]
        public ActionResult<Monster> GetMonsterByName(string name)
        {
            
            var monster = monsterService.GetByName(name);
            if (monster == null)
            {
                return NotFound();
            }
            return monster;
        }

        [HttpPut("{id}")]
        public IActionResult PutMonster(int id, Monster monster)
        {
            if (id != monster.MonsterId)
            {
                return BadRequest();
            }

            if (monsterService.Update(monster))
            {
                return Content("Monster Updated Successfully");
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpPost]
        public IActionResult PostMonster(Monster monster)
        {
            if (monsterService.Create(monster))
            {
                return Content("Monster Created Successfully");
            }
            else
            {
                return BadRequest();
            }
        }
        

        [HttpDelete("{id}")]
        public IActionResult DeleteMonster(int id)
        {
            if (monsterService.Delete(id))
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
