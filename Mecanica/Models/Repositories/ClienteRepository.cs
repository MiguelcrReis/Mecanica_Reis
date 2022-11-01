using Mecanica.Models.Contracts.Contexts;
using Mecanica.Models.Contracts.Repositories;
using Mecanica.Models.DTOS;
using Mecanica.Models.Entidades;
using System.Collections.Generic;

namespace Mecanica.Models.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        #region Instancias
        private readonly IContextData _contextData;

        public ClienteRepository(IContextData contextData)
        {
            _contextData = contextData;
        }
        #endregion

        #region Atualizar
        public void Atualizar(Cliente cliente)
        {
            _contextData.AtualizarCliente(cliente);
        }
        #endregion

        #region Cadastrar
        public void Cadastrar(Cliente cliente)
        {
            _contextData.CadastrarCliente(cliente);
        }
        #endregion

        #region Excluir
        public void Excluir(string id)
        {
            _contextData.ExcluirCliente(id);
        }
        #endregion

        #region Listar
        public List<Cliente> Listar()
        {
            return _contextData.ListarCliente();
        }
        #endregion

        #region Pesquisar Por Id
        public Cliente PesquisarPorId(string id)
        {
            return _contextData.PesquisarClientePorId(id);
        }
        #endregion
    }
}
