using Mecanica.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Mecanica.Models.DTOS
{
    public class VeiculoDto
    {
        #region Parametros da Classe
        public string Id { get; set; }
        public string Placa { get; set; }
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public int AnoFabricacao { get; set; }
        public int AnoModelo { get; set; }
        public string Combustivel { get; set; }
        public string Cor { get; set; }
        #endregion

        #region Construtores da Classe
        public VeiculoDto() { }
        #endregion

        #region Metodos    
        public Veiculo ConverterParaEntidade()
        {
            return new Veiculo
            {
                Id = this.Id,
                Placa = this.Placa,
                Fabricante = this.Fabricante,
                Modelo = this.Modelo,
                AnoFabricacao = this.AnoFabricacao,
                AnoModelo = this.AnoModelo,
                Combustivel = this.Combustivel,
                Cor = this.Cor
            };
        }
        #endregion
    }
}
