using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RpgApi.Data;
using RpgApi.Models;


namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArmasController : ControllerBase
    {
         private readonly DataContext _context;
        

        public ArmasController(DataContext context)
        {
            _context = context;
        }
   

      [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            try 
            {
                Armas ar = await _context.TB_ARMAS
                    .FirstOrDefaultAsync(arBusca => arBusca.Id == id);

                    return Ok(ar);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<Armas> lista = await _context.TB_ARMAS.ToListAsync();
                return Ok(lista);
            }
            catch (SystemException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(Armas novoArma)
        {
            try
            {
                if (novoArma.Dano > 35)
                {
                    throw new Exception("Tá op demais, da uma nerfada ai");
                }
                if (novoArma.Dano <= 0)
                {
                    throw new System.Exception("Não vai ter cura!");
                }

                Personagem p = await _context.TB_PERSONAGENS
                    .FirstOrDefaultAsync(p => p.Id == novoArma.PersonagemId);
                
                
                if (p == null)
                    throw new Exception("Não existe personagem com o Id informado");

                    Armas buscaArma = await _context.TB_ARMAS
                        .FirstOrDefaultAsync(a => a.PersonagemId == novoArma.PersonagemId);

                if(buscaArma != null)
                    throw new Exception("O personagem selecionado já contém uma arma atribuída a ele.");

                await _context.TB_ARMAS.AddAsync(novoArma);
                await _context.SaveChangesAsync();

                return Ok(novoArma.Id);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(Armas novoArma)
        {
            try
            {
                if (novoArma.Dano > 35)
                {
                    throw new System.Exception("Tá op demais, da uma nerfada ai");
                }
                if (novoArma.Dano <= 0)
                {
                    throw new System.Exception("Não vai ter cura!");
                }
                _context.TB_ARMAS.Update(novoArma);
                int linhasAfetadas = await _context.SaveChangesAsync();

                return Ok(linhasAfetadas);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete (int id)
        {
            try
            {
                Armas arRemover = await _context.TB_ARMAS.FirstOrDefaultAsync(ar => ar.Id == id);

                _context.TB_ARMAS.Remove(arRemover);
                int linhasAfetadas = await _context.SaveChangesAsync();
                return Ok(linhasAfetadas);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}