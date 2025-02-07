using Microsoft.EntityFrameworkCore;
using SmartSchoolAPI.Helpers;
using SmartSchoolAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SmartSchoolAPI.Data
{
    public class Repository : IRepository
    {
        private readonly SmartSchoolContext _context;

        public Repository(SmartSchoolContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }


        public Aluno[] GetAllAlunos(bool includeProfessor = false)
        {
            IQueryable<Aluno> query = _context.Alunos;

            if (includeProfessor)
            {
                query = query.Include(a => a.AlunoDisciplinas)
                                        .ThenInclude(ad => ad.Disciplina)
                                        .ThenInclude(d => d.Professor);
            }


            query = query.AsNoTracking().OrderBy(a => a.Id);

            return  query.ToArray();
        }


        public  async Task<PageList<Aluno>> GetAllAlunosAsync(
            PageParams pageParams,
            bool includeProfessor = false)
        {
            IQueryable<Aluno> query = _context.Alunos;

            if (includeProfessor)
            {
                query = query.Include(a => a.AlunoDisciplinas)
                                        .ThenInclude(ad => ad.Disciplina)
                                        .ThenInclude(d => d.Professor);
            }

            if (!String.IsNullOrEmpty(pageParams.Nome))
            {
                query = query.Where(a => a.Nome.ToUpper().Contains(pageParams.Nome.ToUpper())
                                         ||
                                         a.Nome.ToUpper().Contains(pageParams.Nome.ToUpper())
                                   );
            }

            if(pageParams.Matricula > 0)
            {
                query = query.Where(a => a.Matricula == pageParams.Matricula);
            }

            if (pageParams.Ativo)
            {
                query = query.Where(a => a.Ativo == pageParams.Ativo);
            }

                query = query.AsNoTracking().OrderBy(a => a.Id);


            //return await query.ToListAsync();
            return await PageList<Aluno>.CreateAsync(query, pageParams.PageNumber, pageParams.PageSize);
        }

        public Aluno[] GetAllAlunosByDisciplinasId(int DisciplinaId, bool includeProfessor = false)
        {

            IQueryable<Aluno> query = _context.Alunos;

            if (includeProfessor)
            {
                query = query.Include(a => a.AlunoDisciplinas)
                                        .ThenInclude(ad => ad.Disciplina)
                                        .ThenInclude(d => d.Professor);
            }


            query = query.AsNoTracking().OrderBy(a => a.Id)
                    .Where(al => al.AlunoDisciplinas.Any(ad => ad.DisciplinaId == DisciplinaId));

            return query.ToArray();
        }

        public Aluno GetAlunoById(int AlunoId, bool includeProfessor = false)
        {
            IQueryable<Aluno> query = _context.Alunos;

            if (includeProfessor)
            {
                query = query.Include(a => a.AlunoDisciplinas)
                                            .ThenInclude(ad => ad.Disciplina)
                                            .ThenInclude(d => d.Professor);
                                            
            }                        
            query = query.AsNoTracking().OrderBy(a => a.Id)
                    .Where(al => al.Id == AlunoId);

            return query.FirstOrDefault();
        }

        public Professor[] GetAllProfessores(bool includeAlunos = false)
        {
            IQueryable<Professor> query = _context.Professores;
            if (includeAlunos)
            {
                query = query.Include(p => p.Disciplinas)
                              .ThenInclude(d => d.AlunoDisciplinas)
                              .ThenInclude(ad => ad.Aluno);
            }

            query = query.AsNoTracking().OrderBy(p => p.Id);
            return query.ToArray();
        }

        public Professor[] GetAllProfessoresByDisciplinasId(int disciplinaId, bool includeAlunos = false)
        {
            IQueryable<Professor> query = _context.Professores;
            if (includeAlunos)
            {
                query = query.Include(p => p.Disciplinas)
                              .ThenInclude(d => d.AlunoDisciplinas)
                              .ThenInclude(ad => ad.Aluno);
            }

            query = query.AsNoTracking().OrderBy(p => p.Id)
                    .Where(al => al.Disciplinas.Any(
                          d => d.AlunoDisciplinas.Any(ad => ad.DisciplinaId == disciplinaId)
                          ));

            return query.ToArray();


        }

        public Professor GetProfessoreById(int professorId, bool includeProfessor = false)
        {
            IQueryable<Professor> query = _context.Professores;
            if (includeProfessor)
            {
                query = query.Include(p => p.Disciplinas)
                              .ThenInclude(ad => ad.AlunoDisciplinas)
                              .ThenInclude(a => a.Aluno);
            }

            query = query.AsNoTracking()
                    .OrderBy(a => a.Id)
                    .Where(p => p.Id == professorId);

            return query.FirstOrDefault();
        }



    }
}
