using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MM_DocsManager.ViewModels
{
    public class FacturaCreateViewModel
    {
        public int NumeroSerie { get; set; }
        public string NombreCliente { get; set; }
        public IEnumerable<ProductoItemViewModel> Productos { get; set; }
    }

    public class ProductoItemViewModel
    {
        public Guid Id { get; set; }
        public decimal Monto { get; set; }
        public string Cantidad { get; set; }
    }
}
