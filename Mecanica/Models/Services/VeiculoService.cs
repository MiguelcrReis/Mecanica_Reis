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

        public void Atualizar(VeiculoDto veiculo)
        {
            try
            {
                _veiculoRepository.Atualizar(veiculo);
            }
            catch (Exception ex) { throw ex; }
        }

        public void Cadastrar(VeiculoDto veiculo)
        {
            try
            {
                _veiculoRepository.Cadastrar(veiculo);
            }
            catch (Exception ex) { throw ex; }
        }

        public List<VeiculoDto> Listar()
        {
            try
            {
                return _veiculoRepository.Listar();
            }
            catch (Exception ex) { throw ex; }
        }

        public VeiculoDto PesquisarPorId(string id)
        {
            try
            {
                return _veiculoRepository.PesquisarPorId(id);
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
