using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoTccHBSIS.Models
{
    public class TermoDeUso
    {
        [Key]
        public int Id { get; set; }
        public string TermoUso { get; set; }
    }
}