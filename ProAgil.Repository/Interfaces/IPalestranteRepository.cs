using System;
using System.Threading.Tasks;
using ProAgil.Domain.Entityes;

namespace ProAgil.Repository.Interfaces
{
    public interface IPalestranteRepository
    {
         Task<Palestrante[]>  GetAllPalestrantesAsyncByName(string name);
         Task<Palestrante[]>  GetAllPalestrantesAsync(bool includeEvento =false);
         Task<Palestrante>  GetAllPalestrantesAsyncById(Guid id, bool includeEvento =false);
    }
}