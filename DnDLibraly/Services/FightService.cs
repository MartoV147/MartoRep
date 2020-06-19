using DnDLibraly.Data;
using DnDLibraly.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DnDLibraly.Services
{
    public class FightService
    {

        ApplicationDbContext context;

        public FightService(ApplicationDbContext context)
        {
            this.context = context;
        }


        public IEnumerable<Fight> GetAll()
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(context))
            {
                var fights = unitOfWork.FightRepo.GetAll();

                var result = fights.Select(fight => new Fight
                {
                    FightId = fight.FightId,
                    Terrain = fight.Terrain,
                    PriceWon = fight.PriceWon,
                    ExpPoints = fight.ExpPoints,
                    CreatedOn = fight.CreatedOn,
                    UpdatedOn = fight.UpdatedOn
                    
                }).ToList();

                return fights;
            }
        }

        public Fight GetById(int id)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(context))
            {
                var fight = unitOfWork.FightRepo.GetById(id);

                return fight == null ? null : new Fight
                {
                    FightId = fight.FightId,
                    Terrain = fight.Terrain,
                    PriceWon = fight.PriceWon,
                    ExpPoints = fight.ExpPoints,
                    CreatedOn = fight.CreatedOn,
                    UpdatedOn = fight.UpdatedOn
                };
            }
        }

        public bool Create(Fight Fight)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(context))
            {
                var fight = new Fight()
                {
                    FightId = Fight.FightId,
                    Terrain = Fight.Terrain,
                    PriceWon = Fight.PriceWon,
                    ExpPoints = Fight.ExpPoints,
                    CreatedOn = DateTime.UtcNow
                };

                unitOfWork.FightRepo.Create(fight);
                return unitOfWork.Save();
            }
        }

        public bool Update(Fight fight)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(context))
            {
                var result = unitOfWork.FightRepo.GetById(fight.FightId);

                if (result == null)
                {
                    return false;
                }

                result.Terrain = fight.Terrain;
                result.PriceWon = fight.PriceWon;
                result.ExpPoints = fight.ExpPoints;
                result.UpdatedOn = DateTime.UtcNow;

                unitOfWork.FightRepo.Update(result);
                return unitOfWork.Save();
            }
        }

        public bool Delete(int id)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(context))
            {
                Fight result = unitOfWork.FightRepo.GetById(id);

                if (result == null)
                {
                    return false;
                }

                unitOfWork.FightRepo.Delete(result);
                return unitOfWork.Save();
            }
        }
    }
}
