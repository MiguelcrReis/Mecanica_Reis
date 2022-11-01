using Mecanica.Models.Contracts.Repositories;
using Mecanica.Models.Contracts.Services;
using Mecanica.Models.Dtos;
using Mecanica.Models.Repositories;
using System;
using System.Collections.Generic;

namespace Mecanica.Models.Services
{
    public class PessoaService : IPessoaService
    {
        #region Instanciamentos da classe
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }
        #endregion

        #region Atualizar 
        public void Atualizar(PessoaDto pessoa)
        {
            try
            {
                var objPessoa = pessoa.ConverteParaEntidade();
                _pessoaRepository.Atualizar(objPessoa);
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #region Cadastrar
        public void Cadastrar(PessoaDto pessoa)
        {
            try
            {
                var objPessoa = pessoa.ConverteParaEntidade();
                _pessoaRepository.Cadastrar(objPessoa);
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #region Excluir
        public void Excluir(int id)
        {
            try
            {
                _pessoaRepository.Excluir(id);
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #region Listar
        public List<PessoaDto> Listar()
        {
            try
            {
                var pessoasDto = new List<PessoaDto>();
                var pessoas = _pessoaRepository.Listar();
                foreach (var item in pessoas)
                {
                    pessoasDto.Add(item.ConverteParaDto());
                }
                return pessoasDto;
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #region Pesquisar Por Id
        public PessoaDto PesquisarPorId(int id)
        {
            try
            {
                var pessoa = _pessoaRepository.PesquisarPorId(id);
                return pessoa.ConverteParaDto();
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion
    }
}
