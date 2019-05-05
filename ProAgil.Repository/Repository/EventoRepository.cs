using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProAgil.Domain.Entityes;
using ProAgil.Repository.Context;
using ProAgil.Repository.Interfaces;

namespace ProAgil.Repository.Repository
{
    public class EventoRepository : BaseRepository<Evento>, IEventoRepository
    {
        private readonly ProAgilContext _context;
        public EventoRepository(ProAgilContext context)
            :base(context)
        {
            _context = context;
        }
        
        public async Task<Evento[]> GetAllEventosAsyncBytTema(string tema, bool includePalestrantes)
        {
            IQueryable<Evento> query = _context.Eventos
            .Include(c=>c.Lotes)
            .Include(c=>c.RedesSociais)
            .Where(c=>c.Tema.Contains(tema));

            if(includePalestrantes){
                query = query
                .Include(pe=>pe.PalestranteEventos)
                .ThenInclude(p=>p.Palestrante);
            }
            query = query.OrderByDescending(x=>x.DataEvento);
            return await query.ToArrayAsync();
        }

        public async Task<Evento[]> GetAllEventosAsync(bool includePalestrantes = false)
        {
            IQueryable<Evento> query = _context.Eventos
            .Include(c=>c.Lotes)
            .Include(c=>c.RedesSociais);

            if(includePalestrantes){
                query = query
                .Include(pe=>pe.PalestranteEventos)
                .ThenInclude(p=>p.Palestrante);
            }
            query = query.OrderByDescending(x=>x.DataEvento);
            return await query.ToArrayAsync();
        }

        public async Task<Evento> GetAllEventosAsyncById(Guid id,bool includePalestrantes = false)
        {
            IQueryable<Evento> query = _context.Eventos
            .Include(c=>c.Lotes)
            .Include(c=>c.RedesSociais)
            .Where(c=>c.Id == id);

            if(includePalestrantes){
                query = query
                .Include(pe=>pe.PalestranteEventos)
                .ThenInclude(p=>p.Palestrante);
            }
            return await query.FirstOrDefaultAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await SaveChangesAsync();
        }

        
    }
}