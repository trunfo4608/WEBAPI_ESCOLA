using SmartSchoolAPI.Helpers;
using SmartSchoolAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartSchoolAPI.Data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        bool SaveChanges();


        Task<PageList<Aluno>> GetAllAlunosAsync(PageParams pageParams, bool includeProfessor = false);
        Aluno[] GetAllAlunos(bool includeProfessor = false);
        Aluno[] GetAllAlunosByDisciplinasId(int DisciplinaId, bool includeProfessor = false);
        Aluno GetAlunoById(int AlunoId, bool includeProfessor = false);


        Professor[] GetAllProfessores(bool includeAlunos = false);
        Professor[] GetAllProfessoresByDisciplinasId(int disciplinaId, bool includeAlunos = false);
        Professor GetProfessoreById(int professorId, bool includeProfessor = false);

    }
}
