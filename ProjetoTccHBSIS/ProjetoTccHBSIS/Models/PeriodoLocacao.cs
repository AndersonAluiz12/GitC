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

        [ForeignKey("VeiculosTipos")]
        public VeiculosTipos veiculosTipos { get; set; }
        public int TipoVeiculo { get; set; }

        public DateTime DataInic { get; set; } = DateTime.Now;
        public DateTime DataFim { get; set; } = DateTime.Now;
    }
}