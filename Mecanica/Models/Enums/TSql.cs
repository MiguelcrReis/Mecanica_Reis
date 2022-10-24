using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mecanica.Models.Enums
{
    public enum TSql
    {
        #region Veiculo
        CADASTRAR_VEICULO,
        LISTAR_VEICULO,
        PESQUISAR_VEICULO,
        ATUALIZAR_VEICULO,
        EXCLUIR_VEICULO,
        #endregion

        #region Cliente
        CADASTRAR_CLIENTE,
        LISTAR_CLIENTE,
        PESQUISAR_CLIENTE,
        ATUALIZAR_CLIENTE,
        EXCLUIR_CLIENTE
        #endregion
    }
}
