using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EClinicApi.Repository
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T Get(long id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
