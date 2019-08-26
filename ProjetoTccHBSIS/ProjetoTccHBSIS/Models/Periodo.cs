using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoTccHBSIS.Models
{
    public class Periodo
    {
        public int Id { get; set; }
        public DateTime DataInic { get; set; } = DateTime.Now;
        public DateTime DataFim { get; set; } = DateTime.Now;

    }
}