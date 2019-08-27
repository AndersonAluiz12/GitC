using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoTccHBSIS.Models
{
    public class Modelos
    {
        [Key]
        public int CodModelo { get; set; }
        public string Descricao { get; set; }
        public virtual Marcas VeiculosMarcas { get; set; }

        public virtual TipoVeiculo VeiculosTipos { get; set; }

    }
}