using Mecanica.Models.Contracts.Contexts;
using Mecanica.Models.Contracts.Repositories;
using Mecanica.Models.Dtos;
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
        #region Instancias
        private readonly SqlConnection _connection = null;

        public ContextDataSqlServer(IConnectionManager connectionManager)
        {
            _connection = connectionManager.GetConnection();
        }
        #endregion

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
                command.Parameters.Add("@anoFabricacao", SqlDbType.Int).Value = veiculo.AnoFabricacao;
                command.Parameters.Add("@anoModelo", SqlDbType.Int).Value = veiculo.AnoModelo;
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
                        Id = id_veiculo,
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
                command.Parameters.Add("@idPessoa", SqlDbType.SmallInt).Value = cliente.Pessoa.Id;
                //command.Parameters.Add("@idPessoa", SqlDbType.SmallInt).Value = cliente.IdPessoa;
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
                command.Parameters.Add("@idPessoa", SqlDbType.SmallInt).Value = cliente.Pessoa.Id;
                //command.Parameters.Add("@idPessoa", SqlDbType.SmallInt).Value = cliente.IdPessoa;
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
                    var idPessoa = int.Parse(colunas[1].ToString());
                    var ativo = bool.Parse(colunas[2].ToString());
                    var dataCadastro = DateTime.Parse(colunas[3].ToString());

                    var cliente = new Cliente
                    {
                        Id = id,
                        Pessoa = new PessoaDto(idPessoa),
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
                    var idPessoa = int.Parse(colunas[1].ToString());
                    var ativo = bool.Parse(colunas[2].ToString());
                    var dataCadastro = DateTime.Parse(colunas[3].ToString());

                    cliente = new Cliente
                    {
                        Id = id_cliente,
                        Pessoa = new Pessoa(idPessoa),
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

        #region Pessoa

        #region Atualizar Pessoa
        public void AtualizarPessoa(Pessoa pessoa)
        {
            try
            {
                _connection.Open();
                var query = SqlManager.GetSql(TSql.ATUALIZAR_PESSOA);
                var command = new SqlCommand(query, _connection);

                command.Parameters.Add("@id", SqlDbType.SmallInt).Value = pessoa.Id;
                command.Parameters.Add("@tipoPessoa", SqlDbType.SmallInt).Value = int.Parse(pessoa.TipoPessoa.ToString());
                command.Parameters.Add("@dataCadastro", SqlDbType.DateTime).Value = pessoa.DataCadastro;
                command.Parameters.Add("@pessoa", SqlDbType.Bit).Value = pessoa.Cliente ? 1 : 0;
                command.Parameters.Add("@colaborador", SqlDbType.Bit).Value = pessoa.Colaborador ? 1 : 0;
                command.Parameters.Add("@fornecedor", SqlDbType.Bit).Value = pessoa.Fornecedor ? 1 : 0;

                command.ExecuteNonQuery();
            }
            catch (Exception ex) { throw ex; }
            finally { if (_connection.State == ConnectionState.Open) { _connection.Close(); } }
        }
        #endregion

        #region Cadastrar Pessoa
        public int CadastrarPessoa(Pessoa pessoa)
        {
            try
            {
                _connection.Open();
                var query = SqlManager.GetSql(TSql.CADASTRAR_PESSOA);
                var command = new SqlCommand(query, _connection);

                command.Parameters.Add("@tipoPessoa", SqlDbType.SmallInt).Value = int.Parse(pessoa.TipoPessoa.ToString());
                command.Parameters.Add("@dataCadastro", SqlDbType.DateTime).Value = pessoa.DataCadastro;
                command.Parameters.Add("@cliente", SqlDbType.Bit).Value = pessoa.Cliente ? 1 : 0;
                command.Parameters.Add("@colaborador", SqlDbType.Bit).Value = pessoa.Colaborador ? 1 : 0;
                command.Parameters.Add("@fornecedor", SqlDbType.Bit).Value = pessoa.Fornecedor ? 1 : 0;

                //command.ExecuteNonQuery();

                SqlDataReader reader = command.ExecuteReader();
                var dt = new DataTable();
                dt.Load(reader);
                reader.Close();

                int idPessoa = int.Parse(dt.Rows[0][0].ToString());

                return idPessoa;
            }
            catch (Exception ex) { throw ex; }
            finally { if (_connection.State == ConnectionState.Open) { _connection.Close(); } }
        }
        #endregion

        #region Excluir Pessoa
        public void ExcluirPessoa(int id)
        {
            try
            {
                _connection.Open();
                var query = SqlManager.GetSql(TSql.EXCLUIR_PESSOA);
                var command = new SqlCommand(query, _connection);

                command.Parameters.Add("@id", SqlDbType.SmallInt).Value = id;

                command.ExecuteNonQuery();

            }
            catch (Exception ex) { throw ex; }
            finally { if (_connection.State == ConnectionState.Open) { _connection.Close(); } }
        }
        #endregion

        #region Listar Pessoa
        public List<Pessoa> ListarPessoa()
        {
            var pessoas = new List<Pessoa>();
            try
            {
                var query = SqlManager.GetSql(TSql.LISTAR_PESSOA);
                var command = new SqlCommand(query, _connection);
                var dataset = new DataSet();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dataset);

                var rows = dataset.Tables[0].Rows;

                foreach (DataRow item in rows)
                {
                    var colunas = item.ItemArray;

                    var id = int.Parse(colunas[0].ToString());
                    var tipoPessoa = (TipoPessoa)int.Parse(colunas[1].ToString());
                    var dataCadastro = DateTime.Parse(colunas[2].ToString());
                    var cliente = bool.Parse(colunas[3].ToString());
                    var colaborador = bool.Parse(colunas[4].ToString());
                    var fornecedor = bool.Parse(colunas[5].ToString());

                    var pessoa = new Pessoa
                    {
                        Id = id,
                        TipoPessoa = tipoPessoa,
                        DataCadastro = dataCadastro,
                        Cliente = cliente,
                        Colaborador = colaborador,
                        Fornecedor = fornecedor
                    };
                    pessoas.Add(pessoa);
                }

                adapter = null; dataset = null;

                return pessoas;
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #region Pesquisar Pessoa Por Id
        public Pessoa PesquisarPessoaPorId(int id)
        {
            Pessoa pessoa = new Pessoa();

            try
            {
                _connection.Open();
                var query = SqlManager.GetSql(TSql.PESQUISAR_PESSOA);
                var command = new SqlCommand(query, _connection);

                command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;

                var dataset = new DataSet();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dataset);

                var rows = dataset.Tables[0].Rows;

                foreach (DataRow item in rows)
                {
                    var colunas = item.ItemArray;

                    var id_pessoa = int.Parse(colunas[0].ToString());
                    var dataCadastro = DateTime.Parse(colunas[1].ToString());
                    var cliente = bool.Parse(colunas[2].ToString());
                    var colaborador = bool.Parse(colunas[3].ToString());
                    var fornecedor = bool.Parse(colunas[4].ToString());

                    pessoa = new Pessoa
                    {
                        Id = id_pessoa,
                        DataCadastro = dataCadastro,
                        Cliente = cliente,
                        Colaborador = colaborador,
                        Fornecedor = fornecedor
                    };
                }

                adapter = null; dataset = null;

                return pessoa;

            }
            catch (Exception ex) { throw ex; }
            finally { if (_connection.State == ConnectionState.Open) { _connection.Close(); } }
        }
        #endregion

        #endregion

        #region Pessoa Juridica

        #region Atualizar Pessoa Juridica
        public void AtualizarPessoaJuridica(PessoaJuridica pessoaJuridica)
        {
            try
            {
                _connection.Open();
                var query = SqlManager.GetSql(TSql.ATUALIZAR_PESSOA_JURIDICA);
                var command = new SqlCommand(query, _connection);

                command.Parameters.Add("@id", SqlDbType.SmallInt).Value = pessoaJuridica.Id;
                command.Parameters.Add("@idPessoa", SqlDbType.SmallInt).Value = pessoaJuridica.Pessoa.Id;
                //command.Parameters.Add("@idPessoa", SqlDbType.SmallInt).Value = pessoaJuridica.IdPessoa;
                command.Parameters.Add("@nomeFantasia", SqlDbType.VarChar).Value = pessoaJuridica.NomeFantasia;
                command.Parameters.Add("@razaoSocial", SqlDbType.VarChar).Value = pessoaJuridica.RazaoSocial;
                command.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = pessoaJuridica.Cnpj;

                command.ExecuteNonQuery();
            }
            catch (Exception ex) { throw ex; }
            finally { if (_connection.State == ConnectionState.Open) { _connection.Close(); } }
        }
        #endregion

        #region Cadastrar Pessoa Juridica
        public void CadastrarPessoaJuridica(PessoaJuridica pessoaJuridica)
        {
            try
            {
                _connection.Open();
                var query = SqlManager.GetSql(TSql.CADASTRAR_PESSOA_JURIDICA);
                var command = new SqlCommand(query, _connection);

                command.Parameters.Add("@id", SqlDbType.SmallInt).Value = pessoaJuridica.Id;
                command.Parameters.Add("@idPessoa", SqlDbType.SmallInt).Value = pessoaJuridica.Pessoa.Id;
                //command.Parameters.Add("@idPessoa", SqlDbType.SmallInt).Value = pessoaJuridica.IdPessoa;
                command.Parameters.Add("@nomeFantasia", SqlDbType.VarChar).Value = pessoaJuridica.NomeFantasia;
                command.Parameters.Add("@razaoSocial", SqlDbType.VarChar).Value = pessoaJuridica.RazaoSocial;
                command.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = pessoaJuridica.Cnpj;

                command.ExecuteNonQuery();

            }
            catch (Exception ex) { throw ex; }
            finally { if (_connection.State == ConnectionState.Open) { _connection.Close(); } }
        }
        #endregion

        #region Excluir Pessoa Juridica
        public void ExcluirPessoaJuridica(int id)
        {
            try
            {
                _connection.Open();
                var query = SqlManager.GetSql(TSql.EXCLUIR_PESSOA_JURIDICA);
                var command = new SqlCommand(query, _connection);

                command.Parameters.Add("@id", SqlDbType.SmallInt).Value = id;

                command.ExecuteNonQuery();

            }
            catch (Exception ex) { throw ex; }
            finally { if (_connection.State == ConnectionState.Open) { _connection.Close(); } }
        }
        #endregion

        #region Listar Pessoa Juridica
        public List<PessoaJuridica> ListarPessoaJuridica()
        {
            var pessoasJuridicas = new List<PessoaJuridica>();
            try
            {
                var query = SqlManager.GetSql(TSql.LISTAR_PESSOA_JURIDICA);
                var command = new SqlCommand(query, _connection);
                var dataset = new DataSet();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dataset);

                var rows = dataset.Tables[0].Rows;

                foreach (DataRow item in rows)
                {
                    var colunas = item.ItemArray;

                    var id = int.Parse(colunas[0].ToString());
                    var idPessoa = int.Parse(colunas[1].ToString());
                    var nomeFantasia = (colunas[2].ToString());
                    var razaoSocial = (colunas[3].ToString());
                    var cnpj = (colunas[4].ToString());


                    var pessoaJuridica = new PessoaJuridica
                    {
                        Id = id,
                        Pessoa = new Pessoa(idPessoa),
                        NomeFantasia = nomeFantasia,
                        RazaoSocial = razaoSocial,
                        Cnpj = cnpj
                    };
                    pessoasJuridicas.Add(pessoaJuridica);
                }

                adapter = null; dataset = null;

                return pessoasJuridicas;
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #region Pesquisar Pessoa Juridica Por Id
        public PessoaJuridica PesquisarPessoaJuridicaPorId(int id)
        {
            PessoaJuridica pessoaJuridica = new PessoaJuridica();

            try
            {
                _connection.Open();
                var query = SqlManager.GetSql(TSql.PESQUISAR_PESSOA_JURIDICA);
                var command = new SqlCommand(query, _connection);

                command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;

                var dataset = new DataSet();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dataset);

                var rows = dataset.Tables[0].Rows;

                foreach (DataRow item in rows)
                {
                    var colunas = item.ItemArray;

                    var idPessoaJuridica = int.Parse(colunas[0].ToString());
                    var idPessoa = int.Parse(colunas[1].ToString());
                    var nomeFantasia = (colunas[2].ToString());
                    var razaoSocial = (colunas[3].ToString());
                    var cnpj = (colunas[4].ToString());

                    pessoaJuridica = new PessoaJuridica
                    {
                        Id = idPessoaJuridica,
                        Pessoa = new Pessoa(idPessoa),
                        NomeFantasia = nomeFantasia,
                        RazaoSocial = razaoSocial,
                        Cnpj = cnpj
                    };
                }

                adapter = null; dataset = null;

                return pessoaJuridica;

            }
            catch (Exception ex) { throw ex; }
            finally { if (_connection.State == ConnectionState.Open) { _connection.Close(); } }
        }
        #endregion

        #endregion

        #region Pessoa Fisica

        #region Atualizar Pessoa Fisica
        public void AtualizarPessoaFisica(PessoaFisica pessoaFisica)
        {
            try
            {
                _connection.Open();
                var query = SqlManager.GetSql(TSql.ATUALIZAR_PESSOA_FISICA);
                var command = new SqlCommand(query, _connection);

                command.Parameters.Add("@id", SqlDbType.SmallInt).Value = pessoaFisica.Id;
                command.Parameters.Add("@idPessoa", SqlDbType.SmallInt).Value = pessoaFisica.Pessoa.Id;
                //command.Parameters.Add("@idPessoa", SqlDbType.SmallInt).Value = pessoaFisica.IdPessoa;
                command.Parameters.Add("@nome", SqlDbType.VarChar).Value = pessoaFisica.Nome;
                command.Parameters.Add("@cpf", SqlDbType.VarChar).Value = pessoaFisica.Cpf;

                command.ExecuteNonQuery();

            }
            catch (Exception ex) { throw ex; }
            finally { if (_connection.State == ConnectionState.Open) { _connection.Close(); } }
        }
        #endregion

        #region Cadastrar Pessoa Fisica
        public void CadastrarPessoaFisica(PessoaFisica pessoaFisica)
        {
            try
            {
                _connection.Open();
                var query = SqlManager.GetSql(TSql.CADASTRAR_PESSOA_FISICA);
                var command = new SqlCommand(query, _connection);

                command.Parameters.Add("@id", SqlDbType.SmallInt).Value = pessoaFisica.Id;
                command.Parameters.Add("@idPessoa", SqlDbType.SmallInt).Value = pessoaFisica.Pessoa.Id;
                //command.Parameters.Add("@idPessoa", SqlDbType.SmallInt).Value = pessoaFisica.IdPessoa;
                command.Parameters.Add("@nome", SqlDbType.VarChar).Value = pessoaFisica.Nome;
                command.Parameters.Add("@cpf", SqlDbType.VarChar).Value = pessoaFisica.Cpf;

                command.ExecuteNonQuery();

            }
            catch (Exception ex) { throw ex; }
            finally { if (_connection.State == ConnectionState.Open) { _connection.Close(); } }
        }
        #endregion

        #region Excluir Pessoa Fisica
        public void ExcluirPessoaFisica(int id)
        {
            try
            {
                _connection.Open();
                var query = SqlManager.GetSql(TSql.EXCLUIR_PESSOA_FISICA);
                var command = new SqlCommand(query, _connection);

                command.Parameters.Add("@id", SqlDbType.SmallInt).Value = id;

                command.ExecuteNonQuery();

            }
            catch (Exception ex) { throw ex; }
            finally { if (_connection.State == ConnectionState.Open) { _connection.Close(); } }
        }
        #endregion

        #region Listar Pessoa Fisica
        public List<PessoaFisica> ListarPessoaFisica()
        {
            var pessoasFisicas = new List<PessoaFisica>();
            try
            {
                var query = SqlManager.GetSql(TSql.LISTAR_PESSOA_FISICA);
                var command = new SqlCommand(query, _connection);
                var dataset = new DataSet();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dataset);

                var rows = dataset.Tables[0].Rows;

                foreach (DataRow item in rows)
                {
                    var colunas = item.ItemArray;

                    var id = int.Parse(colunas[0].ToString());
                    var idPessoa = int.Parse(colunas[1].ToString());
                    var nome = (colunas[2].ToString());
                    var cpf = (colunas[3].ToString());


                    var pessoaFisica = new PessoaFisica
                    {
                        Id = id,
                        Pessoa = new Pessoa(idPessoa),
                        Nome = nome,
                        Cpf = cpf
                    };
                    pessoasFisicas.Add(pessoaFisica);
                }

                adapter = null; dataset = null;

                return pessoasFisicas;
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #region Pesquisar Pessoa Fisica Por Id
        public PessoaFisica PesquisarPessoaFisicaPorId(int id)
        {
            PessoaFisica pessoaFisica = new PessoaFisica();

            try
            {
                _connection.Open();
                var query = SqlManager.GetSql(TSql.PESQUISAR_PESSOA_FISICA);
                var command = new SqlCommand(query, _connection);

                command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;

                var dataset = new DataSet();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dataset);

                var rows = dataset.Tables[0].Rows;

                foreach (DataRow item in rows)
                {
                    var colunas = item.ItemArray;

                    var idPessoaFisica = int.Parse(colunas[0].ToString());
                    var idPessoa = int.Parse(colunas[1].ToString());
                    var nome = (colunas[2].ToString());
                    var cpf = (colunas[3].ToString());

                    pessoaFisica = new PessoaFisica
                    {
                        Id = idPessoaFisica,
                        Pessoa = new Pessoa(idPessoa),
                        Nome = nome,
                        Cpf = cpf
                    };
                }

                adapter = null; dataset = null;

                return pessoaFisica;

            }
            catch (Exception ex) { throw ex; }
            finally { if (_connection.State == ConnectionState.Open) { _connection.Close(); } }
        }
        #endregion

        #endregion
    }
}
