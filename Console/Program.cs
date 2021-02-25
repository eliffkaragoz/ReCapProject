using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            //ColorTest();
            //BrandTest();
            CarManager carManager = new CarManager(new EfCarDal());


            foreach (var car in carManager.GetCarDetails().Data)
            {

                Console.WriteLine(car.Description + "    /  " + car.BrandName + "    /  " + car.ColorName + "    /  " + car.DailyPrice);
           
            }

        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Update(new Car { CarID = 1, BrandID = 1, ColorID = 6, DailyPrice = 675, Description = "BMW", ModelYear = "2015" });

            foreach (var car in carManager.GetAll().Data)
            {

                Console.WriteLine(car.Description);

            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Delete(new Brand {BrandID = 3,BrandName = "Mercedes" });
            foreach (var brand in brandManager.GetAll().Data)
            {
                System.Console.WriteLine(brand.BrandName);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorName = "pink" });
            colorManager.Add(new Color { ColorName = "black" });
            colorManager.Add(new Color { ColorName = "blue" });
            colorManager.Add(new Color { ColorName = "gray" });
            colorManager.Add(new Color { ColorName = "yellow" });



            foreach (var color in colorManager.GetAll().Data)
            {
                System.Console.WriteLine(color.ColorName);
            }

        }




    }
}
