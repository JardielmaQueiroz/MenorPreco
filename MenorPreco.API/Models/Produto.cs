namespace MenorPreco.API.Models
{
    public class Produto
    {
        public Produto() { }
        public Produto(int id_produto, string desc_produto, float valor_unitario, int id_GTIN)
        {
            this.id_produto = id_produto;
            this.desc_produto = desc_produto;
            this.valor_unitario = valor_unitario;
            this.id_GTIN = id_GTIN;
        }
        
        public int id_produto { get; set; }
        public string desc_produto { get; set; }
        public float valor_unitario { get; set; }
        public long id_GTIN { get; set; }
    }
}