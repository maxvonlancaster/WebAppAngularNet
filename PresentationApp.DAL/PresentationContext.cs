using Microsoft.EntityFrameworkCore;
using PresentationApp.DAL.Entities;
using System;
using System.Diagnostics.CodeAnalysis;

namespace PresentationApp.DAL
{
    public class PresentationContext : DbContext
    {
        public PresentationContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Presentation> Presentations { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
