﻿using CleanMovie.Domain;
using Microsoft.EntityFrameworkCore;

namespace CleanMovie.Infrastructure.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // One to Many (Member and Rental)
            modelBuilder.Entity<Member>()
                .HasOne(s => s.Rental)
                .WithMany(r => r.Members)
                .HasForeignKey(s => s.RentalId);
                
            //Many to Many (Rental and Movie)
            modelBuilder.Entity<MovieRental>()
                .HasKey(g => new { g.RenatalId, g.MovieId });

            modelBuilder.Entity<Rental>()
                .HasKey(s => s.MemberId);

            //Handle Decimals to avoid precision loss
            modelBuilder.Entity<Rental>()
                //.HasKey(s => s.MemberId)
                .Property(p => p.TotalCost)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Movie>()
                .Property(p => p.RentalCost)
                .HasColumnType("decimal(18,2)");
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<MovieRental> MovieRentals { get; set; }

    }
}
