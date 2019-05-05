using System;
using System.Threading.Tasks;
using ProAgil.Domain.Entityes;

namespace ProAgil.Repository.Interfaces
{
    public interface IEventoRepository
    {
         Task<Evento[]>  GetAllEventosAsyncBytTema(string tema, bool includePalestrantes);
         Task<Evento[]>  GetAllEventosAsync();
         Task<Evento>  GetAllEventosAsyncById(Guid id);
         Task<Evento>  GetAllEventosAsyncById(int id);
    }
}