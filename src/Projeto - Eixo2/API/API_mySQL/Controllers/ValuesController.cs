using API_mySQL.Data;
using API_mySQL.Migrations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_mySQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ValuesController : ControllerBase
    {

        private readonly APIDbContext _context;

        public ValuesController(APIDbContext context)
        {
            _context = context;
        }


       // GET: api/<ValuesController>
        [HttpGet]
        public async Task<List<dynamic>> Get(int id)
        {
            var doacao = await _context.Doacao.ToListAsync();
            var empresa = await _context.CadastroCampanha.ToListAsync();

            var doacoes = doacao.Where(d => d.CadastroCampanhaidCampanha == id).ToList();

            var innerJoin = doacao.Join(
                                 empresa,
                                 d => d.CadastroCampanhaidCampanha,
                                 e => e.idCampanha,
                                (d, e) => new
                                {
                                    d.CadastroCampanhaidCampanha,
                                    d.tipoDoacao,
                                    d.Valor,
                                    e.CadastroCodigo
                                });

            var query = innerJoin.ToArray().ToList();

            List<dynamic> result = new List<dynamic>();
            
            foreach (var item in query)
                if (item.CadastroCampanhaidCampanha == id)
                    result.Add(item);
            
            var texto = string.Join(",", result.ToArray());

            //{ CadastroCodigo = 4 }
            var idCadastoCodigo = texto.Substring(texto.Length - 1, 3);
            
            query = innerJoin.ToArray().Where(d => d.CadastroCodigo.ToString().Equals(idCadastoCodigo)).ToList();

            return query.ToList<dynamic>();

        }


        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
