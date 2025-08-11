using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class AppDbContext(DbContextOptions options) : DbContext(options) // Para que derive de EntityFrameworkCore.DbContext, se debe agregar la referencia a Microsoft.EntityFrameworkCore
{
    public DbSet<AppUser> Users { get; set; }
}