using AutoMapper;

namespace MultiShop.Catalog.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Entities.Category, Dtos.CategoryDtos.GetByIdCategoryDto>().ReverseMap();
            CreateMap<Entities.Category, Dtos.CategoryDtos.UpdateCategoryDto>().ReverseMap();
            CreateMap<Entities.Category, Dtos.CategoryDtos.ResultCategoryDto>().ReverseMap();
            CreateMap<Entities.Category, Dtos.CategoryDtos.CreateCategoryDto>().ReverseMap();

            CreateMap<Entities.Product, Dtos.ProductDtos.GetByIdProductDto>().ReverseMap();
            CreateMap<Entities.Product, Dtos.ProductDtos.UpdateProductDto>().ReverseMap();
            CreateMap<Entities.Product, Dtos.ProductDtos.ResultProductDto>().ReverseMap();
            CreateMap<Entities.Product, Dtos.ProductDtos.CreateProductDto>().ReverseMap();

            CreateMap<Entities.ProductDetail,Dtos.ProductDetailDtos.CreateProductDetailDto>().ReverseMap();
            CreateMap<Entities.ProductDetail, Dtos.ProductDetailDtos.GetByIdProductDetailDto>().ReverseMap();
            CreateMap<Entities.ProductDetail, Dtos.ProductDetailDtos.UpdateProductDetailDto>().ReverseMap();
            CreateMap<Entities.ProductDetail, Dtos.ProductDetailDtos.ResultProductDetailDto>().ReverseMap();

            CreateMap<Entities.ProductImage, Dtos.ProductImageDtos.GetByIdProductImageDto>().ReverseMap();
            CreateMap<Entities.ProductImage, Dtos.ProductImageDtos.UpdateProductImageDto>().ReverseMap();
            CreateMap<Entities.ProductImage, Dtos.ProductImageDtos.ResultProductImageDto>().ReverseMap();
            CreateMap<Entities.ProductImage, Dtos.ProductImageDtos.CreateProductImageDto>().ReverseMap();

        }
    }
}
