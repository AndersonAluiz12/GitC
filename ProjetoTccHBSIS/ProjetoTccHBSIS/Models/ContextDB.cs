using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoTccHBSIS.Models
{
    public class ContextDB : DbContext
    {
        public DbSet<Colaborador> colaboradores {get; set; }

        public System.Data.Entity.DbSet<ProjetoTccHBSIS.Models.VeiculosCores> VeiculosCores { get; set; }
    }
}