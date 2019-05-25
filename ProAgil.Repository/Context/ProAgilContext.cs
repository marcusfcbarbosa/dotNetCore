using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;
using ProAgil.Domain.ProAgilContext.Entities;
using ProAgil.Domain.ValueObjects;
using ProAgil.Shared.Entities;

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

        [NotMapped]
        public DbSet<Notification> Notification { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            
            modelBuilder.Entity<Evento>()
                .ToTable("Evento");

            modelBuilder.Entity<Lote>()
                .ToTable("Lote");

            modelBuilder.Entity<Palestrante>()
                .ToTable("Palestrante");

            modelBuilder.Entity<RedeSocial>()
                .ToTable("RedeSocial");

            modelBuilder.Entity<PalestranteEvento>()
                .HasKey(PE=> new {PE.EventoId, PE.PalestranteId});
            
            modelBuilder.Ignore<Notification>();
            modelBuilder.Ignore<Email>();

            base.OnModelCreating(modelBuilder);
        }
    }
}