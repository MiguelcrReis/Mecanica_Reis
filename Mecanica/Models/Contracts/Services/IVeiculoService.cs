using Mecanica.Models.Dtos;
using Mecanica.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mecanica.Models.Contracts.Services
{
    public interface IVeiculoService : IService<VeiculoDto, string>
    {
    }
}
