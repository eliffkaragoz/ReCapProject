using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal //İnterface'ler default olarak public tanımlanmaz ama preporty'leri default olarak public tanımlanır.
    {
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);


        List<Car> GetAll();
        List<Car> GetByID(int carId);

      

    }
}

