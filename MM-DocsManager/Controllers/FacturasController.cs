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
            var factura = new FacturaCreateViewModel();
            return View(factura);
        }

        [HttpPost("[controller]/Crear")]
        public async Task<IActionResult> CreateDB(FacturaCreateViewModel factura)
        {
            return RedirectToAction("Index");
        }
    }
}
