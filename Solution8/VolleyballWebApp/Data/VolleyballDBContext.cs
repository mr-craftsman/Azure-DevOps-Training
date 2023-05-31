using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VolleyballWebApp.Models;

    public class VolleyballDBContext : DbContext
    {
        public VolleyballDBContext (DbContextOptions<VolleyballDBContext> options)
            : base(options)
        {
        }

        public DbSet<VolleyballWebApp.Models.VolleyballPlayer> VolleyballPlayer { get; set; } = default!;
    }
