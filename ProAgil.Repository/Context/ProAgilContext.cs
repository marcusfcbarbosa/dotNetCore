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
        public DbSet<RedeSocial> RedeSociais { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            
                modelBuilder.Entity<PalestranteEvento>()
                     .HasKey(ev => new { ev.EventoId, ev.PalestranteId});            

            modelBuilder.Entity<PalestranteEvento>()
                .HasOne(p => p.Evento)
                .WithMany(b => b.PalestranteEventos)
                .HasForeignKey(bc => bc.EventoId);  

           modelBuilder.Entity<PalestranteEvento>()
                .HasOne(p => p.Palestrante)
                .WithMany(b => b.PalestranteEventos)
                .HasForeignKey(bc => bc.PalestranteId);  

            modelBuilder.Entity<Palestrante>().OwnsOne(x=>x.Email);

            modelBuilder.Entity<Lote>();
            

            modelBuilder.Entity<RedeSocial>();
                
            
            modelBuilder.Ignore<Notification>();
            modelBuilder.Ignore<Email>();

            base.OnModelCreating(modelBuilder);
        }
    }
}