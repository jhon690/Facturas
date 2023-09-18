using Facturas.Data;
using Facturas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Facturas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CrearFactura()
        {
            var modelo = new CrearDetalleViewModel();
            return View(modelo);
        }

        [HttpPost]
        public async Task<IActionResult> CrearFactura(CrearDetalleViewModel modelo)
        {
            if (ModelState.IsValid)
            {
                var productoExistente = await _context.Productos.FindAsync(modelo.IdProducto);
                if (productoExistente == null)
                {
                    ModelState.AddModelError(nameof(modelo.IdProducto), "El producto seleccionado no existe.");
                    return View(modelo);
                }

                try
                {
                    DetallesModel detalle = new DetallesModel()
                    {
                        IdFactura = modelo.IdFactura,
                        IdProducto = modelo.IdProducto,
                        Cantidad = modelo.Cantidad,
                        PrecioUnitario = modelo.PrecioUnitario
                    };

                    _context.Add(detalle);
                    await _context.SaveChangesAsync();

                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "Ocurrió un error al crear el detalle.");
                    
                }
            }

            return View(modelo);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}