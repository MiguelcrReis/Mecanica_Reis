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

        public void Atualizar(Veiculo veiculo)
        {
            _contextData.Atualizar(veiculo);
        }

        public void Cadastrar(Veiculo veiculo)
        {
            _contextData.Cadastrar(veiculo);
        }

        public void Excluir(string id)
        {
            _contextData.Excluir(id);
        }

        public List<Veiculo> Listar()
        {
            return _contextData.Listar();
        }

        public Veiculo PesquisarPorId(string id)
        {
            return _contextData.PesquisarPorId(id);
        }
    }
}
