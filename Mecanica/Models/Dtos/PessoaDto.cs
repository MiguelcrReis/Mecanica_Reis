using Mecanica.Models.Entidades;
using Mecanica.Models.Enums;
using System;

namespace Mecanica.Models.Dtos
{
    public class PessoaDto
    {
        #region Parametros
        public int Id { get; set; }
        public TipoPessoa TipoPessoa { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Cliente { get; set; }
        public bool Colaborador { get; set; }
        public bool Fornecedor { get; set; }
        #endregion

        #region Construtores
        public PessoaDto() { }
        #endregion

        #region Metodos
        public Pessoa ConverteParaEntidade()
        {
            return new Pessoa
            {
                Id = this.Id,
                TipoPessoa = this.TipoPessoa,
                DataCadastro = this.DataCadastro,
                Cliente = this.Cliente,
                Colaborador = this.Colaborador,
                Fornecedor = this.Fornecedor
            };
        }
        #endregion
    }
}
