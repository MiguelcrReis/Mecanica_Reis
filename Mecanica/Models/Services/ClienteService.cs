using Mecanica.Models.Contracts.Repositories;
using Mecanica.Models.Contracts.Services;
using Mecanica.Models.Dtos;
using Mecanica.Models.Entidades;
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
                var objCliente = cliente.ConverteParaEntidade();
                _clienteRepository.Atualizar(objCliente);
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #region Cadastrar Cliente
        public void Cadastrar(ClienteDto cliente)
        {
            try
            {
                var objCliente = cliente.ConverteParaEntidade();
                _clienteRepository.Cadastrar(objCliente);
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
                var clientesDto = new List<ClienteDto>();
                var clientes = _clienteRepository.Listar();
                foreach (var item in clientes)
                {   
                    clientesDto.Add(item.ConverteParaDto());
                }
                return clientesDto;
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #region Pesquisar Cliente por Id
        public ClienteDto PesquisarPorId(string id)
        {
            try
            {
                var cliente = _clienteRepository.PesquisarPorId(id);
                return cliente.ConverteParaDto();
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion
    }
}
