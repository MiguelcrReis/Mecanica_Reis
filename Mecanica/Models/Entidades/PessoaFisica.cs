using Mecanica.Models.Dtos;

namespace Mecanica.Models.Entidades
{
    public class PessoaFisica
    {
        #region Parametros
        public int Id { get; set; }
        public Pessoa Pessoa { get; set; }
        //public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        #endregion

        #region Construtores
        public PessoaFisica() { }
        public PessoaFisica(int id, int idPessoa, string nome, string cpf)
        {
            Id = id;
            Pessoa.Id = idPessoa;
            Nome = nome;
            Cpf = cpf;
        }
        #endregion

        #region Metodos
        public PessoaFisicaDto ConverteParaDto()
        {
            return new PessoaFisicaDto
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
