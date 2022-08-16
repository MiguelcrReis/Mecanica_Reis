using Mecanica.Models.Contracts.Repositories;
using Mecanica.Models.Contracts.Services;
using Mecanica.Models.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mecanica.Models.Services
{
    public class VeiculoService : IVeiculoService
    {
        private readonly IVeiculoRepository _veiculoRepository;

        public VeiculoService(IVeiculoRepository veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }

        public List<VeiculoDto> Listar()
        {
            try
            {
                return _veiculoRepository.Listar();
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
