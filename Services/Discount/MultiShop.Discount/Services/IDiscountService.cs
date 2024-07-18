using MultiShop.Discount.Dtos;

namespace MultiShop.Discount.Services
{
    public interface IDiscountService
    {
        Task<List<ResultDiscountCouponDto>> GetAllDiscountCouponAsync();
        Task CreateDiscountCouponAsync(CreateDiscountCouponDto createCouponDto);

        Task DeleteDiscountCouponAsync(int id);

        Task UpdateDiscountCouponAsync(UpdateDiscountCouponDto updateCouponDto);

        Task<GetByIdDiscountCouponDto> GetByIdDiscountCouponAsync(int id);
    }
}
