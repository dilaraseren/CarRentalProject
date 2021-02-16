using Business.Concrete;
using Business.Contants;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
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
            //DtoTest();
            //ResultTest();
            UserManager usersManager = new UserManager(new EfUserDal());


            var result = usersManager.GetAll();
            if (result.Success == true)
            {
                foreach (var users in result.Data)
                {
                    Console.WriteLine(users.FirstName + " " + users.LastName + "\n");
                   
                }
                Console.WriteLine(Messages.SuccessListed);
            }
            else
            {
                Console.WriteLine(result.Message);
            }


        }


        private static void ResultTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + "------" + car.ModelYear);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void DtoTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("Id \t Model Year \t Brand \t Color \t Description \t Daily Price \n");

            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.Id + "\t" + car.ModelYear + "\t\t" + car.BrandName + "\t" + car.ColorName + "\t" + car.Description + "\t" + car.DailyPrice);

            }

        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void GetAllByDailyPriceTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetByDailyPrice(100, 200).Data)
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
