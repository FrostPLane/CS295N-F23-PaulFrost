﻿using ThurstonBoardGameClub.Models;
using Microsoft.EntityFrameworkCore;

namespace ThurstonBoardGameClub.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Message> Messages { get; set; }
        // TODO: Remove Users when we add Identity
        public DbSet<AppUser> Users { get; set; }
    }
}