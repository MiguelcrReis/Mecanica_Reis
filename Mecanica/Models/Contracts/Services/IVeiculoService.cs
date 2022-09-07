using Mecanica.Models.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mecanica.Models.Contracts.Services
{
    public interface IVeiculoService
    {
        void Cadastrar(VeiculoDto veiculo);
        List<VeiculoDto> Listar();
        VeiculoDto PesquisarPorId(string id);
        void Atualizar(VeiculoDto veiculo);
        void Excluir(string id);
    }
}
