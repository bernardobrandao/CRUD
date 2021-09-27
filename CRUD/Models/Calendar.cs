using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD1.Models
{
    public class Calendar
    {
        [Key]
        public DateTime DayMounthYear { get; set; }
        public int Quantidade { get; set; }

        public int QuantidadeEventos { get; set; }

    }


}