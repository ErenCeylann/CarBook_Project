using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Interfaces.StatisticsInterfaces
{
    public interface IStatisticsRepository
    {
        int GetCarCount();

        int GetLocationCount();
        int GetAuthorCount();

        int GetBrandCount();
        int GetBlogCount();
        decimal GetAvgRentPriceForDaily();
        decimal GetAvgRentPriceForWeekly();
        decimal GetAvgRentPriceForMonthly();

        int GetCarCountByTransmissionIsAuto();

        string GetBrandNameByMaxCar();
        string GetBlogTitleByMaxBlogComment();

        int GetCarCountByKmLessThan1000();

        int GetCarCountByFuelGasolinaOrDisel();

        int GetCarCountByFuelElectric();

        string GetCarBrandAndModelByRentPriceDailyMax();
        string GetCarBrandAndModelByRentPriceDailyMin();
    }
}
