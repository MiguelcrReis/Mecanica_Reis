﻿using Mecanica.Models.Contracts.Repositories;
using Mecanica.Models.Contracts.Services;
using Mecanica.Models.DTOS;
using Mecanica.Models.Repositories;
using System;
using System.Collections.Generic;

namespace Mecanica.Models.Services
{
    public class ClienteService : IClienteService
    {
        #region Instanciamentos da classe
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        #endregion

        #region Atualizar Cliente
        public void Atualizar(ClienteDto cliente)
        {
            try
            {
                _clienteRepository.Atualizar(cliente);
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #region Cadastrar Cliente
        public void Cadastrar(ClienteDto cliente)
        {
            try
            {
                _clienteRepository.Cadastrar(cliente);
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #region Excluir Cliente
        public void Excluir(string id)
        {
            try
            {
                _clienteRepository.Excluir(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Listar Cliente
        public List<ClienteDto> Listar()
        {
            try
            {
                return _clienteRepository.Listar();
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #region Pesquisar Cliente por Id
        public ClienteDto PesquisarPorId(string id)
        {
            try
            {
                return _clienteRepository.PesquisarPorId(id);
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion
    }
}