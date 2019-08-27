using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoTccHBSIS.Models
{
    public class ContextDB : DbContext
    {
        public DbSet<Colaborador> colaboradores { get; set; }
        public DbSet<Periodo> periodos { get; set; }
        public DbSet<PeriodoLocacao> periodoLocacao { get; set; }
        public DbSet<TermoDeUso> termoDeUsos { get; set; }
        public DbSet<VagasGaragem> vagasGaragems { get; set; }
        public DbSet<Veiculos> veiculos { get; set; }
        public DbSet<Cores> cores { get; set; }
        public DbSet<Marcas> marcas { get; set; }
        public DbSet<Modelos> modelos { get; set; }
        public DbSet<TipoVeiculo> tipoVeiculos { get; set; }
    }
}