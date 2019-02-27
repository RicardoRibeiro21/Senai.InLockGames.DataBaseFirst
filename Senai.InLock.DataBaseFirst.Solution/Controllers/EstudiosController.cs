using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Senai.InLock.DataBaseFirst.Solution.Domains;

namespace Senai.InLock.DataBaseFirst.Solution.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiosController : ControllerBase
    {
        [HttpGet("estudiosComJogos")]
        public IActionResult EstudiosComJogos()
        {
            //SqlConnection (conexao) + SqlCommand (comando select)
            try
            {
                using (InLockContext ctx = new InLockContext())
                {
                    return Ok(ctx.Estudios.Include("Jogos").ToList());
                }
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }
        [HttpPost]
        public IActionResult Post(Estudios estudios)
        {
            try
            {
                using (InLockContext ctx = new InLockContext())
                {
                    ctx.Estudios.Add(estudios);
                    ctx.SaveChanges();
                    return Ok();
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }
    }
}