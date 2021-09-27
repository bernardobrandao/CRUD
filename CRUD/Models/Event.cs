using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD1.Models
{
    public class Evento
    {
        [Key]
        public string NomeDoEvento { get; set; }
        public int QuantidadeEventosCalendario { get; set; }
    }
}
