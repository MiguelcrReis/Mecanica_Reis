using Mecanica.Models.Dtos;
using System;

namespace Mecanica.Models.Entidades
{
    public class Veiculo : EntidadeBase
    {
        #region Parametros da Classe
        public string Placa { get; set; }
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public int AnoFabricacao { get; set; }
        public int AnoModelo { get; set; }
        public string Combustivel { get; set; }
        public string Cor { get; set; }
        #endregion

        #region Construtores da Classe
        public Veiculo()
            : base()
        {

        }
        #endregion

        #region Metodos
        public VeiculoDto ConverterParaDto()
        {
            return new VeiculoDto
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
