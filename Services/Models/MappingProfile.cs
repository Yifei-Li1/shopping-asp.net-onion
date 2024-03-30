using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain;

namespace Services.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Define mapping from the Product entity to the ProductDto
            CreateMap<Product, ProductDTO>();

            // If you have other mappings, define them here. For example:
            // CreateMap<AnotherEntity, AnotherDto>();
        }
    }
}
