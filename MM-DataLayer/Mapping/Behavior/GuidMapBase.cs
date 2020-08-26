using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MM_EntityLayer.Models.Behavior;
using System;
using System.Collections.Generic;
using System.Text;

namespace MM_DataLayer.Mapping.Behavior
{
    public class GuidMapBase : IEntityTypeConfiguration<IGuid>
    {
        private readonly string _tableName;

        public GuidMapBase(string tableName)
        {
            _tableName = tableName;
        }

        public void Configure(EntityTypeBuilder<IGuid> builder)
        {
            builder.ToTable(_tableName).HasKey(m => m.Id);
        }
    }
}
