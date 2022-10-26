using Mecanica.Models.Entidades;
using System.Collections.Generic;

namespace Mecanica.Models.Contracts.Repositories
{
    public interface IRepository<T, Y>
    {
        void Cadastrar(T entidade);
        List<T> Listar();
        T PesquisarPorId(Y id);
        void Atualizar(T entidade);
        void Excluir(Y id);
    }
}
