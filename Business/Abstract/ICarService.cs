using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllBrandId(int brandId);
        List<Car> GetAllColorId(int colorId);
        List<Car> GetByDailyPrice(int min,int max);
        List<Car> GetById(int carId);
    }
}
