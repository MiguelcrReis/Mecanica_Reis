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
                var objVeiculo = veiculo.ConverterParaEntidade();
                _veiculoRepository.Atualizar(objVeiculo);
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #region Cadastrar Veiculo
        public void Cadastrar(VeiculoDto veiculo)
        {
            try
            {
                var objVeiculo = veiculo.ConverterParaEntidade();
                _veiculoRepository.Cadastrar(objVeiculo);
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
                var veiculosDto = new List<VeiculoDto>();
                var veiculos = _veiculoRepository.Listar();
                foreach (var item in veiculos)
                {
                    veiculosDto.Add(item.ConverterParaDto());
                }

                return veiculosDto;
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #region Pesquisar Veiculo por Id
        public VeiculoDto PesquisarPorId(string id)
        {
            try
            {
                var veiculo = _veiculoRepository.PesquisarPorId(id);
                return veiculo.ConverterParaDto();
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion  
    }
}
