using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MM_DocsManager.ViewModels
{
    public class FacturaCreateViewModel
    {
        [Required]
        public string NumeroSerie { get; set; }
        [Required]
        public string NombreCliente { get; set; }
        [Required]
        public string Producto { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public decimal PrecioUnit { get; set; }
    }
}
