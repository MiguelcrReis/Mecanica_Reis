using Mecanica.Models.Contracts.Repositories;
using Mecanica.Models.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mecanica.Models.Repositories
{
    public class VeiculoRepository : IVeiculoRepository
    {
        public List<VeiculoDto> Listar()
        {
            var veiculos = ContextDataFake.Veiculos;
            return veiculos.OrderBy(p => p.Fabricante).ToList();
        }
    }
}
