using Mecanica.Models.Contracts.Contexts;
using Mecanica.Models.Contracts.Repositories;
using Mecanica.Models.DTOS;
using Mecanica.Models.Entidades;
using System.Collections.Generic;

namespace Mecanica.Models.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly IContextData _contextData;

        public ClienteRepository(IContextData contextData)
        {
            _contextData = contextData;
        }

        public void Atualizar(Cliente cliente)
        {
            _contextData.AtualizarCliente(cliente);
        }

        public void Cadastrar(Cliente cliente)
        {
            _contextData.CadastrarCliente(cliente);
        }

        public void Excluir(string id)
        {
            _contextData.ExcluirCliente(id);
        }

        public List<Cliente> Listar()
        {
            return _contextData.ListarCliente();
        }

        public Cliente PesquisarPorId(string id)
        {
            return _contextData.PesquisarClientePorId(id);
        }
    }
}
