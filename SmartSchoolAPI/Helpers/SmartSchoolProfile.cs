using AutoMapper;
using SmartSchoolAPI.DTO;
using SmartSchoolAPI.Models;
using System;

namespace SmartSchoolAPI.Helpers
{
    public class SmartSchoolProfile : Profile
    {

        public SmartSchoolProfile()
        {
            CreateMap<Aluno,AlunoDto>()
                .ForMember(
                           dest => dest.Nome,
                           opt => opt.MapFrom(src => $"{src.Nome} {src.SobreNome}")
                           )
                .ForMember(dest => dest.Idade,
                           opt => opt.MapFrom(src => (DateTime.Now.Year - src.DataNasc.Year))
                           );

            CreateMap<AlunoDto, Aluno>();

            CreateMap<Aluno, AlunoRegistroDto>().ReverseMap();


            CreateMap<Professor, ProfessorDto>()
                    .ForMember(
                           dest => dest.Nome,
                           opt => opt.MapFrom(src => $"{src.Nome} {src.SobreNome}")
                           );

            CreateMap<ProfessorDto, Professor>();

            CreateMap<Professor, ProfessorRegistroDto>().ReverseMap();



        }
    }
}
