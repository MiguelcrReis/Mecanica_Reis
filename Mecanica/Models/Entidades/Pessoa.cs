using System;
using System.Data;

namespace Mecanica.Models.Entidades
{
    public class Pessoa
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Cliente { get; set; }
        public bool Colaborador { get; set; }
        public bool Fornecedor { get; set; }
    }
}
