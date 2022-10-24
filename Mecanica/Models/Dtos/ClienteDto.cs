using Mecanica.Models.Entidades;
using System;

namespace Mecanica.Models.Dtos
{
    public class ClienteDto : EntidadeBase
    {
        #region Parametros da Classe
        //public Pessoa Pessoa { get; set; }
        public int Pessoa { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        #endregion

        #region Metodos
        public Cliente ConverteParaEntidade()
        {
            return new Cliente
            {
                Id = this.Id,
                Pessoa = this.Pessoa,
                Ativo = this.Ativo,
                DataCadastro = this.DataCadastro
            };
        }
        #endregion
    }
}
