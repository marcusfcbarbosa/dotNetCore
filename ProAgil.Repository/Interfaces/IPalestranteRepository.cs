using System;
using System.Threading.Tasks;
using ProAgil.Domain.Entityes;

namespace ProAgil.Repository.Interfaces
{
    public interface IPalestranteRepository
    {
         Task<Palestrante[]>  GetAllPalestrantesAsyncByName(string name);
         Task<Palestrante[]>  GetAllPalestrantesAsync();
         Task<Palestrante>  GetAllPalestrantesAsyncById(Guid id);
         Task<Palestrante>  GetAllPalestrantesAsyncById(int id, bool includePalestrantes);
    }
}