using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MM_DataLayer;
using MM_DocsManager.Controllers.Behavior;
using MM_DocsManager.ViewModels;
using MM_EntityLayer.Models;

namespace MM_DocsManager.Controllers
{
    public class FacturasController : MainControllerBase
    {
        public FacturasController(DBContextManager context) : base(context)
        {
        }

        public async Task<IActionResult> Index()
        {
            var facturas = await _context.Facturas.ToListAsync();

            return View(facturas);
        }

        [HttpGet("[controller]/Crear")]
        public async Task<IActionResult> Create()
        {
            var factura = new FacturaCreateViewModel()
            {
                NumeroSerie = "001" // mientras se implementa el login
            };
            return View(factura);
        }

        [HttpPost("[controller]/Crear")]
        public async Task<IActionResult> CreateDB(FacturaCreateViewModel factura)
        {
            var facturasMismaSerie = (List<Factura>)_context.Facturas.Where(f => f.NumeroSerie == 1);
            var facturasOrden = facturasMismaSerie.OrderByDescending(f => f.NumeroDocumento);
            var numeroDocumentoMax = facturasOrden.ElementAt(0).NumeroDocumento;
            
            _context.Facturas.Add(new Factura()
            {
                NumeroSerie = 1, // mientras se implementa el login
                NumeroDocumento = numeroDocumentoMax,
                Cantidad = factura.Cantidad,
                Fecha = DateTime.Now,
                MontoTotal = factura.PrecioUnit,
                NombreCliente = factura.NombreCliente,
                Producto = factura.Producto
            });

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
