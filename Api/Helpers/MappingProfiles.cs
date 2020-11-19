using API.Dtos;
using AutoMapper;
using AutoMapper.Configuration;
using Core.Entities;

namespace EShop.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
                .ForMember(d => d.ProductBrand, o => o.MapFrom(a => a.ProductBrand.Name))
                .ForMember(d => d.ProductType, o => o.MapFrom(a => a.ProductType.Name))
                .ForMember(d => d.PictureUrl,o => o.MapFrom<ProductUrlResolver>());
        }
    }
}
