using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MM_EntityLayer.Models
{
    public class Producto
    {
        public static string TableName => "TB_Producto";
        [Column("IDProducto")]
        public Guid Id { get; set; }
        [Column("Producto")]
        public string NombreProducto { get; set; }
    }
}
