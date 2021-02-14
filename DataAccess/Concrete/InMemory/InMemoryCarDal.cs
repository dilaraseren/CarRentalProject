using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id =1,BrandId=1,ColorId=1,ModelYear=1997,DailyPrice=100,Description="Opel Astra"},
                new Car {Id =2,BrandId=1,ColorId=2,ModelYear=1995,DailyPrice=100,Description="Opel Vectra"},
                new Car {Id =3,BrandId=2,ColorId=1,ModelYear=2013,DailyPrice=125,Description="Fiat Egea"},
                new Car {Id =4,BrandId=3,ColorId=2,ModelYear=2007,DailyPrice=120,Description="Ford Focus"},
                new Car {Id =5,BrandId=4,ColorId=2,ModelYear=2020,DailyPrice=1350,Description="Mercedes Benz"}

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            //LİNQ olmadan yaptığımız silme işlemi 
            Car carToDelete = null;
            foreach (var c in _cars)
            {
                if (car.Id==c.Id)
                {
                    carToDelete = c;
                }
            }
            _cars.Remove(carToDelete);

            //LİNQ ile yapılan silme işlemi 
            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            /*Her bir c için arabanın idsine sahip olan arabanın id 'sini bulma işlemi 
            *LİNQ -- Language Integrated Query : SQl sorguları gibi filtreleme işlemleri yapıabilir. 
            */
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByBrandId(int brandId)
        {
            return _cars.Where(b => b.BrandId == brandId).ToList();
        }

        public List<Car> GetAllByColorId(int colorId)
        {
            return _cars.Where(cl => cl.ColorId == colorId).ToList();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();         
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id ==car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

    }
}
