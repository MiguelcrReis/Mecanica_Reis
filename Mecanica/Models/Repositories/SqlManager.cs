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
                case TSql.CADASTRAR_VEICULO:
                    sql = "INSERT INTO Veiculos (id, placa, fabricante, modelo, anoFabricacao, anoModelo, combustivel, cor) " +
                        "VALUES (CONVERT(binary(36), @id), @placa, @fabricante, @modelo, @anoFabricacao, @anoModelo, @combustivel, @cor)";
                    break;

                case TSql.LISTAR_VEICULO:
                    sql = "SELECT CONVERT(varchar(36), id) 'id', placa, fabricante, modelo, anoFabricacao, anoModelo, combustivel, cor FROM Veiculos ORDER BY Placa";
                    break;

                case TSql.PESQUISAR_VEICULO:
                    sql = "SELECT CONVERT(varchar(36), id) 'id', placa, fabricante, modelo, anoFabricacao, anoModelo, combustivel, cor FROM Veiculos WHERE id = @id ORDER BY Placa";
                    break;

                case TSql.ATUALIZAR_VEICULO:
                    sql = "UPDATE Veiculos SET anoModelo = @anoModelo, combustivel = @combustivel, cor = @cor FROM Veiculos WHERE id = @id";
                    break;

                case TSql.EXCLUIR_VEICULO:
                    sql = "DELETE FROM Veiculos WHERE id = @id";
                    break;
            }

            return sql;
        }
    }
}
