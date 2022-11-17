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

                #region Modo alternativo
                //var pessoas = _pessoaService.Listar();
                //var pessoasJuridicas = _pessoaJuridicaService.Listar();
                //var pessoasFisicas = _pessoaFisicaService.Listar();

                //foreach (var cliente in clientes)
                //{
                //    foreach (var pessoa in pessoas)
                //    {
                //        if (cliente.IdPessoa.Equals(pessoa.Id))
                //        {
                //            cliente.Pessoa = pessoa;

                //            if (cliente.Pessoa.TipoPessoa.Equals(TipoPessoa.Juridica))
                //            {
                //                foreach (var pj in pessoasJuridicas)
                //                {
                //                    if (cliente.IdPessoa.Equals(pj.IdPessoa))
                //                    {
                //                        cliente.PessoaJuridica = pj;
                //                    }
                //                }
                //            }
                //            else
                //            {
                //                foreach (var pf in pessoasFisicas)
                //                {
                //                    if (cliente.IdPessoa.Equals(pf.IdPessoa))
                //                    {
                //                        cliente.PessoaFisica = pf;
                //                    }
                //                }
                //            }
                //        }
                //    }
                //}
                #endregion

                return View(clientes);
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("TipoPessoa")] PessoaDto pessoa)
        {
            try
            {
                if(pessoa.TipoPessoa == (int)TipoPessoa.Juridica)
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

        [HttpPost]
        public IActionResult CreatePF([Bind("PessoaFisica")] ClienteDto cliente)
        {
            try
            {
                _clienteService.Cadastrar(cliente);
                return RedirectToAction("List");
            }
            catch (Exception ex) { throw ex; }
        }

        [HttpPost]
        public IActionResult CreatePJ([Bind("PessoaJuridica")] ClienteDto cliente)
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
