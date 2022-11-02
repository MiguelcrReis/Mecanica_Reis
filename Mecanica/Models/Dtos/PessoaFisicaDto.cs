using Mecanica.Models.Entidades;

namespace Mecanica.Models.Dtos
{
    public class PessoaFisicaDto
    {
        #region Parametros
        public int Id { get; set; }
        public int IdPessoa { get; set; }
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
                IdPessoa = this.IdPessoa,
                Nome = this.Nome,
                Cpf = this.Cpf
            };
        }
        #endregion
    }
}
