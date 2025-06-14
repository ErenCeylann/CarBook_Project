using CarBookDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Interfaces.CarFeatureInterfaces
{
    public interface ICarFeatureRepository
    {
        List<CarFeature> GetCarFeaturesByCarId(int carId);
        void ChangCarFeatureAvailableToFalse(int id);
        void ChangCarFeatureAvailableToTrue(int id);
        void CreateCarFeatureByCar(CarFeature carFeature);
    }
}
