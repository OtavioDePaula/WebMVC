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
        [Display(Name = "Código")]
        public int IdUsu { get; set; }
        [Display(Name = "Nome")]
        public string NomeUsu { get; set; }
        [Display(Name = "Cargo")]
        public string Cargo { get; set; }
        [Display(Name = "Data de nascimento")]
        public DateTime DataNasc { get; set; }
    
    }
}
