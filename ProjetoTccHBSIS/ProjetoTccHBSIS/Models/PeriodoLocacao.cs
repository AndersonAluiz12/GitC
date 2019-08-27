using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoTccHBSIS.Models
{
    public class PeriodoLocacao
    {
        [Key]
        public int Id { get; set; }
        public virtual TipoVeiculo VeiculosTipos { get; set; }
        public DateTime DataInic { get; set; } = DateTime.Now;
        public DateTime DataFim { get; set; } = DateTime.Now;
    }
}