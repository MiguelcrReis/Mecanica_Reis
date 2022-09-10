using Mecanica.Models.Contracts.Contexts;
using Mecanica.Models.Contracts.Repositories;
using Mecanica.Models.DTOS;
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

        public void Atualizar(VeiculoDto veiculo)
        {
            _contextData.Atualizar(veiculo);
        }

        public void Cadastrar(VeiculoDto veiculo)
        {
            _contextData.Cadastrar(veiculo);
        }

        public void Excluir(string id)
        {
            _contextData.Excluir(id);
        }

        public List<VeiculoDto> Listar()
        {
            return _contextData.Listar();
        }

        public VeiculoDto PesquisarPorId(string id)
        {
            return _contextData.PesquisarPorId(id);
        }
    }
}
