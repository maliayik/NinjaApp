using NinjaApp.DTOs;

namespace NinjaApp.Business.Services
{
    public interface IChartService
    {
        List<ChartDto> GetChart(int count);
    }
}
