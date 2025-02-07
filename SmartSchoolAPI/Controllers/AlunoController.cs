using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchoolAPI.Data;
using SmartSchoolAPI.DTO;
using SmartSchoolAPI.Helpers;
using SmartSchoolAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartSchoolAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly SmartSchoolContext _context;

        public readonly IRepository _repo;
        public readonly IMapper _mapper;
        public AlunoController( IRepository repo, IMapper mapper) {
            _repo = repo;
            _mapper = mapper;
        }

        
        [HttpGet]
        public async Task<ActionResult> Get([FromQuery]PageParams pageParams)
        {
            var alunos = await _repo.GetAllAlunosAsync(pageParams,true);

            var result = _mapper.Map<IEnumerable<AlunoDto>>(alunos);

            Response.AddPagination(alunos.CurrentPage, alunos.PageSize, alunos.TotalCount, alunos.TotalPages);

            return Ok(result);         
            
        }


        [HttpGet("GetRegistrer")]
        public ActionResult GetRegistrer()
        {


            return Ok(new AlunoRegistroDto());

        }

        // GET api/<AlunoController>/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = _repo.GetAlunoById(id, false);
            if(aluno == null)
            {
                return BadRequest("Aluno não encontrado");
            }
            
            return Ok(_mapper.Map<AlunoDto>(aluno));
        }

        // POST api/<AlunoController>
        [HttpPost]
        public IActionResult Post(AlunoRegistroDto model)
        {
            var aluno = _mapper.Map<Aluno>(model);

            _repo.Add(aluno);
            if (_repo.SaveChanges())
            {
                return Created($"/api/aluno/{aluno.Id}", _mapper.Map<AlunoDto>(aluno));
            }
            return BadRequest("Aluno não cadastrado");
        }

        // PUT api/<AlunoController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, AlunoRegistroDto model)
        {
            var obj = _repo.GetAlunoById(id);
            if(obj == null)
            {
                return BadRequest("Aluno não encontrado");
            }

            var aluno =_mapper.Map<Aluno>(model);

            _repo.Update(aluno);
            if (_repo.SaveChanges())
            {
                return Created($"/api/aluno/{model.Id}", _mapper.Map<AlunoDto>(obj));

            }

            return BadRequest("Aluno não foi alterado");

        }


        [HttpPatch("{id}")]
        public IActionResult Patch(int id, AlunoRegistroDto model)
        {
            var obj = _repo.GetProfessoreById(id);
            if(obj == null)
            {
                return BadRequest("Aluno não encotrado");
            }

            var aluno = _mapper.Map<Aluno>(model);


            _repo.Update(aluno);
            if (_repo.SaveChanges())
            {
                return Created($"/api/aluno/{model.Id}", _mapper.Map<AlunoDto>(obj));

            }

            return BadRequest("Aluno não foi alterado");
        }


        // DELETE api/<AlunoController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var aluno = _repo.GetAlunoById(id);
            if(aluno == null)
            {
                return BadRequest("Aluno não encontrado");
            }


            _repo.Delete(aluno);
            if (_repo.SaveChanges())
            {
                return Ok("Aluno deletado");

            }

            return BadRequest("Aluno não foi deletado");
        }
    }
}
