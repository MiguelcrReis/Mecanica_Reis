using Mecanica.Models.Contracts.Repositories;
using Mecanica.Models.Contracts.Services;
using Mecanica.Models.DTOS;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mecanica.Models.Services
{
    public class VeiculoService : IVeiculoService
    {
        #region Instanciamentos da classe
        private readonly IVeiculoRepository _veiculoRepository;

        public VeiculoService(IVeiculoRepository veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }
        #endregion

        #region Atualizar Veiculo
        public void Atualizar(VeiculoDto veiculo)
        {
            try
            {
                _veiculoRepository.Atualizar(veiculo);
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #region Cadastrar Veiculo
        public void Cadastrar(VeiculoDto veiculo)
        {
            try
            {
                _veiculoRepository.Cadastrar(veiculo);
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #region Excluir Veiculo
        public void Excluir(string id)
        {
            try
            {
                _veiculoRepository.Excluir(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Listar Veiculos
        public List<VeiculoDto> Listar()
        {
            try
            {
                return _veiculoRepository.Listar();
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #region Pesquisar Veiculo por Id
        public VeiculoDto PesquisarPorId(string id)
        {
            try
            {
                return _veiculoRepository.PesquisarPorId(id);
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion  
    }
}
