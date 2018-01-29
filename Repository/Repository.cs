using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EClinicApi.Data;
using EClinicApi.Models;
namespace EClinicApi.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly EclinicData data;
        private DbSet<T> entities;



        public Repository(EclinicData _data)
        {
            this.data = _data;
            entities = data.Set<T>();
        }

        public void Delete(T entity)
        {
            entities.Remove(entity);
            data.SaveChanges();
        }

        public  T Get(long id)
        {
            return  entities.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public void Insert(T entity)
        {
            entities.Add(entity);
            data.SaveChanges();
        }

        public void Update(T entity)
        {
            var ent = entities.Find(entity);
            ent = entity;
            data.SaveChanges();
        }

       
    }
}
