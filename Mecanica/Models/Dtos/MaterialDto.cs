namespace Mecanica.Models.Dtos
{
    public class MaterialDto
    {
        #region Parametros da Classe
        public string Id { get; set; }
        public string Descricao { get; set; }
        public string Marca { get; set; }
        public decimal ValorCompra { get; set; }
        public decimal ValorVenda { get; set; }
        public string CodProduto { get; set; }
        #endregion

        #region Construtores da Classe
        public MaterialDto()
        {
        }

        public MaterialDto(string id, string descricao, string marca, decimal valorCompra, decimal valorVenda, string codProduto) 
        :this(descricao, marca, valorCompra, valorVenda, codProduto)
        {
            this.Id = id;
        }

        public MaterialDto(string descricao, string marca, decimal valorCompra, decimal valorVenda, string codProduto)
        {
            Descricao = descricao;
            Marca = marca;
            ValorCompra = valorCompra;
            ValorVenda = valorVenda;
            CodProduto = codProduto;
        }

        #endregion
    }
}
