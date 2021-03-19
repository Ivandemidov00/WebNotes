using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebNotesData.Models
{
    public class WebNotesContext : DbContext
    {
        public DbSet<categories> categories { get; set; }
        public WebNotesContext(DbContextOptions<WebNotesContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<categories>();
        }
    }
}
