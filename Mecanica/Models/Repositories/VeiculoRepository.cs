using Mecanica.Models.Contracts.Contexts;
using Mecanica.Models.Contracts.Repositories;
using Mecanica.Models.Dtos;
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

        public void Atualizar(Veiculo veiculo)
        {
            _contextData.AtualizarVeiculo(veiculo);
        }

        public void Cadastrar(Veiculo veiculo)
        {
            _contextData.CadastrarVeiculo(veiculo);
        }

        public void Excluir(string id)
        {
            _contextData.ExcluirVeiculo(id);
        }

        public List<Veiculo> Listar()
        {
            return _contextData.ListarVeiculo();
        }

        public Veiculo PesquisarPorId(string id)
        {
            return _contextData.PesquisarVeiculoPorId(id);
        }
    }
}
