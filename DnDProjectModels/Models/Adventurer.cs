using DnDLibraly.Models.MIdWareTables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DnDLibraly.Models {
    public class Adventurer : BaseModel{

        [Key]
        public int AdventurerId { get; set; }

        public int Level { get; set; }

        public double ManaPoints { get; set; }

        public List<AdventurerFight> AdventurerFight { get; set; }

    }
}
