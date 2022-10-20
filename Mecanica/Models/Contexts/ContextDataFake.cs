using Mecanica.Models.Contracts.Contexts;
using Mecanica.Models.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mecanica.Models.Contexts
{
    public class ContextDataFake : IContextData
    {
        private static List<VeiculoDto> veiculos;

        public ContextDataFake()
        {
            veiculos = new List<VeiculoDto>();
            InitializeData();
        }

        public void Atualizar(VeiculoDto veiculo)
        {
            try
            {
                var objPesquisa = PesquisarPorId(veiculo.Id);
                veiculos.Remove(objPesquisa);

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
            try
            {
                veiculos.Add(veiculo);
            }
            catch (Exception ex) { throw ex; }
        }

        public void Excluir(string id)
        {
            try
            {
                var objPesquisa = PesquisarPorId(id);
                veiculos.Remove(objPesquisa);
            }
            catch (Exception ex) { throw ex; }
        }

        public List<VeiculoDto> Listar()
        {
            try
            {
                return veiculos.OrderBy(p => p.Fabricante).ToList();
            }
            catch (Exception ex) { throw ex; }
        }

        public VeiculoDto PesquisarPorId(string id)
        {
            try
            {
                return veiculos.FirstOrDefault(p => p.Id == id);
            }
            catch (Exception ex) { throw ex; }
        }

        private void InitializeData()
        {
            var veiculo = new VeiculoDto { Placa = "AAA1234", Fabricante = "Volkswagen", Modelo = "GOL 1.6", AnoFabricacao = 2018, AnoModelo = 2018, Combustivel = "Flex", Cor = "Azul-Marinho" };
            veiculos.Add(veiculo);
            veiculo = new VeiculoDto { Placa = "BBB1234", Fabricante = "Chevrolet", Modelo = "Onix 1.4", AnoFabricacao = 2017, AnoModelo = 2018, Combustivel = "Flex", Cor = "Prata" };
            veiculos.Add(veiculo);
            veiculo = new VeiculoDto { Placa = "CCC1234", Fabricante = "Fiat", Modelo = "Uno 900", AnoFabricacao = 1999, AnoModelo = 2000, Combustivel = "Flex", Cor = "Roxo" };
            veiculos.Add(veiculo);
            veiculo = new VeiculoDto { Placa = "DDD1234", Fabricante = "Honda", Modelo = "Civic 2.0", AnoFabricacao = 2022, AnoModelo = 2023, Combustivel = "Flex", Cor = "Vermelho" };
            veiculos.Add(veiculo);
            veiculo = new VeiculoDto { Placa = "EEE1234", Fabricante = "Renault", Modelo = "Logan 1.0", AnoFabricacao = 2020, AnoModelo = 2020, Combustivel = "Flex", Cor = "Branco" };
            veiculos.Add(veiculo);
        }
    }
}
