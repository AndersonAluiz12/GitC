using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoTccHBSIS.Models
{
    public class Marcas
    {
        [Key]
        public int CodMarca { get; set; }
        public string Descricao { get; set; }
        public virtual TipoVeiculo VeiculosTipos { get; set; }
    }
}