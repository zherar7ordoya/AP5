using Menpos.Application.Modules.SettingsManager;
using Menpos.Persistence.ModelConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Menpos.Persistence.Common
{
    public class PosContext : DbContext
    {
        public PosContext()
        {
            ChangeTracker.LazyLoadingEnabled = true;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(SettingsManager.GetConnectionString());
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["cn"].ToString());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmpresaConfig());
        }
    }
}
