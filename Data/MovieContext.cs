﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data;

public partial class MovieContext : DbContext
{
    public MovieContext()
    {
    }

    public MovieContext(DbContextOptions<MovieContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Movie> Movie { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PKMovie3214EC07659BF9C6");

            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ReleaseDate).HasColumnType("date");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}