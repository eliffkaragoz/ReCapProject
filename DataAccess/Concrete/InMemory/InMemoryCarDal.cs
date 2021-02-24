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
        List<Car> _car; //Global 
        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{CarID = 1, BrandID = 1, ColorID = 1, ModelYear = "2010", DailyPrice = 327 , Description = "MERCEDES VITO 2.1 CDI 190HP 119 EU6 TOUR. SELECT A348O"},
                new Car{CarID = 2, BrandID = 2, ColorID = 1, ModelYear = "2015", DailyPrice = 992 , Description = "KIA SORENTO 2.0L PRESTIGE DSL 8AT AVN"},
                new Car{CarID = 3, BrandID = 3, ColorID = 2, ModelYear = "2013", DailyPrice = 417 , Description = "RENAULT CLIO 0.9 TCE 90 HP SPORT TOURER JOY"},
                new Car{CarID = 4, BrandID = 3, ColorID = 3, ModelYear = "2017", DailyPrice = 520 , Description = "RENAULT CLIO 1.0 TCE 100 HP X-TRONIC JOY"},
                new Car{CarID = 5, BrandID = 4, ColorID = 3, ModelYear = "2009", DailyPrice = 867 , Description = "AUDI Q2 1.6 30 TDI 116 HP DESIGN STR"},
                new Car{CarID = 6, BrandID = 5, ColorID = 3, ModelYear = "2020", DailyPrice = 626 , Description = "NISSAN QASHQAI 1.6 DCI SKYPACK XTRONIC"},
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
            
        }

        public void Delete(Car car)
        {
            //Program.cs'den gelen Car new'lenerek geliyor farklı bellek nosuna sahip. _car listesinin her elemeanı da new'lendiği için farklı bellek nolarına sahipler.
            //Bu yüzden car silmemeiz için referanslarını eşleştirmemiz gerekiyor. 
            //Bu eşleştirmeyi L
            Car carToDelete = _car.SingleOrDefault(p => p.CarID  == car.CarID);
            _car.Remove(carToDelete);
        }
        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(p => p.CarID == car.CarID);
            carToUpdate.BrandID = car.BrandID;
            carToUpdate.ColorID = car.ColorID;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetByID(int carId)
        {
            return _car.Where(p => p.CarID == carId).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _car;
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        //public List<CarDetailDto> GetCarDetails()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
