using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using apiUniversidade.Model;
using apiUniversidade.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace apiUniversidade.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/{v:apiversion}/disciplina")]
    public class DisciplinaController : ControllerBase
    {

        private readonly ILogger<DisciplinaController> _logger;
        
        private readonly apiUniversidadeContext _context;

        public DisciplinaController(ILogger<DisciplinaController> logger, apiUniversidadeContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]

        public ActionResult<IEnumerable<Disciplina>> Get()
        {

            var disciplinas = _context.Disciplinas.ToList();
            if(disciplinas is null)
                return NotFound();
            
            return disciplinas;
        }

        [HttpPost]

        public ActionResult Post(Disciplina disciplinas){
            _context.Disciplinas.Add(disciplinas);
            _context.SaveChanges();

            return new CreatedAtRouteResult("GetDisciplina",
                new { id = disciplinas.ID },
                disciplinas);
        }

        [HttpGet("{id:int}", Name="GetDisciplina")]

        public ActionResult<Disciplina> Get(int id){
            var disciplinas = _context.Disciplinas.FirstOrDefault(p => p.ID == id);
            if(disciplinas is null)
                return NotFound("Disciplina não encontrada.");

            return disciplinas;
        }

        [HttpPut("{id:int}")]

        public ActionResult Put(int id, Disciplina disciplinas){
            if(id != disciplinas.ID)
                return BadRequest();

            _context.Entry(disciplinas).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(disciplinas);
        }

        [HttpDelete("{id:int}")]

        public ActionResult Delete(int id){
            var disciplinas = _context.Disciplinas.FirstOrDefault(p => p.ID == id);

            if(disciplinas is null)
                return NotFound();

            _context.Disciplinas.Remove(disciplinas);
            _context.SaveChanges();

            return Ok(disciplinas);
        }

        // [HttpGet(Name = "GetV1")]
        // [Route("version1")]

        // public String GetV1()
        // {
        //     return "Api Universidade - Versão 1.0";
        // }
    }
}