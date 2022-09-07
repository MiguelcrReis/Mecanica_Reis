﻿using Mecanica.Models.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mecanica.Models.Repositories
{
    public static class ContextDataFake
    {
        public static List<VeiculoDto> Veiculos;

        static ContextDataFake()
        {
            Veiculos = new List<VeiculoDto>();
            InitializeData();
        }

        private static void InitializeData()
        {
            var veiculo = new VeiculoDto("AAA1234", "Volkswagen", "GOL 1.6", 2018, 2018, "Flex", "Azul-Marinho");
            Veiculos.Add(veiculo);
            veiculo = new VeiculoDto("BBB1234", "Chevrolet", "Onix 1.4", 2017, 2018, "Flex", "Prata");
            Veiculos.Add(veiculo);
            veiculo = new VeiculoDto("CCC1234", "Fiat", "Uno 900", 1999, 2000, "Flex", "Roxo");
            Veiculos.Add(veiculo);
            veiculo = new VeiculoDto("DDD1234", "Honda", "Civic 2.0", 2022, 2023, "Flex", "Vermelho");
            Veiculos.Add(veiculo);
            veiculo = new VeiculoDto("EEE1234", "Renault", "Logan 1.0", 2020, 2020, "Flex", "Branco");
            Veiculos.Add(veiculo);
        }
    }
}