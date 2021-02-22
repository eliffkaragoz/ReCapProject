using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //İnterface'ler default olarak public tanımlanmaz ama preporty'leri default olarak public tanımlanır.
    public interface ICarDal : IEntityRepository<Car>
    {
        
    }
}

