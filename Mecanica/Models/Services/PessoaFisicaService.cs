using Mecanica.Models.Contracts.Repositories;
using Mecanica.Models.Contracts.Services;
using Mecanica.Models.Dtos;
using Mecanica.Models.Entidades;
using Mecanica.Models.Repositories;
using Microsoft.AspNetCore.Razor.Language;
using System;
using System.Collections.Generic;

namespace Mecanica.Models.Services
{
    public class PessoaFisicaService : IPessoaFisicaService
    {
        #region Instanciamentos da classe
        private readonly IPessoaFisicaRepository _pessoaFisicaRepository;

        public PessoaFisicaService(IPessoaFisicaRepository pessoaFisicaRepository)
        {
            _pessoaFisicaRepository = pessoaFisicaRepository;
        }
        #endregion

        #region Atualizar 
        public void Atualizar(PessoaFisicaDto pessoaFisica)
        {
            try
            {
                var objPessoaFisica = pessoaFisica.ConverteParaEntidade();
                _pessoaFisicaRepository.Atualizar(objPessoaFisica);
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #region Cadastrar
        public void Cadastrar(PessoaFisicaDto pessoaFisica)
        {
            try
            {
                var objPessoaFisica = pessoaFisica.ConverteParaEntidade();
                _pessoaFisicaRepository.Cadastrar(objPessoaFisica);
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #region Excluir
        public void Excluir(int id)
        {
            try
            {
                _pessoaFisicaRepository.Excluir(id);
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #region Listar
        public List<PessoaFisicaDto> Listar()
        {
            try
            {
                var pessoasFisicasDto = new List<PessoaFisicaDto>();
                var pessoasFisicas = _pessoaFisicaRepository.Listar();
                foreach (var item in pessoasFisicas)
                {
                    pessoasFisicasDto.Add(item.ConverteParaDto());
                }
                return pessoasFisicasDto;
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #region Pesquisar Por Id
        public PessoaFisicaDto PesquisarPorId(int id)
        {
            try
            {
                var pessoaFisica = _pessoaFisicaRepository.PesquisarPorId(id);
                return pessoaFisica.ConverteParaDto();
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion
    }
}
