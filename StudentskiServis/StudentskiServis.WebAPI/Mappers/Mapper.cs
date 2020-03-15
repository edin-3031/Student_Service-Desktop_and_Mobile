using AutoMapper;
using StudentskiServis.Models;
using StudentskiServis.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiServis.WebAPI.Mappers
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<Database.Administracija, Models.AdministracijaAll>().ReverseMap();
            CreateMap<Database.Administracija, Models.AdministracijaAdmin>().ReverseMap();
            CreateMap<Database.Administracija, AdministracijaInsertRequest>().ReverseMap();
            
            CreateMap<Database.Profesor, ProfesorAdmin>().ReverseMap();
            CreateMap<Database.Profesor, ProfesorAll>().ReverseMap();
            CreateMap<Database.Profesor, ProfesorView>().ReverseMap();
            CreateMap<Database.Profesor, ProfesorSearchRequest>().ReverseMap();

            CreateMap<Database.Student, StudentAdmin>().ReverseMap();
            CreateMap<Database.Student, StudentSearchRequest>().ReverseMap();
            CreateMap<Database.Student, StudentDetalji>().ReverseMap();

            CreateMap<Database.Student, Models.STUD>().ReverseMap();
            CreateMap<Database.Profesor, Models.PROF>().ReverseMap();
            CreateMap<Database.Kurs, Models.kursevi>().ReverseMap();
            CreateMap<Models.kursevi, Database.Kurs>().ReverseMap();
            CreateMap<Database.Predaje, Models.predavanja>().ReverseMap();
            CreateMap<Models.predavanja, Database.Predaje>().ReverseMap();

            CreateMap<Models.uplate, Database.Uplata>().ReverseMap();
            CreateMap<Models.obavijesti, Database.Obavijest>().ReverseMap();


        }
    }
}
