using System;

namespace Mecanica.Models.Entidades
{
    public class Veiculo : EntidadeBase
    {
        #region Parametros da Classe
        public string Placa { get; set; }
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public DateTime AnoFabricacao { get; set; }
        public DateTime AnoModelo { get; set; }
        public string Combustivel { get; set; }
        public string Cor { get; set; }
        #endregion
    }
}
