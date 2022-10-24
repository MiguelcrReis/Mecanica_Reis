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

                #region ATUALIZAR_VEICULO
                case TSql.ATUALIZAR_VEICULO:
                    sql = "UPDATE Veiculos SET anoModelo = @anoModelo, combustivel = @combustivel, cor = @cor FROM Veiculos " +
                        "WHERE CONVERT(varchar(36), id) = @id";
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

                #region ATUALIZAR_CLIENTE
                case TSql.ATUALIZAR_CLIENTE:
                    sql = "UPDATE [dbo].[Clientes] SET [idPessoa] = @idPessoa, [ativo] = @ativo, [dataCadastro] = @dataCadastro " +
                        "WHERE CONVERT(varchar(36), id) = @id";
                    break;
                #endregion

                #region EXCLUIR_CLIENTE
                case TSql.EXCLUIR_CLIENTE:
                    sql = "DELETE FROM Clientes WHERE CONVERT(varchar(36), id) = @id";
                    break;
                    #endregion
                    #endregion
            }

            return sql;
        }
    }
}
