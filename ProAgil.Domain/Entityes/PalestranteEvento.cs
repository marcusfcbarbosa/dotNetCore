using ProAgil.Shared.Entities;

namespace ProAgil.Domain.Entityes
{
    public class PalestranteEvento
    {
        public PalestranteEvento(Evento evento, Palestrante palestrante)
        {
            Evento = evento;
            Palestrante = palestrante;
        }

        public int EventoId { get; set; }
        public Evento Evento { get; private set; }
        public int PalestranteId { get; set; }
        public Palestrante Palestrante { get; private set; }
    }
}