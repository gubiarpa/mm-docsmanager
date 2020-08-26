using Microsoft.AspNetCore.Mvc;
using MM_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MM_DocsManager.Controllers.Behavior
{
    public abstract class MainControllerBase : Controller
    {
        protected readonly DBContextManager _context;

        public MainControllerBase(DBContextManager context)
        {
            _context = context;
        }
    }
}
