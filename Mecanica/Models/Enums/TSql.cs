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
        EXCLUIR_CLIENTE,
        #endregion

        #region Pessoa
        CADASTRAR_PESSOA,
        LISTAR_PESSOA,
        PESQUISAR_PESSOA,
        ATUALIZAR_PESSOA,
        EXCLUIR_PESSOA,
        #endregion

        #region Pessoa Juridica
        CADASTRAR_PESSOA_JURIDICA,
        LISTAR_PESSOA_JURIDICA,
        PESQUISAR_PESSOA_JURIDICA,
        ATUALIZAR_PESSOA_JURIDICA,
        EXCLUIR_PESSOA_JURIDICA,
        #endregion

        #region Pessoa Fisica
        CADASTRAR_CLIENTE_FISICA,
        CADASTRAR_PESSOA_FISICA,
        LISTAR_PESSOA_FISICA,
        PESQUISAR_PESSOA_FISICA,
        ATUALIZAR_PESSOA_FISICA,
        EXCLUIR_PESSOA_FISICA
        #endregion
    }
}
