using System.Collections.Generic;
using System.Linq;
using MenorPreco.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace MenorPreco.API.Controllers
{   
    [ApiController]
    [Route("v1/produtos")]
    public class ProdutoController : ControllerBase
    {   
        public List<Produto> Produtos = new List<Produto>(){
            new Produto(){
                id_produto = 1,
                desc_produto = "MARGARINA QUALY C/SAL 250G",
                valor_unitario = (float)3.99,
                id_GTIN = 7893000394117
            },
            new Produto(){
                id_produto = 2,
                desc_produto = "JILO SELECIONADO 600G",
                valor_unitario = (float)3.99,
                id_GTIN = 7899921601051
            }
        };
        public ProdutoController(){ }

        [HttpGet]
        public IActionResult Get()
        { 
            return Ok(Produtos);
        }

        [HttpGet("{GTIN}")]
        public IActionResult GetByGtin(long? GTIN)
        { 
            if(GTIN == null) return BadRequest();
            var produto = Produtos.FirstOrDefault(prod => prod.id_GTIN == (long)GTIN);
            if (produto == null) return NotFound();
            
            return Ok(produto);
        }

        [HttpGet("descricao/{desc_prod}")]
        public IActionResult GetByName(string desc_prod)
        { 
            if(desc_prod == null) return BadRequest();
            var produto = Produtos.FirstOrDefault(prod => prod.desc_produto.Contains(desc_prod.ToUpper()));
            if (produto == null) return NotFound();
            return Ok(produto);
        }
        
    }
}