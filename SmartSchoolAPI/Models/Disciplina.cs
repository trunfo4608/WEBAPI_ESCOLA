﻿using System.Collections.Generic;

namespace SmartSchoolAPI.Models
{
    public class Disciplina
    {
        public int Id { get; set; }
        public string Nome { get; set; }     
        public int CargaHoraria { get; set; }


        public int? PrerequisitoId { get; set; } = null;
        public Disciplina PreRequisito { get; set; }
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
        public IEnumerable<AlunoDisciplina> AlunoDisciplinas { get; set; }  
        public int CursoId { get; set; }
        public Curso Curso { get; set; }



        public Disciplina()
        {
                
        }

        public Disciplina(int id, string nome, int professorId, int cursoId)
        {
            Id = id;
            Nome = nome;
            ProfessorId = professorId;
            CursoId = cursoId;
        }
    }
}
