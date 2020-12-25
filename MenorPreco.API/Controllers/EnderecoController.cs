using System.Collections.Generic;
using System.Linq;
using MenorPreco.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace MenorPreco.API.Controllers
{   
    [ApiController]
    [Route("v1/enderecos")]
    public class EnderecoController : ControllerBase
    {   
        public List<Endereco> Enderecos = new List<Endereco>(){
            new Endereco(){
                id_endereco = 1,
                nome_logradouro = "RUA MANOEL JOAQUIM DOS SANTOS",
                num_logradouro = 2,
                nome_bairro = "ITACIBA",
                cod_municipio = 3201308,
                nome_municipio = "CARIACICA",
                sigla_uf = "ES",
                cep = 29150270,
                num_latitude = -20.3204997,
                num_longitude = -40.3819473
            }
        };
        public EnderecoController(){ }

        [HttpGet]
        public IActionResult Get()
        { 
            return Ok(Enderecos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int? id)
        { 
            if(id == null) return BadRequest();
            var endereco = Enderecos.FirstOrDefault(end => end.id_endereco == id);
            if (endereco == null) return NotFound();          
            return Ok(endereco);
        }        
    }
}