using Mecanica.Models.Dtos;

namespace Mecanica.Models.Entidades
{
    public class PessoaJuridica
    {
        #region Parametros
        public int Id { get; set; }
        //public int IdPessoa { get; set; }
        public Pessoa Pessoa { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        #endregion

        #region Construtores
        public PessoaJuridica() { }
        #endregion

        #region Metodos
        public PessoaJuridicaDto ConverteParaDto()
        {
            return new PessoaJuridicaDto
            {
                Id = this.Id,
                Pessoa = this.Pessoa,
                NomeFantasia = this.NomeFantasia,
                RazaoSocial = this.RazaoSocial,
                Cnpj = this.Cnpj
            };
        }
        #endregion
    }
}
