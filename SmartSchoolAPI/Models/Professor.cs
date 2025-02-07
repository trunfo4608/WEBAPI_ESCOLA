using System;
using System.Collections;
using System.Collections.Generic;

namespace SmartSchoolAPI.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public int Registro { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataIni { get; set; } = DateTime.Now;
        public DateTime? DataFim { get; set; } = null;
        public bool Ativo { get; set; } = true;



        public IEnumerable<Disciplina> Disciplinas{ get; set; }


        public Professor()
        {
                
        }

        public Professor(int id, int registro, string nome, string sobreNome, string telefone)
        {
            Id = id;
            Registro = registro;
            Nome = nome;
            SobreNome = sobreNome;
            Telefone = telefone;
        }

    }
}
