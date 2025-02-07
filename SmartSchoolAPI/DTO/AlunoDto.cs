using System;

namespace SmartSchoolAPI.DTO
{
    public class AlunoDto
    {
        public int Id { get; set; }
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNasc { get; set; }
        public int Idade { get; set; } 
        public bool Ativo { get; set; } = true;



        
    }
}
