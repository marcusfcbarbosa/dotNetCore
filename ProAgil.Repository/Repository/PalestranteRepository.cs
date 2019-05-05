using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProAgil.Domain.Entityes;
using ProAgil.Repository.Context;
using ProAgil.Repository.Interfaces;

namespace ProAgil.Repository.Repository
{
    public class PalestranteRepository : BaseRepository<Palestrante>, IPalestranteRepository
    {
        private readonly ProAgilContext _context;
        public PalestranteRepository(ProAgilContext context)
        :base(context){
                _context = context;
        }
        
        public async Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEvento =false)
        {
            IQueryable<Palestrante> query = _context.Palestrantes
            .Include(c=>c.RedesSociais);

            if(includeEvento){
                query = query
                .Include(pe=>pe.PalestranteEventos)
                .ThenInclude(p=>p.Evento);
            }
            query = query.OrderByDescending(x=>x.Nome);
            return await query.ToArrayAsync();
        }

        public async Task<Palestrante> GetAllPalestrantesAsyncById(Guid id)
        {
            return await _context.Palestrantes.FirstOrDefaultAsync(x=>x.Id == id);
        }

        public async Task<Palestrante[]> GetAllPalestrantesAsyncByName(string name)
        {
             IQueryable<Palestrante> query = _context.Palestrantes
                
                .Include(pe=>pe.PalestranteEventos)
                .ThenInclude(p=>p.Evento)
                .Where(x=>x.Nome.ToLower().Contains(name.ToLower()));

            return await query.ToArrayAsync();
        }

        public async Task<Palestrante> GetAllPalestrantesAsyncById(Guid id, bool includeEvento = false)
        {
            IQueryable<Palestrante> query = _context.Palestrantes
            .Include(c=>c.RedesSociais)
            .Where(x=>x.Id == id);

            if(includeEvento){
                query = query
                .Include(pe=>pe.PalestranteEventos)
                .ThenInclude(p=>p.Evento);
            }
            query = query.OrderBy(x=>x.Nome);
            return await query.FirstAsync();
        }
    }
}