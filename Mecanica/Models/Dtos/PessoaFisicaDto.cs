using Mecanica.Models.Entidades;

namespace Mecanica.Models.Dtos
{
    public class PessoaFisicaDto
    {
        #region Parametros
        public int Id { get; set; }
        public Pessoa Pessoa { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        #endregion

        #region Construtores
        public PessoaFisicaDto() { }
        #endregion

        #region Metodos
        public PessoaFisica ConverteParaEntidade()
        {
            return new PessoaFisica
            {
                Id = this.Id,
                Pessoa = this.Pessoa,
                Nome = this.Nome,
                Cpf = this.Cpf
            };
        }
        #endregion
    }
}
