﻿using Microsoft.EntityFrameworkCore;
using PORTFOLIO.Models;

namespace PORTFOLIO.Contexts
{
    public class TempDbContext:DbContext
    {
        public TempDbContext(DbContextOptions opt):base(opt)
        {
            
        }
        public DbSet<Detal> Detals { get; set; }
    }
}
