using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD1.Models
{
    public class Usuario
    {
        [Key]
        public int CPF { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }

        public string setor { get; set; }

        public int Ddd { get; set; }

        public int Telefone { get; set; }

        public int CodigoDaEquipe { get; set; }



    }
}