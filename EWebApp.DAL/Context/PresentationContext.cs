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
    }
}
