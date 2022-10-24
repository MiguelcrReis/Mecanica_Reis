using Mecanica.Models.Contracts.Contexts;
using Mecanica.Models.Contracts.Repositories;
using Mecanica.Models.DTOS;
using Mecanica.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mecanica.Models.Repositories
{
    public class VeiculoRepository : IVeiculoRepository
    {
        private readonly IContextData _contextData;

        public VeiculoRepository(IContextData contextData)
        {
            _contextData = contextData;
        }

        public void AtualizarVeiculo(Veiculo veiculo)
        {
            _contextData.AtualizarVeiculo(veiculo);
        }

        public void CadastrarVeiculo(Veiculo veiculo)
        {
            _contextData.CadastrarVeiculo(veiculo);
        }

        public void ExcluirVeiculo(string id)
        {
            _contextData.ExcluirVeiculo(id);
        }

        public List<Veiculo> ListarVeiculo()
        {
            return _contextData.ListarVeiculo();
        }

        public Veiculo PesquisarVeiculoPorId(string id)
        {
            return _contextData.PesquisarVeiculoPorId(id);
        }
    }
}
