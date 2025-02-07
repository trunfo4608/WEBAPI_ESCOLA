using System;

namespace SmartSchoolAPI.Models
{
    public class AlunoDisciplina
    {

        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public int DisciplinaId { get; set; }  
        public Disciplina Disciplina{ get; set; }

        public DateTime DataInicio { get; set; } = DateTime.Now;
        public DateTime? DataFim { get; set; }
        public int? Nota { get; set; } = null;


        public AlunoDisciplina()
        {
                
        }

        public AlunoDisciplina(int alunoId, int disciplinaId)
        {
            AlunoId = alunoId;
            DisciplinaId = disciplinaId;
        }
    }
}
