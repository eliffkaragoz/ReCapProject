using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<Tentity,Tcontext>
        where Tentity : class, IEntity ,new()
        where Tcontext : DbContext , new()
    {
        public void Add(Tentity entity)
        {
            //using içindeyazdığımız için ReCapProjectContext işi bitince bellekten atılacak.
            using (Tcontext context = new Tcontext())
            {
                var addedEntity = context.Entry(entity); //!
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

            };
        }

        public void Delete(Tentity entity)
        {
            using (Tcontext context = new Tcontext())
            {
                var deleteEntity = context.Entry(entity); //!
                deleteEntity.State = EntityState.Deleted;
                context.SaveChanges();

            };
        }
        public void Update(Tentity entity)
        {
            using (Tcontext context = new Tcontext())
            {
                var updateEntity = context.Entry(entity); //!
                updateEntity.State = EntityState.Modified;
                context.SaveChanges();

            };
        }



        public List<Tentity> GetAll(Expression<Func<Tentity, bool>> filter = null)
        {
            using (Tcontext context = new Tcontext())
            {
                return filter == null ? context.Set<Tentity>().ToList() : context.Set<Tentity>().Where(filter).ToList();
            }
        }

        public Tentity Get(Expression<Func<Tentity, bool>> filter)
        {
            using (Tcontext context = new Tcontext())
            {
                return context.Set<Tentity>().SingleOrDefault(filter);
            }
        }






    }
}
