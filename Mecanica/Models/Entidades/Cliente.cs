using Mecanica.Models.Dtos;
using Mecanica.Models.Enums;
using System;

namespace Mecanica.Models.Entidades
{
    public class Cliente : EntidadeBase
    {
        #region Parametros da Classe
        public int IdPessoa { get; set; }
        public Pessoa Pessoa { get; set; }
        public PessoaJuridica PessoaJuridica { get; set; }
        public PessoaFisica PessoaFisica { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        #endregion

        #region Construtores da Classe

        public Cliente() { }

        #endregion

        #region Metodos 
        public ClienteDto ConverteParaDto()
        {
            if ((int)Pessoa.TipoPessoa == 2)
            {
                return new ClienteDto
                {
                    Id = this.Id,
                    IdPessoa = this.IdPessoa,
                    Pessoa = this.Pessoa.ConverteParaDto(),
                    PessoaJuridica = this.PessoaJuridica.ConverteParaDto(),
                    Ativo = this.Ativo,
                    DataCadastro = this.DataCadastro
                };
            }
            else
            {
                return new ClienteDto
                {
                    Id = this.Id,
                    IdPessoa = this.IdPessoa,
                    Pessoa = this.Pessoa.ConverteParaDto(),
                    PessoaFisica = this.PessoaFisica.ConverteParaDto(),
                    Ativo = this.Ativo,
                    DataCadastro = this.DataCadastro
                };
            }
        }
        #endregion
    }
}
