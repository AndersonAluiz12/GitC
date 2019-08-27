using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoTccHBSIS.Models
{
    public class Veiculos
    {
       
        public int Id { get; set; }

        public virtual Colaborador Colaborador { get; set; }

        public virtual TipoVeiculo VeiculosTipos  { get; set; }

        public virtual Marcas VeiculosMarcas { get; set; }

        public virtual Modelos VeiculosModelos { get; set; }

        public virtual Cores VeiculosCores { get; set; }

        public string Placa { get; set; }
        
    }
}