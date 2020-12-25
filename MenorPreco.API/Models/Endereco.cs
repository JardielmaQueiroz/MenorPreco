namespace MenorPreco.API.Models
{
    public class Endereco
    {
        public Endereco() { }
        public Endereco(int id_endereco, string nome_logradouro, int num_logradouro, string nome_bairro, int cod_municipio, string sigla_uf, int cep, int num_latitude, int num_longitude)
        {
            this.id_endereco = id_endereco;
            this.nome_logradouro = nome_logradouro;
            this.num_logradouro = num_logradouro;
            this.nome_bairro = nome_bairro;
            this.cod_municipio = cod_municipio;
            this.cod_municipio = cod_municipio;
            this.sigla_uf = sigla_uf;
            this.cep = cep;
            this.num_latitude = num_latitude;
            this.num_longitude = num_longitude;
        }

        public int id_endereco { get; set; }
        public string nome_logradouro { get; set; }
        public int num_logradouro { get; set; }
        public string nome_bairro { get; set; }
        public int cod_municipio { get; set; }
         public string nome_municipio { get; set; }
        public string sigla_uf { get; set; }
        public int cep { get; set; }
        public double num_latitude { get; set; }
        public double num_longitude { get; set; }
    }
}