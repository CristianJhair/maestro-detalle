using MaestroDetalle.Models;
using MaestroDetalle.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MaestroDetalle.Controllers
{
    public class HomeController : Controller
    {
        private readonly DbcompraContext _context;

        public HomeController(DbcompraContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index([FromBody] CompraVM oCompraVM)
        {
            //Objeto de tipo Compra-oCompra
            Compra oCompra = oCompraVM.oCompra;

            //Objeto de tipo Compra-oDetalleCompra
            oCompra.DetalleCompras = oCompraVM.oDetalleCompra;

            //Guardando objeto en tabla Compras
            _context.Compras.Add(oCompra);
            _context.SaveChanges();

            return Json(new {respuesta=true});
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}