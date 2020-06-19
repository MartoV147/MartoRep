using DnDLibraly.Data;
using DnDLibraly.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DnDLibraly.Services
{
    public class UserService
    {
        ApplicationDbContext context;


        public UserService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<User> GetAll()
        {
            using UnitOfWork unitOfWork = new UnitOfWork(context);
            var users = unitOfWork.UserRepo.GetAll();

            return users.Select(user => new User
            {
                Id = user.Id,
                FName = user.FName,
                LName = user.LName,
                Age = user.Age,
                Email = user.Email,
                Username = user.Username,
                Password = user.Password
            });
        }

        public User GetById(int id)
        {
            using UnitOfWork unitOfWork = new UnitOfWork(context);
            var user = unitOfWork.UserRepo.GetById(id);

            return user == null ? null : new User
            {
                Id = user.Id,
                FName = user.FName,
                LName = user.LName,
                Age = user.Age,
                Email = user.Email,
                Username = user.Username,
                Password = user.Password
            };
        }
        public bool Create(User User)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(context))
            {
                var user = new User()
                {
                    Id = User.Id,
                    FName = User.FName,
                    LName = User.LName,
                    Age = User.Age,
                    Email = User.Email,
                    Username = User.Username,
                    Password = User.Password
                };

                unitOfWork.UserRepo.Create(user);
                return unitOfWork.Save();
            }
        }

        public bool Update(User User)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(context))
            {
                var result = unitOfWork.UserRepo.GetById(User.Id);

                if (result == null)
                {
                    return false;
                }

                result.FName = User.FName;
                result.LName = User.LName;
                result.Age = User.Age;
                result.Email = User.Email;
                result.Username = User.Username;
                result.Password = User.Password;

                unitOfWork.UserRepo.Update(result);
                return unitOfWork.Save();
            }
        }

        public bool Delete(int id)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(context))
            {
                User result = unitOfWork.UserRepo.GetById(id);

                if (result == null)
                {
                    return false;
                }

                unitOfWork.UserRepo.Delete(result);
                return unitOfWork.Save();
            }
        }

        /*
        public IEnumerable<Adventurer> GetAllByName(string name)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                var adventurers = unitOfWork.AdventurerRepo.GetAll(d => d.Name == name);

                return adventurers.Select(adventurer => new Adventurer
                {
                    AdventurerId = adventurer.AdventurerId,
                    Name = adventurer.Name,
                    Level = adventurer.Level,
                    ManaPoints = adventurer.ManaPoints,
                    HealthPoints = adventurer.HealthPoints,
                    AttackPoints = adventurer.AttackPoints,
                    DefensePoints = adventurer.DefensePoints
                });
            }
        }
        */
    }
}