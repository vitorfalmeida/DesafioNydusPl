using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.DataBase
{
    public class NydusDBContext : DbContext
    {
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<HistoricoCargo> HistoricoCargos { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Implementar metodo override

        }
    }
}