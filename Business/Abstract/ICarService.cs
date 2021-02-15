using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetAllBrandId(int brandId);
        Car GetAllColorId(int colorId);
        List<Car> GetByDailyPrice(int min,int max);
        Car GetById(int carId);
        List<CarDetailDto> GetCarDetails();
    }
}
