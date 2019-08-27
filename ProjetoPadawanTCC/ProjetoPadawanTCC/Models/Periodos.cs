﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoPadawanTCC.Models {
    public class Periodos {
        public int CodigoPeriodo { get; set; }

        public virtual TipoVeiculos CodigoTipo { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; } 
    }
}