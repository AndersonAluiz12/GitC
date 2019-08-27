using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoTccHBSIS.Models
{
    public class TipoVeiculo
    {
        [Key]
        public int CodTipo { get; set; }
        public string Descricao { get; set; }

    }
}