using Mecanica.Models.Entidades;

namespace Mecanica.Models.Contracts.Repositories
{
    public interface IPessoaRepository : IRepository<Pessoa, int>
    {
        new int Cadastrar(Pessoa pessoa);
    }
}
