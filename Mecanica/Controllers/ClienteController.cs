using Mecanica.Models.Contracts.Services;
using Mecanica.Models.Dtos;
using Mecanica.Models.Entidades;
using Mecanica.Models.Enums;
using Mecanica.Models.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace Mecanica.Controllers
{
    public class ClienteController : Controller
    {
        #region Instancias
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
                var clientes = _clienteService.Listar();

                return View(clientes);
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

        #region Create Cliente
        [HttpPost]
        public IActionResult Create([Bind("Pessoa, TipoPessoa")] ClienteDto cliente)
        {
            try
            {
                if (cliente.Pessoa.TipoPessoa == (int)TipoPessoa.Juridica)
                {
                    return View("CreatePJ");
                }
                else
                {
                    return View("CreatePF");
                }
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #region Create Cliente Pessoa Juridica
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatePJ([Bind("PessoaJuridica, NomeFantasia, RazaoSocial, Cnpj")] ClienteDto cliente)
        {
            try
            {
                cliente.Ativo = true;
                cliente.DataCadastro = DateTime.Now;
                cliente.Pessoa = new PessoaDto();
                cliente.Pessoa.DataCadastro = DateTime.Now;
                cliente.Pessoa.Cliente = true;
                cliente.Pessoa.TipoPessoa = TipoPessoa.Juridica;

                _clienteService.Cadastrar(cliente);
                return RedirectToAction("List");
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #region Create Cliente Pessoa Fisica
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatePF([Bind("PessoaFisica, Nome, Cpf")] ClienteDto cliente)
        {
            try
            {
                cliente.Ativo = true;
                cliente.DataCadastro = DateTime.Now;
                cliente.Pessoa = new PessoaDto();
                cliente.Pessoa.DataCadastro = DateTime.Now;
                cliente.Pessoa.Cliente = true;
                cliente.Pessoa.TipoPessoa = TipoPessoa.Fisica;

                _clienteService.Cadastrar(cliente);
                return RedirectToAction("List");
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion
    }
}
