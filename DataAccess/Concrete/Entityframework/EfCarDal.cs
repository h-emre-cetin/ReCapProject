﻿using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Entityframework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (ReCapCarContext context = new ReCapCarContext())

            {
                var addedEntity = context.Entry(entity); 
                addedEntity.State = EntityState.Added;   
                context.SaveChanges();                   
            }
        }

        public void Delete(Car entity)
        {
            using (ReCapCarContext context = new ReCapCarContext())

            {
                var deletedEntity = context.Entry(entity); 
                deletedEntity.State = EntityState.Deleted;   
                context.SaveChanges();                   
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (ReCapCarContext context=new ReCapCarContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);

            }       
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter)
        {
            using (ReCapCarContext context = new ReCapCarContext())
            {
                return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
            }
        }

        public Car GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public Car GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            using (ReCapCarContext context = new ReCapCarContext())

            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }

}
