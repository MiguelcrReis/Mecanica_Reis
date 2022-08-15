using Mecanica.Models.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mecanica.Models.Contracts.Services
{
    interface IVeiculoService
    {
        List<VeiculoDto> ListarVeiculos();
    }
}
