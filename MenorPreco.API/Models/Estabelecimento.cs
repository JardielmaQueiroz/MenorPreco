namespace MenorPreco.API.Models
{
    public class Estabelecimento
    {
        public Estabelecimento() { }
        public Estabelecimento(int id_estabelecimento, string name_estabelecimento, int enderecoId)
        {
            this.id_estabelecimento = id_estabelecimento;
            this.name_estabelecimento = name_estabelecimento;
            this.enderecoId = enderecoId;
        }

        public int id_estabelecimento { get; set; }
        public string name_estabelecimento { get; set; }
        public int enderecoId { get; set; }
        public Endereco endereco { get; set; }
    }
}