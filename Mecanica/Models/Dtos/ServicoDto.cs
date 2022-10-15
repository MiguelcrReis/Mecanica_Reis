namespace Mecanica.Models.Dtos
{
    public class ServicoDto
    {
        #region Parametros da Classe
        public string Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        #endregion

        #region Construtores da Classe
        public ServicoDto() { }


        #endregion
    }
}
