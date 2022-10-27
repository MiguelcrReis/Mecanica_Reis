using Mecanica.Models.Dtos;
using System.Collections.Generic;

namespace Mecanica.Models.Contracts.Services
{
    public interface IService<T, Y>
    {
        void Cadastrar(T entidade);
        List<T> Listar();
        T PesquisarPorId(Y id);
        void Atualizar(T entidade);
        void Excluir(Y id);
    }
}
