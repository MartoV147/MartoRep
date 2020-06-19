using DnDLibraly.Models.MIdWareTables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DnDLibraly.Models {
    public class Fight {

        public int FightId { get; set; }

        [Required, MaxLength(200)]
        public string Terrain { get; set; }

        public double PriceWon { get; set; }

        public int ExpPoints { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public List<AdventurerFight> AdventurerFight { get; set; }

        public List<MonsterFight> MonsterFight { get; set; }

    }
}
