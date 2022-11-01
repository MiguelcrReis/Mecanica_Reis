using Mecanica.Models.Contracts.Contexts;
using Mecanica.Models.Contracts.Repositories;
using Mecanica.Models.Entidades;
using System.Collections.Generic;

namespace Mecanica.Models.Repositories
{
    public class PessoaJuridicaRepository : IPessoaJuridicaRepository
    {
        #region Instancias
        private readonly IContextData _contextData;

        public PessoaJuridicaRepository(IContextData contextData)
        {
            _contextData = contextData;
        }
        #endregion

        #region Atualizar
        public void Atualizar(PessoaJuridica pessoaJuridica)
        {
            _contextData.AtualizarPessoaJuridica(pessoaJuridica);
        }
        #endregion

        #region Cadastrar
        public void Cadastrar(PessoaJuridica pessoaJuridica)
        {
            _contextData.CadastrarPessoaJuridica(pessoaJuridica);
        }
        #endregion

        #region Excluir
        public void Excluir(int id)
        {
            _contextData.ExcluirPessoaJuridica(id);
        }
        #endregion

        #region Listar
        public List<PessoaJuridica> Listar()
        {
            return _contextData.ListarPessoaJuridica();
        }
        #endregion

        #region Pesquisar Por Id
        public PessoaJuridica PesquisarPorId(int id)
        {
            return _contextData.PesquisarPessoaJuridicaPorId(id);
        }
        #endregion
    }
}
