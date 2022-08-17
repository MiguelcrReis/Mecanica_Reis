using Mecanica.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mecanica.Models.DTOS
{
    public class VeiculoDto : EntidadeBase
    {
        //public string Id { get; set; }
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public int AnoFabricacao { get; set; }
        public int AnoModelo { get; set; }
        public string Combustivel { get; set; }
        public string Cor { get; set; }

        public VeiculoDto()
        {

        }

        public VeiculoDto(string id, string fabricante, string modelo, int anoFabricacao, int anoModelo, string combustivel, string cor)
            : this(fabricante, modelo, anoFabricacao, anoModelo, combustivel, cor)
        {
            this.Id = id;

        }

        public VeiculoDto(string fabricante, string modelo, int anoFabricacao, int anoModelo, string combustivel, string cor)
        {
            this.Fabricante = fabricante;
            this.Modelo = modelo;
            this.AnoFabricacao = anoFabricacao;
            this.AnoModelo = anoModelo;
            this.Combustivel = combustivel;
            this.Cor = cor;
        }
    }
}
