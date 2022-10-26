using Mecanica.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mecanica.Models.Contracts.Contexts
{
    public interface IContextData
    {
        #region Veiculo
        void CadastrarVeiculo(Veiculo veiculo);
        List<Veiculo> ListarVeiculo();
        Veiculo PesquisarVeiculoPorId(string id);
        void AtualizarVeiculo(Veiculo veiculo);
        void ExcluirVeiculo(string id);
        #endregion

        #region Cliente
        void CadastrarCliente(Cliente cliente);
        List<Cliente> ListarCliente();
        Cliente PesquisarClientePorId(string id);
        void AtualizarCliente(Cliente cliente);
        void ExcluirCliente(string id);
        #endregion

        #region Pessoa
        void CadastrarPessoa(Pessoa pessoa);
        List<Pessoa> ListarPessoa();
        Pessoa PesquisarPessoaPorId(int id);
        void AtualizarPessoa(Pessoa pessoa);
        void ExcluirPessoa(int id);
        #endregion

        #region Pessoa Juridica
        void CadastrarPessoaJuridica(PessoaJuridica pessoaJuridica);
        List<PessoaJuridica> ListarPessoaJuridica();
        PessoaJuridica PesquisarPessoaJuridicaPorId(int id);
        void AtualizarPessoaJuridica(PessoaJuridica pessoaJuridica);
        void ExcluirPessoaJuridica(int id);
        #endregion

        #region Pessoa Fisica
        void CadastrarPessoaFisica(PessoaFisica pessoaFisica);
        List<PessoaFisica> ListarPessoaFisica();
        PessoaFisica PesquisarPessoaFisicaPorId(int id);
        void AtualizarPessoaFisica(PessoaFisica pessoaFisica);
        void ExcluirPessoaFisica(int id);
        #endregion
    }
}
