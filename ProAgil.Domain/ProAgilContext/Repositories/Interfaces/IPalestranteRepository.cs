using System;
using System.Threading.Tasks;
using ProAgil.Domain.ProAgilContext.Entities;

namespace ProAgil.Domain.ProAgilContext.Repositories.Interfaces
{
    public interface IPalestranteRepository : IBaseRepository<Palestrante>
    {
         Task<Palestrante[]>  GetAllPalestrantesAsyncByName(string name);
         Task<Palestrante[]>  GetAllPalestrantesAsync(bool includeEvento =false);
         Task<Palestrante>  GetAllPalestrantesAsyncById(Guid id, bool includeEvento =false);
    }
}