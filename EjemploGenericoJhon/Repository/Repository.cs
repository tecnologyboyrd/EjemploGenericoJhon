using EjemploGenericoJhon.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploGenericoJhon.Repository
{
    public class Repository<TEntiry> : IRepository<TEntiry> where TEntiry : class
    {
        private TESTContext _dbContext;
        private DbSet<TEntiry> _dbSet;

        public Repository(TESTContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntiry>();
            
        }
        public void Add(TEntiry Data)=> _dbSet.Add(Data);

        public IEnumerable<TEntiry> Get() => _dbSet.ToList();

        public TEntiry Get(int Id) => _dbSet.Find(Id);

        public void Delete(int Id)
        {
            var dataToDelete = _dbSet.Find(Id);
            _dbSet.Remove(dataToDelete); 
        }        

        public void Save()=> _dbContext.SaveChanges();

        public void Update(TEntiry Data) => _dbContext.Entry(Data).State = EntityState.Modified;
    }
}
