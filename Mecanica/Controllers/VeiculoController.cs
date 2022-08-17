using Mecanica.Models.Contracts.Services;
using Mecanica.Models.DTOS;
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

        public IActionResult Create()
        {
            try
            {
                return View();
            }
            catch (Exception ex) { throw ex; }
        }

        //Todas as Actions por padrão são get, para enviar dados via post precisa usar o HttpPost

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Fabricante, Modelo, AnoFabricacao, AnoModelo, Combustivel, Cor")] VeiculoDto veiculo)
        {
            try
            {
                _veiculoService.Cadastrar(veiculo);
                return RedirectToAction("List");
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
