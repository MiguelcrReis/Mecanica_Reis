using Mecanica.Models.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mecanica.Models.Contracts.Repositories
{
    interface IVeiculoRepository
    {
        List<VeiculoDto> ListarVeiculos();
    }
}
