using Mecanica.Models.Entidades;

namespace Mecanica.Models.Dtos
{
    public class PessoaJuridicaDto
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
        public PessoaJuridicaDto() { }
        #endregion

        #region Metodos
        public PessoaJuridica ConverteParaEntidade()
        {
            return new PessoaJuridica
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
