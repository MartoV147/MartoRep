using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDLibraly.Models.MIdWareTables {
    public class AdventurerFight {

        public int AdventurerId { get; set; }

        public int FightId { get; set; }

        public Adventurer Adventurer { get; set; }

        public Fight Fight { get; set; }
    }
}
