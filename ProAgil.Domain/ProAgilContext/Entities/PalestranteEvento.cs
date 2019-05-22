using ProAgil.Shared.Entities;

namespace ProAgil.Domain.ProAgilContext.Entities
{
    public class PalestranteEvento : Entity
    {
        protected PalestranteEvento(){}
        public PalestranteEvento(Evento evento, Palestrante palestrante)
        {
            Evento = evento;
            Palestrante = palestrante;
        }

        public int EventoId { get; private set; }
        public Evento Evento { get; private set; }
        public int PalestranteId { get; private set; }
        public Palestrante Palestrante { get; private set; }
    }
}