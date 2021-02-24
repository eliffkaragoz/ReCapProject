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
            //ColorTest();
            //BrandTest();
            CarTest();

        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { CarID = 1,BrandID=1,ColorID=1,  CarName = "Mercedes ML", DailyPrice = 675, Description = "Automatic", ModelYear = "2015" });
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandID = 1, BrandName = "Mercedes" });
            foreach (var brand in brandManager.GetAll())
            {
                System.Console.WriteLine(brand.BrandName);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorID = 2, ColorName = "White" });

            foreach (var color in colorManager.GetAll())
            {
                System.Console.WriteLine(color.ColorName);
            }

        }




    }
}
