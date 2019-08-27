using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoTccHBSIS.Models
{
    public class VagasGaragem
    {
        public int Id { get; set; }
        public virtual TipoVeiculo VeiculosTipos { get; set; }
        public int QtdVagas { get; set; }

    }
}