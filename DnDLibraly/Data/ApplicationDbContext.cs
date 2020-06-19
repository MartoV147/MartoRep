using DnDLibraly.Models;
using DnDLibraly.Models.MIdWareTables;
using Microsoft.EntityFrameworkCore;
using System;

namespace DnDLibraly.Data {
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public ApplicationDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

            builder.Entity<Adventurer>().HasIndex(s => s.Name).IsUnique();
            builder.Entity<Monster>().HasIndex(s => s.Name).IsUnique();
            builder.Entity<User>().HasIndex(s => s.Username).IsUnique();


            builder.Entity<AdventurerFight>().HasKey(s => new { s.AdventurerId, s.FightId });
            builder.Entity<AdventurerFight>().HasOne(s => s.Adventurer).WithMany(s => s.AdventurerFight).HasForeignKey(s => s.AdventurerId);
            builder.Entity<AdventurerFight>().HasOne(s => s.Fight).WithMany(s => s.AdventurerFight).HasForeignKey(s => s.FightId);


            builder.Entity<MonsterFight>().HasKey(s => new { s.MonsterId, s.FightId });
            builder.Entity<MonsterFight>().HasOne(s => s.Monster).WithMany(s => s.MonsterFight).HasForeignKey(s => s.MonsterId);
            builder.Entity<MonsterFight>().HasOne(s => s.Fight).WithMany(s => s.MonsterFight).HasForeignKey(s => s.FightId);

            builder.Entity<AdventurerFight>().HasKey(s => new { s.AdventurerId, s.FightId });
            builder.Entity<AdventurerFight>().HasOne(s => s.Adventurer).WithMany(s => s.AdventurerFight).HasForeignKey(s => s.AdventurerId);
            builder.Entity<AdventurerFight>().HasOne(s => s.Fight).WithMany(s => s.AdventurerFight).HasForeignKey(s => s.FightId);


            builder.Entity<MonsterFight>().HasKey(s => new { s.MonsterId, s.FightId });
            builder.Entity<MonsterFight>().HasOne(s => s.Monster).WithMany(s => s.MonsterFight).HasForeignKey(s => s.MonsterId);
            builder.Entity<MonsterFight>().HasOne(s => s.Fight).WithMany(s => s.MonsterFight).HasForeignKey(s => s.FightId);

            builder.Entity<Adventurer>().HasData(
                new Adventurer { AdventurerId = 1, Name = "Gladitorian", Level = 15, HealthPoints = 50.0, ManaPoints = 0.0, AttackPoints = 20.0, DefensePoints = 9.11, CreatedOn = new DateTime(2017, 1, 18) },
                new Adventurer { AdventurerId = 2, Name = "Pheterion", Level = 10, HealthPoints = 30.0, ManaPoints = 10.0, AttackPoints = 8.0, DefensePoints = 13.37, CreatedOn = new DateTime(2017, 1, 18) },
                new Adventurer { AdventurerId = 3, Name = "Makintosh", Level = 12, HealthPoints = 42.0, ManaPoints = 6.9, AttackPoints = 3.2, DefensePoints = 20.0, CreatedOn = new DateTime(2017, 1, 18) },
                new Adventurer { AdventurerId = 4, Name = "Gosho", Level = 14, HealthPoints = 32.2, ManaPoints = 20.0, AttackPoints = 16.6, DefensePoints = 9.9, CreatedOn = new DateTime(2017, 1, 18) },
                new Adventurer { AdventurerId = 5, Name = "Bark", Level = 16, HealthPoints = 40.0, ManaPoints = 0.0, AttackPoints = 18.0, DefensePoints = 17.0, CreatedOn = new DateTime(2017, 1, 18) },
                new Adventurer { AdventurerId = 6, Name = "Ultrapure", Level = 15, HealthPoints = 50.0, ManaPoints = 10.0, AttackPoints = 12.2, DefensePoints = 12.2, CreatedOn = new DateTime(2017, 1, 18) },
                new Adventurer { AdventurerId = 7, Name = "TodiInc", Level = 19, HealthPoints = 69.0, ManaPoints = 42.0, AttackPoints = 6.9, DefensePoints = 42.0, CreatedOn = new DateTime(2017, 1, 18) }
            );

            builder.Entity<Monster>().HasData(
                new Monster { MonsterId = 1, Name = "Adult Red Dragon", HealthPoints = 256, AttackPoints = 22.0, DefensePoints = 19.0, ExPoints = 18000, CreatedOn = new DateTime(2017, 1, 18) },
                new Monster { MonsterId = 2, Name = "Adult Black Dragon", HealthPoints = 240, AttackPoints = 24.0, DefensePoints = 19.0, ExPoints = 18000, CreatedOn = new DateTime(2017, 1, 18) },
                new Monster { MonsterId = 3, Name = "Goblin", HealthPoints = 10, AttackPoints = 11.0, DefensePoints = 10.0, ExPoints = 10, CreatedOn = new DateTime(2017, 1, 18) },
                new Monster { MonsterId = 4, Name = "Dark Monarch", HealthPoints = 240, AttackPoints = 20.0, DefensePoints = 15.0, ExPoints = 15000, CreatedOn = new DateTime(2017, 1, 18) },
                new Monster { MonsterId = 5, Name = "Blue-Eyes White Dragon", HealthPoints = 300, AttackPoints = 30.0, DefensePoints = 25.0, ExPoints = 20000, CreatedOn = new DateTime(2017, 1, 18) },
                new Monster { MonsterId = 6, Name = "The Fallen", HealthPoints = 150, AttackPoints = 18.0, DefensePoints = 18.0, ExPoints = 7000, CreatedOn = new DateTime(2017, 1, 18) }   
            );

            builder.Entity<AdventurerFight>().HasData(
                new AdventurerFight { AdventurerId = 1, FightId = 1 },
                new AdventurerFight { AdventurerId = 2, FightId = 1 }
                );

            builder.Entity<MonsterFight>().HasData(
                new MonsterFight { MonsterId = 1, FightId = 1 },
                new MonsterFight { MonsterId = 3, FightId = 1 }
                );

            builder.Entity<Fight>().HasData(
                new Fight { FightId = 1, Terrain = "Plain", PriceWon = 0, CreatedOn = new DateTime(2017, 1, 18) },
                new Fight { FightId = 2, Terrain = "Forest", PriceWon = 500, CreatedOn = new DateTime(2017, 1, 18) }
                );

            builder.Entity<User>().HasData(
                new User { Id = 1, Age = 21, Email = "martomail@abv.bg", FName = "Martin", LName = "Vasilev", Username = "martov", Password = "martopass" },
                new User { Id = 2, Age = 25, Email = "macintosh@abv.bg", FName = "Richard", LName = "Hristov", Username = "traps", Password = "arentgay" },
                new User { Id = 3, Age = 64, Email = "ohhimark@abv.bg", FName = "Tommy", LName = "Wiseau", Username = "yourtearingme", Password = "apartlisa" },
                new User { Id = 4, Age = 17, Email = "dva", FName = "Hana", LName = "Song", Username = "dva", Password = "dva" }
                );

        }
    
        public DbSet<Adventurer> Adventurers { get; set;}
        public DbSet<Monster> Monsters { get; set; }
        public DbSet<Fight> Fights { get; set; }
        public DbSet<AdventurerFight> AdventurerFights { get; set; }
        public DbSet<MonsterFight> MonsterFights { get; set; }
        public DbSet<User> Users { get; set; }
    }
}

