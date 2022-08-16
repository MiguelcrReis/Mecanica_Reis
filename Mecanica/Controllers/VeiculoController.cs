using Mecanica.Models.Contracts.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mecanica.Controllers
{
    public class VeiculoController : Controller
    {
        private readonly IVeiculoService _veiculoService;

        public VeiculoController(IVeiculoService veiculoService)
        {
            _veiculoService = veiculoService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            try
            {
                var veiculos = _veiculoService.Listar();
                return View(veiculos);
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
