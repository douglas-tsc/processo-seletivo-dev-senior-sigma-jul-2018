using AutoMapper;
using System.IO;
using TJMT.Prova.Senior.Domain.Entities;
using TJMT.Prova.Senior.MVC.ViewModels;

namespace TJMT.Prova.Senior.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {

        public override string ProfileName
        {
            get { return "ViewModelToDomainMappingProfile"; }
        }

        public ViewModelToDomainMappingProfile()
        {
            CreateMap<LivroVM, Livro>().
                ForMember
                (
                   (x => x.Capa), y => y.MapFrom(m => new BinaryReader(m.Capa.InputStream).ReadBytes(m.Capa.ContentLength))
                
                );
            CreateMap<GeneroVM, Genero>();
        }



    }
}