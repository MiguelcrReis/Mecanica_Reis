namespace Mecanica.Models.Entidades
{
    public class PessoaFisica
    {
        public int Id { get; set; }
        public Pessoa Pessoa { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
    }
}
