using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoTccHBSIS.Models
{
    public class VeiculosMarcas
    {
        [Key]
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Tipo { get; set; }
    }
}