using Mecanica.Models.Dtos;

namespace Mecanica.Models.Entidades
{
    public class PessoaFisica
    {
        #region Parametros
        public int Id { get; set; }
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        #endregion

        #region Construtores
        public PessoaFisica() { }
        #endregion

        #region Metodos
        public PessoaFisicaDto ConverteParaDto()
        {
            return new PessoaFisicaDto
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
