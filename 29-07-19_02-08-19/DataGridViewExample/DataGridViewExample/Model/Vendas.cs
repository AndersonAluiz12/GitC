using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridViewExample.Model
{
    public class Vendas
    {
        public int Carros { get; set; } = 0;
        public int Quantidade { get; set; } = 0;
        public decimal Valor { get; set; } = 0;
        public bool Ativo { get; set; } = true;
        public string UsuInc { get; set; }
        public string UsuAlt { get; set; }
        public DateTime DatInc { get; set; } = DateTime.Now;
        public DateTime DatAlt { get; set; } = DateTime.Now;
    
    }
}
