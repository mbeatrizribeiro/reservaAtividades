﻿using Microsoft.EntityFrameworkCore;
using ReservaAtividades.Domain.Entidades;

namespace ReservaAtividades.Data
{
    public class ReservasContext : DbContext
    {
        public ReservasContext(DbContextOptions<ReservasContext> options)
            : base(options) { }

        public DbSet<Reservas> Reservas { get; set; }

        public DbSet<Clientes> Clientes { get; set; }
    }
}