using Mecanica.Models.Contracts.Contexts;
using Mecanica.Models.Contracts.Repositories;
using Mecanica.Models.Entidades;
using System.Collections.Generic;

namespace Mecanica.Models.Repositories
{
    public class PessoaFisicaRepository : IPessoaFisicaRepository
    {
        #region Instancias
        private readonly IContextData _contextData;

        public PessoaFisicaRepository(IContextData contextData)
        {
            _contextData = contextData;
        }
        #endregion

        #region Atualizar
        public void Atualizar(PessoaFisica pessoaFisica)
        {
            _contextData.AtualizarPessoaFisica(pessoaFisica);
        }
        #endregion

        #region Cadastrar
        public void Cadastrar(PessoaFisica pessoaFisica)
        {
            _contextData.CadastrarPessoaFisica(pessoaFisica);
        }
        #endregion

        #region Excluir
        public void Excluir(int id)
        {
            _contextData.ExcluirPessoaFisica(id);
        }
        #endregion

        #region Listar
        public List<PessoaFisica> Listar()
        {
            return _contextData.ListarPessoaFisica();
        }
        #endregion

        #region Pesquisar Por Id
        public PessoaFisica PesquisarPorId(int id)
        {
            return _contextData.PesquisarPessoaFisicaPorId(id);
        }
        #endregion
    }
}
