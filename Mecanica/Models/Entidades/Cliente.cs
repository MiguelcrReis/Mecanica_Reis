using Mecanica.Models.Dtos;
using System;

namespace Mecanica.Models.Entidades
{
    public class Cliente : EntidadeBase
    {
        #region Parametros da Classe
        public int IdPessoa { get; set; }
        public Pessoa Pessoa { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        #endregion

        #region Construtores da Classe
        public Cliente() { }

        #region Cliente Pessoa Fisica
        //// Cliente Pessoa Fisica
        //public Cliente(string id, string nome, string cpf, string email, string endereco, string telefone)
        //    : this(nome, cpf, email, endereco, telefone)
        //{
        //    Id = id;
        //}

        //public Cliente(string nome, string cpf, string email, string endereco, string telefone)
        //{
        //    Nome = nome;
        //    Cpf = cpf;
        //    Email = email;
        //    Endereco = endereco;
        //    Telefone = telefone;
        //}
        //#endregion

        //#region Cliente Pessoa Juridica
        //// Cliente Pessoa Juridica
        //public Cliente(string id, string razaoSocial, string nomeFantasia, string cnpj, string email, string endereco, string telefone)
        //    : this(razaoSocial, nomeFantasia, cnpj, email, endereco, telefone)
        //{
        //    Id = id;
        //}

        //public Cliente(string razaoSocial, string nomeFantasia, string cnpj, string email, string endereco, string telefone)
        //{
        //    RazaoSocial = razaoSocial;
        //    NomeFantasia = nomeFantasia;
        //    Cnpj = cnpj;
        //    Email = email;
        //    Endereco = endereco;
        //    Telefone = telefone;
        //}
        #endregion

        #endregion

        #region Metodos 
        public ClienteDto ConverteParaDto()
        {
            return new ClienteDto
            {
                Id = this.Id,
                //Pessoa = this.Pessoa,
                IdPessoa = this.IdPessoa,
                Ativo = this.Ativo,
                DataCadastro = this.DataCadastro
            };
        }
        #endregion
    }
}
