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
        [ForeignKey("UserLocador")]
        public Colaborador userLocador { get; set; }
        public int UsuarioLocador { get; set; }

        [ForeignKey ("Tipo")]
        public VeiculosTipos veiculosTipos { get; set; }
        public int Tipo { get; set; }

        [ForeignKey ("Marca")]
        public VeiculosMarcas veiculosMarcas { get; set; }
        public int Marca { get; set; }

        [ForeignKey ("Modelo")]
        public VeiculosModelos veiculosModelos { get; set; }
        public int Modelo { get; set; }

        [ForeignKey ("Cor")]
        public VeiculosCores veiculosCores { get; set; }
        public int Cor { get; set; }

        public string Placa { get; set; }
        
    }
}