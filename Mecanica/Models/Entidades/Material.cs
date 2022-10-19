namespace Mecanica.Models.Entidades
{
    public class Material
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
        public Material()
        {
        }

        public Material(string id, string descricao, string marca, decimal valorCompra, decimal valorVenda, string codProduto)
        : this(descricao, marca, valorCompra, valorVenda, codProduto)
        {
            Id = id;
        }

        public Material(string descricao, string marca, decimal valorCompra, decimal valorVenda, string codProduto)
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
