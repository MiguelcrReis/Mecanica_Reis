using Microsoft.VisualBasic;
using System;

namespace Mecanica.Models.Entidades
{
    public class Colaborador
    {
        #region Parametros da Classe
        public string Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public DateTime Admissao { get; set; }
        public DateTime Aniverssario { get; set; }
        #endregion

        #region Construtores da Classe
        public Colaborador()
        {

        }
        #endregion
    }
}
