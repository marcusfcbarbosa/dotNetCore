using System;
using System.Linq;
using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;
using ProAgil.Domain.ProAgilContext.Entities;
using ProAgil.Domain.ValueObjects;
namespace ProAgil.Repository.Context
{
    public class ProAgilContext : DbContext
    {
        public ProAgilContext(DbContextOptions<ProAgilContext> options) 
            : base(options){
        }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Lote> Lotes { get; set; }
        public DbSet<Palestrante> Palestrantes { get; set; }
        public DbSet<PalestranteEvento> PalestranteEventos { get; set; }
        public DbSet<RedeSocial> RedeSociais { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
                modelBuilder.Entity<PalestranteEvento>()
                .HasKey(PE=> new {PE.EventoId, PE.PalestranteId});
                modelBuilder.Ignore<Notification>();
                modelBuilder.Ignore<Email>();
        }
    }
}