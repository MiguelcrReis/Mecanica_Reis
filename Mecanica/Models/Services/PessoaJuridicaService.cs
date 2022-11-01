using Mecanica.Models.Contracts.Services;
using Mecanica.Models.Dtos;
using Mecanica.Models.Contracts.Repositories;
using Microsoft.CodeAnalysis.CodeActions;
using System.Collections.Generic;
using Mecanica.Models.Entidades;
using Mecanica.Models.Repositories;
using System;

namespace Mecanica.Models.Services
{
    public class PessoaJuridicaService : IPessoaJuridicaService
    {
        #region Instanciamentos da classe
        private readonly IPessoaJuridicaRepository _pessoaJuridicaRepository;

        public PessoaJuridicaService(IPessoaJuridicaRepository pessoaJuridicaRepository)
        {
            _pessoaJuridicaRepository = pessoaJuridicaRepository;
        }
        #endregion

        #region Atualizar 
        public void Atualizar(PessoaJuridicaDto pessoaJuridica)
        {
            try
            {
                var objPessoaJuridica = pessoaJuridica.ConverteParaEntidade();
                _pessoaJuridicaRepository.Atualizar(objPessoaJuridica);
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #region Cadastrar
        public void Cadastrar(PessoaJuridicaDto pessoaJuridica)
        {
            try
            {
                var objPessoaJuridica = pessoaJuridica.ConverteParaEntidade();
                _pessoaJuridicaRepository.Cadastrar(objPessoaJuridica);
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #region Excluir
        public void Excluir(int id)
        {
            try
            {
                _pessoaJuridicaRepository.Excluir(id);
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #region Listar
        public List<PessoaJuridicaDto> Listar()
        {
            try
            {
                var pessoasJuridicasDto = new List<PessoaJuridicaDto>();
                var pessoasJuridicas = _pessoaJuridicaRepository.Listar();
                foreach (var item in pessoasJuridicas)
                {
                    pessoasJuridicasDto.Add(item.ConverteParaDto());
                }
                return pessoasJuridicasDto;
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #region Pesquisar Por Id
        public PessoaJuridicaDto PesquisarPorId(int id)
        {
            try
            {
                var pessoaJuridica = _pessoaJuridicaRepository.PesquisarPorId(id);
                return pessoaJuridica.ConverteParaDto();
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion
    }
}
