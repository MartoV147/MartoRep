using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DnDLibraly.Models {
    public class BaseModel {

        [Required, MaxLength(200)]
        public string Name { get; set; }

        public double HealthPoints { get; set; }

        public double AttackPoints { get; set; }

        public double DefensePoints { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }
    }
}
