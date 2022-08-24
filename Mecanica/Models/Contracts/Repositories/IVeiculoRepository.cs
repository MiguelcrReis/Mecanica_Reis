using Mecanica.Models.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mecanica.Models.Contracts.Repositories
{
    public interface IVeiculoRepository
    {
        void Cadastrar(VeiculoDto veiculo);
        List<VeiculoDto> Listar();

        VeiculoDto PesquisarPorId(string id);

        void Atualizar(VeiculoDto veiculo);
    }
}
