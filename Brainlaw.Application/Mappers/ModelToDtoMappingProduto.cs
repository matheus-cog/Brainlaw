using AutoMapper;
using Brainlaw.Application.DTO;
using Brainlaw.Domain.Models;

namespace Brainlaw.Application.Mappers
{
    public class ModelToDtoMappingProduto : Profile
    {
        public ModelToDtoMappingProduto()
        {
            ProdutoDTOMap();
        }
        private void ProdutoDTOMap()
        {
            CreateMap<Produto, ProdutoDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(x => x.Nome))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(x => x.Status));
        }
    }
}
