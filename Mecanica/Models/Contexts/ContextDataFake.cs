using Mecanica.Models.Contracts.Contexts;
using Mecanica.Models.DTOS;
using Mecanica.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mecanica.Models.Contexts
{
    public class ContextDataFake : IContextData
    {
        private static List<Veiculo> veiculos;

        public ContextDataFake()
        {
            veiculos = new List<Veiculo>();
            InitializeDataVeiculo();
        }

        #region Veiculo
        public void AtualizarVeiculo(Veiculo veiculo)
        {
            try
            {
                var objPesquisa = PesquisarVeiculoPorId(veiculo.Id);
                veiculos.Remove(objPesquisa);

                objPesquisa.Placa = veiculo.Placa;
                objPesquisa.Fabricante = veiculo.Fabricante;
                objPesquisa.Modelo = veiculo.Modelo;
                objPesquisa.AnoFabricacao = veiculo.AnoFabricacao;
                objPesquisa.AnoModelo = veiculo.AnoModelo;
                objPesquisa.Combustivel = veiculo.Combustivel;
                objPesquisa.Cor = veiculo.Cor;

                CadastrarVeiculo(objPesquisa);
            }
            catch (Exception ex) { throw ex; }
        }

        public void CadastrarVeiculo(Veiculo veiculo)
        {
            try
            {
                veiculos.Add(veiculo);
            }
            catch (Exception ex) { throw ex; }
        }

        public void ExcluirVeiculo(string id)
        {
            try
            {
                var objPesquisa = PesquisarVeiculoPorId(id);
                veiculos.Remove(objPesquisa);
            }
            catch (Exception ex) { throw ex; }
        }

        public List<Veiculo> ListarVeiculo()
        {
            try
            {
                return veiculos.OrderBy(p => p.Fabricante).ToList();
            }
            catch (Exception ex) { throw ex; }
        }

        public Veiculo PesquisarVeiculoPorId(string id)
        {
            try
            {
                return veiculos.FirstOrDefault(p => p.Id == id);
            }
            catch (Exception ex) { throw ex; }
        }

        private void InitializeDataVeiculo()
        {
            var veiculo = new Veiculo { Placa = "AAA1234", Fabricante = "Volkswagen", Modelo = "GOL 1.6", AnoFabricacao = 2018, AnoModelo = 2018, Combustivel = "Flex", Cor = "Azul-Marinho" };
            veiculos.Add(veiculo);
            veiculo = new Veiculo { Placa = "BBB1234", Fabricante = "Chevrolet", Modelo = "Onix 1.4", AnoFabricacao = 2017, AnoModelo = 2018, Combustivel = "Flex", Cor = "Prata" };
            veiculos.Add(veiculo);
            veiculo = new Veiculo { Placa = "CCC1234", Fabricante = "Fiat", Modelo = "Uno 900", AnoFabricacao = 1999, AnoModelo = 2000, Combustivel = "Flex", Cor = "Roxo" };
            veiculos.Add(veiculo);
            veiculo = new Veiculo { Placa = "DDD1234", Fabricante = "Honda", Modelo = "Civic 2.0", AnoFabricacao = 2022, AnoModelo = 2023, Combustivel = "Flex", Cor = "Vermelho" };
            veiculos.Add(veiculo);
            veiculo = new Veiculo { Placa = "EEE1234", Fabricante = "Renault", Modelo = "Logan 1.0", AnoFabricacao = 2020, AnoModelo = 2020, Combustivel = "Flex", Cor = "Branco" };
            veiculos.Add(veiculo);
        }
        #endregion

        #region Cliente
        public void AtualizarCliente(Cliente veiculo)
        {
            throw new NotImplementedException();
        }

        public void CadastrarCliente(Cliente veiculo)
        {
            throw new NotImplementedException();
        }

        public void ExcluirCliente(string id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ListarCliente()
        {
            throw new NotImplementedException();
        }

        public Cliente PesquisarClientePorId(string id)
        {
            throw new NotImplementedException();
        }

        private void InitializeDataCliente()
        {

        }
        #endregion

        #region Pessoas
        public void CadastrarPessoa(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public List<Pessoa> ListarPessoa()
        {
            throw new NotImplementedException();
        }

        public Pessoa PesquisarPessoaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void AtualizarPessoa(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public void ExcluirPessoa(int id)
        {
            throw new NotImplementedException();
        }

        public void CadastrarPessoaJuridica(PessoaJuridica pessoaJuridica)
        {
            throw new NotImplementedException();
        }

        public List<PessoaJuridica> ListarPessoaJuridica()
        {
            throw new NotImplementedException();
        }

        public PessoaJuridica PesquisarPessoaJuridicaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void AtualizarPessoaJuridica(PessoaJuridica pessoaJuridica)
        {
            throw new NotImplementedException();
        }

        public void ExcluirPessoaJuridica(int id)
        {
            throw new NotImplementedException();
        }

        public void CadastrarPessoaFisica(PessoaFisica pessoaFisica)
        {
            throw new NotImplementedException();
        }

        public List<PessoaFisica> ListarPessoaFisica()
        {
            throw new NotImplementedException();
        }

        public PessoaFisica PesquisarPessoaFisicaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void AtualizarPessoaFisica(PessoaFisica pessoaFisica)
        {
            throw new NotImplementedException();
        }

        public void ExcluirPessoaFisica(int id)
        {
            throw new NotImplementedException();
        }

        int IContextData.CadastrarPessoa(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
