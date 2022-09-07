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
        public void Atualizar(VeiculoDto veiculo)
        {
            try
            {
                var objPesquisa = PesquisarPorId(veiculo.Id);
                ContextDataFake.Veiculos.Remove(objPesquisa);

                objPesquisa.Placa = veiculo.Placa;
                objPesquisa.Fabricante = veiculo.Fabricante;
                objPesquisa.Modelo = veiculo.Modelo;
                objPesquisa.AnoFabricacao = veiculo.AnoFabricacao;
                objPesquisa.AnoModelo = veiculo.AnoModelo;
                objPesquisa.Combustivel = veiculo.Combustivel;
                objPesquisa.Cor = veiculo.Cor;

                Cadastrar(objPesquisa);

            }
            catch (Exception ex) { throw ex; }
        }

        public void Cadastrar(VeiculoDto veiculo)
        {
            ContextDataFake.Veiculos.Add(veiculo);
        }

        public List<VeiculoDto> Listar()
        {
            var veiculos = ContextDataFake.Veiculos;
            return veiculos.OrderBy(p => p.Fabricante).ToList();
        }

        public VeiculoDto PesquisarPorId(string id)
        {
            try
            {
                var veiculo = ContextDataFake.Veiculos.FirstOrDefault(p => p.Id == id);
                return veiculo;
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
