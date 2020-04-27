using API.Dtos;
using AutoMapper;
using Core.Entities;

namespace API.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
                .ForMember(p => p.ProductType, opts => opts.MapFrom(s => s.ProductType.Name))
                .ForMember(p => p.ProductBrand, opts => opts.MapFrom(s => s.ProductBrand.Name))
                .ForMember(p => p.PictureUrl, opts => opts.MapFrom<ProductUrlResolver>());
        }
    }
}