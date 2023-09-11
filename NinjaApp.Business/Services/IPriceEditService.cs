using NinjaApp.DTOs;

namespace NinjaApp.Business.Services
{
    public interface IPriceEditService
    {
        public List<PriceEditDto> GetPriceEditDtos();
        void UpdatePriceEdit(PriceEditDto priceEditDto);
    }
}
