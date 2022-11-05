using Mecanica.Models.Entidades;
using Microsoft.Extensions.WebEncoders.Testing;
using System;

namespace Mecanica.Models.Dtos
{
    public class ClienteDto : EntidadeBase
    {
        #region Parametros da Classe
        public int IdPessoa { get; set; }
        public PessoaDto Pessoa { get; set; }
        public PessoaJuridicaDto PessoaJuridica { get; set; }
        public PessoaFisicaDto PessoaFisica { get; set; }
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
                //Pessoa = this.Pessoa,
                IdPessoa = this.IdPessoa,
                Ativo = this.Ativo,
                DataCadastro = this.DataCadastro
            };
        }
        #endregion
    }
}
