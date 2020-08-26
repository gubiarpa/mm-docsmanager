using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MM_EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MM_DataLayer.Mapping
{
    public class FacturaMap : IEntityTypeConfiguration<Factura>
    {
        public void Configure(EntityTypeBuilder<Factura> builder)
        {
            builder.ToTable(Factura.TableName);
        }
    }
}
