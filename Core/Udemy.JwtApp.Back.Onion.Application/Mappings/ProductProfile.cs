using AutoMapper;
using Udemy.JwtApp.Back.Onion.Application.Dto;
using Udemy.JwtApp.Back.Onion.Domain;


namespace Udemy.JwtApp.Back.Onion.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            this.CreateMap<Product,ProductListDto>().ReverseMap();
        }
    }
}
