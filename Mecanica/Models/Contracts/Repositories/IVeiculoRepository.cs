using Mecanica.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mecanica.Models.Contracts.Repositories
{
    public interface IVeiculoRepository
    {
        void CadastrarVeiculo(Veiculo veiculo);
        List<Veiculo> ListarVeiculo();
        Veiculo PesquisarVeiculoPorId(string id);
        void AtualizarVeiculo(Veiculo veiculo);
        void ExcluirVeiculo(string id);
    }
}
