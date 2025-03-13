﻿using Microsoft.EntityFrameworkCore;
using FinanceApp.Models;

namespace FinanceApp.Data
{
    public class FinanceAppContext : DbContext
    {
        public FinanceAppContext(DbContextOptions<FinanceAppContext> options):base(options) { }
        
        public DbSet<Expenses> Expenses { get; set; }
    }
}
