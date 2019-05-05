
using System;
using System.Threading.Tasks;

namespace ProAgil.Repository.Interfaces
{
    public interface IBaseRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        T GetById<T>(long id) where T : class;
        T GetById<T>(Guid id) where T : class;
        Task<bool> SaveChangesAsync();
    }
}