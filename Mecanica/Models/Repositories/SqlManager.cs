using Mecanica.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mecanica.Models.Repositories
{
    public class SqlManager
    {
        public static string GetSql(TSql tsql)
        {
            var sql = string.Empty;

            switch (tsql)
            {
                #region Veiculo
                #region CADASTRAR_VEICULO
                case TSql.CADASTRAR_VEICULO:
                    sql = "INSERT INTO Veiculos (id, placa, fabricante, modelo, anoFabricacao, anoModelo, combustivel, cor) " +
                        "VALUES (CONVERT(binary(36), @id), @placa, @fabricante, @modelo, @anoFabricacao, @anoModelo, @combustivel, @cor)";
                    break;
                #endregion

                #region ATUALIZAR_VEICULO
                case TSql.ATUALIZAR_VEICULO:
                    sql = "UPDATE Veiculos SET anoModelo = @anoModelo, combustivel = @combustivel, cor = @cor FROM Veiculos " +
                        "WHERE CONVERT(varchar(36), id) = @id";
                    break;
                #endregion

                #region LISTAR_VEICULO
                case TSql.LISTAR_VEICULO:
                    sql = "SELECT CONVERT(varchar(36), id) 'id', placa, fabricante, modelo, anoFabricacao, anoModelo, combustivel, cor " +
                        "FROM Veiculos ORDER BY Placa";
                    break;
                #endregion

                #region PESQUISAR_VEICULO
                case TSql.PESQUISAR_VEICULO:
                    sql = "SELECT CONVERT(varchar(36), id) 'id', placa, fabricante, modelo, anoFabricacao, anoModelo, combustivel, cor " +
                        "FROM Veiculos WHERE CONVERT(varchar(36), id) = @id";
                    break;
                #endregion

                #region EXCLUIR_VEICULO
                case TSql.EXCLUIR_VEICULO:
                    sql = "DELETE FROM Veiculos WHERE CONVERT(varchar(36), id) = @id";
                    break;
                #endregion

                #endregion

                #region Cliente
                #region CADASTRAR_CLIENTE
                case TSql.CADASTRAR_CLIENTE:
                    sql = "INSERT INTO [dbo].[Clientes] ([id] ,[idPessoa] ,[ativo] ,[dataCadastro]) " +
                        "VALUES (CONVERT(binary(36), @id), @idPessoa, @ativo, @dataCadastro)";
                    break;
                #endregion

                #region ATUALIZAR_CLIENTE
                case TSql.ATUALIZAR_CLIENTE:
                    sql = "UPDATE [dbo].[Clientes] SET [idPessoa] = @idPessoa, [ativo] = @ativo, [dataCadastro] = @dataCadastro " +
                        "WHERE CONVERT(varchar(36), id) = @id";
                    break;
                #endregion

                #region LISTAR_CLIENTE
                case TSql.LISTAR_CLIENTE:
                    sql = "SELECT CONVERT(varchar(36),[id]) ,[idPessoa] ,[ativo] ,[dataCadastro] FROM [dbo].[Clientes]";
                    break;
                #endregion

                #region PESQUISAR_CLIENTE
                case TSql.PESQUISAR_CLIENTE:
                    sql = "SELECT CONVERT(varchar(36), [id]) ,[idPessoa] ,[ativo] ,[dataCadastro] FROM [dbo].[Clientes] WHERE CONVERT(varchar(36), id) = @id";
                    break;
                #endregion

                #region EXCLUIR_CLIENTE
                case TSql.EXCLUIR_CLIENTE:
                    sql = "DELETE FROM Clientes WHERE CONVERT(varchar(36), id) = @id";
                    break;
                #endregion

                #endregion

                #region Pessoa

                #region CADASTRAR_PESSOA
                case TSql.CADASTRAR_PESSOA:
                    sql = "INSERT INTO [dbo].[Pessoa] ([tipoPessoa], [dataCadastro], [cliente], [colaborador], [fornecedor])" +
                        "VALUES ('@tipoPessoa, @dataCadastro', @cliente, @colaborador, @fornecedor) " +
                        "SELECT SCOPE_IDENTITY() GO";
                    break;
                #endregion

                #region ATUALIZAR_PESSOA
                case TSql.ATUALIZAR_PESSOA:
                    sql = "UPDATE [dbo].[Pessoa] SET [tipoPessoa] = @tipoPessoa, [dataCadastro] = @dataCadastro, " +
                        "[cliente] = @cliente, [colaborador] = @colaborador, [fornecedor] = @fornecedor WHERE id = @id";
                    break;
                #endregion

                #region LISTAR_PESSOA
                case TSql.LISTAR_PESSOA:
                    sql = "SELECT * FROM [dbo].[Pessoa]";
                    break;
                #endregion

                #region PESQUISAR_PESSOA
                case TSql.PESQUISAR_PESSOA:
                    sql = "SELECT * FROM [dbo].[Pessoa] WHERE id = @id";
                    break;
                #endregion

                #region EXCLUIR_PESSOA
                case TSql.EXCLUIR_PESSOA:
                    sql = "DELETE FROM Pessoa WHERE id = @id";
                    break;
                #endregion

                #endregion

                #region Pessoa Juridica

                #region CADASTRAR_PESSOA_JURIDICA 
                case TSql.CADASTRAR_PESSOA_JURIDICA:
                    sql = "INSERT INTO [dbo].[PessoaJuridica] ([idPessoa], [nomeFantasia], [razaoSocial], [cnpj])" +
                        "VALUES (@idPessoa, @nomeFantasia, @razaoSocial, @cnpj)";
                    //"SELECT SCOPE_IDENTITY() GO";
                    break;
                #endregion

                #region ATUALIZAR_PESSOA_JURIDICA
                case TSql.ATUALIZAR_PESSOA_JURIDICA:
                    sql = "UPDATE [dbo].[PessoaJuridica] SET [idPessoa] = @idPessoa, [nomeFantasia] = @nomeFantasia, " +
                        "[razaoSocial] = @razaoSocial, [cnpj] = @cnpj WHERE id = @id";
                    break;
                #endregion

                #region LISTAR_PESSOA_JURIDICA
                case TSql.LISTAR_PESSOA_JURIDICA:
                    sql = "SELECT * FROM [dbo].[PessoaJuridica]";
                    break;
                #endregion

                #region PESQUISAR_PESSOA_JURIDICA
                case TSql.PESQUISAR_PESSOA_JURIDICA:
                    sql = "SELECT * FROM [dbo].[PessoaJuridicas] WHERE id = @id";
                    break;
                #endregion

                #region EXCLUIR_PESSOA_JURIDICA
                case TSql.EXCLUIR_PESSOA_JURIDICA:
                    sql = "DELETE FROM PessoaJuridica WHERE id = @id";
                    break;
                #endregion

                #endregion

                #region Pessoa Fisica

                #region CADASTRAR_PESSOA_FISICA 
                case TSql.CADASTRAR_PESSOA_FISICA:
                    sql = "INSERT INTO [dbo].[PessoaFisica] ([idPessoa], [nome], [cpf]) VALUES (@idPessoa, @nome, @cpf)";
                    break;
                #endregion

                #region ATUALIZAR_PESSOA_FISICA
                case TSql.ATUALIZAR_PESSOA_FISICA:
                    sql = "UPDATE [dbo].[PessoaFisica] SET [idPessoa] = @idPessoa, [nome] = @nome, [cpf] = @cpf WHERE id = @id";
                    break;
                #endregion

                #region LISTAR_PESSOA_FISICA
                case TSql.LISTAR_PESSOA_FISICA:
                    sql = "SELECT * FROM [dbo].[PessoaFisica]";
                    break;
                #endregion

                #region PESQUISAR_PESSOA_FISICA
                case TSql.PESQUISAR_PESSOA_FISICA:
                    sql = "SELECT * FROM [dbo].[PessoaFisicas] WHERE id = @id";
                    break;
                #endregion

                #region EXCLUIR_PESSOA_FISICA
                case TSql.EXCLUIR_PESSOA_FISICA:
                    sql = "DELETE FROM PessoaFisica WHERE id = @id";
                    break;

                    #endregion

                    #endregion
            }
            return sql;
        }
    }
}
