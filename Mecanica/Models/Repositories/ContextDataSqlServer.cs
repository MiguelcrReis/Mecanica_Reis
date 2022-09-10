using Mecanica.Models.Contracts.Contexts;
using Mecanica.Models.Contracts.Repositories;
using Mecanica.Models.DTOS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Mecanica.Models.Repositories
{
    public class ContextDataSqlServer : IContextData
    {
        private readonly SqlConnection _connection = null;
        
        public ContextDataSqlServer(IConnectionManager connectionManager)
        {
            _connection = connectionManager.GetConnection();
        }

        public void Atualizar(VeiculoDto veiculo)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(VeiculoDto veiculo)
        {
            throw new NotImplementedException();
        }

        public void Excluir(string id)
        {
            throw new NotImplementedException();
        }

        public List<VeiculoDto> Listar()
        {
            throw new NotImplementedException();
        }

        public VeiculoDto PesquisarPorId(string id)
        {
            throw new NotImplementedException();
        }
    }
}
