using Mecanica.Models.DTOS;
using System.Collections.Generic;

namespace Mecanica.Models.Contracts.Repositories
{
    public interface IClienteRepository
    {
        void Cadastrar(ClienteDto cliente);
        List<ClienteDto> Listar();
        ClienteDto PesquisarPorId(string id);
        void Atualizar(ClienteDto cliente);
        void Excluir(string id);
    }
}
