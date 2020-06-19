using DnDLibraly.Data;
using DnDLibraly.Models.MIdWareTables;
using System.Collections.Generic;
using System.Linq;

namespace DnDLibraly.Services
{
    public class MonsterFightService
    {
        ApplicationDbContext context;

        public MonsterFightService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<MonsterFight> GetAll()
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(context))
            {
                var monsterFights = unitOfWork.MonsterFightRepo.GetAll();

                return monsterFights.Select(monsterFight => new MonsterFight
                {
                    MonsterId = monsterFight.MonsterId,
                    FightId = monsterFight.FightId
                });
            }
        }


        public MonsterFight GetById(int monsterId, int fightId)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(context))
            {
                var monsterFight = unitOfWork.MonsterFightRepo.GetMFById(monsterId, fightId);

                return monsterFight == null ? null : new MonsterFight
                {
                    MonsterId = monsterFight.MonsterId,
                    FightId = monsterFight.FightId
                };
            }
        }


        public bool Create(MonsterFight MonsterFight)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(context))
            {
                var monsterFight = new MonsterFight()
                {
                    MonsterId = MonsterFight.MonsterId,
                    FightId = MonsterFight.FightId
                };

                unitOfWork.MonsterFightRepo.Create(monsterFight);
                return unitOfWork.Save();
            }
        }


        public bool Update(MonsterFight monsterFight)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(context))
            {
                var result = unitOfWork.MonsterFightRepo.GetAll().Where(x => x.MonsterId == monsterFight.MonsterId
                && x.FightId == monsterFight.FightId).FirstOrDefault();

                if (result == null)
                {
                    return false;
                }

                result.MonsterId = monsterFight.MonsterId;
                result.FightId = monsterFight.FightId;

                unitOfWork.MonsterFightRepo.Update(result);
                return unitOfWork.Save();
            }
        }

        public bool Delete(int MonsterId, int FightId)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(context))
            {
                MonsterFight result = unitOfWork.MonsterFightRepo.GetMFById(MonsterId, FightId);

                if (result == null)
                {
                    return false;
                }

                unitOfWork.MonsterFightRepo.Delete(result);
                return unitOfWork.Save();
            }
        }
    }
}
