using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProAgil.Domain.Entityes;
using ProAgil.Repository.Context;
using ProAgil.Repository.Interfaces;

namespace ProAgil.Repository.Repository
{
    public class PalestranteRepository : IBaseRepository, IPalestranteRepository
    {
        private readonly ProAgilContext _context;
        public PalestranteRepository(ProAgilContext context){
                    _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }
        public T GetById<T>(Guid id) where T : class
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() > 0);
        }

        
        public async Task<Palestrante[]> GetAllPalestrantesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Palestrante> GetAllPalestrantesAsyncById(Guid id)
        {
            return await _context.Palestrantes.FirstOrDefaultAsync(x=>x.Id == id);
        }

        public Task<Palestrante> GetAllPalestrantesAsyncById(int id, bool includePalestrantes)
        {
            throw new NotImplementedException();
        }

        public Task<Palestrante[]> GetAllPalestrantesAsyncByName(string name)
        {
            throw new NotImplementedException();
        }

        public T GetById<T>(long id) where T : class
        {
            throw new NotImplementedException();
        }

       
    }
}