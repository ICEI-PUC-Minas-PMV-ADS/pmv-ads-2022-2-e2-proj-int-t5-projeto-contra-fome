using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_mySQL.Data;
using API_mySQL.Models;
using NuGet.Common;
using System.Drawing;

namespace API_mySQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoacaoController : ControllerBase
    {
        private readonly APIDbContext _context;

        public DoacaoController(APIDbContext context)
        {
            _context = context;
        }

        // GET: api/Doacao
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Doacao>>> GetDoacao()
        {
            return await _context.Doacao.ToListAsync();
        }

        // GET: api/Doacao/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Doacao>>> GetDoacao(int id)
        {
            var doacao = await _context.Doacao.ToListAsync();
            //var empresa = await _context.CadastroCampanha.ToListAsync();
            if (doacao == null)
                return NotFound();

           var doacoes = doacao.Where(d => d.CadastroCampanhaidCampanha == id).ToList();

            //var innerJoin = doacao.Join( 
            //                     empresa,   
            //                     d => d.CadastroCampanhaidCampanha,   
            //                     e => e.idCampanha, 
            //                    (d, e) => new {
            //                        d.CadastroCampanhaidCampanha,
            //                        d.tipoDoacao,
            //                        d.Valor,
            //                        e.CadastroCodigo
            //                    });

            //var query = innerJoin.ToArray().ToList();
            //var idCadastoCodigo = query[0].CadastroCodigo;
            //query = innerJoin.ToArray().Where(d => d.CadastroCodigo == idCadastoCodigo).ToList();

            if (doacoes == null)
                return NotFound();
   
            return doacoes;
        }

        // PUT: api/Doacao/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDoacao(int id, Doacao doacao)
        {
            if (id != doacao.idDoacao)
            {
                return BadRequest();
            }

            _context.Entry(doacao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DoacaoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Doacao
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Doacao>> PostDoacao(Doacao doacao)
        {
            _context.Doacao.Add(doacao);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDoacao", new { id = doacao.idDoacao }, doacao);
        }

        // DELETE: api/Doacao/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDoacao(int id)
        {
            var doacao = await _context.Doacao.FindAsync(id);
            if (doacao == null)
            {
                return NotFound();
            }

            _context.Doacao.Remove(doacao);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DoacaoExists(int id)
        {
            return _context.Doacao.Any(e => e.idDoacao == id);
        }
    }
}
