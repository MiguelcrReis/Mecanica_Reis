using Mecanica.Models.Contracts.Contexts;
using Mecanica.Models.Contracts.Repositories;
using Mecanica.Models.Entidades;
using Mecanica.Models.Enums;
using Mecanica.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Mecanica.Models.Contexts
{
    public class ContextDataSqlServer : IContextData
    {
        private readonly SqlConnection _connection = null;

        public ContextDataSqlServer(IConnectionManager connectionManager)
        {
            _connection = connectionManager.GetConnection();
        }

        #region Veiculo 

        #region Atualizar Veiculo
        public void AtualizarVeiculo(Veiculo veiculo)
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
        #endregion

        #region Cadastrar Veiculo
        public void CadastrarVeiculo(Veiculo veiculo)
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
        #endregion

        #region Excluir Veiculo
        public void ExcluirVeiculo(string id)
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
        #endregion

        #region Listar Veiculo
        public List<Veiculo> ListarVeiculo()
        {
            var veiculos = new List<Veiculo>();
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
                    var anoFabricacao = int.Parse(colunas[4].ToString());
                    var anoModelo = int.Parse(colunas[5].ToString());
                    var combustivel = colunas[6].ToString();
                    var cor = colunas[7].ToString();

                    var veiculo = new Veiculo
                    {
                        Id = id,
                        Placa = placa,
                        Fabricante = fabricante,
                        Modelo = modelo,
                        AnoFabricacao = anoFabricacao,
                        AnoModelo = anoModelo,
                        Combustivel = combustivel,
                        Cor = cor
                    };
                    veiculos.Add(veiculo);
                }

                adapter = null; dataset = null;

                return veiculos;
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #region Pesquisar Veiculo Por Id
        public Veiculo PesquisarVeiculoPorId(string id)
        {
            Veiculo veiculo = new Veiculo();
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

                    veiculo = new Veiculo
                    {
                        Id = id,
                        Placa = placa,
                        Fabricante = fabricante,
                        Modelo = modelo,
                        AnoFabricacao = anoFabricacao,
                        AnoModelo = anoModelo,
                        Combustivel = combustivel,
                        Cor = cor
                    };
                }

                adapter = null; dataset = null;

                return veiculo;
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #endregion

        #region Cliente

        #region Atualizar Cliente
        public void AtualizarCliente(Cliente cliente)
        {
            try
            {
                _connection.Open();
                var query = SqlManager.GetSql(TSql.ATUALIZAR_CLIENTE);
                var command = new SqlCommand(query, _connection);

                command.Parameters.Add("@id", SqlDbType.VarChar).Value = cliente.Id;
                //command.Parameters.Add("@idPessoa", SqlDbType.SmallInt).Value = cliente.Pessoa.Id;
                command.Parameters.Add("@idPessoa", SqlDbType.SmallInt).Value = cliente.Pessoa;
                command.Parameters.Add("@ativo", SqlDbType.Bit).Value = cliente.Ativo ? 1 : 0;
                command.Parameters.Add("@dataCadastro", SqlDbType.DateTime).Value = cliente.DataCadastro;

                command.ExecuteNonQuery();

            }
            catch (Exception ex) { throw ex; }
            finally { if (_connection.State == ConnectionState.Open) { _connection.Close(); } }
        }
        #endregion

        #region Cadastrar Cliente
        public void CadastrarCliente(Cliente cliente)
        {
            try
            {
                _connection.Open();
                var query = SqlManager.GetSql(TSql.CADASTRAR_CLIENTE);
                var command = new SqlCommand(query, _connection);

                command.Parameters.Add("@id", SqlDbType.VarChar).Value = cliente.Id;
                //command.Parameters.Add("@idPessoa", SqlDbType.SmallInt).Value = cliente.Pessoa.Id;
                command.Parameters.Add("@idPessoa", SqlDbType.SmallInt).Value = cliente.Pessoa;
                command.Parameters.Add("@ativo", SqlDbType.Bit).Value = cliente.Ativo ? 1 : 0;
                command.Parameters.Add("@dataCadastro", SqlDbType.DateTime).Value = cliente.DataCadastro;

                command.ExecuteNonQuery();

            }
            catch (Exception ex) { throw ex; }
            finally { if (_connection.State == ConnectionState.Open) { _connection.Close(); } }
        }
        #endregion

        #region Excluir Cliente
        public void ExcluirCliente(string id)
        {
            try
            {
                _connection.Open();
                var query = SqlManager.GetSql(TSql.EXCLUIR_CLIENTE);
                var command = new SqlCommand(query, _connection);

                command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;

                command.ExecuteNonQuery();

            }
            catch (Exception ex) { throw ex; }
            finally { if (_connection.State == ConnectionState.Open) { _connection.Close(); } }
        }
        #endregion

        #region Listar Cliente
        public List<Cliente> ListarCliente()
        {
            var clientes = new List<Cliente>();
            try
            {
                var query = SqlManager.GetSql(TSql.LISTAR_CLIENTE);
                var command = new SqlCommand(query, _connection);
                var dataset = new DataSet();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dataset);

                var rows = dataset.Tables[0].Rows;

                foreach (DataRow item in rows)
                {
                    var colunas = item.ItemArray;

                    var id = colunas[0].ToString();
                    var pessoa = int.Parse(colunas[1].ToString());
                    var ativo = bool.Parse(colunas[2].ToString());
                    var dataCadastro = DateTime.Parse(colunas[3].ToString());

                    var cliente = new Cliente
                    {
                        Id = id,
                        Pessoa = pessoa,
                        Ativo = ativo,
                        DataCadastro = dataCadastro
                    };
                    clientes.Add(cliente);
                }

                adapter = null; dataset = null;

                return clientes;
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #region Pesquisar Cliente Por Id
        public Cliente PesquisarClientePorId(string id)
        {
            Cliente cliente = new Cliente();
            try
            {
                var query = SqlManager.GetSql(TSql.PESQUISAR_CLIENTE);

                var command = new SqlCommand(query, _connection);
                command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;

                var dataset = new DataSet();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dataset);

                var rows = dataset.Tables[0].Rows;

                foreach (DataRow item in rows)
                {
                    var colunas = item.ItemArray;

                    var id_cliente = colunas[0].ToString();
                    var pessoa = int.Parse(colunas[1].ToString());
                    var ativo = bool.Parse(colunas[2].ToString());
                    var dataCadastro = DateTime.Parse(colunas[3].ToString());

                    cliente = new Cliente
                    {
                        Id = id,
                        Pessoa = pessoa,
                        Ativo = ativo,
                        DataCadastro = dataCadastro
                    };
                }

                adapter = null; dataset = null;

                return cliente;
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #endregion
    }
}
