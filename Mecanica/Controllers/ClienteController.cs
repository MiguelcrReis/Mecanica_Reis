using Mecanica.Models.Contracts.Services;
using Mecanica.Models.Dtos;
using Mecanica.Models.DTOS;
using Mecanica.Models.Entidades;
using Mecanica.Models.Enums;
using Mecanica.Models.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mecanica.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteService _clienteService;
        private readonly IPessoaService _pessoaService;
        private readonly IPessoaJuridicaService _pessoaJuridicaService;
        private readonly IPessoaFisicaService _pessoaFisicaService;

        public ClienteController(IClienteService clienteService, IPessoaService pessoaService,
            IPessoaJuridicaService pessoaJuridicaService, IPessoaFisicaService pessoaFisicaService)
        {
            _clienteService = clienteService;
            _pessoaService = pessoaService;
            _pessoaJuridicaService = pessoaJuridicaService;
            _pessoaFisicaService = pessoaFisicaService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            try
            {
                var clientes = _clienteService.Listar();
                var pessoas = _pessoaService.Listar();
                var pessoasJuridicas = _pessoaJuridicaService.Listar();
                var pessoasFisicas = _pessoaFisicaService.Listar();

                foreach (var cliente in clientes)
                {
                    //cliente.Pessoa = new Pessoa(pessoas.Where(c => c.Id == cliente.Pessoa.Id));
                    if (cliente.Pessoa.TipoPessoa.Equals(TipoPessoa.Juridica))
                    {
                        cliente.PessoaJuridica = (PessoaJuridicaDto)pessoasJuridicas.Where(c => c.Pessoa.Id == cliente.Pessoa.Id);
                    }
                    else
                    {
                        cliente.PessoaFisica = (PessoaFisicaDto)pessoasFisicas.Where(c => c.Pessoa.Id == cliente.Pessoa.Id);
                    }
                }

                return View(clientes);
            }
            catch (Exception ex) { throw ex; }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Pessoa")] ClienteDto cliente)
        {
            try
            {
                _clienteService.Cadastrar(cliente);
                return RedirectToAction("List");
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
