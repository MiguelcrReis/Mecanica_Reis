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
            var veiculo = new VeiculoDto("AAA1234", "Volkswagen", "GOL 1.6", 2018, 2018, "Flex", "Azul-Marinho");
            veiculos.Add(veiculo);
            veiculo = new VeiculoDto("BBB1234", "Chevrolet", "Onix 1.4", 2017, 2018, "Flex", "Prata");
            veiculos.Add(veiculo);
            veiculo = new VeiculoDto("CCC1234", "Fiat", "Uno 900", 1999, 2000, "Flex", "Roxo");
            veiculos.Add(veiculo);
            veiculo = new VeiculoDto("DDD1234", "Honda", "Civic 2.0", 2022, 2023, "Flex", "Vermelho");
            veiculos.Add(veiculo);
            veiculo = new VeiculoDto("EEE1234", "Renault", "Logan 1.0", 2020, 2020, "Flex", "Branco");
            veiculos.Add(veiculo);
        }
    }
}
