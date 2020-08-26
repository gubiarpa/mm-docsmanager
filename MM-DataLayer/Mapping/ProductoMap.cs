using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MM_EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MM_DataLayer.Mapping
{
    public class ProductoMap : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.ToTable("TB_Producto").HasKey(x => x.Id);
        }
    }
}
