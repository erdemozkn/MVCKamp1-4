using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        void Update(T obj);
        void Insert(T obj);
        void Delete(T obj);
        List<T> getList();
        List<T> List(Expression<Func<T,bool>> filter);
    }
}
