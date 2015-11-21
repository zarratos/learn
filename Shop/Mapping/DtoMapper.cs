using AutoMapper;
using DAL;
using DAL.Mapping;
using Shop.Models;

namespace Shop.Mapping
{
    public class DtoMapper : IMapper
    {
        public DtoMapper()
        {
            Config();
        }

        public void Config()
        {
            Mapper.CreateMap<Product, ProductModel>()
                .ForMember(dst => dst.ProductId, src => src.MapFrom(o => o.ProductId))
                .ForMember(dst => dst.CategoryId, src => src.MapFrom(o => o.CategoryId))
                .ForMember(dst => dst.ProductName, src => src.MapFrom(o => o.ProductName))
                .ForMember(dst => dst.ProductDescription, src => src.MapFrom(o => o.ProductDescription))
                .ForMember(dst => dst.ProductDiscount, src => src.MapFrom(o => o.ProductDiscount))
                .ForMember(dst => dst.ProductPrice, src => src.MapFrom(o => o.ProductPrice))
                .ForMember(dst => dst.ImageData, src => src.MapFrom(o => o.ImageData))
                .ForMember(dst => dst.ImageMimeType, src => src.MapFrom(o => o.ImageMimeType));

            Mapper.CreateMap<ProductModel, Product>()
                .ForMember(dst => dst.CategoryId, src => src.MapFrom(o => o.CategoryId))
                .ForMember(dst => dst.ProductName, src => src.MapFrom(o => o.ProductName))
                .ForMember(dst => dst.ProductDescription, src => src.MapFrom(o => o.ProductDescription))
                .ForMember(dst => dst.ProductDiscount, src => src.MapFrom(o => o.ProductDiscount))
                .ForMember(dst => dst.ProductPrice, src => src.MapFrom(o => o.ProductPrice))
                .ForMember(dst => dst.ImageData, src => src.MapFrom(o => o.ImageData))
                .ForMember(dst => dst.ImageMimeType, src => src.MapFrom(o => o.ImageMimeType));

            Mapper.CreateMap<CategoryModel, Category>()
                .ForMember(dst => dst.CategoryId, src => src.MapFrom(o => o.CategoryId))
                .ForMember(dst => dst.CategoryName, src => src.MapFrom(o => o.CategoryName))
                .ForMember(dst => dst.ParentCategoryId, src => src.MapFrom(o => o.ParentCategoryId));

            Mapper.CreateMap<Category, CategoryModel>()
                .ForMember(dst => dst.CategoryId, src => src.MapFrom(o => o.CategoryId))
                .ForMember(dst => dst.CategoryName, src => src.MapFrom(o => o.CategoryName))
                .ForMember(dst => dst.ParentCategoryId, src => src.MapFrom(o => o.ParentCategoryId));
        }

        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return Mapper.Map<TSource, TDestination>(source);
        }

        public TDestination Map<TSource, TDestination>(TSource source, TDestination destination)
        {
            return Mapper.Map(source, destination);
        }
    }
}
