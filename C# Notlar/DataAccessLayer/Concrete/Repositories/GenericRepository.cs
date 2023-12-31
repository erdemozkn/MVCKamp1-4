﻿using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context context = new Context();
        DbSet<T> _object;
        public GenericRepository()
        {
            _object = context.Set<T>();
            context.SaveChanges();
        }
        public void Delete(T obj)
        {
            _object.Remove(obj);
            context.SaveChanges();
        }

        public List<T> getList()
        {
            return _object.ToList();
        }

        public void Insert(T obj)
        {
            _object.Add(obj);
            context.SaveChanges();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T obj)
        {
            context.SaveChanges();
        }
    }
}
