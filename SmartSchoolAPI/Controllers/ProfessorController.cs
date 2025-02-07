using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchoolAPI.Data;
using SmartSchoolAPI.DTO;
using SmartSchoolAPI.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SmartSchoolAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : Controller
    {
        private readonly IRepository _repo;
        public readonly IMapper _mapper;

        public ProfessorController(IRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var professores = _repo.GetAllProfessores(true);
            return Ok(_mapper.Map<IEnumerable<ProfessorDto>>(professores));
        }

        [HttpGet("GetByRegistroDto")]

        public IActionResult GetByRegistroDto()
        {
            return Ok(new ProfessorRegistroDto());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var professor = _repo.GetProfessoreById(id,false);
            if(professor == null)
            {
                return BadRequest("Professor não encontrado");
            }

            return Ok(_mapper.Map<ProfessorDto>(professor));

        }

     
        [HttpPost]
        public IActionResult Post(ProfessorRegistroDto model)
        {
            var professor = _mapper.Map<Professor>(model);

            _repo.Add(professor);

            if (_repo.SaveChanges())
            {
                return Created($"/api/professor{professor.Id}", _mapper.Map<ProfessorDto>(professor));
            }
            return BadRequest("Professor não cadastrado");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, ProfessorRegistroDto model)
        {
            var obj = _repo.GetProfessoreById(id,false);
            if(obj == null)
            {
                BadRequest("Professor não encontrado");
            }

            var professor = _mapper.Map<Professor>(model);

            _repo.Update(professor);
            if (_repo.SaveChanges())
            {
                return Created($"api/professor/{model.Id}", _mapper.Map<ProfessorDto>(obj));
            }

            return BadRequest("Professor nao foi alterado");
            
        }

        [HttpPatch]
        public IActionResult Patch(int id,Professor professor)
        {
            var obj = _repo.GetProfessoreById(id, false);
            if(obj == null)
            {
                return BadRequest("Professor não encontrado");
            }

            _repo.Update(obj);
            if (_repo.SaveChanges())
            {
                return Ok(professor);
            };

            return BadRequest("Professor não foi alterado");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {


            var result = _repo.GetProfessoreById(id, false);
            if(result == null)
            {
                return BadRequest("Professor não encontrado ");
            }

            _repo.Delete(result);
            if (_repo.SaveChanges())
            {
                return Ok("Professor deletado");
            }

            return BadRequest("Professor não foi deletado");
        }

    }
}
