using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal; //field

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            // iş kodları 
            //yetkisi var mı ?
            return _carDal.GetAll();
        }

        public Car GetAllBrandId(int brandId)
        {
            return _carDal.Get(b => b.BrandId == brandId);
        }

        public Car GetAllColorId(int colorId)
        {
            return _carDal.Get(cl => cl.ColorId == colorId);
        }

        public List<Car> GetByDailyPrice(int min, int max)
        {
            return _carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max);
        }

        public Car GetById(int carId)
        {
            return _carDal.Get(c => c.Id == carId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
