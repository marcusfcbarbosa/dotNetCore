using System;
using System.Threading.Tasks;
using ProAgil.Domain.Entityes;

namespace ProAgil.Repository.Interfaces
{
    public interface IEventoRepository
    {
         Task<Evento[]>  GetAllEventosAsyncBytTema(string tema, bool includePalestrantes);
         Task<Evento[]>  GetAllEventosAsync(bool includePalestrantes = false);
         Task<Evento>  GetAllEventosAsyncById(Guid id,bool includePalestrantes = false);

    }
}