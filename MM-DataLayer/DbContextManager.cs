using Microsoft.EntityFrameworkCore;
using MM_DataLayer.Mapping;
using MM_EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MM_DataLayer
{
    public class DBContextManager : DbContext
    {
        #region DbSet
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        #endregion

        public DBContextManager(DbContextOptions<DBContextManager> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region RegisterMap
            modelBuilder.ApplyConfiguration(new FacturaMap());
            modelBuilder.ApplyConfiguration(new ProductoMap());
            #endregion
        }
    }
}
