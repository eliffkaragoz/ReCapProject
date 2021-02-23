using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.Abstract
{
    //İnterface'ler new'lenemez.
    //Tip olarak sadece Entities'in Concrete klasöründeki referansları almaların sağladık- Kısıtlama getirdik.
    public interface IEntityRepository<T>  where T: class, IEntity, new()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        //Filter == null -> Filtrelemeden tüm datalar gelir.
        //Filtre parametresi verilirse Filtrelenmiş datalar gelir.
        List<T> GetAll(Expression<Func<T,bool>> filter = null);

        T Get(Expression<Func<T, bool>> filter); //Tek data getirmek için
      

    }
}
