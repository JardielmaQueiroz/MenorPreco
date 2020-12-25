using System;
using System.Collections.Generic;

namespace MenorPreco.API.Models
{
    public class NotaFiscal
    {
        public NotaFiscal() { }
        public NotaFiscal(int cod_NCM, int cod_tipo_pagamento, int estabelecimentoId)
        {
            this.cod_NCM = cod_NCM;
            this.cod_tipo_pagamento = cod_tipo_pagamento;
            this.estabelecimentoId = estabelecimentoId;
        }
        public int cod_NCM { get; set; }
        public DateTime date_emissão { get; set; }
        public int cod_tipo_pagamento { get; set; }
        public int id_produto { get; set; }
        public IEnumerable<Produto> produtos { get; set; }
        public int estabelecimentoId { get; set; }
        public Estabelecimento estabelecimento { get; set; }
    }
}