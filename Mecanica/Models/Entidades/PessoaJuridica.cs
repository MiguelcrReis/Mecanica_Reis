namespace Mecanica.Models.Entidades
{
    public class PessoaJuridica
    {
        public int Id { get; set; }
        //public int IdPessoa { get; set; }
        public Pessoa Pessoa { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
    }
}
