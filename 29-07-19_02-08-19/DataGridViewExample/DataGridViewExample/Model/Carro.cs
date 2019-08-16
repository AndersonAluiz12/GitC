using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridViewExample.Model
{
    public class Carro
    {
        public string Modelo { get; set; }
        public DateTime Ano{ get; set; }
        public int Marca { get; set; }
        public bool Ativo { get; set; }
        public int UsuInc { get; set; }
        public int UsuAlt { get; set; }
        public DateTime DateInc { get; set; } = DateTime.Now;
        public DateTime DateAlt { get; set; } = DateTime.Now;

    }
}
