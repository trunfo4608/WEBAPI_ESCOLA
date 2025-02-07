using System;

namespace SmartSchoolAPI.DTO
{
    public class ProfessorRegistroDto
    {

        public int Id { get; set; }
        public int Registro { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataIni { get; set; } = DateTime.Now;
        public bool Ativo { get; set; } = true;



    }
}
