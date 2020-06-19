using DnDLibraly.Models;
using DnDLibraly.Models.MIdWareTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDLibraly.Data
{
    public class UnitOfWork : IDisposable
    {
        private ApplicationDbContext dbContext;
        private BaseRepository<Adventurer> adventurerRepo;
        private BaseRepository<Fight> fightRepo;
        private BaseRepository<Monster> monsterRepo;
        private BaseRepository<User> userRepo;

        private BaseRepository<AdventurerFight> adventurerFightRepo;
        private BaseRepository<MonsterFight> monsterFightRepo;

        private bool disposed = false;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public BaseRepository<Adventurer> AdventurerRepo
        {
            get
            {
                if (adventurerRepo == null)
                {
                    adventurerRepo = new BaseRepository<Adventurer>(dbContext);
                }
                return adventurerRepo;
            }
        }

        public BaseRepository<Fight> FightRepo
        {
            get
            {
                if (fightRepo == null)
                {
                    fightRepo = new BaseRepository<Fight>(dbContext);
                }
                return fightRepo;
            }
        }

        public BaseRepository<Monster> MonsterRepo
        {
            get
            {
                if (monsterRepo == null)
                {
                    monsterRepo = new BaseRepository<Monster>(dbContext);
                }
                return monsterRepo;
            }
        }

        public BaseRepository<AdventurerFight> AdventurerFightRepo
        {
            get
            {
                if (adventurerFightRepo == null)
                {
                    adventurerFightRepo = new BaseRepository<AdventurerFight>(dbContext);
                }
                return adventurerFightRepo;
            }
        }

        public BaseRepository<MonsterFight> MonsterFightRepo
        {
            get
            {
                if (monsterFightRepo == null)
                {
                    monsterFightRepo = new BaseRepository<MonsterFight>(dbContext);
                }
                return monsterFightRepo;
            }
        }

        public BaseRepository<User> UserRepo
        {
            get
            {
                if (userRepo == null)
                {
                    userRepo = new BaseRepository<User>(dbContext);
                }
                return userRepo;
            }
        }

        public bool Save()
        {
            try
            {
                dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Dispose()
        {}

        protected virtual void Dispose(bool disposing)
        {}

        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}

        //protected virtual void Dispose(bool disposing)
        //{
        //    if (!disposed && disposing)
        //    {
        //        dbContext.Dispose();
        //        disposed = true;
        //    }
        //}
    }
}