using NinjaApp.Business.Services;
using NinjaApp.Data;
using NinjaApp.Data.Interfaces;
using NinjaApp.DTOs;

namespace NinjaApp.Business.Managers
{
    public class ChartManager : IChartService
    {
        private readonly IReceiptRepository _receiptRepository;
        public ChartManager()
        {
            _receiptRepository = new DataServiceRegistration().GetReceiptRepositoryInstance();
        }

        public List<ChartDto> GetChart(int count)
        {
            List<ChartDto> chartData = new List<ChartDto>();


            var topSellingReceipts = _receiptRepository.GetTopSellingReceipts(count);


            foreach (var receipt in topSellingReceipts)
            {
                var chartItem = new ChartDto
                {
                    ProductName = receipt.ProductName,
                    SaleCount = receipt.SaleCount
                };

                chartData.Add(chartItem);
            }

            return chartData;
        }
    }
}
