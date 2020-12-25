using System.Collections.Generic;
using System.Linq;
using MenorPreco.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace MenorPreco.API.Controllers
{   
    [ApiController]
    [Route("v1/estabelecimentos")]
    public class EstabelecimentoController : ControllerBase
    {   
        public List<Estabelecimento> Estabelecimentos = new List<Estabelecimento>(){
            new Estabelecimento(){
                id_estabelecimento = 131966,
                name_estabelecimento = "Estabelecimento 14",
                enderecoId = 1
            }
        };
        public EstabelecimentoController(){ }

        [HttpGet]
        public IActionResult Get()
        { 
            return Ok(Estabelecimentos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int? id)
        { 
            if(id == null) return BadRequest();
            var estabelecimento = Estabelecimentos.FirstOrDefault(estab => estab.id_estabelecimento == id);
            if (estabelecimento == null) return NotFound();
            return Ok(estabelecimento);
        }

        [HttpGet("ByName/{name}")]
        public IActionResult GetByName(string name)
        { 
            if(name == null) return BadRequest();
            var estabelecimento = Estabelecimentos.FirstOrDefault(estab => estab.name_estabelecimento.Contains(name));
            if (estabelecimento == null) return NotFound();
            
            return Ok(estabelecimento);
        }
    }
}