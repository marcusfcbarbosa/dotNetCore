using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProAgil.Domain.Entityes;
using ProAgil.Repository.Context;
using ProAgil.Repository.Interfaces;

namespace ProAgil.Repository.Repository
{
    public class EventoRepository : IBaseRepository, IEventoRepository
    {
        private readonly ProAgilContext _context;
        public EventoRepository(ProAgilContext context){
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
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() > 0);
        }

        public Task<Evento[]> GetAllEventosAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Evento> GetAllEventosAsyncById(Guid id)
        {
            return await _context.Eventos.FirstOrDefaultAsync(x=>x.Id == id);
        }

        public async Task<Evento> GetAllEventosAsyncById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Evento[]> GetAllEventosAsyncBytTema(string tema, bool includePalestrantes)
        {
            throw new NotImplementedException();
        }

        public T GetById<T>(long id) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetById<T>(Guid id) where T : class
        {
            throw new NotImplementedException();
        }


    }
}