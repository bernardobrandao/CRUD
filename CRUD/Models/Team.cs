using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD1.Models
{
    public class Team
    {
        [Key]
        public int Codigo { get; set; }

        public int QuantidadeCalendarios { get; set; }
    }
}