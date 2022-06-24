using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public int IdUsu { get; set; }
        public string NomeUsu { get; set; }
        public string Cargo { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataNasc { get; set; }
    
    }
}
