using Mecanica.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mecanica.Models.Contracts.Contexts
{
    public interface IContextData
    {
        #region Veiculo
        void CadastrarVeiculo(Veiculo veiculo);
        List<Veiculo> ListarVeiculo();
        Veiculo PesquisarVeiculoPorId(string id);
        void AtualizarVeiculo(Veiculo veiculo);
        void ExcluirVeiculo(string id);
        #endregion

        #region Cliente
        void CadastrarCliente(Cliente veiculo);
        List<Cliente> ListarCliente();
        Cliente PesquisarClientePorId(string id);
        void AtualizarCliente(Cliente veiculo);
        void ExcluirCliente(string id);
        #endregion
    }
}
