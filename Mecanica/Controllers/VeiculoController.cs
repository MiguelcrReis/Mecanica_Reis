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
        #region Instancias
        private readonly IVeiculoService _veiculoService;

        public VeiculoController(IVeiculoService veiculoService)
        {
            _veiculoService = veiculoService;
        }
        #endregion

        #region Index
        public IActionResult Index()
        {
            return View();
        }
        #endregion

        #region List
        public IActionResult List()
        {
            try
            {
                var veiculos = _veiculoService.Listar();
                return View(veiculos);
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #region Create
        public IActionResult Create()
        {
            return View();
        }
        #endregion

        //Todas as Actions por padrão são get, para enviar dados via post precisa usar o HttpPost

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Placa, Fabricante, Modelo, AnoFabricacao, AnoModelo, Combustivel, Cor")] VeiculoDto veiculo)
        {
            try
            {
                _veiculoService.Cadastrar(veiculo);
                return RedirectToAction("List");
            }
            catch (Exception ex) { throw ex; }
        }

        public IActionResult Edit(string? id)
        {
            if (string.IsNullOrEmpty(id))
                return NotFound();

            var veiculo = _veiculoService.PesquisarPorId(id);

            if (veiculo == null)
                return NotFound();


            return View(veiculo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind("Id, Placa, Fabricante, Modelo, AnoFabricacao, AnoModelo, Combustivel, Cor")] VeiculoDto veiculo)
        {
            if (string.IsNullOrEmpty(veiculo.Id))
                return NotFound();

            try
            {
                _veiculoService.Atualizar(veiculo);
                return RedirectToAction("List");
            }
            catch (Exception ex) { throw ex; }
        }

        public IActionResult Details(string? id)
        {
            if (string.IsNullOrEmpty(id))
                return NotFound();

            var veiculo = _veiculoService.PesquisarPorId(id);

            if (veiculo == null)
                return NotFound();

            return View(veiculo);
        }

        public IActionResult Delete(string? id)
        {
            if (string.IsNullOrEmpty(id))
                return NotFound();

            var veiculo = _veiculoService.PesquisarPorId(id);

            if (veiculo == null)
                return NotFound();

            return View(veiculo);
        }

        [HttpPost]
        public IActionResult Delete([Bind("Id, Placa, Fabricante, Modelo, AnoFabricacao, AnoModelo, Combustivel, Cor")] VeiculoDto veiculo)
        {
            _veiculoService.Excluir(veiculo.Id);
            return RedirectToAction("List");
        }
    }
}
