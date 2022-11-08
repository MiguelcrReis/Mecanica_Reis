using Mecanica.Models.Entidades;
using Mecanica.Models.Enums;
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
            if ((int)Pessoa.TipoPessoa == 2)
            {
                return new Cliente
                {
                    Id = this.Id,
                    IdPessoa = this.IdPessoa,
                    Pessoa = this.Pessoa.ConverteParaEntidade(),
                    PessoaJuridica = this.PessoaJuridica.ConverteParaEntidade(),
                    //PessoaFisica = this.PessoaFisica.ConverteParaEntidade(),
                    Ativo = this.Ativo,
                    DataCadastro = this.DataCadastro
                };
            }
            else
            {
                return new Cliente
                {
                    Id = this.Id,
                    IdPessoa = this.IdPessoa,
                    Pessoa = this.Pessoa.ConverteParaEntidade(),
                    //PessoaJuridica = this.PessoaJuridica.ConverteParaEntidade(),
                    PessoaFisica = this.PessoaFisica.ConverteParaEntidade(),
                    Ativo = this.Ativo,
                    DataCadastro = this.DataCadastro
                };
            }
        }
        #endregion
    }
}
