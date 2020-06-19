using DnDLibraly.Models.MIdWareTables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DnDLibraly.Data
{
    public class BaseRepository<TEntity> where TEntity : class, new()
    {
        private readonly ApplicationDbContext dbContext;

        public BaseRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
            Entities = dbContext.Set<TEntity>();
        }

        protected DbSet<TEntity> Entities { get; private set; }

        public virtual IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            if (filter != null)
            {
                return Entities
                    .Where(filter)
                    .ToList();
            }
            return dbContext.Set<TEntity>().ToList();
        }

        public virtual TEntity GetById(int id)
        {
            return Entities.Find(id);
        }

        
        public AdventurerFight GetAFById(int adventurerId, int fightId)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(dbContext))
            {
                var result = unitOfWork.AdventurerFightRepo.GetAll().Where(x => x.AdventurerId == adventurerId && x.FightId == fightId).FirstOrDefault();
                return result;
            } 
        }

        public MonsterFight GetMFById(int monsterId, int fightId)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(dbContext))
            {
                var result = unitOfWork.MonsterFightRepo.GetAll().Where(x => x.MonsterId == monsterId && x.FightId == fightId).FirstOrDefault();
                return result;
            }
        }



        public virtual TEntity Create(TEntity entity)
        {
            Entities.Add(entity);
            return entity;
        }


        public virtual void Update(TEntity entity)
        {
            Entities.Attach(entity);
            dbContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(TEntity entity)
        {
            Entities.Remove(entity);
        }
    }
}
