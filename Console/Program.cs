using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                System.Console.WriteLine(car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice );
            }
           
            //CarTest();
            //BrandTest();
            //ColorTest();
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorName = "White" });
        }



        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandName = "Hyundai" });
            //brandManager.Delete(new Brand { BrandName = "Hyundai" });

            foreach (var brand in brandManager.GetAll())
            {
                System.Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Add(new Car { CarName = "Hyundai i20",
            //    BrandID = 3, ColorID = 5, DailyPrice = 417, Description = "automatic", ModelYear = "2010" });
            //carManager.Delete(new Car
            //{
            //    CarID = 3003,
            //    CarName = "Mercedes",
            //    BrandID = 1,
            //    ColorID = 1,
            //    DailyPrice = 417,
            //    Description = "automatic",
            //    ModelYear = "2010"
            //});


            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.Description);
            }
        }
    }
}
