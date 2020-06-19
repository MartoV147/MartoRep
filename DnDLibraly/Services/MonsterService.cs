using DnDLibraly.Data;
using DnDLibraly.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DnDLibraly.Services
{
    public class MonsterService
    {

        ApplicationDbContext context;

        public MonsterService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Monster> GetAll()
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(context))
            {
                var monsters = unitOfWork.MonsterRepo.GetAll();

                return monsters.Select(monster => new Monster
                {
                    MonsterId = monster.MonsterId,
                    Name = monster.Name,
                    HealthPoints = monster.HealthPoints,
                    AttackPoints = monster.AttackPoints,
                    DefensePoints = monster.DefensePoints,
                    ExPoints = monster.ExPoints,
                    CreatedOn = monster.CreatedOn,
                    UpdatedOn = monster.UpdatedOn
                });
            }
        }

        public Monster GetById(int id)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(context))
            {
                var monster = unitOfWork.MonsterRepo.GetById(id);

                return monster == null ? null : new Monster
                {
                    MonsterId = monster.MonsterId,
                    Name = monster.Name,
                    HealthPoints = monster.HealthPoints,
                    AttackPoints = monster.AttackPoints,
                    DefensePoints = monster.DefensePoints,
                    ExPoints = monster.ExPoints
                };
            }
        }

        public bool Create(Monster Monster)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(context))
            {
                var monster = new Monster()
                {
                    MonsterId = Monster.MonsterId,
                    Name = Monster.Name,
                    HealthPoints = Monster.HealthPoints,
                    AttackPoints = Monster.AttackPoints,
                    DefensePoints = Monster.DefensePoints,
                    ExPoints = Monster.ExPoints,
                    CreatedOn = DateTime.Now
                };
                unitOfWork.MonsterRepo.Create(monster);
                return unitOfWork.Save();
            }
        }

        public bool Update(Monster Monster)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(context))
            {
                var result = unitOfWork.MonsterRepo.GetById(Monster.MonsterId);

                if (result == null)
                {
                    return false;
                }

                result.Name = Monster.Name;
                result.HealthPoints = Monster.HealthPoints;
                result.AttackPoints = Monster.AttackPoints;
                result.DefensePoints = Monster.DefensePoints;
                result.ExPoints = Monster.ExPoints;
                result.UpdatedOn = DateTime.Now;

                unitOfWork.MonsterRepo.Update(result);
                return unitOfWork.Save();
            }
        }

        public bool Delete(int id)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(context))
            {
                Monster result = unitOfWork.MonsterRepo.GetById(id);

                if (result == null)
                {
                    return false;
                }

                unitOfWork.MonsterRepo.Delete(result);
                return unitOfWork.Save();
            }
        }

        public Monster GetByName(string name)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(context))
            {
                var monsters = unitOfWork.MonsterRepo.GetAll(d => d.Name == name).ToList();

                return monsters.FirstOrDefault();
            }
        }
    }
}
