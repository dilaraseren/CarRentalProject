using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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

        public List<Car> GetAllBrandId(int brandId)
        {
            return _carDal.GetAll(b => b.BrandId == brandId);
        }

        public List<Car> GetAllColorId(int colorId)
        {
            return _carDal.GetAll(cl => cl.ColorId == colorId);
        }

        public List<Car> GetByDailyPrice(int min, int max)
        {
            return _carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max);
        }

        public List<Car> GetById(int carId)
        {
            return _carDal.GetAll(c => c.Id == carId);
        }
    }
}
