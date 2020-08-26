using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MM_DataLayer;
using MM_DocsManager.Controllers.Behavior;

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
    }
}
