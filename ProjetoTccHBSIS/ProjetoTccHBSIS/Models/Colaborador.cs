using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoTccHBSIS.Models
{
    public class Colaborador
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Email { get; set; }
        public int CEP { get; set; }
        public string Tipo { get; set; }
    }
}