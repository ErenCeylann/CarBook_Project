using CarBookDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Dto.CarDtos;

namespace CarBook.Application.Interfaces.CarInterfaces
{
    public interface ICarRepositories
    {
        List<Car> GetCarWithBrand();
        List<Car> GetLast5CarsWithBrand();

        List<BrandCarCountDto> GetGroupBrandByCarCount();
    }
}
