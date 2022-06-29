using AutoMapper;
using Brainlaw.Application.DTO;
using Brainlaw.Domain.Models;

namespace Brainlaw.Application.Mappers
{
    public class DtoToModelMappingProduto : Profile
    {
        public DtoToModelMappingProduto()
        {
            ProdutoMap();
        }

        private void ProdutoMap()
        {
            CreateMap<ProdutoDTO, Produto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(x => x.Nome))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(x => x.Status));
        }
    }
}
