using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MM_DataLayer.Mapping.Behavior;
using MM_EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MM_DataLayer.Mapping
{
    public class FacturaMap : GuidMapBase
    {
        public FacturaMap(string tableName) : base(tableName)
        {
        }
    }
}
