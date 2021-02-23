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
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
          if(car.Description.Length> 0 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }
        public void Update(Car car)
        {
            _carDal.Update(car);
        }
        public List<Car> GetAll()
        {
            //İş kodları
            return _carDal.GetAll();
        }

        public List<Car> GetCarsBybrandID(int id)
        {
            return _carDal.GetAll(c => c.BrandID == id);

        }

        public List<Car> GetCarsByColorID(int id)
        {
            return _carDal.GetAll(c => c.ColorID == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
