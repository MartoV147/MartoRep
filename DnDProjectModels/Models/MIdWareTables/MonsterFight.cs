using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDLibraly.Models.MIdWareTables {
    public class MonsterFight {

        public int MonsterId { get; set; }

        public int FightId { get; set; }

        public Monster Monster { get; set; }

        public Fight Fight { get; set; }
    }
}
