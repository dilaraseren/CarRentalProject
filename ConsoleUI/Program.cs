﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        //SOLID 
        static void Main(string[] args)
        {
            ////GetAllByDailyPriceTest();
            //GetAllByBrandTest(2);
            //ColorTest();
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.BrandName + "------" + car.ColorName);
            }
        }


        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void GetAllByDailyPriceTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetByDailyPrice(100, 200))
            {
                Console.WriteLine(car.Description);
            }
        }
        private static void GetAllByBrandTest(int brandId)
        {
            CarRentalContext context = new CarRentalContext();

            var result = context.Brands.Where(b => b.BrandId == brandId);

            foreach (var brand in result)
            {
                Console.WriteLine(brand.BrandName);
            }
        }
    }
}
