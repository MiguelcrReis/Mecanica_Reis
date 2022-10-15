using Mecanica.Models.Contracts.Contexts;
using Mecanica.Models.Contracts.Repositories;
using Mecanica.Models.DTOS;
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

        public void Atualizar(ClienteDto cliente)
        {
            _contextData.Atualizar(cliente);
        }

        public void Cadastrar(ClienteDto cliente)
        {
            _contextData.Cadastrar(cliente);
        }

        public void Excluir(string id)
        {
            _contextData.Excluir(id);
        }

        public List<ClienteDto> Listar()
        {
            return _contextData.Listar();
        }

        public ClienteDto PesquisarPorId(string id)
        {
            return _contextData.PesquisarPorId(id);
        }
    }
}
