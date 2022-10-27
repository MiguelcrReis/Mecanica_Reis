using Mecanica.Models.Entidades;
using System;

namespace Mecanica.Models.Dtos
{
    public class PessoaDto
    {
        #region Parametros
        public int Id { get; set; }
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
                Id = Id,
                DataCadastro = DataCadastro,
                Cliente = Cliente,
                Colaborador = Colaborador,
                Fornecedor = Fornecedor
            };
        }
        #endregion
    }
}
