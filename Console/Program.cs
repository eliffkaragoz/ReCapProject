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
            //JoinTest();
            //CarTest();
           //CustomerTest();  //!!
            //UserTest();      
            RentTest();
        }

        private static void RentTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(new Rental { CarId = 1, CustomerId = 1, RentDate = new DateTime(2021, 02, 24)});
            foreach (var rent in rentalManager.GetAll().Data)
            {
                Console.WriteLine(rent.RentDate);
            }
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User {FirstName = "Elif", LastName = "Karagöz", Email = "eliffkaragoz00@gmail.com", Password = "123456" });
            userManager.Add(new User { FirstName = "Hatice", LastName = "Karagöz", Email = "haticekaragoz00@gmail.com", Password = "123456789" });
            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine(user.FirstName);
            }
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //customerManager.Add(new Customer { UserId = 1, CompanyName = "A" });
            customerManager.Add(new Customer {CustomerId=3, UserId = 7, CompanyName = "B" });


            var result = customerManager.GetAll();
             foreach (var customer in result.Data)
                {
                    Console.WriteLine(customer.CompanyName);
                }
            
        }

        private static void JoinTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());


            foreach (var car in carManager.GetCarDetails().Data)
            {

                Console.WriteLine(car.Description + "    /  " + car.BrandName + "    /  " + car.ColorName + "    /  " + car.DailyPrice);

            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(new Car { BrandID = 1, ColorID = 2, ModelYear ="2018",DailyPrice = 700, Description = "BMW M8 CABRİO  " });
            carManager.Add(new Car { BrandID = 2, ColorID = 1, ModelYear ="2019",DailyPrice = 900, Description = "Mercedes A180 " });

            foreach (var car in carManager.GetAll().Data)
            {

                Console.WriteLine(car.Description);

            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand {BrandName = "BMW" });
            brandManager.Add(new Brand {BrandName = "Mercedes" });
            foreach (var brand in brandManager.GetAll().Data)
            {
                System.Console.WriteLine(brand.BrandName);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorName = "white" });
            colorManager.Add(new Color { ColorName = "black" });
           



            foreach (var color in colorManager.GetAll().Data)
            {
                System.Console.WriteLine(color.ColorName);
            }

        }




    }
}
