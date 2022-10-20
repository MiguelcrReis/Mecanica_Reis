using Mecanica.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mecanica.Models.Contracts.Contexts
{
    public interface IContextData
    {
        void Cadastrar(Veiculo veiculo);
        List<Veiculo> Listar();
        Veiculo PesquisarPorId(string id);
        void Atualizar(Veiculo veiculo);
        void Excluir(string id);
    }
}
