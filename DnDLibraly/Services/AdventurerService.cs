using DnDLibraly.Data;
using DnDLibraly.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DnDLibraly.Services
{
    public class AdventurerService
    {
        ApplicationDbContext context;


        public AdventurerService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Adventurer> GetAll()
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(context))
            {
                var adventurers = unitOfWork.AdventurerRepo.GetAll();

                return adventurers;
            }
        }

        public Adventurer GetById(int id)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(context))
            {
                var adventurer = unitOfWork.AdventurerRepo.GetById(id);

                return adventurer == null ? null : new Adventurer
                {
                    AdventurerId = adventurer.AdventurerId,
                    Name = adventurer.Name,
                    Level = adventurer.Level,
                    ManaPoints = adventurer.ManaPoints,
                    HealthPoints = adventurer.HealthPoints,
                    AttackPoints = adventurer.AttackPoints,
                    DefensePoints = adventurer.DefensePoints
                };
            }
        }

        public Adventurer GetByName(string name)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(context))
            {
                var adventurers = unitOfWork.AdventurerRepo.GetAll(d => d.Name == name).ToList();

                Adventurer result = adventurers.FirstOrDefault();

                return result == null ? null : new Adventurer
                {
                    AdventurerId = result.AdventurerId,
                    Name = result.Name,
                    Level = result.Level,
                    ManaPoints = result.ManaPoints,
                    HealthPoints = result.HealthPoints,
                    AttackPoints = result.AttackPoints,
                    DefensePoints = result.DefensePoints
                };
            }
        }

        public bool Create(Adventurer Adventurer)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(context))
            {
                var adventurer = new Adventurer()
                {
                    AdventurerId = Adventurer.AdventurerId,
                    Name = Adventurer.Name,
                    Level = Adventurer.Level,
                    ManaPoints = Adventurer.ManaPoints,
                    HealthPoints = Adventurer.HealthPoints,
                    AttackPoints = Adventurer.AttackPoints,
                    DefensePoints = Adventurer.DefensePoints,
                    CreatedOn = DateTime.UtcNow
                };

                unitOfWork.AdventurerRepo.Create(adventurer);

                return unitOfWork.Save();
            }
        }

        public bool Update(Adventurer adventurer)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(context))
            {
                var result = unitOfWork.AdventurerRepo.GetById(adventurer.AdventurerId);

                if (result == null)
                {
                    return false;
                }

                result.Name = adventurer.Name;
                result.Level = adventurer.Level;
                result.ManaPoints = adventurer.ManaPoints;
                result.HealthPoints = adventurer.HealthPoints;
                result.AttackPoints = adventurer.AttackPoints;
                result.DefensePoints = adventurer.DefensePoints;
                result.UpdatedOn = DateTime.UtcNow;

                unitOfWork.AdventurerRepo.Update(result);
                return unitOfWork.Save();
            }
        }

        public bool Delete(int id)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(context))
            {
                Adventurer result = unitOfWork.AdventurerRepo.GetById(id);

                if (result == null)
                {
                    return false;
                }

                unitOfWork.AdventurerRepo.Delete(result);
                return unitOfWork.Save();
            }
        }
    }
}