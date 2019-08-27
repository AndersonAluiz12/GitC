using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoPadawanTCC.Models {
    public class TipoVeiculos: UserControls {
        [Key]
        public int CodigoTipo { get; set; }
        public string Descricao { get; set; }
    }
}