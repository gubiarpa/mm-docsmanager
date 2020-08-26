using MM_EntityLayer.Models.Behavior;
using System;
using System.Collections.Generic;
using System.Text;

namespace MM_EntityLayer.Models
{
    public class Factura : IGuid
    {
        public Guid Id { get; set; }
        public int NumeroSerie { get; set; }
        public int NumeroDocumento { get; set; }
        public string NombreCliente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public int Cantidad { get; set; }
        public string NombreProducto { get; set; }
    }
}
