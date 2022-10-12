﻿using Mecanica.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Mecanica.Models.DTOS
{
    public class VeiculoDto : EntidadeBase
    {
        #region Parametros da Classe
        public string Id { get; set; }
        public string Placa { get; set; }
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public DateTime AnoFabricacao { get; set; }
        public DateTime AnoModelo { get; set; }
        public string Combustivel { get; set; }
        public string Cor { get; set; }
        #endregion

        #region Construtores da Classe
        public VeiculoDto()
        {

        }

        public VeiculoDto(string id, string placa, string fabricante, string modelo, DateTime anoFabricacao, DateTime anoModelo, string combustivel, string cor)
            : this(placa, fabricante, modelo, anoFabricacao, anoModelo, combustivel, cor)
        {
            this.Id = id;

        }

        public VeiculoDto(string placa, string fabricante, string modelo, DateTime anoFabricacao, DateTime anoModelo, string combustivel, string cor)
        {
            this.Placa = placa;
            this.Fabricante = fabricante;
            this.Modelo = modelo;
            this.AnoFabricacao = anoFabricacao;
            this.AnoModelo = anoModelo;
            this.Combustivel = combustivel;
            this.Cor = cor;
        }
        #endregion
    }
}
