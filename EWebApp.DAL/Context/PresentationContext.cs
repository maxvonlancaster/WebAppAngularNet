using EWebApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EWebApp.DAL.Context
{
    public class PresentationContext : DbContext
    {
        public PresentationContext(DbContextOptions<PresentationContext> options):base(options)
        {}

        public DbSet<User> Users { get; set; }
        public DbSet<Presentation> Presentations { get; set; }

    }
}
