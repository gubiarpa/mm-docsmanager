using MM_EntityLayer.Models.Behavior;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MM_EntityLayer.Models
{
    public class Factura : IGuid
    {
        public static string TableName => "TB_Factura";
        [Column("IDFactura")]
        public Guid Id { get; set; }
        [Column("Serie")]
        public int NumeroSerie { get; set; }
        [Column("Documento")]
        public int NumeroDocumento { get; set; }
        [Column("Cliente")]
        public string NombreCliente { get; set; }
        [Column("Fecha")]
        public DateTime Fecha { get; set; }
        [Column("MontoTotal")]
        public decimal MontoTotal { get; set; }
    }
}
