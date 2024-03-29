﻿using AutoMapper;
using WebRozetka.Data.Entities;
using WebRozetka.Models.Category;
using WebRozetka.Models.Product;

namespace WebRozetka.Mapper
{
    public class AppMapProfile : Profile
    {
        public AppMapProfile()
        {
            CreateMap<CategoryEntity, CategoryItemViewModel>();
            CreateMap<CategoryCreateViewModel, CategoryEntity>();

            CreateMap<ProductCreateViewModel, ProductEntity>()
                .ForMember(x => x.ProductImages, opt => opt.Ignore());

            CreateMap<ProductEntity, ProductItemViewModel>()
                .ForMember(x => x.CategoryName, opt => opt.MapFrom(x => x.Category.Name))
                .ForMember(x => x.Images, opt => opt.MapFrom(x => x.ProductImages.Select(x => x.Name)));
        }
    }
}
