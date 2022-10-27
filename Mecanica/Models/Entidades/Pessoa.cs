﻿using Mecanica.Models.Dtos;
using System;
using System.Data;

namespace Mecanica.Models.Entidades
{
    public class Pessoa
    {
        #region Parametros
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Cliente { get; set; }
        public bool Colaborador { get; set; }
        public bool Fornecedor { get; set; }
        #endregion

        #region Construtores
        public Pessoa() { }
        #endregion

        #region Metodos
        public PessoaDto ConverteParaDto()
        {
            return new PessoaDto
            {
                Id = this.Id,
                DataCadastro = this.DataCadastro,
                Cliente = this.Cliente,
                Colaborador = this.Colaborador,
                Fornecedor = this.Fornecedor
            };
        }
        #endregion
    }
}
