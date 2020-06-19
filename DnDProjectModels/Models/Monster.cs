using DnDLibraly.Models.MIdWareTables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DnDLibraly.Models {
    public class Monster : BaseModel{

        [Key]
        public int MonsterId { get; set; }

        public int ExPoints { get; set; }

        public List<MonsterFight> MonsterFight { get; set; }

    }
}
