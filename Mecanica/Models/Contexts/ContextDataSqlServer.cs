using Mecanica.Models.Contracts.Contexts;
using Mecanica.Models.Contracts.Repositories;
using Mecanica.Models.DTOS;
using Mecanica.Models.Enums;
using Mecanica.Models.Repositories;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace Mecanica.Models.Contexts
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
            try
            {
                _connection.Open();
                var query = SqlManager.GetSql(TSql.ATUALIZAR_VEICULO);
                var command = new SqlCommand(query, _connection);

                command.Parameters.Add("@id", SqlDbType.VarChar).Value = veiculo.Id;
                command.Parameters.Add("@placa", SqlDbType.VarChar).Value = veiculo.Placa;
                command.Parameters.Add("@fabricante", SqlDbType.VarChar).Value = veiculo.Fabricante;
                command.Parameters.Add("@modelo", SqlDbType.VarChar).Value = veiculo.Modelo;
                command.Parameters.Add("@anoFabricacao", SqlDbType.Date).Value = veiculo.AnoFabricacao;
                command.Parameters.Add("@anoModelo", SqlDbType.Date).Value = veiculo.AnoModelo;
                command.Parameters.Add("@combustivel", SqlDbType.VarChar).Value = veiculo.Combustivel;
                command.Parameters.Add("@cor", SqlDbType.VarChar).Value = veiculo.Cor;

                command.ExecuteNonQuery();

            }
            catch (Exception ex) { throw ex; }
            finally { if (_connection.State == ConnectionState.Open) { _connection.Close(); } }
        }

        public void Cadastrar(VeiculoDto veiculo)
        {
            try
            {
                _connection.Open();
                var query = SqlManager.GetSql(TSql.CADASTRAR_VEICULO);
                var command = new SqlCommand(query, _connection);

                command.Parameters.Add("@id", SqlDbType.VarChar).Value = veiculo.Id;
                command.Parameters.Add("@placa", SqlDbType.VarChar).Value = veiculo.Placa;
                command.Parameters.Add("@fabricante", SqlDbType.VarChar).Value = veiculo.Fabricante;
                command.Parameters.Add("@modelo", SqlDbType.VarChar).Value = veiculo.Modelo;
                command.Parameters.Add("@anoFabricacao", SqlDbType.Date).Value = veiculo.AnoFabricacao;
                command.Parameters.Add("@anoModelo", SqlDbType.Date).Value = veiculo.AnoModelo;
                command.Parameters.Add("@combustivel", SqlDbType.VarChar).Value = veiculo.Combustivel;
                command.Parameters.Add("@cor", SqlDbType.VarChar).Value = veiculo.Cor;

                command.ExecuteNonQuery();

            }
            catch (Exception ex) { throw ex; }
            finally { if (_connection.State == ConnectionState.Open) { _connection.Close(); } }
        }

        public void Excluir(string id)
        {
            try
            {
                _connection.Open();
                var query = SqlManager.GetSql(TSql.EXCLUIR_VEICULO);
                var command = new SqlCommand(query, _connection);

                command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;

                command.ExecuteNonQuery();

            }
            catch (Exception ex) { throw ex; }
            finally { if (_connection.State == ConnectionState.Open) { _connection.Close(); } }
        }

        public List<VeiculoDto> Listar()
        {
            var veiculos = new List<VeiculoDto>();
            try
            {
                var query = SqlManager.GetSql(TSql.LISTAR_VEICULO);
                var command = new SqlCommand(query, _connection);
                var dataset = new DataSet();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dataset);

                var rows = dataset.Tables[0].Rows;

                foreach (DataRow item in rows)
                {
                    var colunas = item.ItemArray;

                    var id = colunas[0].ToString();
                    var placa = colunas[1].ToString();
                    var fabricante = colunas[2].ToString();
                    var modelo = colunas[3].ToString();
                    var anoFabricacao = Int32.Parse(colunas[4].ToString());
                    var anoModelo = Int32.Parse(colunas[5].ToString());
                    var combustivel = colunas[6].ToString();
                    var cor = colunas[7].ToString();

                    var veiculo = new VeiculoDto(placa, id, fabricante, modelo, anoFabricacao, anoModelo, combustivel, cor);
                    veiculos.Add(veiculo);
                }

                adapter = null; dataset = null;

                return veiculos;
            }
            catch (Exception ex) { throw ex; }
        }

        public VeiculoDto PesquisarPorId(string id)
        {
            VeiculoDto veiculo = new VeiculoDto();
            try
            {
                var query = SqlManager.GetSql(TSql.PESQUISAR_VEICULO);

                var command = new SqlCommand(query, _connection);
                command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;

                var dataset = new DataSet();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dataset);

                var rows = dataset.Tables[0].Rows;

                foreach (DataRow item in rows)
                {
                    var colunas = item.ItemArray;

                    var id_veiculo = colunas[0].ToString();
                    var placa = colunas[1].ToString();
                    var fabricante = colunas[2].ToString();
                    var modelo = colunas[3].ToString();
                    var anoFabricacao = int.Parse(colunas[4].ToString());
                    var anoModelo = int.Parse(colunas[5].ToString());
                    var combustivel = colunas[6].ToString();
                    var cor = colunas[7].ToString();

                    veiculo = new VeiculoDto(placa, id, fabricante, modelo, anoFabricacao, anoModelo, combustivel, cor);
                }

                adapter = null; dataset = null;

                return veiculo;
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
