using Mecanica.Models.Entidades;
using System;

namespace Mecanica.Models.Dtos
{
    public class ClienteDto : EntidadeBase
    {
        #region Parametros da Classe
        //public Pessoa Pessoa { get; set; }
        public int IdPessoa { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        #endregion

        #region Construtores
        public ClienteDto() { }
        #endregion

        #region Metodos
        public Cliente ConverteParaEntidade()
        {
            return new Cliente
            {
                Id = this.Id,
                IdPessoa = this.IdPessoa,
                Ativo = this.Ativo,
                DataCadastro = this.DataCadastro
            };
        }
        #endregion
    }
}
