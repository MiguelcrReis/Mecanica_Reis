using Mecanica.Models.Contracts.Contexts;
using Mecanica.Models.Contracts.Repositories;
using Mecanica.Models.Entidades;
using System.Collections.Generic;

namespace Mecanica.Models.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        #region Instancias
        private readonly IContextData _contextData;

        public PessoaRepository(IContextData contextData)
        {
            _contextData = contextData;
        }
        #endregion

        #region Atualizar
        public void Atualizar(Pessoa pessoa)
        {
            _contextData.AtualizarPessoa(pessoa);
        }
        #endregion

        #region Cadastrar
        public void Cadastrar(Pessoa pessoa)
        {
            _contextData.CadastrarPessoa(pessoa);
        }
        #endregion

        #region Excluir
        public void Excluir(int id)
        {
            _contextData.ExcluirPessoa(id);
        }
        #endregion

        #region Listar
        public List<Pessoa> Listar()
        {
            return _contextData.ListarPessoa();
        }
        #endregion

        #region Pesquisar Por Id
        public Pessoa PesquisarPorId(int id)
        {
            return _contextData.PesquisarPessoaPorId(id);
        }
        #endregion
    }
}
