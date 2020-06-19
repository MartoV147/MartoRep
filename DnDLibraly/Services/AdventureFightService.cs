using DnDLibraly.Controllers;
using DnDLibraly.Data;
using DnDLibraly.Models.MIdWareTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDLibraly.Services
{
    public class AdventureFightService
    {
        ApplicationDbContext context;

        public AdventureFightService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<AdventurerFight> GetAll()
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(context))
            {
                var adventurersFights = unitOfWork.AdventurerFightRepo.GetAll();

                return adventurersFights.Select(adventurerFight => new AdventurerFight
                {
                    AdventurerId = adventurerFight.AdventurerId,
                    FightId = adventurerFight.FightId
                });
            }
        }


        public AdventurerFight GetById(int adventureId, int fightId)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(context))
            {
                var adventurerFight = unitOfWork.AdventurerFightRepo.GetAFById(adventureId, fightId);

                return adventurerFight == null ? null : new AdventurerFight
                {
                    AdventurerId = adventurerFight.AdventurerId,
                    FightId = adventurerFight.FightId
                };
            }
        }


        public bool Create(AdventurerFight AdventurerFight)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(context))
            {
                var adventurerFight = new AdventurerFight()
                {
                    AdventurerId = AdventurerFight.AdventurerId,
                    FightId = AdventurerFight.FightId
                };

                unitOfWork.AdventurerFightRepo.Create(adventurerFight);
                return unitOfWork.Save();
            }
        }


        public bool Update(AdventurerFight adventurerFight)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(context))
            {
                var result = unitOfWork.AdventurerFightRepo.GetAll().Where(x => x.AdventurerId == adventurerFight.AdventurerId 
                && x.FightId == adventurerFight.FightId).FirstOrDefault();

                if (result == null)
                {
                    return false;
                }

                result.AdventurerId = adventurerFight.AdventurerId;
                result.FightId = adventurerFight.FightId;

                unitOfWork.AdventurerFightRepo.Update(result);
                return unitOfWork.Save();
            }
        }


        public bool Delete(int adventureId, int fightId)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(context))
            {
                AdventurerFight result = unitOfWork.AdventurerFightRepo.GetAFById(adventureId, fightId);

                if (result == null)
                {
                    return false;
                }

                unitOfWork.AdventurerFightRepo.Delete(result);
                return unitOfWork.Save();
            }
        }
    }
}
