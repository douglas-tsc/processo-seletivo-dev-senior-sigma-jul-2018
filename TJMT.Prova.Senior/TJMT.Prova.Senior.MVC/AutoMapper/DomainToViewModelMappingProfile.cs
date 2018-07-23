using AutoMapper;
using System.IO;
using System.Web;
using TJMT.Prova.Senior.Domain.Entities;
using TJMT.Prova.Senior.MVC.ViewModels;

namespace TJMT.Prova.Senior.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {

        private HttpPostedFileBase _capa { get; set; }

        public override string ProfileName
        {
            get { return "DomainToViewModelMappingProfile"; }
        }

        public DomainToViewModelMappingProfile()
        {
            CreateMap<Livro, LivroVM>().ForMember
                (
                    y => y.CapaExibicao, x => x.MapFrom(p => p.Capa)
                )
                .ForMember
                (
                    y => y.Capa, x => x.MapFrom( p=> _capa )
                );
            CreateMap<Genero, GeneroVM>();
        }


    }
}