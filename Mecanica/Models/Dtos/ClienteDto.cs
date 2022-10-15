using Mecanica.Models.Entidades;

namespace Mecanica.Models.DTOS
{
    public class ClienteDto : EntidadeBase
    {
        #region Parametros da Classe
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Condutor { get; set; }
        public string Cnpj { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        #endregion

        #region Construtores da Classe
        public ClienteDto() { }

        #region Cliente Pessoa Fisica
        // Cliente Pessoa Fisica
        public ClienteDto(string id, string nome, string cpf, string email, string endereco, string telefone)
            : this(nome, cpf, email, endereco, telefone)
        {
            this.Id = id;
        }

        public ClienteDto(string nome, string cpf, string email, string endereco, string telefone)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Email = email;
            this.Endereco = endereco;
            this.Telefone = telefone;
        }
        #endregion

        #region Cliente Pessoa Juridica
        // Cliente Pessoa Juridica
        public ClienteDto(string id, string razaoSocial, string nomeFantasia, string condutor, string cnpj, string email, string endereco, string telefone)
            : this(razaoSocial, nomeFantasia, condutor, cnpj, email, endereco, telefone)
        {
            this.Id = id;
        }

        public ClienteDto(string razaoSocial, string nomeFantasia, string condutor, string cnpj, string email, string endereco, string telefone)
        {
            this.RazaoSocial = razaoSocial;
            this.NomeFantasia = nomeFantasia;
            this.Condutor = condutor;
            this.Cnpj = cnpj;
            this.Email = email;
            this.Endereco = endereco;
            this.Telefone = telefone;
        }
        #endregion
        #endregion
    }
}
