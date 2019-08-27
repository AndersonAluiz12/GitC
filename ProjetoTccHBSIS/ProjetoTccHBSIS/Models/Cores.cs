using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoTccHBSIS.Models
{
    public class Cores
    {
        [Key]
        public int CodCor { get; set; }
        public string Descricao { get; set; }

    }
}